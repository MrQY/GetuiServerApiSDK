using System;
using System.Collections.Generic;
using com.gexin.rp.sdk.dto;
using com.igetui.api.openservice.igetui;
using Newtonsoft.Json;
using Target = com.igetui.api.openservice.igetui.Target;

namespace com.igetui.api.openservice
{
    public class BatchImpl : IBatch
    {
        private readonly string APPKEY;
        private readonly string batchId;
        private readonly List<SingleBatchItem> innerMsgList = new List<SingleBatchItem>();
        private Dictionary<string, object> lastPostData;
        private readonly IGtPush push;
        private int seqId;

        public BatchImpl(string appKey, IGtPush push)
        {
            batchId = Guid.NewGuid().ToString();
            APPKEY = appKey;
            this.push = push;
        }

        public void setApiUrl(string url)
        {
        }

        public string add(SingleMessage message, Target target)
        {
            if (seqId >= 5000)
                throw new Exception("Can not add over 5000 message once! Please call submit() first.");
            innerMsgList.Add(SingleBatchItem.CreateBuilder().SetSeqId(seqId).SetData(createPostParams(message, target))
                .Build());
            ++seqId;
            return string.Concat(seqId);
        }

        public string submit()
        {
            var str = Guid.NewGuid().ToString();
            seqId = 0;
            var postData = new Dictionary<string, object>();
            postData.Add("requestId", str);
            postData.Add("appkey", APPKEY);
            postData.Add("action", "pushMessageToSingleBatchAction");
            postData.Add("serialize", "pb");
            postData.Add("async", GtConfig.isPushSingleBatchAsync());
            var singleBatchRequest = SingleBatchRequest.CreateBuilder().SetBatchId(batchId)
                .AddRangeBatchItem(innerMsgList).Build();
            postData.Add("singleDatas", Convert.ToBase64String(singleBatchRequest.ToByteArray()));
            lastPostData = postData;
            innerMsgList.Clear();
            return push.httpPostJSON(push.host, postData, true);
        }

        public string retry()
        {
            if (lastPostData != null)
                return push.httpPostJSON(push.host, lastPostData, true);
            return null;
        }

        public string getBatchId()
        {
            return batchId;
        }

        public string createPostParams(SingleMessage message, Target target)
        {
            return JsonConvert.SerializeObject(new Dictionary<string, object>
            {
                {
                    "action", "pushMessageToSingleAction"
                },
                {
                    "appkey",
                    APPKEY
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
                    "appId",
                    target.appId
                },
                {
                    "clientId",
                    target.clientId
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
                    "version",
                    "3.0.0.0"
                }
            });
        }
    }
}