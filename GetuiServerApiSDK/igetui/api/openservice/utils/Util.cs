using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace com.igetui.api.openservice.utils
{
    internal static class Util
    {
        public static void SetCertificatePolicy()
        {
            ServicePointManager.ServerCertificateValidationCallback += RemoteCertificateValidate;
        }

        private static bool RemoteCertificateValidate(
            object sender,
            X509Certificate cert,
            X509Chain chain,
            SslPolicyErrors error)
        {
            return true;
        }
    }
}