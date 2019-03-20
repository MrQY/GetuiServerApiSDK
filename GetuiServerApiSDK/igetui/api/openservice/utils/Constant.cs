using System.Collections.Generic;

namespace com.igetui.api.openservice.utils
{
  internal class Constant
  {
    public static List<string> GEXIN_SDK_HTTP_URL_LIST = new List<string>()
    {
      "http://sdk.open.api.igexin.com/serviceex",
      "http://sdk.open.api.gepush.com/serviceex",
      "http://sdk.open.api.getui.net/serviceex"
    };
    public static string GEXIN_SDK_HTTP_HOSTLIST_URL = "http://sdk.open.apilist.igexin.com/os_list";
  }
}
