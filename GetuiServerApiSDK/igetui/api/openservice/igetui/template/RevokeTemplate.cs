using System.Collections.Generic;
using com.gexin.rp.sdk.dto;

namespace com.igetui.api.openservice.igetui.template
{
    public class RevokeTemplate : AbstractTemplate
    {
        private bool force;

        public string OldTaskId { get; set; }

        public bool isForce()
        {
            return force;
        }

        public void setForce(bool value)
        {
            force = value;
        }

        public override List<ActionChain> getActionChain()
        {
            var actionChainList = new List<ActionChain>();
            var actionChain1 = ActionChain.CreateBuilder().SetActionId(1).SetType(ActionChain.Types.Type.mmsinbox2)
                .SetStype("terminatetask")
                .AddField(InnerFiled.CreateBuilder().SetKey("taskid").SetVal(OldTaskId)
                    .SetType(InnerFiled.Types.Type.str).Build())
                .AddField(InnerFiled.CreateBuilder().SetKey("force").SetVal(force ? "true" : "false")
                    .SetType(InnerFiled.Types.Type.boole).Build()).SetNext(100).Build();
            var actionChain2 = ActionChain.CreateBuilder().SetActionId(100).SetType(ActionChain.Types.Type.eoa).Build();
            actionChainList.Add(actionChain1);
            actionChainList.Add(actionChain2);
            return actionChainList;
        }

        public override string getPushType()
        {
            return "Revoke";
        }

        protected override int getTemplateId()
        {
            return 8;
        }
    }
}