using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Collections;
using Google.ProtocolBuffers.Descriptors;
using Google.ProtocolBuffers.FieldAccess;

namespace com.gexin.rp.sdk.dto
{
    [DebuggerNonUserCode]
    public sealed class ActionChain : GeneratedMessage<ActionChain, ActionChain.Builder>
    {
        public const int ActionIdFieldNumber = 1;
        public const int TypeFieldNumber = 2;
        public const int NextFieldNumber = 3;
        public const int LogoFieldNumber = 100;
        public const int LogoURLFieldNumber = 101;
        public const int TitleFieldNumber = 102;
        public const int TextFieldNumber = 103;
        public const int ClearableFieldNumber = 104;
        public const int RingFieldNumber = 105;
        public const int BuzzFieldNumber = 106;
        public const int BannerURLFieldNumber = 107;
        public const int ImgFieldNumber = 120;
        public const int ButtonsFieldNumber = 121;
        public const int AppidFieldNumber = 140;
        public const int AppstartupidFieldNumber = 141;
        public const int AutostartFieldNumber = 142;
        public const int FailedActionFieldNumber = 143;
        public const int UrlFieldNumber = 160;
        public const int WithcidFieldNumber = 161;
        public const int IsWithnettypeFieldNumber = 162;
        public const int AddressFieldNumber = 180;
        public const int ContentFieldNumber = 181;
        public const int CtFieldNumber = 182;
        public const int FlagFieldNumber = 183;
        public const int SuccessedActionFieldNumber = 200;
        public const int UninstalledActionFieldNumber = 201;
        public const int NameFieldNumber = 220;
        public const int AutoInstallFieldNumber = 223;
        public const int WifiAutodownloadFieldNumber = 225;
        public const int ForceDownloadFieldNumber = 226;
        public const int ShowProgressFieldNumber = 227;
        public const int PostFieldNumber = 241;
        public const int HeadersFieldNumber = 242;
        public const int GroupableFieldNumber = 260;
        public const int MmsTitleFieldNumber = 280;
        public const int MmsURLFieldNumber = 281;
        public const int PreloadFieldNumber = 300;
        public const int TaskidFieldNumber = 320;
        public const int DurationFieldNumber = 340;
        public const int DateFieldNumber = 360;
        public const int StypeFieldNumber = 380;
        public const int FieldFieldNumber = 381;

        private static readonly string[] _actionChainFieldNames = new string[42]
        {
            "actionId",
            "address",
            "appid",
            "appstartupid",
            "autoInstall",
            "autostart",
            "bannerURL",
            "buttons",
            "buzz",
            "clearable",
            "content",
            "ct",
            "date",
            "duration",
            "failedAction",
            "field",
            "flag",
            "forceDownload",
            "groupable",
            "headers",
            "img",
            "is_withnettype",
            "logo",
            "logoURL",
            "mmsTitle",
            "mmsURL",
            "name",
            "next",
            "post",
            "preload",
            "ring",
            "showProgress",
            "stype",
            "successedAction",
            "taskid",
            "text",
            "title",
            "type",
            "uninstalledAction",
            "url",
            "wifiAutodownload",
            "withcid"
        };

        private static readonly uint[] _actionChainFieldTags = new uint[42]
        {
            8U,
            1442U,
            1122U,
            1130U,
            1784U,
            1136U,
            858U,
            970U,
            848U,
            832U,
            1450U,
            1456U,
            2882U,
            2720U,
            1144U,
            3050U,
            1464U,
            1808U,
            2080U,
            1938U,
            962U,
            1296U,
            802U,
            810U,
            2242U,
            2250U,
            1762U,
            24U,
            1930U,
            2400U,
            840U,
            1816U,
            3042U,
            1600U,
            2562U,
            826U,
            818U,
            16U,
            1608U,
            1282U,
            1800U,
            1290U
        };

        private int actionId_;
        private string address_ = "";
        private string appid_ = "";
        private AppStartUp appstartupid_;
        private bool autoInstall_;
        private bool autostart_;
        private string bannerURL_ = "";
        private readonly PopsicleList<Button> buttons_ = new PopsicleList<Button>();
        private bool buzz_;
        private bool clearable_;
        private string content_ = "";
        private long ct_;
        private string date_ = "";
        private long duration_;
        private int failedAction_;
        private readonly PopsicleList<InnerFiled> field_ = new PopsicleList<InnerFiled>();
        private SMSStatus flag_;
        private bool forceDownload_;
        private bool groupable_;
        private string headers_ = "";
        private string img_ = "";
        private bool isWithnettype_;
        private string logo_ = "";
        private string logoURL_ = "";
        private int memoizedSerializedSize = -1;
        private string mmsTitle_ = "";
        private string mmsURL_ = "";
        private string name_ = "";
        private int next_;
        private string post_ = "";
        private bool preload_;
        private bool ring_;
        private bool showProgress_;
        private string stype_ = "";
        private int successedAction_;
        private string taskid_ = "";
        private string text_ = "";
        private string title_ = "";
        private Types.Type type_;
        private int uninstalledAction_;
        private string url_ = "";
        private bool wifiAutodownload_;
        private string withcid_ = "";

        static ActionChain()
        {
            var descriptor = GtReq.Descriptor;
        }

        private ActionChain()
        {
        }

        public static ActionChain DefaultInstance { get; } = new ActionChain().MakeReadOnly();

        public override ActionChain DefaultInstanceForType => DefaultInstance;

        protected override ActionChain ThisMessage => this;

        public static MessageDescriptor Descriptor =>
            GtReq.internal__static_com_gexin_rp_sdk_dto_ActionChain__Descriptor;

        protected override FieldAccessorTable<ActionChain, Builder> InternalFieldAccessors =>
            GtReq.internal__static_com_gexin_rp_sdk_dto_ActionChain__FieldAccessorTable;

        public bool HasActionId { get; private set; }

        public int ActionId => actionId_;

        public bool HasType { get; private set; }

        public Types.Type Type => type_;

        public bool HasNext { get; private set; }

        public int Next => next_;

        public bool HasLogo { get; private set; }

        public string Logo => logo_;

        public bool HasLogoURL { get; private set; }

        public string LogoURL => logoURL_;

        public bool HasTitle { get; private set; }

        public string Title => title_;

        public bool HasText { get; private set; }

        public string Text => text_;

        public bool HasClearable { get; private set; }

        public bool Clearable => clearable_;

        public bool HasRing { get; private set; }

        public bool Ring => ring_;

        public bool HasBuzz { get; private set; }

        public bool Buzz => buzz_;

        public bool HasBannerURL { get; private set; }

        public string BannerURL => bannerURL_;

        public bool HasImg { get; private set; }

        public string Img => img_;

        public IList<Button> ButtonsList => buttons_;

        public int ButtonsCount => buttons_.Count;

        public bool HasAppid { get; private set; }

        public string Appid => appid_;

