using com.igetui.api.openservice.igetui;
using com.igetui.api.openservice.utils;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace com.igetui.api.openservice
{
    public class IGtPush : IIGtPush, IIGtQuery, IGtAPN
    {
        private static readonly object thisLock = new object();
        private static volatile Dictionary<string, List<string>> appkeyUrlList = new Dictionary<string, List<string>>();
        private string appKey;
        private List<string> domailUrlList;
        public string host;
        private HttpProxy httpProxy;
        private ILogger _logger;
        private string masterSecret;

        public IGtPush(string domainUrl, string appKey, string masterSecret)
        {
            _IGtPush(domainUrl, appKey, masterSecret, false, null);
        }

        public IGtPush(string appKey, string masterSecret, bool useSSL)
        {
            _IGtPush(null, appKey, masterSecret, useSSL, null);
        }

        public IGtPush(string domainUrl, string appKey, string masterSecret, ILogger logger)
        {
            _IGtPush(domainUrl, appKey, masterSecret, false, logger);
        }

        public IGtPush(string appKey, string masterSecret, bool useSSL, ILogger logger)
        {
            _IGtPush(null, appKey, masterSecret, useSSL, logger);
        }

        public string AuthToken { get; set; }

        public string pushAPNMessageToSingle(string appId, string deviceToken, SingleMessage message)
        {
            if (deviceToken == null || deviceToken.Length != 64)
                throw new Exception("deviceToken " + deviceToken + " length must be 64");
            return httpPostJSON(new Dictionary<string, object>
            {
                {
                    "action",
                    "apnPushToSingleAction"
                },
                {
                    nameof(appId),
                    appId
                },
                {
                    "appkey",
                    appKey
                },
                {
                    "DT",
                    deviceToken
                },
                {
                    "PI",
                    Convert.ToBase64String(message.Data.getPushInfo().ToByteArray())
                }
            });
        }

        public string pushAPNMessageToList(
            string appId,
            string contentId,
            List<string> deviceTokenlist)
        {
            foreach (var str in deviceTokenlist)
                if (str == null || str.Length != 64)
                    throw new Exception("deviceToken length must be 64");
            return httpPostJSON(new Dictionary<string, object>
            {
                {
                    "action",
                    "apnPushToListAction"
                },
                {
                    "appkey",
                    appKey
                },
                {
                    nameof(appId),
                    appId
                },
                {
                    nameof(contentId),
                    contentId
                },
                {
                    "DTL",
                    deviceTokenlist
                },
                {
                    "needDetails",
                    GtConfig.isPushListNeedDetails()
                },
                {
                    "async",
                    GtConfig.isPushListAsync()
                }
            });
        }

        public string getAPNContentId(string appId, ListMessage message)
        {
            var contentInfo = JsonConvert.DeserializeObject<ContentInfo>(httpPostJSON(new Dictionary<string, object>
            {
                {
                    "action",
                    "apnGetContentIdAction"
                },
                {
                    "appkey",
                    appKey
                },
                {
                    nameof(appId),
                    appId
                },
                {
                    "PI",
                    Convert.ToBase64String(message.Data.getPushInfo().ToByteArray())
                }
            }));
            var result = contentInfo.result;
            if (result.IndexOf("ok") > -1)
                return contentInfo.contentId;
            throw new Exception("获取 contentId 失败：" + result);
        }

        public bool connect()
        {
            var num = ConvertDateTimeInt(DateTime.Now);
            var md5SignValue = getMD5SignValue(new Dictionary<string, string>
            {
                {
                    "appkey",
                    appKey
                },
                {
                    "timeStamp",
                    string.Concat(num)
                },
                {
                    "masterSecret",
                    masterSecret
                }
            });
            var paramData = new Dictionary<string, object>
            {
                {
                    "action",
                    nameof(connect)
                },
                {
                    "appkey",
                    appKey
                },
                {
                    "timeStamp",
                    num
                },
                {
                    "sign",
                    md5SignValue
                },
                {
                    "version",
                    GtConfig.getSDKVersion()
                }
            };
            JsonConvert.SerializeObject(paramData);
            var input = httpPost(host, paramData, false);
            var dictionary = JsonConvert.DeserializeObject<Dictionary<string, object>>(input);
            if (input.IndexOf("success") <= -1)
                throw new Exception("appKey or masterSecret is auth failed.");
            AuthToken = (string) dictionary["authtoken"];
            return true;
        }

        public IBatch getBatch()
        {
            return new BatchImpl(appKey, this);
        }

        public string pushMessageToSingle(SingleMessage message, Target target)
        {
            return pushMessageToSingle(message, target, null);
        }

        public string pushMessageToApp(AppMessage message)
        {
            return pushMessageToApp(message, null);
        }

        public string pushMessageToList(string contentId, List<Target> targetList)
        {
            var flag1 = GtConfig.isPushListAsync();
            var flag2 = GtConfig.isPushListNeedAliasDetails();
            var flag3 = GtConfig.isPushListNeedDetails();
            var postData = new Dictionary<string, object>
            {
                {
                    "action",
                    "pushMessageToListAction"
                },
                {
                    "appkey",
                    appKey
                },
                {
                    nameof(contentId),
                    contentId
                },
                {
                    "needDetails",
                    flag3
                },
                {
                    "needAliasDetails",
                    flag2
                },
                {
                    "async",
                    flag1
                }
            };
            var num = !flag1 || flag3 ? GtConfig.getSyncListLimit() : GtConfig.getAsyncListLimit();
            if (targetList.Count > num)
                return "target size:" + targetList.Count + " beyond the limit:" + num;
            var stringList1 = new List<string>();
            var stringList2 = new List<string>();
            var str = "";
            foreach (var target in targetList)
            {
                var clientId = target.clientId;
                var alias = target.alias;
                if (!string.IsNullOrWhiteSpace(clientId))
                    stringList1.Add(clientId);
                else if (!string.IsNullOrWhiteSpace(alias))
                    stringList2.Add(alias);
                if (string.IsNullOrWhiteSpace(str))
                    str = target.appId;
            }

            postData.Add("appId", str);
            postData.Add("clientIdList", stringList1);
            postData.Add("aliasList", stringList2);
            postData.Add("type", 2);
            return httpPostJSON(host, postData, true);
        }

        public void pushMessageToList(
            ListMessage message,
            IListProvider listProvider,
            IPushEventListener listener)
        {
        }

        public void close()
        {
            httpPostJSON(new Dictionary<string, object>
            {
                {
                    "action",
                    nameof(close)
                },
                {
                    "appkey",
                    appKey
                },
                {
                    "version",
                    GtConfig.getSDKVersion()
                },
                {
                    "authToken",
                    AuthToken
                }
            });
        }

        public string getContentId(ListMessage message)
        {
            return getContentId(message, null);
        }

        public string addCidListToBlk(string appId, List<string> cidList)
        {
            return blackCidList(appId, cidList, 1);
        }

        public string restoreCidListFromBlk(string appId, List<string> cidList)
        {
            return blackCidList(appId, cidList, 2);
        }

        public bool cancelContentId(string contentId)
        {
            return httpPostJSON(new Dictionary<string, object>
            {
                {
                    "action",
                    "cancleContentIdAction"
                },
                {
                    "appkey",
                    appKey
                },
                {
                    nameof(contentId),
                    contentId
                }
            }).IndexOf("ok") > -1;
        }

        public bool stop(string contentId)
        {
            return httpPostJSON(new Dictionary<string, object>
            {
                {
                    "action",
                    "stopTaskAction"
                },
                {
                    "appkey",
                    appKey
                },
                {
                    nameof(contentId),
                    contentId
                }
            }).IndexOf("ok") > -1;
        }

        public string getPushResultByTaskidList(List<string> taskIdList)
        {
            return getPushActionResultByTaskids(taskIdList, null);
        }

        public string getPushActionResultByTaskids(List<string> taskIdList, List<string> actionIdList)
        {
            return httpPostJSON(new Dictionary<string, object>
            {
                {
                    "action",
                    "getPushMsgResultByTaskidList"
                },
                {
                    "appkey",
                    appKey
                },
                {
                    nameof(taskIdList),
                    taskIdList
                },
                {
                    nameof(actionIdList),
                    actionIdList
                }
            });
        }

        public string getScheduleTask(string taskId, string appId)
        {
            return httpPostJSON(new Dictionary<string, object>
            {
                {
                    "action",
                    "getScheduleTaskAction"
                },
                {
                    "appkey",
                    appKey
                },
                {
                    nameof(appId),
                    appId
                },
                {
                    nameof(taskId),
                    taskId
                }
            });
        }

        public string delScheduleTask(string taskId, string appId)
        {
            return httpPostJSON(new Dictionary<string, object>
            {
                {
                    "action",
                    "delScheduleTaskAction"
                },
                {
                    "appkey",
                    appKey
                },
                {
                    nameof(appId),
                    appId
                },
                {
                    nameof(taskId),
                    taskId
                }
            });
        }

        public string bindCidPn(string appId, Dictionary<string, string> cidAndPn)
        {
            return httpPostJSON(new Dictionary<string, object>
            {
                {
                    "action",
                    "bind_cid_pn"
                },
                {
                    nameof(appId),
                    appId
                },
                {
                    "appkey",
                    appKey
                },
                {
                    "cidpnlist",
                    cidAndPn
                }
            });
        }

        public string unbindCidPn(string appId, List<string> cid)
        {
            return httpPostJSON(new Dictionary<string, object>
            {
                {
                    "action",
                    "unbind_cid_pn"
                },
                {
                    nameof(appId),
                    appId
                },
                {
                    "appkey",
                    appKey
                },
                {
                    "cids",
                    cid
                }
            });
        }

        public string queryCidPn(string appId, List<string> cid)
        {
            return httpPostJSON(new Dictionary<string, object>
            {
                {
                    "action",
                    "query_cid_pn"
                },
                {
                    nameof(appId),
                    appId
                },
                {
                    "appkey",
                    appKey
                },
                {
                    "cids",
                    cid
                }
            });
        }

        public string stopSendSms(string appId, string taskId)
        {
            return httpPostJSON(new Dictionary<string, object>
            {
                {
                    "action",
                    "stop_sms"
                },
                {
                    nameof(appId),
                    appId
                },
                {
                    "appkey",
                    appKey
                },
                {
                    nameof(taskId),
                    taskId
                }
            });
        }

        public string getUserCountByTags(string appId, List<string> tagList)
        {
            var postData = new Dictionary<string, object>
            {
                {
                    "action",
                    nameof(getUserCountByTags)
                },
                {
                    "appkey",
                    appKey
                },
                {
                    nameof(appId),
                    appId
                },
                {
                    nameof(tagList),
                    tagList
                }
            };
            var tagListLimit = GtConfig.getTagListLimit();
            if (tagListLimit < tagList.Count)
                throw new Exception("tagList size:" + tagList.Count + "beyond the limit" + tagListLimit);
            return httpPostJSON(postData);
        }

        public string pushTagMessage(TagMessage message)
        {
            return pushTagMessage(message, null);
        }

        public string pushTagMessage(TagMessage message, string requestId)
        {
            if (string.IsNullOrEmpty(requestId))
                requestId = Guid.NewGuid().ToString();
            return httpPostJSON(new Dictionary<string, object>
            {
                {
                    "action",
                    "pushMessageByTagAction"
                },
                {
                    "appkey",
                    appKey
                },
                {
                    "clientData",
                    Convert.ToBase64String(message.Data.getTransparent().ToByteArray())
                },
                {
                    "transmissionContent",
                    message.Data.getTransmissionContent()
                },
                {
                    "isOffline",
                    message.IsOffline
                },
                {
                    "offlineExpireTime",
                    message.OfflineExpireTime
                },
                {
                    "pushNetWorkType",
                    message.PushNetWorkType
                },
                {
                    "appIdList",
                    message.AppIdList
                },
                {
                    "speed",
                    message.Speed
                },
                {
                    nameof(requestId),
                    requestId
                },
                {
                    "tag",
                    message.Tag
                }
            });
        }

        public string setBadgeForCID(string badge, string appid, List<string> cidList)
        {
            return setBadge(badge, appid, new List<string>(), cidList);
        }

        public string setBadgeForDeviceToken(string badge, string appid, List<string> deviceTokenList)
        {
            return setBadge(badge, appid, deviceTokenList, new List<string>());
        }

        public string getClientIdStatus(string appId, string clientId)
        {
            return httpPostJSON(new Dictionary<string, object>
            {
                {
                    "action",
                    "getClientIdStatusAction"
                },
                {
                    "appkey",
                    appKey
                },
                {
                    nameof(appId),
                    appId
                },
                {
                    nameof(clientId),
                    clientId
                }
            });
        }

        public string getLast24HoursOnlineUserStatistics(string appId)
        {
            return httpPostJSON(new Dictionary<string, object>
            {
                {
                    "action",
                    "getLast24HoursOnlineUser"
                },
                {
                    "appkey",
                    appKey
                },
                {
                    nameof(appId),
                    appId
                }
            });
        }

        public string getPersonaTags(string appId)
        {
            return httpPostJSON(new Dictionary<string, object>
            {
                {
                    "action",
                    nameof(getPersonaTags)
                },
                {
                    "appkey",
                    appKey
                },
                {
                    nameof(appId),
                    appId
                }
            });
        }

        public string getPushResultByGroupName(string appId, string groupName)
        {
            return httpPostJSON(new Dictionary<string, object>
            {
                {
                    "action",
                    nameof(getPushResultByGroupName)
                },
                {
                    "appkey",
                    appKey
                },
                {
                    nameof(appId),
                    appId
                },
                {
                    nameof(groupName),
                    groupName
                }
            });
        }

        public string getPushResult(string contentId)
        {
            return httpPostJSON(new Dictionary<string, object>
            {
                {
                    "action",
                    "getPushMsgResult"
                },
                {
                    "appkey",
                    appKey
                },
                {
                    "taskId",
                    contentId
                }
            });
        }

        public string getUserTags(string appId, string clientId)
        {
            return httpPostJSON(new Dictionary<string, object>
            {
                {
                    "action",
                    nameof(getUserTags)
                },
                {
                    "appkey",
                    appKey
                },
                {
                    nameof(appId),
                    appId
                },
                {
                    nameof(clientId),
                    clientId
                }
            });
        }

        public string queryUserCount(string appId, AppConditions conditions)
        {
            var postData = new Dictionary<string, object>
            {
                {
                    "action",
                    nameof(queryUserCount)
                },
                {
                    nameof(appId),
                    appId
                },
                {
                    "appkey",
                    appKey
                }
            };
            if (conditions != null)
                postData.Add(nameof(conditions), conditions.getCondition());
            return httpPostJSON(postData);
        }
        
        private void _IGtPush(string domainUrl,string appKey,string masterSecret,bool useSSL,ILogger logger)
        {
            this.appKey = appKey;
            this.masterSecret = masterSecret;
            this._logger = logger;
            httpProxy = new HttpProxy(new IGtHttpProxy());
            var defaultConnectionLimit = ServicePointManager.DefaultConnectionLimit;
            if (defaultConnectionLimit < 100)
            {
                ServicePointManager.DefaultConnectionLimit = 1024;
            }

            if (domainUrl == null || domainUrl.Trim().Length == 0)
                domailUrlList = GtConfig.getDefaultDomainUrl(useSSL);
            else
                domailUrlList = new List<string>
                {
                    domainUrl
                };
            initOSDomain(null);
        }

        private void initOSDomain(List<string> hosts)
        {
            if (hosts == null || hosts.Count == 0)
            {
                if (!appkeyUrlList.ContainsKey(appKey))
                    lock (thisLock)
                    {
                        if (!appkeyUrlList.ContainsKey(appKey))
                        {
                            hosts = getOSPushDomainUrlList(domailUrlList, appKey);
                            if (hosts != null)
                                if (hosts.Count > 0)
                                    appkeyUrlList.Add(appKey, hosts);
                        }
                    }

                if (appkeyUrlList.ContainsKey(appKey))
                    hosts = appkeyUrlList[appKey];
            }

            if (hosts == null || hosts.Count == 0)
                throw new Exception("Get Push Host Error");
            dynamicGetFastest(hosts);
            if (hosts.Count <= 1)
                return;
            var timer = new Timer(dynamicGetFastest, hosts, 600000, 600000);
        }

        private List<string> getOSPushDomainUrlList(List<string> hosts, string AppKey)
        {
            var stringList = (List<string>) null;
            var postData = new Dictionary<string, object>
            {
                {
                    "action",
                    "getOSPushDomailUrlListAction"
                },
                {
                    "appkey",
                    AppKey
                }
            };
            var innerException = (Exception) null;
            foreach (var host in hosts)
                try
                {
                    var dictionary =
                        JsonConvert.DeserializeObject<Dictionary<string, object>>(httpPostJSON(host, postData, false));
                    if (dictionary != null)
                        if ("ok".Equals(dictionary["result"]))
                        {
                            stringList = CastToList(((JArray)dictionary["osList"]).ToObject<List<dynamic>>());
                            if (stringList != null)
                                if (stringList.Count > 0)
                                    break;
                        }
                }
                catch (Exception ex)
                {
                    _logger?.LogError(ex, "get hosts error: :" + host);
                    innerException = ex;
                }

            if (stringList == null || stringList.Count <= 0)
                throw new Exception("Can not get hosts from " + hosts, innerException);
            return stringList;
        }

        private List<string> CastToList(List<dynamic> a)
        {
            var stringList = new List<string>();
            foreach (var obj in a)
                if (obj is string)
                    stringList.Add((string) obj);
            return stringList;
        }

        public void dynamicGetFastest(object hostsObj)
        {
            var appkeyUrl = appkeyUrlList[appKey];
            ApiUrlRespectUtil.setProxy(httpProxy);
            host = ApiUrlRespectUtil.getFastest(appKey, appkeyUrl);
        }

        public string pushMessageToSingle(SingleMessage message, Target target, string requestId)
        {
            message.Data.getTransparent();
            if (string.IsNullOrEmpty(requestId))
                requestId = Guid.NewGuid().ToString();
            return httpPostJSON(new Dictionary<string, object>
            {
                {
                    nameof(requestId),
                    requestId
                },
                {
                    "action",
                    "pushMessageToSingleAction"
                },
                {
                    "appkey",
                    appKey
                },
                {
                    "appId",
                    target.appId
                },
                {
                    "alias",
                    target.alias
                },
                {
                    "clientId",
                    target.clientId
                },
                {
                    "isOffline",
                    message.IsOffline
                },
                {
                    "offlineExpireTime",
                    message.OfflineExpireTime
                },
                {
                    "pushNetWorkType",
                    message.PushNetWorkType
                },
                {
                    "transmissionContent",
                    message.Data.getTransmissionContent()
                },
                {
                    "type",
                    2
                },
                {
                    "pushType",
                    message.Data.getPushType()
                },
                {
                    "clientData",
                    Convert.ToBase64String(message.Data.getTransparent().ToByteArray())
                }
            });
        }

        public string pushMessageToApp(AppMessage message, string taskGroupName)
        {
            return httpPostJSON(new Dictionary<string, object>
            {
                {
                    "action",
                    "pushMessageToAppAction"
                },
                {
                    "appkey",
                    appKey
                },
                {
                    "contentId",
                    getContentId(message, taskGroupName)
                },
                {
                    "type",
                    2
                }
            });
        }

        public string getContentId(Message message, string taskGroupName)
        {
            var postData = new Dictionary<string, object>();
            if (taskGroupName != null && taskGroupName.Trim() != "")
            {
                if (Encoding.UTF8.GetBytes(taskGroupName).Length > 40)
                    throw new Exception("TaskGroupName is OverLimit 40");
                postData.Add(nameof(taskGroupName), taskGroupName);
            }

            postData.Add("action", "getContentIdAction");
            postData.Add("appkey", appKey);
            postData.Add("clientData", Convert.ToBase64String(message.Data.getTransparent().ToByteArray()));
            postData.Add("transmissionContent", message.Data.getTransmissionContent());
            postData.Add("isOffline", message.IsOffline);
            postData.Add("offlineExpireTime", message.OfflineExpireTime);
            postData.Add("pushNetWorkType", message.PushNetWorkType);
            postData.Add("pushType", message.Data.getPushType());
            postData.Add("type", 2);
            if (message is ListMessage)
                postData.Add("contentType", 1);
            if (message is AppMessage)
            {
                postData.Add("contentType", 2);
                var appMessage = (AppMessage) message;
                postData.Add("appIdList", appMessage.AppIdList);
                if (appMessage.Conditions == null)
                {
                    var phoneTypeList = appMessage.PhoneTypeList;
                    var provinceList = appMessage.ProvinceList;
                    var tagList = appMessage.TagList;
                    postData.Add("phoneTypeList", phoneTypeList);
                    postData.Add("provinceList", provinceList);
                    postData.Add("tagList", tagList);
                }
                else
                {
                    var condition = appMessage.Conditions.getCondition();
                    postData.Add("conditions", condition);
                }

                postData.Add("speed", appMessage.Speed);
                var pushTime = appMessage.PushTime;
                if (!string.IsNullOrEmpty(pushTime))
                    postData.Add("pushTime", pushTime);
            }

            var input = httpPostJSON(postData);
            Console.WriteLine("---------pushMessageToList result-----------" + input);
            var contentInfo = JsonConvert.DeserializeObject<ContentInfo>(input);
            var result = contentInfo.result;
            if (result.IndexOf("ok") > -1)
                return contentInfo.contentId;
            throw new Exception("获取 contentId 失败：" + result);
        }

        public string blackCidList(string appId, List<string> cidList, int optType)
        {
            var lenOfBlackCidList = GtConfig.getMaxLenOfBlackCidList();
            if (lenOfBlackCidList < cidList.Count)
                return httpPostJSON(new Dictionary<string, object>
                {
                    {
                        "result",
                        "cid size:" + cidList.Count + " beyond the limit:" + lenOfBlackCidList
                    }
                });
            return httpPostJSON(new Dictionary<string, object>
            {
                {
                    "action",
                    "blackCidAction"
                },
                {
                    "appkey",
                    appKey
                },
                {
                    nameof(appId),
                    appId
                },
                {
                    nameof(cidList),
                    cidList
                },
                {
                    nameof(optType),
                    optType
                }
            });
        }

        public string setBadge(
            string badge,
            string appid,
            List<string> deviceTokenList,
            List<string> cidList)
        {
            return httpPostJSON(new Dictionary<string, object>
            {
                {
                    "action",
                    "setBadgeAction"
                },
                {
                    "appkey",
                    appKey
                },
                {
                    nameof(badge),
                    badge
                },
                {
                    nameof(appid),
                    appid
                },
                {
                    "deviceToken",
                    deviceTokenList
                },
                {
                    "cid",
                    cidList
                }
            });
        }

        public string setClientTag(string appId, string clientId, List<string> tags)
        {
            return httpPostJSON(new Dictionary<string, object>
            {
                {
                    "action",
                    "setTagAction"
                },
                {
                    "appkey",
                    appKey
                },
                {
                    nameof(appId),
                    appId
                },
                {
                    nameof(clientId),
                    clientId
                },
                {
                    "tagList",
                    tags
                }
            });
        }

        public string queryAppPushDataByDate(string appId, string date)
        {
            if (!LangUtils.validateDate(date))
                throw new Exception("DateError|" + date);
            return httpPostJSON(new Dictionary<string, object>
            {
                {
                    "action",
                    "queryAppPushData"
                },
                {
                    "appkey",
                    appKey
                },
                {
                    nameof(appId),
                    appId
                },
                {
                    nameof(date),
                    date
                }
            });
        }

        public string queryAppUserDataByDate(string appId, string date)
        {
            if (!LangUtils.validateDate(date))
                throw new Exception("DateError|" + date);
            return httpPostJSON(new Dictionary<string, object>
            {
                {
                    "action",
                    "queryAppUserData"
                },
                {
                    "appkey",
                    appKey
                },
                {
                    nameof(appId),
                    appId
                },
                {
                    nameof(date),
                    date
                }
            });
        }

        private string httpPostJSON(Dictionary<string, object> postData)
        {
            return httpPostJSON(host, postData, false);
        }

        public string httpPostJSON(string url, Dictionary<string, object> postData, bool gzip)
        {
            postData.Add("version", GtConfig.getSDKVersion());
            JsonConvert.SerializeObject(postData);
            postData.Add("authToken", AuthToken);
            var input = httpPost(url, postData, gzip);
            if (string.IsNullOrEmpty(input))
            {
                if (postData.ContainsKey("requestId"))
                    throw new RequestException((string) postData["requestId"],
                        "Http request exception,address is " + url);
                return input;
            }

            if (input.IndexOf("sign_error") > -1)
            {
                if (connect())
                {
                    postData.Remove("authToken");
                    postData.Add("authToken", AuthToken);
                    return httpPost(url, postData, gzip);
                }
            }
            else if (input.IndexOf("domain_error") > -1)
            {
                var dictionary = JsonConvert.DeserializeObject<Dictionary<string, object>>(input);
                appkeyUrlList.Add(appKey, CastToList(((JArray)dictionary["osList"]).ToObject<List<dynamic>>()));
                dynamicGetFastest(null);
                return httpPost(host, postData, gzip);
            }

            return input;
        }

        private string httpPost(string postUrl, Dictionary<string, object> paramData, bool gzip)
        {
            var str1 = (string) paramData["action"];
            var str2 = "";
            var httpTryCount = GtConfig.getHttpTryCount();
            var num1 = 0;
            while (num1 <= httpTryCount)
            {
                var httpWebResponse = (HttpWebResponse) null;
                var streamReader = (StreamReader) null;
                var stream1 = (Stream) null;
                var httpWebRequest = (HttpWebRequest) null;
                try
                {
                    Util.SetCertificatePolicy();
                    var num2 = ConvertDateTimeInt(DateTime.Now);
                    httpWebRequest = (HttpWebRequest) WebRequest.Create(new Uri(postUrl));
                    var webProxy = httpProxy.getWebProxy();
                    if (webProxy != null)
                        httpWebRequest.Proxy = webProxy;
                    var str3 = JsonConvert.SerializeObject(paramData);
                    var buffer = Encoding.UTF8.GetBytes(str3);
                    if (str1 != null)
                        httpWebRequest.Headers.Add("Gt-Action", str1);
                    if (gzip)
                    {
                        httpWebRequest.Headers.Add("Content-Encoding", nameof(gzip));
                        httpWebRequest.Headers.Add("Accept-Encoding", nameof(gzip));
                        buffer = Zip(str3);
                    }

                    httpWebRequest.Method = "POST";
                    httpWebRequest.ContentType = "text/html;charset=UTF-8";
                    httpWebRequest.Timeout = GtConfig.getHttpConnectionTimeOut();
                    httpWebRequest.ReadWriteTimeout = GtConfig.getHttpSoTimeOut();
                    httpWebRequest.ContentLength = buffer.Length;
                    httpWebRequest.ProtocolVersion = HttpVersion.Version10;
                    httpWebRequest.KeepAlive = true;
                    stream1 = httpWebRequest.GetRequestStream();
                    var num3 = ConvertDateTimeInt(DateTime.Now);
                    stream1.Write(buffer, 0, buffer.Length);
                    stream1.Close();
                    httpWebResponse = (HttpWebResponse) httpWebRequest.GetResponse();
                    Console.WriteLine("RESPONSE HEADER: " + httpWebResponse.Headers);
                    var stream2 = httpWebResponse.GetResponseStream();
                    if (gzip)
                        stream2 = new GZipStream(stream2, CompressionMode.Decompress);
                    streamReader = new StreamReader(stream2, Encoding.UTF8);
                    str2 = streamReader.ReadToEnd();
                    var num4 = ConvertDateTimeInt(DateTime.Now);
                    return str2;
                }
                catch (Exception ex)
                {
                    ++num1;
                    _logger?.LogError(ex, "HTTP 请求异常信息");
                }
                finally
                {
                    streamReader?.Close();
                    httpWebResponse?.Close();
                    stream1?.Close();
                    httpWebRequest?.Abort();
                }
            }

            return str2;
        }

        private long ConvertDateTimeInt(DateTime time)
        {
            return (long) Math.Round(
                (DateTime.Now - TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1, 0, 0, 0, 0)))
                .TotalMilliseconds, MidpointRounding.AwayFromZero);
        }

        public string getMD5SignValue(Dictionary<string, string> param)
        {
            new ArrayList().AddRange(param.Keys);
            return bytearray2string(new MD5CryptoServiceProvider().ComputeHash(
                Encoding.UTF8.GetBytes(param["appkey"] + param["timeStamp"] + param["masterSecret"])));
        }

        private string bytearray2string(byte[] bytes)
        {
            var str = "";
            foreach (var num in bytes)
                str += num.ToString("x2");
            return str;
        }

        public string bindAlias(string appId, string alias, string clientId)
        {
            return httpPostJSON(new Dictionary<string, object>
            {
                {
                    "action",
                    "alias_bind"
                },
                {
                    "appkey",
                    appKey
                },
                {
                    "appid",
                    appId
                },
                {
                    nameof(alias),
                    alias
                },
                {
                    "cid",
                    clientId
                }
            });
        }

        public string bindAlias(string appId, List<Target> targetList)
        {
            var dictionaryList = new List<Dictionary<string, string>>();
            foreach (var target in targetList)
            {
                var dictionary = new Dictionary<string, string>
                {
                    {
                        "cid",
                        target.clientId
                    },
                    {
                        "alias",
                        target.alias
                    }
                };
                dictionaryList.Add(dictionary);
            }

            return httpPostJSON(new Dictionary<string, object>
            {
                {
                    "action",
                    "alias_bind_list"
                },
                {
                    "appkey",
                    appKey
                },
                {
                    "appid",
                    appId
                },
                {
                    "aliaslist",
                    dictionaryList
                }
            });
        }

        public string queryClientId(string appId, string alias)
        {
            return httpPostJSON(new Dictionary<string, object>
            {
                {
                    "action",
                    "alias_query"
                },
                {
                    "appkey",
                    appKey
                },
                {
                    "appid",
                    appId
                },
                {
                    nameof(alias),
                    alias
                }
            });
        }

        public string queryAlias(string appId, string clientId)
        {
            return httpPostJSON(new Dictionary<string, object>
            {
                {
                    "action",
                    "alias_query"
                },
                {
                    "appkey",
                    appKey
                },
                {
                    "appid",
                    appId
                },
                {
                    "cid",
                    clientId
                }
            });
        }

        public string unBindAlias(string appId, string alias, string clientId)
        {
            var postData = new Dictionary<string, object>
            {
                {
                    "action",
                    "alias_unbind"
                },
                {
                    "appkey",
                    appKey
                },
                {
                    "appid",
                    appId
                },
                {
                    nameof(alias),
                    alias
                }
            };
            if (!string.IsNullOrEmpty(clientId))
                postData.Add("cid", clientId);
            return httpPostJSON(postData);
        }

        public string unBindAliasAll(string appId, string alias)
        {
            return unBindAlias(appId, alias, null);
        }

        public static void CopyTo(Stream src, Stream dest)
        {
            var buffer = new byte[4096];
            int count;
            while ((count = src.Read(buffer, 0, buffer.Length)) != 0)
                dest.Write(buffer, 0, count);
        }

        public static byte[] Zip(string str)
        {
            using (var memoryStream1 = new MemoryStream(Encoding.UTF8.GetBytes(str)))
            {
                using (var memoryStream2 = new MemoryStream())
                {
                    using (var gzipStream = new GZipStream(memoryStream2, CompressionMode.Compress))
                    {
                        CopyTo(memoryStream1, gzipStream);
                    }

                    return memoryStream2.ToArray();
                }
            }
        }

        public static string Unzip(byte[] bytes)
        {
            using (var memoryStream1 = new MemoryStream(bytes))
            {
                using (var memoryStream2 = new MemoryStream())
                {
                    using (var gzipStream = new GZipStream(memoryStream1, CompressionMode.Decompress))
                    {
                        CopyTo(gzipStream, memoryStream2);
                    }

                    return Encoding.UTF8.GetString(memoryStream2.ToArray());
                }
            }
        }
    }
}