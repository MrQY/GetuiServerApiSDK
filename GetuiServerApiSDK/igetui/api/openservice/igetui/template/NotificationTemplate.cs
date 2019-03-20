using System;
using System.Collections.Generic;
using com.gexin.rp.sdk.dto;
using com.igetui.api.openservice.igetui.template.style;
using com.igetui.api.openservice.payload;
using Newtonsoft.Json;

namespace com.igetui.api.openservice.igetui.template
{
    public class NotificationTemplate : AbstractTemplate
    {
        private int? notifyid;
        private int notifyStyle;
        private AbstractNotifyStyle style;

        public bool IsRing { get; set; } = true;

        public bool IsVibrate { get; set; } = true;

        public bool IsClearable { get; set; } = true;

        public string Text { get; set; }

        public string Title { get; set; }

        public string Logo { get; set; } = "";

        public string LogoURL { get; set; } = "";

        public int TransmissionType { get; set; }

        public string TransmissionContent { get; set; }

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

        public override List<ActionChain> getActionChain()
        {
            var actionChainList = new List<ActionChain>();
            var actionChain1 = ActionChain.CreateBuilder().SetActionId(1).SetType(ActionChain.Types.Type.Goto)
                .SetNext(10000).Build();
            ActionChain actionChain2;
            if (style != null)
            {
                actionChain2 = style.getActionChain().ToBuilder().AddField(InnerFiled.CreateBuilder().SetKey("notifyid")
                        .SetVal(!notifyid.HasValue ? "" : notifyid.ToString()).SetType(InnerFiled.Types.Type.str)
                        .Build())
                    .Build();
            }
            else
            {
                var builder1 = ActionChain.CreateBuilder().SetActionId(10000).SetType(ActionChain.Types.Type.mmsinbox2)
                    .SetStype("notification")
                    .AddField(InnerFiled.CreateBuilder().SetKey("notifyid")
                        .SetVal(!notifyid.HasValue ? "" : notifyid.ToString()).SetType(InnerFiled.Types.Type.str)
                        .Build())
                    .AddField(InnerFiled.CreateBuilder().SetKey("title").SetVal(Title)
                        .SetType(InnerFiled.Types.Type.str).Build())
                    .AddField(InnerFiled.CreateBuilder().SetKey("text").SetVal(Text).SetType(InnerFiled.Types.Type.str)
                        .Build())
                    .AddField(InnerFiled.CreateBuilder().SetKey("logo").SetVal(Logo).SetType(InnerFiled.Types.Type.str)
                        .Build())
                    .AddField(InnerFiled.CreateBuilder().SetKey("logo_url").SetVal(LogoURL)
                        .SetType(InnerFiled.Types.Type.str).Build()).AddField(InnerFiled.CreateBuilder()
                        .SetKey("notifyStyle").SetVal(notifyStyle.ToString()).SetType(InnerFiled.Types.Type.str)
                        .Build());
                var builder2 = InnerFiled.CreateBuilder().SetKey("is_noring");
                var flag = !IsRing;
                var str1 = flag.Equals(true) ? "true" : "false";
                var innerFiled1 = builder2.SetVal(str1).SetType(InnerFiled.Types.Type.boole).Build();
                var builder3 = builder1.AddField(innerFiled1);
                var builder4 = InnerFiled.CreateBuilder().SetKey("is_noclear");
                flag = !IsClearable;
                var str2 = flag.Equals(true) ? "true" : "false";
                var innerFiled2 = builder4.SetVal(str2).SetType(InnerFiled.Types.Type.boole).Build();
                var builder5 = builder3.AddField(innerFiled2);
                var builder6 = InnerFiled.CreateBuilder().SetKey("is_novibrate");
                flag = !IsVibrate;
                var str3 = flag.Equals(true) ? "true" : "false";
                var innerFiled3 = builder6.SetVal(str3).SetType(InnerFiled.Types.Type.boole).Build();
                actionChain2 = builder5.AddField(innerFiled3).SetNext(10010).Build();
            }

            var actionChain3 = actionChain2;
            var actionChain4 = ActionChain.CreateBuilder().SetActionId(10010).SetType(ActionChain.Types.Type.Goto)
                .SetNext(10030).Build();
            var actionChain5 = ActionChain.CreateBuilder().SetActionId(10030).SetType(ActionChain.Types.Type.startapp)
                .SetAppid("").SetAutostart(1 == TransmissionType)
                .SetAppstartupid(AppStartUp.CreateBuilder().SetAndroid("").SetSymbia("").SetIos("").Build())
                .SetFailedAction(100).SetNext(100).Build();
            var actionChain6 = ActionChain.CreateBuilder().SetActionId(100).SetType(ActionChain.Types.Type.eoa).Build();
            actionChainList.Add(actionChain1);
            actionChainList.Add(actionChain3);
            actionChainList.Add(actionChain4);
            actionChainList.Add(actionChain5);
            actionChainList.Add(actionChain6);
            return actionChainList;
        }

        public override string getTransmissionContent()
        {
            return TransmissionContent;
        }

        public override string getPushType()
        {
            return "NotifyMsg";
        }

        public void setStyle(AbstractNotifyStyle style)
        {
            this.style = style;
        }

        protected override int getTemplateId()
        {
            return 0;
        }
    }
}