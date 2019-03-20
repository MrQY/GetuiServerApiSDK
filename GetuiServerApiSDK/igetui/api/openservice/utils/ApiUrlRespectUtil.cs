using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;

namespace com.igetui.api.openservice.utils
{
    internal class ApiUrlRespectUtil
    {
        private static readonly object thisLock = new object();
        private static volatile Dictionary<string, string> appFastUrlDict = new Dictionary<string, string>();
        private static volatile bool flag;
        private static volatile string url;
        private static HttpProxy proxy;

        public static string getFastest(string appKey, List<string> hosts)
        {
            flag = false;
            url = "";
            var length = hosts.Count();
            switch (length)
            {
                case 0:
                    throw new Exception("can't get fastest host from empty list");
                case 1:
                    return hosts[0];
                default:
                    if (!appFastUrlDict.ContainsKey(appKey))
                        lock (thisLock)
                        {
                            if (!appFastUrlDict.ContainsKey(appKey))
                            {
                                var threadArray = new Thread[length];
                                for (var index = 0; index < length; ++index)
                                    new Thread(ThreadMethod)
                                    {
                                        IsBackground = true
                                    }.Start(hosts[index]);
                                while (!flag)
                                    Thread.Sleep(1);
                                appFastUrlDict[appKey] = url;
                            }
                        }

                    return appFastUrlDict[appKey];
            }
        }

        public static void setProxy(HttpProxy p)
        {
            proxy = p;
        }

        private static void ThreadMethod(object ob)
        {
            var requestUriString = (string) ob;
            var httpWebRequest1 = (HttpWebRequest) null;
            var httpWebResponse = (HttpWebResponse) null;
            try
            {
                httpWebRequest1 = WebRequest.Create(requestUriString) as HttpWebRequest;
                var webProxy = proxy.getWebProxy();
                if (webProxy != null)
                    httpWebRequest1.Proxy = webProxy;
                httpWebRequest1.Timeout = 30000;
                httpWebRequest1.Method = "HEAD";
                httpWebRequest1.ProtocolVersion = new Version(1, 1);
                httpWebResponse = httpWebRequest1.GetResponse() as HttpWebResponse;
                if (httpWebResponse.StatusCode != HttpStatusCode.OK || flag)
                    return;
                flag = true;
                url = requestUriString;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                HttpWebRequest httpWebRequest2;
                if (httpWebRequest1 != null)
                {
                    httpWebRequest1.Abort();
                    httpWebRequest2 = null;
                }

                if (httpWebResponse != null)
                {
                    httpWebResponse.Close();
                    httpWebRequest2 = null;
                }
            }
        }
    }
}