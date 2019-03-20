using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using com.gexin.rp.sdk.dto;
using com.igetui.api.openservice.igetui.template.style;
using com.igetui.api.openservice.payload;
using Newtonsoft.Json;

namespace com.igetui.api.openservice.igetui.template
{
    public class StartActivityTemplate : AbstractTemplate
    {
        private string intent;
        private int? notifyid;
        private readonly string pattern = "^(intent:).*(;end)$";
        private AbstractNotifyStyle style;

        public void setNotifyid(int? notifyid)
        {
            var nullable = notifyid;
            var num = 0;
            if ((nullable.GetValueOrDefault() < num ? nullable.HasValue ? 1 : 0 : 0) != 0)
                throw new Exception("notifyid need greater than 0");
            if (!getPushInfoBuilder().InvalidAPN)
            {
                var dictionary =
                    JsonConvert.DeserializeObject<Dictionary<string, object>>(getPushInfoBuilder().ApnJson);
                if (string.IsNullOrEmpty((string) dictionary["apns-collapse-id"]))
                {
                    dictionary.Add("apns-collapse-id", notifyid);
                    getPushInfoBuilder().SetApnJson(JsonConvert.SerializeObject(dictionary));
                }
            }

            this.notifyid = notifyid;
        }

        public new void setAPNInfo(Payload apn)
        {
            if (apn is APNPayload)
            {
                var apnPayload = (APNPayload) apn;
                if (notifyid.HasValue && string.IsNullOrEmpty(apnPayload.getApnsCollapseId()))
                    apnPayload.setApnsCollapseId(notifyid.ToString());
            }

            base.setAPNInfo(apn);
        }

        public override string getPushType()
        {
            return "StartActivity";
        }

        public override List<ActionChain> getActionChain()
        {
            var actionChainList = new List<ActionChain>();
            var actionChain1 = ActionChain.CreateBuilder().SetActionId(1).SetType(ActionChain.Types.Type.Goto)
                .SetNext(10000).Build();
            var actionChain2 = style.getActionChain().ToBuilder().AddField(InnerFiled.CreateBuilder().SetKey("notifyid")
                    .SetVal(!notifyid.HasValue ? "" : string.Concat(notifyid)).SetType(InnerFiled.Types.Type.str)
                    .Build())
                .Build();
            var actionChain3 = ActionChain.CreateBuilder().SetActionId(10010).SetType(ActionChain.Types.Type.Goto)
                .SetNext(11220).Build();
            var actionChain4 = ActionChain.CreateBuilder().SetActionId(11220).SetType(ActionChain.Types.Type.mmsinbox2)
                .SetStype("startmyactivity")
                .AddField(InnerFiled.CreateBuilder().SetKey("uri").SetVal(getIntent())
                    .SetType(InnerFiled.Types.Type.str))
                .AddField(InnerFiled.CreateBuilder().SetKey("do_failed").SetVal("100")
                    .SetType(InnerFiled.Types.Type.str)).SetNext(100).Build();
            var actionChain5 = ActionChain.CreateBuilder().SetActionId(100).SetType(ActionChain.Types.Type.eoa).Build();
            actionChainList.Add(actionChain1);
            actionChainList.Add(actionChain2);
            actionChainList.Add(actionChain3);
            actionChainList.Add(actionChain4);
            actionChainList.Add(actionChain5);
            return actionChainList;
        }

        private string getIntent()
        {
            if (intent != null)
                return intent;
            return "";
        }

        public void setStyle(AbstractNotifyStyle style)
        {
            this.style = style;
        }

        public bool setIntent(string intent)
        {
            if (intent.Length > 1000 || !Regex.IsMatch(intent, pattern))
                return false;
            this.intent = intent;
            return true;
        }

        protected override int getTemplateId()
        {
            return 7;
        }
    }
}