        public bool HasAppstartupid { get; private set; }

        public AppStartUp Appstartupid => appstartupid_ ?? AppStartUp.DefaultInstance;

        public bool HasAutostart { get; private set; }

        public bool Autostart => autostart_;

        public bool HasFailedAction { get; private set; }

        public int FailedAction => failedAction_;

        public bool HasUrl { get; private set; }

        public string Url => url_;

        public bool HasWithcid { get; private set; }

        public string Withcid => withcid_;

        public bool HasIsWithnettype { get; private set; }

        public bool IsWithnettype => isWithnettype_;

        public bool HasAddress { get; private set; }

        public string Address => address_;

        public bool HasContent { get; private set; }

        public string Content => content_;

        public bool HasCt { get; private set; }

        public long Ct => ct_;

        public bool HasFlag { get; private set; }

        public SMSStatus Flag => flag_;

        public bool HasSuccessedAction { get; private set; }

        public int SuccessedAction => successedAction_;

        public bool HasUninstalledAction { get; private set; }

        public int UninstalledAction => uninstalledAction_;

        public bool HasName { get; private set; }

        public string Name => name_;

        public bool HasAutoInstall { get; private set; }

        public bool AutoInstall => autoInstall_;

        public bool HasWifiAutodownload { get; private set; }

        public bool WifiAutodownload => wifiAutodownload_;

        public bool HasForceDownload { get; private set; }

        public bool ForceDownload => forceDownload_;

        public bool HasShowProgress { get; private set; }

        public bool ShowProgress => showProgress_;

        public bool HasPost { get; private set; }

        public string Post => post_;

        public bool HasHeaders { get; private set; }

        public string Headers => headers_;

        public bool HasGroupable { get; private set; }

        public bool Groupable => groupable_;

        public bool HasMmsTitle { get; private set; }

        public string MmsTitle => mmsTitle_;

        public bool HasMmsURL { get; private set; }

        public string MmsURL => mmsURL_;

        public bool HasPreload { get; private set; }

        public bool Preload => preload_;

        public bool HasTaskid { get; private set; }

        public string Taskid => taskid_;

        public bool HasDuration { get; private set; }

        public long Duration => duration_;

        public bool HasDate { get; private set; }

        public string Date => date_;

        public bool HasStype { get; private set; }

        public string Stype => stype_;

        public IList<InnerFiled> FieldList => field_;

        public int FieldCount => field_.Count;

        public override bool IsInitialized
        {
            get
            {
                if (!HasActionId || !HasType)
                    return false;
                foreach (AbstractMessageLite<InnerFiled, InnerFiled.Builder> field in FieldList)
                    if (!field.IsInitialized)
                        return false;
                return true;
            }
        }

        public override int SerializedSize
        {
            get
            {
                var memoizedSerializedSize = this.memoizedSerializedSize;
                if (memoizedSerializedSize != -1)
                    return memoizedSerializedSize;
                var num1 = 0;
                if (HasActionId)
                    num1 += CodedOutputStream.ComputeInt32Size(1, ActionId);
                if (HasType)
                    num1 += CodedOutputStream.ComputeEnumSize(2, (int) Type);
                if (HasNext)
                    num1 += CodedOutputStream.ComputeInt32Size(3, Next);
                if (HasLogo)
                    num1 += CodedOutputStream.ComputeStringSize(100, Logo);
                if (HasLogoURL)
                    num1 += CodedOutputStream.ComputeStringSize(101, LogoURL);
                if (HasTitle)
                    num1 += CodedOutputStream.ComputeStringSize(102, Title);
                if (HasText)
                    num1 += CodedOutputStream.ComputeStringSize(103, Text);
                if (HasClearable)
                    num1 += CodedOutputStream.ComputeBoolSize(104, Clearable);
                if (HasRing)
                    num1 += CodedOutputStream.ComputeBoolSize(105, Ring);
                if (HasBuzz)
                    num1 += CodedOutputStream.ComputeBoolSize(106, Buzz);
                if (HasBannerURL)
                    num1 += CodedOutputStream.ComputeStringSize(107, BannerURL);
                if (HasImg)
                    num1 += CodedOutputStream.ComputeStringSize(120, Img);
                foreach (var buttons in ButtonsList)
                    num1 += CodedOutputStream.ComputeMessageSize(121, buttons);
                if (HasAppid)
                    num1 += CodedOutputStream.ComputeStringSize(140, Appid);
                if (HasAppstartupid)
                    num1 += CodedOutputStream.ComputeMessageSize(141, Appstartupid);
                if (HasAutostart)
                    num1 += CodedOutputStream.ComputeBoolSize(142, Autostart);
                if (HasFailedAction)
                    num1 += CodedOutputStream.ComputeInt32Size(143, FailedAction);
                if (HasUrl)
                    num1 += CodedOutputStream.ComputeStringSize(160, Url);
                if (HasWithcid)
                    num1 += CodedOutputStream.ComputeStringSize(161, Withcid);
                if (HasIsWithnettype)
                    num1 += CodedOutputStream.ComputeBoolSize(162, IsWithnettype);
                if (HasAddress)
                    num1 += CodedOutputStream.ComputeStringSize(180, Address);
                if (HasContent)
                    num1 += CodedOutputStream.ComputeStringSize(181, Content);
                if (HasCt)
                    num1 += CodedOutputStream.ComputeInt64Size(182, Ct);
                if (HasFlag)
                    num1 += CodedOutputStream.ComputeEnumSize(183, (int) Flag);
                if (HasSuccessedAction)
                    num1 += CodedOutputStream.ComputeInt32Size(200, SuccessedAction);
                if (HasUninstalledAction)
                    num1 += CodedOutputStream.ComputeInt32Size(201, UninstalledAction);
                if (HasName)
                    num1 += CodedOutputStream.ComputeStringSize(220, Name);
                if (HasAutoInstall)
                    num1 += CodedOutputStream.ComputeBoolSize(223, AutoInstall);
                if (HasWifiAutodownload)
                    num1 += CodedOutputStream.ComputeBoolSize(225, WifiAutodownload);
                if (HasForceDownload)
                    num1 += CodedOutputStream.ComputeBoolSize(226, ForceDownload);
                if (HasShowProgress)
                    num1 += CodedOutputStream.ComputeBoolSize(227, ShowProgress);
                if (HasPost)
                    num1 += CodedOutputStream.ComputeStringSize(241, Post);
                if (HasHeaders)
                    num1 += CodedOutputStream.ComputeStringSize(242, Headers);
                if (HasGroupable)
                    num1 += CodedOutputStream.ComputeBoolSize(260, Groupable);
                if (HasMmsTitle)
                    num1 += CodedOutputStream.ComputeStringSize(280, MmsTitle);
                if (HasMmsURL)
                    num1 += CodedOutputStream.ComputeStringSize(281, MmsURL);
                if (HasPreload)
                    num1 += CodedOutputStream.ComputeBoolSize(300, Preload);
                if (HasTaskid)
                    num1 += CodedOutputStream.ComputeStringSize(320, Taskid);
                if (HasDuration)
                    num1 += CodedOutputStream.ComputeInt64Size(340, Duration);
                if (HasDate)
                    num1 += CodedOutputStream.ComputeStringSize(360, Date);
                if (HasStype)
                    num1 += CodedOutputStream.ComputeStringSize(380, Stype);
                foreach (var field in FieldList)
                    num1 += CodedOutputStream.ComputeMessageSize(381, field);
                var num2 = num1 + UnknownFields.SerializedSize;
                this.memoizedSerializedSize = num2;
                return num2;
            }
        }

