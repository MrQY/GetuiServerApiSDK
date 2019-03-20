using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace com.igetui.api.openservice
{
    public class VoIPPayload : Payload
    {
        public string voIPPayload { get; set; }

        public string getPayload()
        {
            var voIpPayload = voIPPayload;
            if (string.IsNullOrEmpty(voIpPayload))
                throw new Exception("payload cannot be empty");
            return JsonConvert.SerializeObject(new Dictionary<string, object>
            {
                {
                    "payload",
                    voIpPayload
                },
                {
                    "isVoIP",
                    1
                }
            });
        }
    }
}