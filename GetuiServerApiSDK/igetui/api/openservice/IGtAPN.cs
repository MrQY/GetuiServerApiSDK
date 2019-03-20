using com.igetui.api.openservice.igetui;
using System.Collections.Generic;

namespace com.igetui.api.openservice
{
  internal interface IGtAPN
  {
    string pushAPNMessageToSingle(string appId, string deviceToken, SingleMessage message);

    string pushAPNMessageToList(string appId, string contentId, List<string> deviceTokenList);

    string getAPNContentId(string appId, ListMessage message);
  }
}