        public Button GetButtons(int index)
        {
            return buttons_[index];
        }

        public InnerFiled GetField(int index)
        {
            return field_[index];
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            var serializedSize = SerializedSize;
            var actionChainFieldNames = _actionChainFieldNames;
            if (HasActionId)
                output.WriteInt32(1, actionChainFieldNames[0], ActionId);
            if (HasType)
                output.WriteEnum(2, actionChainFieldNames[37], (int) Type, Type);
            if (HasNext)
                output.WriteInt32(3, actionChainFieldNames[27], Next);
            if (HasLogo)
                output.WriteString(100, actionChainFieldNames[22], Logo);
            if (HasLogoURL)
                output.WriteString(101, actionChainFieldNames[23], LogoURL);
            if (HasTitle)
                output.WriteString(102, actionChainFieldNames[36], Title);
            if (HasText)
                output.WriteString(103, actionChainFieldNames[35], Text);
            if (HasClearable)
                output.WriteBool(104, actionChainFieldNames[9], Clearable);
            if (HasRing)
                output.WriteBool(105, actionChainFieldNames[30], Ring);
            if (HasBuzz)
                output.WriteBool(106, actionChainFieldNames[8], Buzz);
            if (HasBannerURL)
                output.WriteString(107, actionChainFieldNames[6], BannerURL);
            if (HasImg)
                output.WriteString(120, actionChainFieldNames[20], Img);
            if (buttons_.Count > 0)
                output.WriteMessageArray(121, actionChainFieldNames[7], buttons_);
            if (HasAppid)
                output.WriteString(140, actionChainFieldNames[2], Appid);
            if (HasAppstartupid)
                output.WriteMessage(141, actionChainFieldNames[3], Appstartupid);
            if (HasAutostart)
                output.WriteBool(142, actionChainFieldNames[5], Autostart);
            if (HasFailedAction)
                output.WriteInt32(143, actionChainFieldNames[14], FailedAction);
            if (HasUrl)
                output.WriteString(160, actionChainFieldNames[39], Url);
            if (HasWithcid)
                output.WriteString(161, actionChainFieldNames[41], Withcid);
            if (HasIsWithnettype)
                output.WriteBool(162, actionChainFieldNames[21], IsWithnettype);
            if (HasAddress)
                output.WriteString(180, actionChainFieldNames[1], Address);
            if (HasContent)
                output.WriteString(181, actionChainFieldNames[10], Content);
            if (HasCt)
                output.WriteInt64(182, actionChainFieldNames[11], Ct);
            if (HasFlag)
                output.WriteEnum(183, actionChainFieldNames[16], (int) Flag, Flag);
            if (HasSuccessedAction)
                output.WriteInt32(200, actionChainFieldNames[33], SuccessedAction);
            if (HasUninstalledAction)
                output.WriteInt32(201, actionChainFieldNames[38], UninstalledAction);
            if (HasName)
                output.WriteString(220, actionChainFieldNames[26], Name);
            if (HasAutoInstall)
                output.WriteBool(223, actionChainFieldNames[4], AutoInstall);
            if (HasWifiAutodownload)
                output.WriteBool(225, actionChainFieldNames[40], WifiAutodownload);
            if (HasForceDownload)
                output.WriteBool(226, actionChainFieldNames[17], ForceDownload);
            if (HasShowProgress)
                output.WriteBool(227, actionChainFieldNames[31], ShowProgress);
            if (HasPost)
                output.WriteString(241, actionChainFieldNames[28], Post);
            if (HasHeaders)
                output.WriteString(242, actionChainFieldNames[19], Headers);
            if (HasGroupable)
                output.WriteBool(260, actionChainFieldNames[18], Groupable);
            if (HasMmsTitle)
                output.WriteString(280, actionChainFieldNames[24], MmsTitle);
            if (HasMmsURL)
                output.WriteString(281, actionChainFieldNames[25], MmsURL);
            if (HasPreload)
                output.WriteBool(300, actionChainFieldNames[29], Preload);
            if (HasTaskid)
                output.WriteString(320, actionChainFieldNames[34], Taskid);
            if (HasDuration)
                output.WriteInt64(340, actionChainFieldNames[13], Duration);
            if (HasDate)
                output.WriteString(360, actionChainFieldNames[12], Date);
            if (HasStype)
                output.WriteString(380, actionChainFieldNames[32], Stype);
            if (field_.Count > 0)
                output.WriteMessageArray(381, actionChainFieldNames[15], field_);
            UnknownFields.WriteTo(output);
        }

