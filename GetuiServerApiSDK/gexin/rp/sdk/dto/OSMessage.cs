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
  public sealed class OSMessage : GeneratedMessage<OSMessage, OSMessage.Builder>
  {
    private static readonly OSMessage defaultInstance = new OSMessage().MakeReadOnly();
    private static readonly string[] _oSMessageFieldNames = new string[7]
    {
      "extraData",
      "isOffline",
      "msgTraceFlag",
      "msgType",
      "offlineExpireTime",
      "priority",
      "transparent"
    };
    private static readonly uint[] _oSMessageFieldTags = new uint[7]
    {
      42U,
      16U,
      56U,
      48U,
      24U,
      64U,
      34U
    };
    private long offlineExpireTime_ = 1;
    private string extraData_ = "";
    private int memoizedSerializedSize = -1;
    public const int IsOfflineFieldNumber = 2;
    private bool hasIsOffline;
    private bool isOffline_;
    public const int OfflineExpireTimeFieldNumber = 3;
    private bool hasOfflineExpireTime;
    public const int TransparentFieldNumber = 4;
    private bool hasTransparent;
    private Transparent transparent_;
    public const int ExtraDataFieldNumber = 5;
    private bool hasExtraData;
    public const int MsgTypeFieldNumber = 6;
    private bool hasMsgType;
    private int msgType_;
    public const int MsgTraceFlagFieldNumber = 7;
    private bool hasMsgTraceFlag;
    private int msgTraceFlag_;
    public const int PriorityFieldNumber = 8;
    private bool hasPriority;
    private int priority_;

    private OSMessage()
    {
    }

    public static OSMessage DefaultInstance
    {
      get
      {
        return OSMessage.defaultInstance;
      }
    }

    public override OSMessage DefaultInstanceForType
    {
      get
      {
        return OSMessage.DefaultInstance;
      }
    }

    protected override OSMessage ThisMessage
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
        return GtReq.internal__static_com_gexin_rp_sdk_dto_OSMessage__Descriptor;
      }
    }

    protected override FieldAccessorTable<OSMessage, OSMessage.Builder> InternalFieldAccessors
    {
      get
      {
        return GtReq.internal__static_com_gexin_rp_sdk_dto_OSMessage__FieldAccessorTable;
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

    public bool HasOfflineExpireTime
    {
      get
      {
        return this.hasOfflineExpireTime;
      }
    }

    public long OfflineExpireTime
    {
      get
      {
        return this.offlineExpireTime_;
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

    public override bool IsInitialized
    {
      get
      {
        return this.hasIsOffline && this.hasOfflineExpireTime && (!this.HasTransparent || this.Transparent.IsInitialized);
      }
    }

    public override void WriteTo(ICodedOutputStream output)
    {
      int serializedSize = this.SerializedSize;
      string[] smessageFieldNames = OSMessage._oSMessageFieldNames;
      if (this.hasIsOffline)
        output.WriteBool(2, smessageFieldNames[1], this.IsOffline);
      if (this.hasOfflineExpireTime)
        output.WriteInt64(3, smessageFieldNames[4], this.OfflineExpireTime);
      if (this.hasTransparent)
        output.WriteMessage(4, smessageFieldNames[6], (IMessageLite) this.Transparent);
      if (this.hasExtraData)
        output.WriteString(5, smessageFieldNames[0], this.ExtraData);
      if (this.hasMsgType)
        output.WriteInt32(6, smessageFieldNames[3], this.MsgType);
      if (this.hasMsgTraceFlag)
        output.WriteInt32(7, smessageFieldNames[2], this.MsgTraceFlag);
      if (this.hasPriority)
        output.WriteInt32(8, smessageFieldNames[5], this.Priority);
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
        if (this.hasIsOffline)
          num1 += CodedOutputStream.ComputeBoolSize(2, this.IsOffline);
        if (this.hasOfflineExpireTime)
          num1 += CodedOutputStream.ComputeInt64Size(3, this.OfflineExpireTime);
        if (this.hasTransparent)
          num1 += CodedOutputStream.ComputeMessageSize(4, (IMessageLite) this.Transparent);
        if (this.hasExtraData)
          num1 += CodedOutputStream.ComputeStringSize(5, this.ExtraData);
        if (this.hasMsgType)
          num1 += CodedOutputStream.ComputeInt32Size(6, this.MsgType);
        if (this.hasMsgTraceFlag)
          num1 += CodedOutputStream.ComputeInt32Size(7, this.MsgTraceFlag);
        if (this.hasPriority)
          num1 += CodedOutputStream.ComputeInt32Size(8, this.Priority);
        int num2 = num1 + this.UnknownFields.SerializedSize;
        this.memoizedSerializedSize = num2;
        return num2;
      }
    }

    public static OSMessage ParseFrom(ByteString data)
    {
      return OSMessage.CreateBuilder().MergeFrom(data).BuildParsed();
    }

    public static OSMessage ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
    {
      return OSMessage.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
    }

    public static OSMessage ParseFrom(byte[] data)
    {
      return OSMessage.CreateBuilder().MergeFrom(data).BuildParsed();
    }

    public static OSMessage ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
    {
      return OSMessage.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
    }

    public static OSMessage ParseFrom(Stream input)
    {
      return OSMessage.CreateBuilder().MergeFrom(input).BuildParsed();
    }

    public static OSMessage ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
    {
      return OSMessage.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
    }

    public static OSMessage ParseDelimitedFrom(Stream input)
    {
      return OSMessage.CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }

    public static OSMessage ParseDelimitedFrom(
      Stream input,
      ExtensionRegistry extensionRegistry)
    {
      return OSMessage.CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }

    public static OSMessage ParseFrom(ICodedInputStream input)
    {
      return OSMessage.CreateBuilder().MergeFrom(input).BuildParsed();
    }

    public static OSMessage ParseFrom(
      ICodedInputStream input,
      ExtensionRegistry extensionRegistry)
    {
      return OSMessage.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
    }

    private OSMessage MakeReadOnly()
    {
      return this;
    }

    public static OSMessage.Builder CreateBuilder()
    {
      return new OSMessage.Builder();
    }

    public override OSMessage.Builder ToBuilder()
    {
      return OSMessage.CreateBuilder(this);
    }

    public override OSMessage.Builder CreateBuilderForType()
    {
      return new OSMessage.Builder();
    }

    public static OSMessage.Builder CreateBuilder(OSMessage prototype)
    {
      return new OSMessage.Builder(prototype);
    }

    static OSMessage()
    {
      FileDescriptor descriptor = GtReq.Descriptor;
    }

    [DebuggerNonUserCode]
    public sealed class Builder : GeneratedBuilder<OSMessage, OSMessage.Builder>
    {
      private bool resultIsReadOnly;
      private OSMessage result;

      protected override OSMessage.Builder ThisBuilder
      {
        get
        {
          return this;
        }
      }

      public Builder()
      {
        this.result = OSMessage.DefaultInstance;
        this.resultIsReadOnly = true;
      }

      internal Builder(OSMessage cloneFrom)
      {
        this.result = cloneFrom;
        this.resultIsReadOnly = true;
      }

      private OSMessage PrepareBuilder()
      {
        if (this.resultIsReadOnly)
        {
          OSMessage result = this.result;
          this.result = new OSMessage();
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

      protected override OSMessage MessageBeingBuilt
      {
        get
        {
          return this.PrepareBuilder();
        }
      }

      public override OSMessage.Builder Clear()
      {
        this.result = OSMessage.DefaultInstance;
        this.resultIsReadOnly = true;
        return this;
      }

      public override OSMessage.Builder Clone()
      {
        if (this.resultIsReadOnly)
          return new OSMessage.Builder(this.result);
        return new OSMessage.Builder().MergeFrom(this.result);
      }

      public override MessageDescriptor DescriptorForType
      {
        get
        {
          return OSMessage.Descriptor;
        }
      }

      public override OSMessage DefaultInstanceForType
      {
        get
        {
          return OSMessage.DefaultInstance;
        }
      }

      public override OSMessage BuildPartial()
      {
        if (this.resultIsReadOnly)
          return this.result;
        this.resultIsReadOnly = true;
        return this.result.MakeReadOnly();
      }

      public override OSMessage.Builder MergeFrom(IMessage other)
      {
        if (other is OSMessage)
          return this.MergeFrom((OSMessage) other);
        base.MergeFrom(other);
        return this;
      }

      public override OSMessage.Builder MergeFrom(OSMessage other)
      {
        if (other == OSMessage.DefaultInstance)
          return this;
        this.PrepareBuilder();
        if (other.HasIsOffline)
          this.IsOffline = other.IsOffline;
        if (other.HasOfflineExpireTime)
          this.OfflineExpireTime = other.OfflineExpireTime;
        if (other.HasTransparent)
          this.MergeTransparent(other.Transparent);
        if (other.HasExtraData)
          this.ExtraData = other.ExtraData;
        if (other.HasMsgType)
          this.MsgType = other.MsgType;
        if (other.HasMsgTraceFlag)
          this.MsgTraceFlag = other.MsgTraceFlag;
        if (other.HasPriority)
          this.Priority = other.Priority;
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }

      public override OSMessage.Builder MergeFrom(ICodedInputStream input)
      {
        return this.MergeFrom(input, ExtensionRegistry.Empty);
      }

      public override OSMessage.Builder MergeFrom(
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
            int index = Array.BinarySearch<string>(OSMessage._oSMessageFieldNames, fieldName, (IComparer<string>) StringComparer.Ordinal);
            if (index >= 0)
            {
              fieldTag = OSMessage._oSMessageFieldTags[index];
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
            case 16:
              this.result.hasIsOffline = input.ReadBool(ref this.result.isOffline_);
              continue;
            case 24:
              this.result.hasOfflineExpireTime = input.ReadInt64(ref this.result.offlineExpireTime_);
              continue;
            case 34:
              Transparent.Builder builder = Transparent.CreateBuilder();
              if (this.result.hasTransparent)
                builder.MergeFrom(this.Transparent);
              input.ReadMessage((IBuilderLite) builder, extensionRegistry);
              this.Transparent = builder.BuildPartial();
              continue;
            case 42:
              this.result.hasExtraData = input.ReadString(ref this.result.extraData_);
              continue;
            case 48:
              this.result.hasMsgType = input.ReadInt32(ref this.result.msgType_);
              continue;
            case 56:
              this.result.hasMsgTraceFlag = input.ReadInt32(ref this.result.msgTraceFlag_);
              continue;
            case 64:
              this.result.hasPriority = input.ReadInt32(ref this.result.priority_);
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

      public OSMessage.Builder SetIsOffline(bool value)
      {
        this.PrepareBuilder();
        this.result.hasIsOffline = true;
        this.result.isOffline_ = value;
        return this;
      }

      public OSMessage.Builder ClearIsOffline()
      {
        this.PrepareBuilder();
        this.result.hasIsOffline = false;
        this.result.isOffline_ = false;
        return this;
      }

      public bool HasOfflineExpireTime
      {
        get
        {
          return this.result.hasOfflineExpireTime;
        }
      }

      public long OfflineExpireTime
      {
        get
        {
          return this.result.OfflineExpireTime;
        }
        set
        {
          this.SetOfflineExpireTime(value);
        }
      }

      public OSMessage.Builder SetOfflineExpireTime(long value)
      {
        this.PrepareBuilder();
        this.result.hasOfflineExpireTime = true;
        this.result.offlineExpireTime_ = value;
        return this;
      }

      public OSMessage.Builder ClearOfflineExpireTime()
      {
        this.PrepareBuilder();
        this.result.hasOfflineExpireTime = false;
        this.result.offlineExpireTime_ = 1L;
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

      public OSMessage.Builder SetTransparent(Transparent value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.hasTransparent = true;
        this.result.transparent_ = value;
        return this;
      }

      public OSMessage.Builder SetTransparent(Transparent.Builder builderForValue)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) builderForValue, nameof (builderForValue));
        this.PrepareBuilder();
        this.result.hasTransparent = true;
        this.result.transparent_ = builderForValue.Build();
        return this;
      }

      public OSMessage.Builder MergeTransparent(Transparent value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.transparent_ = !this.result.hasTransparent || this.result.transparent_ == Transparent.DefaultInstance ? value : Transparent.CreateBuilder(this.result.transparent_).MergeFrom(value).BuildPartial();
        this.result.hasTransparent = true;
        return this;
      }

      public OSMessage.Builder ClearTransparent()
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

      public OSMessage.Builder SetExtraData(string value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.hasExtraData = true;
        this.result.extraData_ = value;
        return this;
      }

      public OSMessage.Builder ClearExtraData()
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

      public OSMessage.Builder SetMsgType(int value)
      {
        this.PrepareBuilder();
        this.result.hasMsgType = true;
        this.result.msgType_ = value;
        return this;
      }

      public OSMessage.Builder ClearMsgType()
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

      public OSMessage.Builder SetMsgTraceFlag(int value)
      {
        this.PrepareBuilder();
        this.result.hasMsgTraceFlag = true;
        this.result.msgTraceFlag_ = value;
        return this;
      }

      public OSMessage.Builder ClearMsgTraceFlag()
      {
        this.PrepareBuilder();
        this.result.hasMsgTraceFlag = false;
        this.result.msgTraceFlag_ = 0;
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

      public OSMessage.Builder SetPriority(int value)
      {
        this.PrepareBuilder();
        this.result.hasPriority = true;
        this.result.priority_ = value;
        return this;
      }

      public OSMessage.Builder ClearPriority()
      {
        this.PrepareBuilder();
        this.result.hasPriority = false;
        this.result.priority_ = 0;
        return this;
      }
    }
  }
}
