using System;
using System.Collections.Generic;
using com.gexin.rp.sdk.dto;
using com.igetui.api.openservice.igetui.template.style;

namespace com.igetui.api.openservice.igetui.template
{
    public class NotyPopLoadTemplate : AbstractTemplate
    {
        private int? notifyid;
        private int notifyStyle;
        private AbstractNotifyStyle style;

        public string NotyIcon { get; set; }

        public string LogoURL { get; set; } = "";

        public string NotyTitle { get; set; }

        public string NotyContent { get; set; }

        public bool IsCleared { get; set; } = true;

        public bool IsBelled { get; set; } = true;

        public bool IsVibrationed { get; set; } = true;

        public string PopTitle { get; set; }

        public string PopContent { get; set; }

        public string PopImage { get; set; }

        public string PopButton1 { get; set; }

        public string PopButton2 { get; set; }

        public string LoadIcon { get; set; }

        public string LoadTitle { get; set; }

        public string LoadUrl { get; set; }

        public bool IsAutoInstall { get; set; }

        public bool IsActived { get; set; }

        public string AndroidMark { get; set; } = "";

        public string SymbianMark { get; set; } = "";

        public string IphoneMark { get; set; } = "";

        public void setNotifyid(int? notifyid)
        {
            var nullable = notifyid;
            var num = 0;
            if ((nullable.GetValueOrDefault() < num ? nullable.HasValue ? 1 : 0 : 0) != 0)
                throw new Exception("notifyid need greater than 0");
            this.notifyid = notifyid;
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
                    .AddField(InnerFiled.CreateBuilder().SetKey("title").SetVal(NotyTitle)
                        .SetType(InnerFiled.Types.Type.str).Build())
                    .AddField(InnerFiled.CreateBuilder().SetKey("text").SetVal(NotyContent)
                        .SetType(InnerFiled.Types.Type.str).Build())
                    .AddField(InnerFiled.CreateBuilder().SetKey("logo").SetVal(NotyIcon)
                        .SetType(InnerFiled.Types.Type.str).Build())
                    .AddField(InnerFiled.CreateBuilder().SetKey("logo_url").SetVal(LogoURL)
                        .SetType(InnerFiled.Types.Type.str).Build())
                    .AddField(InnerFiled.CreateBuilder().SetKey("notifyStyle").SetVal(string.Concat(notifyStyle))
                        .SetType(InnerFiled.Types.Type.str).Build()).AddField(InnerFiled.CreateBuilder()
                        .SetKey("is_noring").SetVal((!IsBelled).Equals(true) ? "true" : "false")
                        .SetType(InnerFiled.Types.Type.boole).Build());
                var builder2 = InnerFiled.CreateBuilder().SetKey("is_noclear");
                var flag = !IsCleared;
                var str1 = flag.Equals(true) ? "true" : "false";
                var innerFiled1 = builder2.SetVal(str1).SetType(InnerFiled.Types.Type.boole).Build();
                var builder3 = builder1.AddField(innerFiled1);
                var builder4 = InnerFiled.CreateBuilder().SetKey("is_novibrate");
                flag = !IsVibrationed;
                var str2 = flag.Equals(true) ? "true" : "false";
                var innerFiled2 = builder4.SetVal(str2).SetType(InnerFiled.Types.Type.boole).Build();
                actionChain2 = builder3.AddField(innerFiled2).SetNext(10010).Build();
            }

            var actionChain3 = actionChain2;
            var actionChain4 = ActionChain.CreateBuilder().SetActionId(10010).SetType(ActionChain.Types.Type.Goto)
                .SetNext(10020).Build();
            var actionChain5 = ActionChain.CreateBuilder().SetActionId(10020).SetType(ActionChain.Types.Type.popup)
                .SetTitle(PopTitle).SetText(PopContent).SetImg(PopImage)
                .AddButtons(Button.CreateBuilder().SetText(PopButton1).SetNext(10040).Build())
                .AddButtons(Button.CreateBuilder().SetText(PopButton2).SetNext(100).Build()).SetNext(6).Build();
            var actionChain6 = ActionChain.CreateBuilder().SetActionId(10040)
                .SetType(ActionChain.Types.Type.appdownload).SetName(LoadTitle).SetUrl(LoadUrl).SetLogo(LoadIcon)
                .SetLogoURL(LogoURL).SetAutoInstall(IsAutoInstall).SetAutostart(IsActived)
                .SetAppstartupid(AppStartUp.CreateBuilder().SetAndroid(AndroidMark).SetSymbia(SymbianMark)
                    .SetIos(IphoneMark).Build()).SetNext(6).Build();
            var actionChain7 = ActionChain.CreateBuilder().SetActionId(100).SetType(ActionChain.Types.Type.eoa).Build();
            actionChainList.Add(actionChain1);
            actionChainList.Add(actionChain3);
            actionChainList.Add(actionChain4);
            actionChainList.Add(actionChain5);
            actionChainList.Add(actionChain6);
            actionChainList.Add(actionChain7);
            return actionChainList;
        }

        public override string getPushType()
        {
            return nameof(NotyPopLoadTemplate);
        }

        protected override int getTemplateId()
        {
            return 2;
        }
    }
}