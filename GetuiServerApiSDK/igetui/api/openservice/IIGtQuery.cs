using com.igetui.api.openservice.igetui;
using System.Collections.Generic;

namespace com.igetui.api.openservice
{
  public interface IIGtQuery
  {
    string getClientIdStatus(string appId, string clientId);

    string getPushResult(string contentId);

    string getUserTags(string appId, string clientId);

    string getPushResultByGroupName(string appId, string groupName);

    string getLast24HoursOnlineUserStatistics(string appId);

    string getPersonaTags(string appId);

    string queryUserCount(string appId, AppConditions conditions);

    string setBadgeForCID(string badge, string appid, List<string> cidList);

    string setBadgeForDeviceToken(string badge, string appid, List<string> deviceTokenList);
  }
}