        public static ActionChain ParseFrom(ByteString data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public static ActionChain ParseFrom(
            ByteString data,
            ExtensionRegistry extensionRegistry)
        {
            return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
        }

        public static ActionChain ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public static ActionChain ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
        {
            return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
        }

        public static ActionChain ParseFrom(Stream input)
        {
            return CreateBuilder().MergeFrom(input).BuildParsed();
        }

        public static ActionChain ParseFrom(
            Stream input,
            ExtensionRegistry extensionRegistry)
        {
            return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
        }

        public static ActionChain ParseDelimitedFrom(Stream input)
        {
            return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
        }

        public static ActionChain ParseDelimitedFrom(
            Stream input,
            ExtensionRegistry extensionRegistry)
        {
            return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
        }

        public static ActionChain ParseFrom(ICodedInputStream input)
        {
            return CreateBuilder().MergeFrom(input).BuildParsed();
        }

        public static ActionChain ParseFrom(
            ICodedInputStream input,
            ExtensionRegistry extensionRegistry)
        {
            return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
        }

        private ActionChain MakeReadOnly()
        {
            buttons_.MakeReadOnly();
            field_.MakeReadOnly();
            return this;
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(ActionChain prototype)
        {
            return new Builder(prototype);
        }

        [DebuggerNonUserCode]
        public static class Types
        {
            public enum Type
            {
                Goto,
                notification,
                popup,
                startapp,
                startweb,
                smsinbox,
                checkapp,
                eoa,
                appdownload,
                startsms,
                httpproxy,
                smsinbox2,
                mmsinbox2,
                popupweb,
                dial,
                reportbindapp,
                reportaddphoneinfo,
                reportapplist,
                terminatetask,
                reportapp,
                enablelog,
                disablelog,
                uploadlog
            }
        }

        [DebuggerNonUserCode]
        public sealed class Builder : GeneratedBuilder<ActionChain, Builder>
        {
            private ActionChain result;
            private bool resultIsReadOnly;

            public Builder()
            {
                result = DefaultInstance;
                resultIsReadOnly = true;
            }

            internal Builder(ActionChain cloneFrom)
            {
                result = cloneFrom;
                resultIsReadOnly = true;
            }

            protected override Builder ThisBuilder => this;

            public override bool IsInitialized => result.IsInitialized;

            protected override ActionChain MessageBeingBuilt => PrepareBuilder();

            public override MessageDescriptor DescriptorForType => Descriptor;

            public override ActionChain DefaultInstanceForType => DefaultInstance;

            public bool HasActionId => result.HasActionId;

            public int ActionId
            {
                get => result.ActionId;
                set => SetActionId(value);
            }

            public bool HasType => result.HasType;

            public Types.Type Type
            {
                get => result.Type;
                set => SetType(value);
            }

            public bool HasNext => result.HasNext;

            public int Next
            {
                get => result.Next;
                set => SetNext(value);
            }

            public bool HasLogo => result.HasLogo;

            public string Logo
            {
                get => result.Logo;
                set => SetLogo(value);
            }

            public bool HasLogoURL => result.HasLogoURL;

            public string LogoURL
            {
                get => result.LogoURL;
                set => SetLogoURL(value);
            }

            public bool HasTitle => result.HasTitle;

            public string Title
            {
                get => result.Title;
                set => SetTitle(value);
            }

            public bool HasText => result.HasText;

            public string Text
            {
                get => result.Text;
                set => SetText(value);
            }

            public bool HasClearable => result.HasClearable;

            public bool Clearable
            {
                get => result.Clearable;
                set => SetClearable(value);
            }

            public bool HasRing => result.HasRing;

            public bool Ring
            {
                get => result.Ring;
                set => SetRing(value);
            }

            public bool HasBuzz => result.HasBuzz;

            public bool Buzz
            {
                get => result.Buzz;
                set => SetBuzz(value);
            }

            public bool HasBannerURL => result.HasBannerURL;

            public string BannerURL
            {
                get => result.BannerURL;
                set => SetBannerURL(value);
            }

            public bool HasImg => result.HasImg;

            public string Img
            {
                get => result.Img;
                set => SetImg(value);
            }

            public IPopsicleList<Button> ButtonsList => PrepareBuilder().buttons_;

            public int ButtonsCount => result.ButtonsCount;

            public bool HasAppid => result.HasAppid;

            public string Appid
            {
                get => result.Appid;
                set => SetAppid(value);
            }

            public bool HasAppstartupid => result.HasAppstartupid;

            public AppStartUp Appstartupid
            {
                get => result.Appstartupid;
                set => SetAppstartupid(value);
            }

            public bool HasAutostart => result.HasAutostart;

            public bool Autostart
            {
                get => result.Autostart;
                set => SetAutostart(value);
            }

            public bool HasFailedAction => result.HasFailedAction;

            public int FailedAction
            {
                get => result.FailedAction;
                set => SetFailedAction(value);
            }

            public bool HasUrl => result.HasUrl;

            public string Url
            {
                get => result.Url;
                set => SetUrl(value);
            }

            public bool HasWithcid => result.HasWithcid;

            public string Withcid
            {
                get => result.Withcid;
                set => SetWithcid(value);
            }

            public bool HasIsWithnettype => result.HasIsWithnettype;

            public bool IsWithnettype
            {
                get => result.IsWithnettype;
                set => SetIsWithnettype(value);
            }

            public bool HasAddress => result.HasAddress;

            public string Address
            {
                get => result.Address;
                set => SetAddress(value);
            }

            public bool HasContent => result.HasContent;

            public string Content
            {
                get => result.Content;
                set => SetContent(value);
            }

            public bool HasCt => result.HasCt;

            public long Ct
            {
                get => result.Ct;
                set => SetCt(value);
            }

            public bool HasFlag => result.HasFlag;

            public SMSStatus Flag
            {
                get => result.Flag;
                set => SetFlag(value);
            }

            public bool HasSuccessedAction => result.HasSuccessedAction;

            public int SuccessedAction
            {
                get => result.SuccessedAction;
                set => SetSuccessedAction(value);
            }

            public bool HasUninstalledAction => result.HasUninstalledAction;

            public int UninstalledAction
            {
                get => result.UninstalledAction;
                set => SetUninstalledAction(value);
            }

            public bool HasName => result.HasName;

            public string Name
            {
                get => result.Name;
                set => SetName(value);
            }

            public bool HasAutoInstall => result.HasAutoInstall;

            public bool AutoInstall
            {
                get => result.AutoInstall;
                set => SetAutoInstall(value);
            }

            public bool HasWifiAutodownload => result.HasWifiAutodownload;

            public bool WifiAutodownload
            {
                get => result.WifiAutodownload;
                set => SetWifiAutodownload(value);
            }

            public bool HasForceDownload => result.HasForceDownload;

            public bool ForceDownload
            {
                get => result.ForceDownload;
                set => SetForceDownload(value);
            }

            public bool HasShowProgress => result.HasShowProgress;

            public bool ShowProgress
            {
                get => result.ShowProgress;
                set => SetShowProgress(value);
            }

            public bool HasPost => result.HasPost;

            public string Post
            {
                get => result.Post;
                set => SetPost(value);
            }

            public bool HasHeaders => result.HasHeaders;

            public string Headers
            {
                get => result.Headers;
                set => SetHeaders(value);
            }

            public bool HasGroupable => result.HasGroupable;

            public bool Groupable
            {
                get => result.Groupable;
                set => SetGroupable(value);
            }

            public bool HasMmsTitle => result.HasMmsTitle;

            public string MmsTitle
            {
                get => result.MmsTitle;
                set => SetMmsTitle(value);
            }

            public bool HasMmsURL => result.HasMmsURL;

            public string MmsURL
            {
                get => result.MmsURL;
                set => SetMmsURL(value);
            }

            public bool HasPreload => result.HasPreload;

            public bool Preload
            {
                get => result.Preload;
                set => SetPreload(value);
            }

            public bool HasTaskid => result.HasTaskid;

            public string Taskid
            {
                get => result.Taskid;
                set => SetTaskid(value);
            }

            public bool HasDuration => result.HasDuration;

            public long Duration
            {
                get => result.Duration;
                set => SetDuration(value);
            }

            public bool HasDate => result.HasDate;

            public string Date
            {
                get => result.Date;
                set => SetDate(value);
            }

            public bool HasStype => result.HasStype;

            public string Stype
            {
                get => result.Stype;
                set => SetStype(value);
            }

            public IPopsicleList<InnerFiled> FieldList => PrepareBuilder().field_;

            public int FieldCount => result.FieldCount;

            private ActionChain PrepareBuilder()
            {
                if (resultIsReadOnly)
                {
                    var result = this.result;
                    this.result = new ActionChain();
                    resultIsReadOnly = false;
                    MergeFrom(result);
                }

                return this.result;
            }

            public override Builder Clear()
            {
                result = DefaultInstance;
                resultIsReadOnly = true;
                return this;
            }

            public override Builder Clone()
            {
                if (resultIsReadOnly)
                    return new Builder(result);
                return new Builder().MergeFrom(result);
            }

            public override ActionChain BuildPartial()
            {
                if (resultIsReadOnly)
                    return result;
                resultIsReadOnly = true;
                return result.MakeReadOnly();
            }

            public override Builder MergeFrom(IMessage other)
            {
                if (other is ActionChain)
                    return MergeFrom((ActionChain) other);
                base.MergeFrom(other);
                return this;
            }

            public override Builder MergeFrom(ActionChain other)
            {
                if (other == DefaultInstance)
                    return this;
                PrepareBuilder();
                if (other.HasActionId)
                    ActionId = other.ActionId;
                if (other.HasType)
                    Type = other.Type;
                if (other.HasNext)
                    Next = other.Next;
                if (other.HasLogo)
                    Logo = other.Logo;
                if (other.HasLogoURL)
                    LogoURL = other.LogoURL;
                if (other.HasTitle)
                    Title = other.Title;
                if (other.HasText)
                    Text = other.Text;
                if (other.HasClearable)
                    Clearable = other.Clearable;
                if (other.HasRing)
                    Ring = other.Ring;
                if (other.HasBuzz)
                    Buzz = other.Buzz;
                if (other.HasBannerURL)
                    BannerURL = other.BannerURL;
                if (other.HasImg)
                    Img = other.Img;
                if (other.buttons_.Count != 0)
                    result.buttons_.Add(other.buttons_);
                if (other.HasAppid)
                    Appid = other.Appid;
                if (other.HasAppstartupid)
                    MergeAppstartupid(other.Appstartupid);
                if (other.HasAutostart)
                    Autostart = other.Autostart;
                if (other.HasFailedAction)
                    FailedAction = other.FailedAction;
                if (other.HasUrl)
                    Url = other.Url;
                if (other.HasWithcid)
                    Withcid = other.Withcid;
                if (other.HasIsWithnettype)
                    IsWithnettype = other.IsWithnettype;
                if (other.HasAddress)
                    Address = other.Address;
                if (other.HasContent)
                    Content = other.Content;
                if (other.HasCt)
                    Ct = other.Ct;
                if (other.HasFlag)
                    Flag = other.Flag;
                if (other.HasSuccessedAction)
                    SuccessedAction = other.SuccessedAction;
                if (other.HasUninstalledAction)
                    UninstalledAction = other.UninstalledAction;
                if (other.HasName)
                    Name = other.Name;
                if (other.HasAutoInstall)
                    AutoInstall = other.AutoInstall;
                if (other.HasWifiAutodownload)
                    WifiAutodownload = other.WifiAutodownload;
                if (other.HasForceDownload)
                    ForceDownload = other.ForceDownload;
                if (other.HasShowProgress)
                    ShowProgress = other.ShowProgress;
                if (other.HasPost)
                    Post = other.Post;
                if (other.HasHeaders)
                    Headers = other.Headers;
                if (other.HasGroupable)
                    Groupable = other.Groupable;
                if (other.HasMmsTitle)
                    MmsTitle = other.MmsTitle;
                if (other.HasMmsURL)
                    MmsURL = other.MmsURL;
                if (other.HasPreload)
                    Preload = other.Preload;
                if (other.HasTaskid)
                    Taskid = other.Taskid;
                if (other.HasDuration)
                    Duration = other.Duration;
                if (other.HasDate)
                    Date = other.Date;
                if (other.HasStype)
                    Stype = other.Stype;
                if (other.field_.Count != 0)
                    result.field_.Add(other.field_);
                MergeUnknownFields(other.UnknownFields);
                return this;
            }

            public override Builder MergeFrom(ICodedInputStream input)
            {
                return MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override Builder MergeFrom(
                ICodedInputStream input,
                ExtensionRegistry extensionRegistry)
            {
                PrepareBuilder();
                var unknownFields = (UnknownFieldSet.Builder) null;
                uint fieldTag;
                string fieldName;
                while (input.ReadTag(out fieldTag, out fieldName))
                {
                    if (fieldTag == 0U && fieldName != null)
                    {
                        var index = Array.BinarySearch(_actionChainFieldNames, fieldName, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            fieldTag = _actionChainFieldTags[index];
                        }
                        else
                        {
                            if (unknownFields == null)
                                unknownFields = UnknownFieldSet.CreateBuilder(UnknownFields);
                            ParseUnknownField(input, unknownFields, extensionRegistry, fieldTag, fieldName);
                            continue;
                        }
                    }

                    switch (fieldTag)
                    {
                        case 0:
                            throw InvalidProtocolBufferException.InvalidTag();
                        case 8:
                            result.HasActionId = input.ReadInt32(ref result.actionId_);
                            continue;
                        case 16:
                            object unknown1;
                            if (input.ReadEnum(ref result.type_, out unknown1))
                            {
                                result.HasType = true;
                                continue;
                            }

                            if (unknown1 is int)
                            {
                                if (unknownFields == null)
                                    unknownFields = UnknownFieldSet.CreateBuilder(UnknownFields);
                                unknownFields.MergeVarintField(2, (ulong) (int) unknown1);
                            }

                            continue;
                        case 24:
                            result.HasNext = input.ReadInt32(ref result.next_);
                            continue;
                        case 802:
                            result.HasLogo = input.ReadString(ref result.logo_);
                            continue;
                        case 810:
                            result.HasLogoURL = input.ReadString(ref result.logoURL_);
                            continue;
                        case 818:
                            result.HasTitle = input.ReadString(ref result.title_);
                            continue;
                        case 826:
                            result.HasText = input.ReadString(ref result.text_);
                            continue;
                        case 832:
                            result.HasClearable = input.ReadBool(ref result.clearable_);
                            continue;
                        case 840:
                            result.HasRing = input.ReadBool(ref result.ring_);
                            continue;
                        case 848:
                            result.HasBuzz = input.ReadBool(ref result.buzz_);
                            continue;
                        case 858:
                            result.HasBannerURL = input.ReadString(ref result.bannerURL_);
                            continue;
                        case 962:
                            result.HasImg = input.ReadString(ref result.img_);
                            continue;
                        case 970:
                            input.ReadMessageArray(fieldTag, fieldName, result.buttons_, Button.DefaultInstance,
                                extensionRegistry);
                            continue;
                        case 1122:
                            result.HasAppid = input.ReadString(ref result.appid_);
                            continue;
                        case 1130:
                            var builder = AppStartUp.CreateBuilder();
                            if (result.HasAppstartupid)
                                builder.MergeFrom(Appstartupid);
                            input.ReadMessage(builder, extensionRegistry);
                            Appstartupid = builder.BuildPartial();
                            continue;
                        case 1136:
                            result.HasAutostart = input.ReadBool(ref result.autostart_);
                            continue;
                        case 1144:
                            result.HasFailedAction = input.ReadInt32(ref result.failedAction_);
                            continue;
                        case 1282:
                            result.HasUrl = input.ReadString(ref result.url_);
                            continue;
                        case 1290:
                            result.HasWithcid = input.ReadString(ref result.withcid_);
                            continue;
                        case 1296:
                            result.HasIsWithnettype = input.ReadBool(ref result.isWithnettype_);
                            continue;
                        case 1442:
                            result.HasAddress = input.ReadString(ref result.address_);
                            continue;
                        case 1450:
                            result.HasContent = input.ReadString(ref result.content_);
                            continue;
                        case 1456:
                            result.HasCt = input.ReadInt64(ref result.ct_);
                            continue;
                        case 1464:
                            object unknown2;
                            if (input.ReadEnum(ref result.flag_, out unknown2))
                            {
                                result.HasFlag = true;
                                continue;
                            }

                            if (unknown2 is int)
                            {
                                if (unknownFields == null)
                                    unknownFields = UnknownFieldSet.CreateBuilder(UnknownFields);
                                unknownFields.MergeVarintField(183, (ulong) (int) unknown2);
                            }

                            continue;
                        case 1600:
                            result.HasSuccessedAction = input.ReadInt32(ref result.successedAction_);
                            continue;
                        case 1608:
                            result.HasUninstalledAction = input.ReadInt32(ref result.uninstalledAction_);
                            continue;
                        case 1762:
                            result.HasName = input.ReadString(ref result.name_);
                            continue;
                        case 1784:
                            result.HasAutoInstall = input.ReadBool(ref result.autoInstall_);
                            continue;
                        case 1800:
                            result.HasWifiAutodownload = input.ReadBool(ref result.wifiAutodownload_);
                            continue;
                        case 1808:
                            result.HasForceDownload = input.ReadBool(ref result.forceDownload_);
                            continue;
                        case 1816:
                            result.HasShowProgress = input.ReadBool(ref result.showProgress_);
                            continue;
                        case 1930:
                            result.HasPost = input.ReadString(ref result.post_);
                            continue;
                        case 1938:
                            result.HasHeaders = input.ReadString(ref result.headers_);
                            continue;
                        case 2080:
                            result.HasGroupable = input.ReadBool(ref result.groupable_);
                            continue;
                        case 2242:
                            result.HasMmsTitle = input.ReadString(ref result.mmsTitle_);
                            continue;
                        case 2250:
                            result.HasMmsURL = input.ReadString(ref result.mmsURL_);
                            continue;
                        case 2400:
                            result.HasPreload = input.ReadBool(ref result.preload_);
                            continue;
                        case 2562:
                            result.HasTaskid = input.ReadString(ref result.taskid_);
                            continue;
                        case 2720:
                            result.HasDuration = input.ReadInt64(ref result.duration_);
                            continue;
                        case 2882:
                            result.HasDate = input.ReadString(ref result.date_);
                            continue;
                        case 3042:
                            result.HasStype = input.ReadString(ref result.stype_);
                            continue;
                        case 3050:
                            input.ReadMessageArray(fieldTag, fieldName, result.field_, InnerFiled.DefaultInstance,
                                extensionRegistry);
                            continue;
                        default:
                            if (WireFormat.IsEndGroupTag(fieldTag))
                            {
                                if (unknownFields != null)
                                    UnknownFields = unknownFields.Build();
                                return this;
                            }

                            if (unknownFields == null)
                                unknownFields = UnknownFieldSet.CreateBuilder(UnknownFields);
                            ParseUnknownField(input, unknownFields, extensionRegistry, fieldTag, fieldName);
                            continue;
                    }
                }

                if (unknownFields != null)
                    UnknownFields = unknownFields.Build();
                return this;
            }

            public Builder SetActionId(int value)
            {
                PrepareBuilder();
                result.HasActionId = true;
                result.actionId_ = value;
                return this;
            }

            public Builder ClearActionId()
            {
                PrepareBuilder();
                result.HasActionId = false;
                result.actionId_ = 0;
                return this;
            }

            public Builder SetType(Types.Type value)
            {
                PrepareBuilder();
                result.HasType = true;
                result.type_ = value;
                return this;
            }

            public Builder ClearType()
            {
                PrepareBuilder();
                result.HasType = false;
                result.type_ = Types.Type.Goto;
                return this;
            }

            public Builder SetNext(int value)
            {
                PrepareBuilder();
                result.HasNext = true;
                result.next_ = value;
                return this;
            }

            public Builder ClearNext()
            {
                PrepareBuilder();
                result.HasNext = false;
                result.next_ = 0;
                return this;
            }

            public Builder SetLogo(string value)
            {
                ThrowHelper.ThrowIfNull(value, nameof(value));
                PrepareBuilder();
                result.HasLogo = true;
                result.logo_ = value;
                return this;
            }

            public Builder ClearLogo()
            {
                PrepareBuilder();
                result.HasLogo = false;
                result.logo_ = "";
                return this;
            }

            public Builder SetLogoURL(string value)
            {
                ThrowHelper.ThrowIfNull(value, nameof(value));
                PrepareBuilder();
                result.HasLogoURL = true;
                result.logoURL_ = value;
                return this;
            }

            public Builder ClearLogoURL()
            {
                PrepareBuilder();
                result.HasLogoURL = false;
                result.logoURL_ = "";
                return this;
            }

            public Builder SetTitle(string value)
            {
                ThrowHelper.ThrowIfNull(value, nameof(value));
                PrepareBuilder();
                result.HasTitle = true;
                result.title_ = value;
                return this;
            }

            public Builder ClearTitle()
            {
                PrepareBuilder();
                result.HasTitle = false;
                result.title_ = "";
                return this;
            }

            public Builder SetText(string value)
            {
                ThrowHelper.ThrowIfNull(value, nameof(value));
                PrepareBuilder();
                result.HasText = true;
                result.text_ = value;
                return this;
            }

            public Builder ClearText()
            {
                PrepareBuilder();
                result.HasText = false;
                result.text_ = "";
                return this;
            }

            public Builder SetClearable(bool value)
            {
                PrepareBuilder();
                result.HasClearable = true;
                result.clearable_ = value;
                return this;
            }

            public Builder ClearClearable()
            {
                PrepareBuilder();
                result.HasClearable = false;
                result.clearable_ = false;
                return this;
            }

            public Builder SetRing(bool value)
            {
                PrepareBuilder();
                result.HasRing = true;
                result.ring_ = value;
                return this;
            }

            public Builder ClearRing()
            {
                PrepareBuilder();
                result.HasRing = false;
                result.ring_ = false;
                return this;
            }

            public Builder SetBuzz(bool value)
            {
                PrepareBuilder();
                result.HasBuzz = true;
                result.buzz_ = value;
                return this;
            }

            public Builder ClearBuzz()
            {
                PrepareBuilder();
                result.HasBuzz = false;
                result.buzz_ = false;
                return this;
            }

            public Builder SetBannerURL(string value)
            {
                ThrowHelper.ThrowIfNull(value, nameof(value));
                PrepareBuilder();
                result.HasBannerURL = true;
                result.bannerURL_ = value;
                return this;
            }

            public Builder ClearBannerURL()
            {
                PrepareBuilder();
                result.HasBannerURL = false;
                result.bannerURL_ = "";
                return this;
            }

            public Builder SetImg(string value)
            {
                ThrowHelper.ThrowIfNull(value, nameof(value));
                PrepareBuilder();
                result.HasImg = true;
                result.img_ = value;
                return this;
            }

            public Builder ClearImg()
            {
                PrepareBuilder();
                result.HasImg = false;
                result.img_ = "";
                return this;
            }

            public Button GetButtons(int index)
            {
                return result.GetButtons(index);
            }

            public Builder SetButtons(int index, Button value)
            {
                ThrowHelper.ThrowIfNull(value, nameof(value));
                PrepareBuilder();
                result.buttons_[index] = value;
                return this;
            }

            public Builder SetButtons(int index, Button.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, nameof(builderForValue));
                PrepareBuilder();
                result.buttons_[index] = builderForValue.Build();
                return this;
            }

            public Builder AddButtons(Button value)
            {
                ThrowHelper.ThrowIfNull(value, nameof(value));
                PrepareBuilder();
                result.buttons_.Add(value);
                return this;
            }

            public Builder AddButtons(Button.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, nameof(builderForValue));
                PrepareBuilder();
                result.buttons_.Add(builderForValue.Build());
                return this;
            }

            public Builder AddRangeButtons(IEnumerable<Button> values)
            {
                PrepareBuilder();
                result.buttons_.Add(values);
                return this;
            }

            public Builder ClearButtons()
            {
                PrepareBuilder();
                result.buttons_.Clear();
                return this;
            }

            public Builder SetAppid(string value)
            {
                ThrowHelper.ThrowIfNull(value, nameof(value));
                PrepareBuilder();
                result.HasAppid = true;
                result.appid_ = value;
                return this;
            }

            public Builder ClearAppid()
            {
                PrepareBuilder();
                result.HasAppid = false;
                result.appid_ = "";
                return this;
            }

            public Builder SetAppstartupid(AppStartUp value)
            {
                ThrowHelper.ThrowIfNull(value, nameof(value));
                PrepareBuilder();
                result.HasAppstartupid = true;
                result.appstartupid_ = value;
                return this;
            }

            public Builder SetAppstartupid(AppStartUp.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, nameof(builderForValue));
                PrepareBuilder();
                result.HasAppstartupid = true;
                result.appstartupid_ = builderForValue.Build();
                return this;
            }

            public Builder MergeAppstartupid(AppStartUp value)
            {
                ThrowHelper.ThrowIfNull(value, nameof(value));
                PrepareBuilder();
                result.appstartupid_ = !result.HasAppstartupid || result.appstartupid_ == AppStartUp.DefaultInstance
                    ? value
                    : AppStartUp.CreateBuilder(result.appstartupid_).MergeFrom(value).BuildPartial();
                result.HasAppstartupid = true;
                return this;
            }

            public Builder ClearAppstartupid()
            {
                PrepareBuilder();
                result.HasAppstartupid = false;
                result.appstartupid_ = null;
                return this;
            }

            public Builder SetAutostart(bool value)
            {
                PrepareBuilder();
                result.HasAutostart = true;
                result.autostart_ = value;
                return this;
            }

            public Builder ClearAutostart()
            {
                PrepareBuilder();
                result.HasAutostart = false;
                result.autostart_ = false;
                return this;
            }

            public Builder SetFailedAction(int value)
            {
                PrepareBuilder();
                result.HasFailedAction = true;
                result.failedAction_ = value;
                return this;
            }

            public Builder ClearFailedAction()
            {
                PrepareBuilder();
                result.HasFailedAction = false;
                result.failedAction_ = 0;
                return this;
            }

            public Builder SetUrl(string value)
            {
                ThrowHelper.ThrowIfNull(value, nameof(value));
                PrepareBuilder();
                result.HasUrl = true;
                result.url_ = value;
                return this;
            }

            public Builder ClearUrl()
            {
                PrepareBuilder();
                result.HasUrl = false;
                result.url_ = "";
                return this;
            }

            public Builder SetWithcid(string value)
            {
                ThrowHelper.ThrowIfNull(value, nameof(value));
                PrepareBuilder();
                result.HasWithcid = true;
                result.withcid_ = value;
                return this;
            }

            public Builder ClearWithcid()
            {
                PrepareBuilder();
                result.HasWithcid = false;
                result.withcid_ = "";
                return this;
            }

            public Builder SetIsWithnettype(bool value)
            {
                PrepareBuilder();
                result.HasIsWithnettype = true;
                result.isWithnettype_ = value;
                return this;
            }

            public Builder ClearIsWithnettype()
            {
                PrepareBuilder();
                result.HasIsWithnettype = false;
                result.isWithnettype_ = false;
                return this;
            }

            public Builder SetAddress(string value)
            {
                ThrowHelper.ThrowIfNull(value, nameof(value));
                PrepareBuilder();
                result.HasAddress = true;
                result.address_ = value;
                return this;
            }

            public Builder ClearAddress()
            {
                PrepareBuilder();
                result.HasAddress = false;
                result.address_ = "";
                return this;
            }

            public Builder SetContent(string value)
            {
                ThrowHelper.ThrowIfNull(value, nameof(value));
                PrepareBuilder();
                result.HasContent = true;
                result.content_ = value;
                return this;
            }

            public Builder ClearContent()
            {
                PrepareBuilder();
                result.HasContent = false;
                result.content_ = "";
                return this;
            }

            public Builder SetCt(long value)
            {
                PrepareBuilder();
                result.HasCt = true;
                result.ct_ = value;
                return this;
            }

            public Builder ClearCt()
            {
                PrepareBuilder();
                result.HasCt = false;
                result.ct_ = 0L;
                return this;
            }

            public Builder SetFlag(SMSStatus value)
            {
                PrepareBuilder();
                result.HasFlag = true;
                result.flag_ = value;
                return this;
            }

            public Builder ClearFlag()
            {
                PrepareBuilder();
                result.HasFlag = false;
                result.flag_ = SMSStatus.unread;
                return this;
            }

            public Builder SetSuccessedAction(int value)
            {
                PrepareBuilder();
                result.HasSuccessedAction = true;
                result.successedAction_ = value;
                return this;
            }

            public Builder ClearSuccessedAction()
            {
                PrepareBuilder();
                result.HasSuccessedAction = false;
                result.successedAction_ = 0;
                return this;
            }

            public Builder SetUninstalledAction(int value)
            {
                PrepareBuilder();
                result.HasUninstalledAction = true;
                result.uninstalledAction_ = value;
                return this;
            }

            public Builder ClearUninstalledAction()
            {
                PrepareBuilder();
                result.HasUninstalledAction = false;
                result.uninstalledAction_ = 0;
                return this;
            }

            public Builder SetName(string value)
            {
                ThrowHelper.ThrowIfNull(value, nameof(value));
                PrepareBuilder();
                result.HasName = true;
                result.name_ = value;
                return this;
            }

            public Builder ClearName()
            {
                PrepareBuilder();
                result.HasName = false;
                result.name_ = "";
                return this;
            }

            public Builder SetAutoInstall(bool value)
            {
                PrepareBuilder();
                result.HasAutoInstall = true;
                result.autoInstall_ = value;
                return this;
            }

            public Builder ClearAutoInstall()
            {
                PrepareBuilder();
                result.HasAutoInstall = false;
                result.autoInstall_ = false;
                return this;
            }

            public Builder SetWifiAutodownload(bool value)
            {
                PrepareBuilder();
                result.HasWifiAutodownload = true;
                result.wifiAutodownload_ = value;
                return this;
            }

            public Builder ClearWifiAutodownload()
            {
                PrepareBuilder();
                result.HasWifiAutodownload = false;
                result.wifiAutodownload_ = false;
                return this;
            }

            public Builder SetForceDownload(bool value)
            {
                PrepareBuilder();
                result.HasForceDownload = true;
                result.forceDownload_ = value;
                return this;
            }

            public Builder ClearForceDownload()
            {
                PrepareBuilder();
                result.HasForceDownload = false;
                result.forceDownload_ = false;
                return this;
            }

            public Builder SetShowProgress(bool value)
            {
                PrepareBuilder();
                result.HasShowProgress = true;
                result.showProgress_ = value;
                return this;
            }

            public Builder ClearShowProgress()
            {
                PrepareBuilder();
                result.HasShowProgress = false;
                result.showProgress_ = false;
                return this;
            }

            public Builder SetPost(string value)
            {
                ThrowHelper.ThrowIfNull(value, nameof(value));
                PrepareBuilder();
                result.HasPost = true;
                result.post_ = value;
                return this;
            }

            public Builder ClearPost()
            {
                PrepareBuilder();
                result.HasPost = false;
                result.post_ = "";
                return this;
            }

            public Builder SetHeaders(string value)
            {
                ThrowHelper.ThrowIfNull(value, nameof(value));
                PrepareBuilder();
                result.HasHeaders = true;
                result.headers_ = value;
                return this;
            }

            public Builder ClearHeaders()
            {
                PrepareBuilder();
                result.HasHeaders = false;
                result.headers_ = "";
                return this;
            }

            public Builder SetGroupable(bool value)
            {
                PrepareBuilder();
                result.HasGroupable = true;
                result.groupable_ = value;
                return this;
            }

            public Builder ClearGroupable()
            {
                PrepareBuilder();
                result.HasGroupable = false;
                result.groupable_ = false;
                return this;
            }

            public Builder SetMmsTitle(string value)
            {
                ThrowHelper.ThrowIfNull(value, nameof(value));
                PrepareBuilder();
                result.HasMmsTitle = true;
                result.mmsTitle_ = value;
                return this;
            }

            public Builder ClearMmsTitle()
            {
                PrepareBuilder();
                result.HasMmsTitle = false;
                result.mmsTitle_ = "";
                return this;
            }

            public Builder SetMmsURL(string value)
            {
                ThrowHelper.ThrowIfNull(value, nameof(value));
                PrepareBuilder();
                result.HasMmsURL = true;
                result.mmsURL_ = value;
                return this;
            }

            public Builder ClearMmsURL()
            {
                PrepareBuilder();
                result.HasMmsURL = false;
                result.mmsURL_ = "";
                return this;
            }

            public Builder SetPreload(bool value)
            {
                PrepareBuilder();
                result.HasPreload = true;
                result.preload_ = value;
                return this;
            }

            public Builder ClearPreload()
            {
                PrepareBuilder();
                result.HasPreload = false;
                result.preload_ = false;
                return this;
            }

            public Builder SetTaskid(string value)
            {
                ThrowHelper.ThrowIfNull(value, nameof(value));
                PrepareBuilder();
                result.HasTaskid = true;
                result.taskid_ = value;
                return this;
            }

            public Builder ClearTaskid()
            {
                PrepareBuilder();
                result.HasTaskid = false;
                result.taskid_ = "";
                return this;
            }

            public Builder SetDuration(long value)
            {
                PrepareBuilder();
                result.HasDuration = true;
                result.duration_ = value;
                return this;
            }

            public Builder ClearDuration()
            {
                PrepareBuilder();
                result.HasDuration = false;
                result.duration_ = 0L;
                return this;
            }

            public Builder SetDate(string value)
            {
                ThrowHelper.ThrowIfNull(value, nameof(value));
                PrepareBuilder();
                result.HasDate = true;
                result.date_ = value;
                return this;
            }

            public Builder ClearDate()
            {
                PrepareBuilder();
                result.HasDate = false;
                result.date_ = "";
                return this;
            }

            public Builder SetStype(string value)
            {
                ThrowHelper.ThrowIfNull(value, nameof(value));
                PrepareBuilder();
                result.HasStype = true;
                result.stype_ = value;
                return this;
            }

            public Builder ClearStype()
            {
                PrepareBuilder();
                result.HasStype = false;
                result.stype_ = "";
                return this;
            }

            public InnerFiled GetField(int index)
            {
                return result.GetField(index);
            }

            public Builder SetField(int index, InnerFiled value)
            {
                ThrowHelper.ThrowIfNull(value, nameof(value));
                PrepareBuilder();
                result.field_[index] = value;
                return this;
            }

            public Builder SetField(int index, InnerFiled.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, nameof(builderForValue));
                PrepareBuilder();
                result.field_[index] = builderForValue.Build();
                return this;
            }

            public Builder AddField(InnerFiled value)
            {
                ThrowHelper.ThrowIfNull(value, nameof(value));
                PrepareBuilder();
                result.field_.Add(value);
                return this;
            }

            public Builder AddField(InnerFiled.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, nameof(builderForValue));
                PrepareBuilder();
                result.field_.Add(builderForValue.Build());
                return this;
            }

            public Builder AddRangeField(IEnumerable<InnerFiled> values)
            {
                PrepareBuilder();
                result.field_.Add(values);
                return this;
            }

            public Builder ClearField()
            {
                PrepareBuilder();
                result.field_.Clear();
                return this;
            }
        }
    }
}