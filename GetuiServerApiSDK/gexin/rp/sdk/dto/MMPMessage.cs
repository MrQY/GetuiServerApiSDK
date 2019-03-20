using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Descriptors;
using Google.ProtocolBuffers.FieldAccess;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace com.gexin.rp.sdk.dto
{
  [DebuggerNonUserCode]
  public sealed class MMPMessage : GeneratedMessage<MMPMessage, MMPMessage.Builder>
  {
    private static readonly MMPMessage defaultInstance = new MMPMessage().MakeReadOnly();
    private static readonly string[] _mMPMessageFieldNames = new string[9]
    {
      "cdnUrl",
      "extraData",
      "isOffline",
      "isSync",
      "msgOfflineExpire",
      "msgTraceFlag",
      "msgType",
      "priority",
      "transparent"
    };
    private static readonly uint[] _mMPMessageFieldTags = new uint[9]
    {
      74U,
      26U,
      56U,
      80U,
      48U,
      40U,
      32U,
      64U,
      18U
    };
    private string extraData_ = "";
    private bool isOffline_ = true;
    private string cdnUrl_ = "";
    private bool isSync_ = true;
    private int memoizedSerializedSize = -1;
    public const int TransparentFieldNumber = 2;
    private bool hasTransparent;
    private Transparent transparent_;
    public const int ExtraDataFieldNumber = 3;
    private bool hasExtraData;
    public const int MsgTypeFieldNumber = 4;
    private bool hasMsgType;
    private int msgType_;
    public const int MsgTraceFlagFieldNumber = 5;
    private bool hasMsgTraceFlag;
    private int msgTraceFlag_;
    public const int MsgOfflineExpireFieldNumber = 6;
    private bool hasMsgOfflineExpire;
    private long msgOfflineExpire_;
    public const int IsOfflineFieldNumber = 7;
    private bool hasIsOffline;
    public const int PriorityFieldNumber = 8;
    private bool hasPriority;
    private int priority_;
    public const int CdnUrlFieldNumber = 9;
    private bool hasCdnUrl;
    public const int IsSyncFieldNumber = 10;
    private bool hasIsSync;

    private MMPMessage()
    {
    }

    public static MMPMessage DefaultInstance
    {
      get
      {
        return MMPMessage.defaultInstance;
      }
    }

    public override MMPMessage DefaultInstanceForType
    {
      get
      {
        return MMPMessage.DefaultInstance;
      }
    }

    protected override MMPMessage ThisMessage
    {
      get
      {
        return this;
      }
    }

    public static MessageDescriptor Descriptor
    {
      get
      {
        return GtReq.internal__static_com_gexin_rp_sdk_dto_MMPMessage__Descriptor;
      }
    }

    protected override FieldAccessorTable<MMPMessage, MMPMessage.Builder> InternalFieldAccessors
    {
      get
      {
        return GtReq.internal__static_com_gexin_rp_sdk_dto_MMPMessage__FieldAccessorTable;
      }
    }

    public bool HasTransparent
    {
      get
      {
        return this.hasTransparent;
      }
    }

    public Transparent Transparent
    {
      get
      {
        return this.transparent_ ?? Transparent.DefaultInstance;
      }
    }

    public bool HasExtraData
    {
      get
      {
        return this.hasExtraData;
      }
    }

    public string ExtraData
    {
      get
      {
        return this.extraData_;
      }
    }

    public bool HasMsgType
    {
      get
      {
        return this.hasMsgType;
      }
    }

    public int MsgType
    {
      get
      {
        return this.msgType_;
      }
    }

    public bool HasMsgTraceFlag
    {
      get
      {
        return this.hasMsgTraceFlag;
      }
    }

    public int MsgTraceFlag
    {
      get
      {
        return this.msgTraceFlag_;
      }
    }

    public bool HasMsgOfflineExpire
    {
      get
      {
        return this.hasMsgOfflineExpire;
      }
    }

    public long MsgOfflineExpire
    {
      get
      {
        return this.msgOfflineExpire_;
      }
    }

    public bool HasIsOffline
    {
      get
      {
        return this.hasIsOffline;
      }
    }

    public bool IsOffline
    {
      get
      {
        return this.isOffline_;
      }
    }

    public bool HasPriority
    {
      get
      {
        return this.hasPriority;
      }
    }

    public int Priority
    {
      get
      {
        return this.priority_;
      }
    }

    public bool HasCdnUrl
    {
      get
      {
        return this.hasCdnUrl;
      }
    }

    public string CdnUrl
    {
      get
      {
        return this.cdnUrl_;
      }
    }

    public bool HasIsSync
    {
      get
      {
        return this.hasIsSync;
      }
    }

    public bool IsSync
    {
      get
      {
        return this.isSync_;
      }
    }

    public override bool IsInitialized
    {
      get
      {
        return !this.HasTransparent || this.Transparent.IsInitialized;
      }
    }

    public override void WriteTo(ICodedOutputStream output)
    {
      int serializedSize = this.SerializedSize;
      string[] messageFieldNames = MMPMessage._mMPMessageFieldNames;
      if (this.hasTransparent)
        output.WriteMessage(2, messageFieldNames[8], (IMessageLite) this.Transparent);
      if (this.hasExtraData)
        output.WriteString(3, messageFieldNames[1], this.ExtraData);
      if (this.hasMsgType)
        output.WriteInt32(4, messageFieldNames[6], this.MsgType);
      if (this.hasMsgTraceFlag)
        output.WriteInt32(5, messageFieldNames[5], this.MsgTraceFlag);
      if (this.hasMsgOfflineExpire)
        output.WriteInt64(6, messageFieldNames[4], this.MsgOfflineExpire);
      if (this.hasIsOffline)
        output.WriteBool(7, messageFieldNames[2], this.IsOffline);
      if (this.hasPriority)
        output.WriteInt32(8, messageFieldNames[7], this.Priority);
      if (this.hasCdnUrl)
        output.WriteString(9, messageFieldNames[0], this.CdnUrl);
      if (this.hasIsSync)
        output.WriteBool(10, messageFieldNames[3], this.IsSync);
      this.UnknownFields.WriteTo(output);
    }

    public override int SerializedSize
    {
      get
      {
        int memoizedSerializedSize = this.memoizedSerializedSize;
        if (memoizedSerializedSize != -1)
          return memoizedSerializedSize;
        int num1 = 0;
        if (this.hasTransparent)
          num1 += CodedOutputStream.ComputeMessageSize(2, (IMessageLite) this.Transparent);
        if (this.hasExtraData)
          num1 += CodedOutputStream.ComputeStringSize(3, this.ExtraData);
        if (this.hasMsgType)
          num1 += CodedOutputStream.ComputeInt32Size(4, this.MsgType);
        if (this.hasMsgTraceFlag)
          num1 += CodedOutputStream.ComputeInt32Size(5, this.MsgTraceFlag);
        if (this.hasMsgOfflineExpire)
          num1 += CodedOutputStream.ComputeInt64Size(6, this.MsgOfflineExpire);
        if (this.hasIsOffline)
          num1 += CodedOutputStream.ComputeBoolSize(7, this.IsOffline);
        if (this.hasPriority)
          num1 += CodedOutputStream.ComputeInt32Size(8, this.Priority);
        if (this.hasCdnUrl)
          num1 += CodedOutputStream.ComputeStringSize(9, this.CdnUrl);
        if (this.hasIsSync)
          num1 += CodedOutputStream.ComputeBoolSize(10, this.IsSync);
        int num2 = num1 + this.UnknownFields.SerializedSize;
        this.memoizedSerializedSize = num2;
        return num2;
      }
    }

    public static MMPMessage ParseFrom(ByteString data)
    {
      return MMPMessage.CreateBuilder().MergeFrom(data).BuildParsed();
    }

    public static MMPMessage ParseFrom(
      ByteString data,
      ExtensionRegistry extensionRegistry)
    {
      return MMPMessage.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
    }

    public static MMPMessage ParseFrom(byte[] data)
    {
      return MMPMessage.CreateBuilder().MergeFrom(data).BuildParsed();
    }

    public static MMPMessage ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
    {
      return MMPMessage.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
    }

    public static MMPMessage ParseFrom(Stream input)
    {
      return MMPMessage.CreateBuilder().MergeFrom(input).BuildParsed();
    }

    public static MMPMessage ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
    {
      return MMPMessage.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
    }

    public static MMPMessage ParseDelimitedFrom(Stream input)
    {
      return MMPMessage.CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }

    public static MMPMessage ParseDelimitedFrom(
      Stream input,
      ExtensionRegistry extensionRegistry)
    {
      return MMPMessage.CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }

    public static MMPMessage ParseFrom(ICodedInputStream input)
    {
      return MMPMessage.CreateBuilder().MergeFrom(input).BuildParsed();
    }

    public static MMPMessage ParseFrom(
      ICodedInputStream input,
      ExtensionRegistry extensionRegistry)
    {
      return MMPMessage.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
    }

    private MMPMessage MakeReadOnly()
    {
      return this;
    }

    public static MMPMessage.Builder CreateBuilder()
    {
      return new MMPMessage.Builder();
    }

    public override MMPMessage.Builder ToBuilder()
    {
      return MMPMessage.CreateBuilder(this);
    }

    public override MMPMessage.Builder CreateBuilderForType()
    {
      return new MMPMessage.Builder();
    }

    public static MMPMessage.Builder CreateBuilder(MMPMessage prototype)
    {
      return new MMPMessage.Builder(prototype);
    }

    static MMPMessage()
    {
      FileDescriptor descriptor = GtReq.Descriptor;
    }

    [DebuggerNonUserCode]
    public sealed class Builder : GeneratedBuilder<MMPMessage, MMPMessage.Builder>
    {
      private bool resultIsReadOnly;
      private MMPMessage result;

      protected override MMPMessage.Builder ThisBuilder
      {
        get
        {
          return this;
        }
      }

      public Builder()
      {
        this.result = MMPMessage.DefaultInstance;
        this.resultIsReadOnly = true;
      }

      internal Builder(MMPMessage cloneFrom)
      {
        this.result = cloneFrom;
        this.resultIsReadOnly = true;
      }

      private MMPMessage PrepareBuilder()
      {
        if (this.resultIsReadOnly)
        {
          MMPMessage result = this.result;
          this.result = new MMPMessage();
          this.resultIsReadOnly = false;
          this.MergeFrom(result);
        }
        return this.result;
      }

      public override bool IsInitialized
      {
        get
        {
          return this.result.IsInitialized;
        }
      }

      protected override MMPMessage MessageBeingBuilt
      {
        get
        {
          return this.PrepareBuilder();
        }
      }

      public override MMPMessage.Builder Clear()
      {
        this.result = MMPMessage.DefaultInstance;
        this.resultIsReadOnly = true;
        return this;
      }

      public override MMPMessage.Builder Clone()
      {
        if (this.resultIsReadOnly)
          return new MMPMessage.Builder(this.result);
        return new MMPMessage.Builder().MergeFrom(this.result);
      }

      public override MessageDescriptor DescriptorForType
      {
        get
        {
          return MMPMessage.Descriptor;
        }
      }

      public override MMPMessage DefaultInstanceForType
      {
        get
        {
          return MMPMessage.DefaultInstance;
        }
      }

      public override MMPMessage BuildPartial()
      {
        if (this.resultIsReadOnly)
          return this.result;
        this.resultIsReadOnly = true;
        return this.result.MakeReadOnly();
      }

      public override MMPMessage.Builder MergeFrom(IMessage other)
      {
        if (other is MMPMessage)
          return this.MergeFrom((MMPMessage) other);
        base.MergeFrom(other);
        return this;
      }

      public override MMPMessage.Builder MergeFrom(MMPMessage other)
      {
        if (other == MMPMessage.DefaultInstance)
          return this;
        this.PrepareBuilder();
        if (other.HasTransparent)
          this.MergeTransparent(other.Transparent);
        if (other.HasExtraData)
          this.ExtraData = other.ExtraData;
        if (other.HasMsgType)
          this.MsgType = other.MsgType;
        if (other.HasMsgTraceFlag)
          this.MsgTraceFlag = other.MsgTraceFlag;
        if (other.HasMsgOfflineExpire)
          this.MsgOfflineExpire = other.MsgOfflineExpire;
        if (other.HasIsOffline)
          this.IsOffline = other.IsOffline;
        if (other.HasPriority)
          this.Priority = other.Priority;
        if (other.HasCdnUrl)
          this.CdnUrl = other.CdnUrl;
        if (other.HasIsSync)
          this.IsSync = other.IsSync;
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }

      public override MMPMessage.Builder MergeFrom(ICodedInputStream input)
      {
        return this.MergeFrom(input, ExtensionRegistry.Empty);
      }

      public override MMPMessage.Builder MergeFrom(
        ICodedInputStream input,
        ExtensionRegistry extensionRegistry)
      {
        this.PrepareBuilder();
        UnknownFieldSet.Builder unknownFields = (UnknownFieldSet.Builder) null;
        uint fieldTag;
        string fieldName;
        while (input.ReadTag(out fieldTag, out fieldName))
        {
          if (fieldTag == 0U && fieldName != null)
          {
            int index = Array.BinarySearch<string>(MMPMessage._mMPMessageFieldNames, fieldName, (IComparer<string>) StringComparer.Ordinal);
            if (index >= 0)
            {
              fieldTag = MMPMessage._mMPMessageFieldTags[index];
            }
            else
            {
              if (unknownFields == null)
                unknownFields = UnknownFieldSet.CreateBuilder(this.UnknownFields);
              this.ParseUnknownField(input, unknownFields, extensionRegistry, fieldTag, fieldName);
              continue;
            }
          }
          switch (fieldTag)
          {
            case 0:
              throw InvalidProtocolBufferException.InvalidTag();
            case 18:
              Transparent.Builder builder = Transparent.CreateBuilder();
              if (this.result.hasTransparent)
                builder.MergeFrom(this.Transparent);
              input.ReadMessage((IBuilderLite) builder, extensionRegistry);
              this.Transparent = builder.BuildPartial();
              continue;
            case 26:
              this.result.hasExtraData = input.ReadString(ref this.result.extraData_);
              continue;
            case 32:
              this.result.hasMsgType = input.ReadInt32(ref this.result.msgType_);
              continue;
            case 40:
              this.result.hasMsgTraceFlag = input.ReadInt32(ref this.result.msgTraceFlag_);
              continue;
            case 48:
              this.result.hasMsgOfflineExpire = input.ReadInt64(ref this.result.msgOfflineExpire_);
              continue;
            case 56:
              this.result.hasIsOffline = input.ReadBool(ref this.result.isOffline_);
              continue;
            case 64:
              this.result.hasPriority = input.ReadInt32(ref this.result.priority_);
              continue;
            case 74:
              this.result.hasCdnUrl = input.ReadString(ref this.result.cdnUrl_);
              continue;
            case 80:
              this.result.hasIsSync = input.ReadBool(ref this.result.isSync_);
              continue;
            default:
              if (WireFormat.IsEndGroupTag(fieldTag))
              {
                if (unknownFields != null)
                  this.UnknownFields = unknownFields.Build();
                return this;
              }
              if (unknownFields == null)
                unknownFields = UnknownFieldSet.CreateBuilder(this.UnknownFields);
              this.ParseUnknownField(input, unknownFields, extensionRegistry, fieldTag, fieldName);
              continue;
          }
        }
        if (unknownFields != null)
          this.UnknownFields = unknownFields.Build();
        return this;
      }

      public bool HasTransparent
      {
        get
        {
          return this.result.hasTransparent;
        }
      }

      public Transparent Transparent
      {
        get
        {
          return this.result.Transparent;
        }
        set
        {
          this.SetTransparent(value);
        }
      }

      public MMPMessage.Builder SetTransparent(Transparent value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.hasTransparent = true;
        this.result.transparent_ = value;
        return this;
      }

      public MMPMessage.Builder SetTransparent(Transparent.Builder builderForValue)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) builderForValue, nameof (builderForValue));
        this.PrepareBuilder();
        this.result.hasTransparent = true;
        this.result.transparent_ = builderForValue.Build();
        return this;
      }

      public MMPMessage.Builder MergeTransparent(Transparent value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.transparent_ = !this.result.hasTransparent || this.result.transparent_ == Transparent.DefaultInstance ? value : Transparent.CreateBuilder(this.result.transparent_).MergeFrom(value).BuildPartial();
        this.result.hasTransparent = true;
        return this;
      }

      public MMPMessage.Builder ClearTransparent()
      {
        this.PrepareBuilder();
        this.result.hasTransparent = false;
        this.result.transparent_ = (Transparent) null;
        return this;
      }

      public bool HasExtraData
      {
        get
        {
          return this.result.hasExtraData;
        }
      }

      public string ExtraData
      {
        get
        {
          return this.result.ExtraData;
        }
        set
        {
          this.SetExtraData(value);
        }
      }

      public MMPMessage.Builder SetExtraData(string value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.hasExtraData = true;
        this.result.extraData_ = value;
        return this;
      }

      public MMPMessage.Builder ClearExtraData()
      {
        this.PrepareBuilder();
        this.result.hasExtraData = false;
        this.result.extraData_ = "";
        return this;
      }

      public bool HasMsgType
      {
        get
        {
          return this.result.hasMsgType;
        }
      }

      public int MsgType
      {
        get
        {
          return this.result.MsgType;
        }
        set
        {
          this.SetMsgType(value);
        }
      }

      public MMPMessage.Builder SetMsgType(int value)
      {
        this.PrepareBuilder();
        this.result.hasMsgType = true;
        this.result.msgType_ = value;
        return this;
      }

      public MMPMessage.Builder ClearMsgType()
      {
        this.PrepareBuilder();
        this.result.hasMsgType = false;
        this.result.msgType_ = 0;
        return this;
      }

      public bool HasMsgTraceFlag
      {
        get
        {
          return this.result.hasMsgTraceFlag;
        }
      }

      public int MsgTraceFlag
      {
        get
        {
          return this.result.MsgTraceFlag;
        }
        set
        {
          this.SetMsgTraceFlag(value);
        }
      }

      public MMPMessage.Builder SetMsgTraceFlag(int value)
      {
        this.PrepareBuilder();
        this.result.hasMsgTraceFlag = true;
        this.result.msgTraceFlag_ = value;
        return this;
      }

      public MMPMessage.Builder ClearMsgTraceFlag()
      {
        this.PrepareBuilder();
        this.result.hasMsgTraceFlag = false;
        this.result.msgTraceFlag_ = 0;
        return this;
      }

      public bool HasMsgOfflineExpire
      {
        get
        {
          return this.result.hasMsgOfflineExpire;
        }
      }

      public long MsgOfflineExpire
      {
        get
        {
          return this.result.MsgOfflineExpire;
        }
        set
        {
          this.SetMsgOfflineExpire(value);
        }
      }

      public MMPMessage.Builder SetMsgOfflineExpire(long value)
      {
        this.PrepareBuilder();
        this.result.hasMsgOfflineExpire = true;
        this.result.msgOfflineExpire_ = value;
        return this;
      }

      public MMPMessage.Builder ClearMsgOfflineExpire()
      {
        this.PrepareBuilder();
        this.result.hasMsgOfflineExpire = false;
        this.result.msgOfflineExpire_ = 0L;
        return this;
      }

      public bool HasIsOffline
      {
        get
        {
          return this.result.hasIsOffline;
        }
      }

      public bool IsOffline
      {
        get
        {
          return this.result.IsOffline;
        }
        set
        {
          this.SetIsOffline(value);
        }
      }

      public MMPMessage.Builder SetIsOffline(bool value)
      {
        this.PrepareBuilder();
        this.result.hasIsOffline = true;
        this.result.isOffline_ = value;
        return this;
      }

      public MMPMessage.Builder ClearIsOffline()
      {
        this.PrepareBuilder();
        this.result.hasIsOffline = false;
        this.result.isOffline_ = true;
        return this;
      }

      public bool HasPriority
      {
        get
        {
          return this.result.hasPriority;
        }
      }

      public int Priority
      {
        get
        {
          return this.result.Priority;
        }
        set
        {
          this.SetPriority(value);
        }
      }

      public MMPMessage.Builder SetPriority(int value)
      {
        this.PrepareBuilder();
        this.result.hasPriority = true;
        this.result.priority_ = value;
        return this;
      }

      public MMPMessage.Builder ClearPriority()
      {
        this.PrepareBuilder();
        this.result.hasPriority = false;
        this.result.priority_ = 0;
        return this;
      }

      public bool HasCdnUrl
      {
        get
        {
          return this.result.hasCdnUrl;
        }
      }

      public string CdnUrl
      {
        get
        {
          return this.result.CdnUrl;
        }
        set
        {
          this.SetCdnUrl(value);
        }
      }

      public MMPMessage.Builder SetCdnUrl(string value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.hasCdnUrl = true;
        this.result.cdnUrl_ = value;
        return this;
      }

      public MMPMessage.Builder ClearCdnUrl()
      {
        this.PrepareBuilder();
        this.result.hasCdnUrl = false;
        this.result.cdnUrl_ = "";
        return this;
      }

      public bool HasIsSync
      {
        get
        {
          return this.result.hasIsSync;
        }
      }

      public bool IsSync
      {
        get
        {
          return this.result.IsSync;
        }
        set
        {
          this.SetIsSync(value);
        }
      }

      public MMPMessage.Builder SetIsSync(bool value)
      {
        this.PrepareBuilder();
        this.result.hasIsSync = true;
        this.result.isSync_ = value;
        return this;
      }

      public MMPMessage.Builder ClearIsSync()
      {
        this.PrepareBuilder();
        this.result.hasIsSync = false;
        this.result.isSync_ = true;
        return this;
      }
    }
  }
}
