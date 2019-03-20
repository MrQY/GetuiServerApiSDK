using System.Collections.Generic;
using com.gexin.rp.sdk.dto;
using com.igetui.api.openservice.igetui.template.notify;
using com.igetui.api.openservice.payload;
using Newtonsoft.Json;

namespace com.igetui.api.openservice.igetui.template
{
    public class TransmissionTemplate : AbstractTemplate
    {
        public int TransmissionType { get; set; }

        public string TransmissionContent { get; set; }

        public new void set3rdNotifyInfo(Notify notify)
        {
            if (!getPushInfoBuilder().InvalidAPN && notify.getNotifyId().HasValue)
            {
                var dictionary =
                    JsonConvert.DeserializeObject<Dictionary<string, object>>(getPushInfoBuilder().ApnJson);
                if (string.IsNullOrEmpty((string) dictionary["apns-collapse-id"]))
                {
                    dictionary.Add("apns-collapse-id", notify.getNotifyId());
                    getPushInfoBuilder().SetApnJson(JsonConvert.SerializeObject(dictionary));
                }
            }

            base.set3rdNotifyInfo(notify);
        }

        public new void setAPNInfo(Payload apn)
        {
            if (apn is APNPayload)
            {
                var apnPayload = (APNPayload) apn;
                var notifyId = getPushInfo().NotifyInfo.NotifyId;
                if (notifyId != null && string.IsNullOrEmpty(apnPayload.getApnsCollapseId()))
                    apnPayload.setApnsCollapseId(notifyId);
            }

            base.setAPNInfo(apn);
        }

        public override List<ActionChain> getActionChain()
        {
            var actionChainList = new List<ActionChain>();
            var actionChain1 = ActionChain.CreateBuilder().SetActionId(1).SetType(ActionChain.Types.Type.Goto)
                .SetNext(10030).Build();
            var actionChain2 = ActionChain.CreateBuilder().SetActionId(10030).SetType(ActionChain.Types.Type.startapp)
                .SetAppid("").SetAutostart(1 == TransmissionType)
                .SetAppstartupid(AppStartUp.CreateBuilder().SetAndroid("").SetSymbia("").SetIos("").Build())
                .SetFailedAction(100).SetNext(100).Build();
            var actionChain3 = ActionChain.CreateBuilder().SetActionId(100).SetType(ActionChain.Types.Type.eoa).Build();
            actionChainList.Add(actionChain1);
            actionChainList.Add(actionChain2);
            actionChainList.Add(actionChain3);
            return actionChainList;
        }

        public override string getTransmissionContent()
        {
            return TransmissionContent;
        }

        public override string getPushType()
        {
            return "TransmissionMsg";
        }

        protected override int getTemplateId()
        {
            return 4;
        }
    }
}