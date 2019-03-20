using System;
using System.Collections.Generic;

namespace com.igetui.api.openservice
{
  public class GtConfig
  {
    public static bool isPushSingleBatchAsync()
    {
      return "true".Equals(Environment.GetEnvironmentVariable("gexin_pushSingleBatch_needAsync"));
    }

    public static bool isPushListNeedAliasDetails()
    {
      string environmentVariable1 = Environment.GetEnvironmentVariable("gexin_pushList_needAliasDetails");
      string environmentVariable2 = Environment.GetEnvironmentVariable("needAliasDetails");
      if (environmentVariable2 != null)
        return environmentVariable2.Equals("true");
      if (environmentVariable1 != null)
        return environmentVariable1.Equals("true");
      return false;
    }

    public static bool isPushListAsync()
    {
      return "true".Equals(Environment.GetEnvironmentVariable("gexin_pushList_needAsync"));
    }

    public static bool isPushListNeedDetails()
    {
      string environmentVariable1 = Environment.GetEnvironmentVariable("gexin_pushList_needDetails");
      string environmentVariable2 = Environment.GetEnvironmentVariable("needDetails");
      if (environmentVariable2 != null)
        return environmentVariable2.Equals("true");
      if (environmentVariable1 != null)
        return environmentVariable1.Equals("true");
      return false;
    }

    public static string getHttpProxyIp()
    {
      return Environment.GetEnvironmentVariable("gexin_http_proxy_ip");
    }

    public static int getTagListLimit()
    {
      string environmentVariable = Environment.GetEnvironmentVariable("gexin_tagList_limit");
      if (environmentVariable == null)
        return 10;
      return int.Parse(environmentVariable);
    }

    public static int getHttpProxyPort()
    {
      string environmentVariable = Environment.GetEnvironmentVariable("gexin_http_proxy_port");
      if (environmentVariable == null)
        return 80;
      return int.Parse(environmentVariable);
    }

    public static string getHttpProxyUser()
    {
      return Environment.GetEnvironmentVariable("gexin_http_proxy_username");
    }

    public static string getHttpProxyPasswd()
    {
      return Environment.GetEnvironmentVariable("gexin_http_proxy_passwd");
    }

    public static int getSyncListLimit()
    {
      string environmentVariable = Environment.GetEnvironmentVariable("gexin_pushList_syncLimit");
      if (environmentVariable == null)
        return 1000;
      return int.Parse(environmentVariable);
    }

    public static int getMaxLenOfBlackCidList()
    {
      string environmentVariable = Environment.GetEnvironmentVariable("gexin_max_blkCid_length");
      if (environmentVariable == null)
        return 1000;
      return int.Parse(environmentVariable);
    }

    public static int getAsyncListLimit()
    {
      string environmentVariable = Environment.GetEnvironmentVariable("gexin_pushList_asyncLimit");
      if (environmentVariable == null)
        return 10000;
      return int.Parse(environmentVariable);
    }

    public static int getHttpConnectionTimeOut()
    {
      string environmentVariable = Environment.GetEnvironmentVariable("gexin_http_connection_timeout");
      if (environmentVariable == null)
        return 60000;
      return int.Parse(environmentVariable);
    }

    public static int getHttpSoTimeOut()
    {
      string environmentVariable = Environment.GetEnvironmentVariable("gexin_http_so_timeout");
      if (environmentVariable == null)
        return 30000;
      return int.Parse(environmentVariable);
    }

    public static int getHttpTryCount()
    {
      string environmentVariable = Environment.GetEnvironmentVariable("gexin_http_tryCount");
      if (environmentVariable == null)
        return 3;
      return int.Parse(environmentVariable);
    }

    public static int getHttpInspectInterval()
    {
      string environmentVariable = Environment.GetEnvironmentVariable("gexin_http_inspect_interval");
      if (environmentVariable == null)
        return 60000;
      return int.Parse(environmentVariable);
    }

    public static List<string> getDefaultDomainUrl(bool useSSL)
    {
      List<string> stringList = new List<string>();
      string environmentVariable = Environment.GetEnvironmentVariable("gexin_default_domainurl");
      if (string.IsNullOrEmpty(environmentVariable))
      {
        if (useSSL)
        {
          stringList.Add("https://cncapi.getui.com/serviceex");
          stringList.Add("https://telapi.getui.com/serviceex");
          stringList.Add("https://api.getui.com/serviceex");
          stringList.Add("https://sdk1api.getui.com/serviceex");
          stringList.Add("https://sdk2api.getui.com/serviceex");
          stringList.Add("https://sdk3api.getui.com/serviceex");
        }
        else
        {
          stringList.Add("http://sdk.open.api.igexin.com/serviceex");
          stringList.Add("http://sdk.open.api.gepush.com/serviceex");
          stringList.Add("http://sdk.open.api.getui.net/serviceex");
          stringList.Add("http://sdk1.open.api.igexin.com/serviceex");
          stringList.Add("http://sdk2.open.api.igexin.com/serviceex");
          stringList.Add("http://sdk3.open.api.igexin.com/serviceex");
        }
      }
      else
      {
        string str1 = environmentVariable;
        char[] chArray = new char[1]{ ',' };
        foreach (string str2 in str1.Split(chArray))
        {
          if ((!str2.StartsWith("https://") || useSSL) && !(str2.StartsWith("http://") & useSSL))
          {
            if (!str2.StartsWith("http") & useSSL)
              stringList.Add("https://" + str2);
            else
              stringList.Add(str2);
          }
        }
      }
      return stringList;
    }

    public static int getTransIntentLength()
    {
      string environmentVariable = Environment.GetEnvironmentVariable("trans_intent_length");
      if (environmentVariable == null)
        return 1000;
      return int.Parse(environmentVariable);
    }

    public static string getSDKVersion()
    {
      return "4.1.0.0";
    }
  }
}
