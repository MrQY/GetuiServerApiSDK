using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Collections;
using Google.ProtocolBuffers.Descriptors;
using Google.ProtocolBuffers.FieldAccess;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace com.gexin.rp.sdk.dto
{
  [DebuggerNonUserCode]
  public sealed class SmsInfo : GeneratedMessage<SmsInfo, SmsInfo.Builder>
  {
    private static readonly SmsInfo defaultInstance = new SmsInfo().MakeReadOnly();
    private static readonly string[] _smsInfoFieldNames = new string[6]
    {
      "offlineSendtime",
      "smsChecked",
      "smsCheckedErrorMsg",
      "smsContent",
      "smsSendDuration",
      "smsTemplateId"
    };
    private static readonly uint[] _smsInfoFieldTags = new uint[6]
    {
      24U,
      40U,
      50U,
      18U,
      32U,
      10U
    };
    private string smsTemplateId_ = "";
    private PopsicleList<SmsContentEntry> smsContent_ = new PopsicleList<SmsContentEntry>();
    private string smsCheckedErrorMsg_ = "";
    private int memoizedSerializedSize = -1;
    public const int SmsTemplateIdFieldNumber = 1;
    private bool hasSmsTemplateId;
    public const int SmsContentFieldNumber = 2;
    public const int OfflineSendtimeFieldNumber = 3;
    private bool hasOfflineSendtime;
    private long offlineSendtime_;
    public const int SmsSendDurationFieldNumber = 4;
    private bool hasSmsSendDuration;
    private long smsSendDuration_;
    public const int SmsCheckedFieldNumber = 5;
    private bool hasSmsChecked;
    private bool smsChecked_;
    public const int SmsCheckedErrorMsgFieldNumber = 6;
    private bool hasSmsCheckedErrorMsg;

    private SmsInfo()
    {
    }

    public static SmsInfo DefaultInstance
    {
      get
      {
        return SmsInfo.defaultInstance;
      }
    }

    public override SmsInfo DefaultInstanceForType
    {
      get
      {
        return SmsInfo.DefaultInstance;
      }
    }

    protected override SmsInfo ThisMessage
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
        return GtReq.internal__static_com_gexin_rp_sdk_dto_SmsInfo__Descriptor;
      }
    }

    protected override FieldAccessorTable<SmsInfo, SmsInfo.Builder> InternalFieldAccessors
    {
      get
      {
        return GtReq.internal__static_com_gexin_rp_sdk_dto_SmsInfo__FieldAccessorTable;
      }
    }

    public bool HasSmsTemplateId
    {
      get
      {
        return this.hasSmsTemplateId;
      }
    }

    public string SmsTemplateId
    {
      get
      {
        return this.smsTemplateId_;
      }
    }

    public IList<SmsContentEntry> SmsContentList
    {
      get
      {
        return (IList<SmsContentEntry>) this.smsContent_;
      }
    }

    public int SmsContentCount
    {
      get
      {
        return this.smsContent_.Count;
      }
    }

    public SmsContentEntry GetSmsContent(int index)
    {
      return this.smsContent_[index];
    }

    public bool HasOfflineSendtime
    {
      get
      {
        return this.hasOfflineSendtime;
      }
    }

    public long OfflineSendtime
    {
      get
      {
        return this.offlineSendtime_;
      }
    }

    public bool HasSmsSendDuration
    {
      get
      {
        return this.hasSmsSendDuration;
      }
    }

    public long SmsSendDuration
    {
      get
      {
        return this.smsSendDuration_;
      }
    }

    public bool HasSmsChecked
    {
      get
      {
        return this.hasSmsChecked;
      }
    }

    public bool SmsChecked
    {
      get
      {
        return this.smsChecked_;
      }
    }

    public bool HasSmsCheckedErrorMsg
    {
      get
      {
        return this.hasSmsCheckedErrorMsg;
      }
    }

    public string SmsCheckedErrorMsg
    {
      get
      {
        return this.smsCheckedErrorMsg_;
      }
    }

    public override bool IsInitialized
    {
      get
      {
        if (!this.hasSmsTemplateId || !this.hasOfflineSendtime)
          return false;
        foreach (AbstractMessageLite<SmsContentEntry, SmsContentEntry.Builder> smsContent in (IEnumerable<SmsContentEntry>) this.SmsContentList)
        {
          if (!smsContent.IsInitialized)
            return false;
        }
        return true;
      }
    }

    public override void WriteTo(ICodedOutputStream output)
    {
      int serializedSize = this.SerializedSize;
      string[] smsInfoFieldNames = SmsInfo._smsInfoFieldNames;
      if (this.hasSmsTemplateId)
        output.WriteString(1, smsInfoFieldNames[5], this.SmsTemplateId);
      if (this.smsContent_.Count > 0)
        output.WriteMessageArray<SmsContentEntry>(2, smsInfoFieldNames[3], (IEnumerable<SmsContentEntry>) this.smsContent_);
      if (this.hasOfflineSendtime)
        output.WriteInt64(3, smsInfoFieldNames[0], this.OfflineSendtime);
      if (this.hasSmsSendDuration)
        output.WriteInt64(4, smsInfoFieldNames[4], this.SmsSendDuration);
      if (this.hasSmsChecked)
        output.WriteBool(5, smsInfoFieldNames[1], this.SmsChecked);
      if (this.hasSmsCheckedErrorMsg)
        output.WriteString(6, smsInfoFieldNames[2], this.SmsCheckedErrorMsg);
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
        if (this.hasSmsTemplateId)
          num1 += CodedOutputStream.ComputeStringSize(1, this.SmsTemplateId);
        foreach (SmsContentEntry smsContent in (IEnumerable<SmsContentEntry>) this.SmsContentList)
          num1 += CodedOutputStream.ComputeMessageSize(2, (IMessageLite) smsContent);
        if (this.hasOfflineSendtime)
          num1 += CodedOutputStream.ComputeInt64Size(3, this.OfflineSendtime);
        if (this.hasSmsSendDuration)
          num1 += CodedOutputStream.ComputeInt64Size(4, this.SmsSendDuration);
        if (this.hasSmsChecked)
          num1 += CodedOutputStream.ComputeBoolSize(5, this.SmsChecked);
        if (this.hasSmsCheckedErrorMsg)
          num1 += CodedOutputStream.ComputeStringSize(6, this.SmsCheckedErrorMsg);
        int num2 = num1 + this.UnknownFields.SerializedSize;
        this.memoizedSerializedSize = num2;
        return num2;
      }
    }

    public static SmsInfo ParseFrom(ByteString data)
    {
      return SmsInfo.CreateBuilder().MergeFrom(data).BuildParsed();
    }

    public static SmsInfo ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
    {
      return SmsInfo.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
    }

    public static SmsInfo ParseFrom(byte[] data)
    {
      return SmsInfo.CreateBuilder().MergeFrom(data).BuildParsed();
    }

    public static SmsInfo ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
    {
      return SmsInfo.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
    }

    public static SmsInfo ParseFrom(Stream input)
    {
      return SmsInfo.CreateBuilder().MergeFrom(input).BuildParsed();
    }

    public static SmsInfo ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
    {
      return SmsInfo.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
    }

    public static SmsInfo ParseDelimitedFrom(Stream input)
    {
      return SmsInfo.CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }

    public static SmsInfo ParseDelimitedFrom(
      Stream input,
      ExtensionRegistry extensionRegistry)
    {
      return SmsInfo.CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }

    public static SmsInfo ParseFrom(ICodedInputStream input)
    {
      return SmsInfo.CreateBuilder().MergeFrom(input).BuildParsed();
    }

    public static SmsInfo ParseFrom(
      ICodedInputStream input,
      ExtensionRegistry extensionRegistry)
    {
      return SmsInfo.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
    }

    private SmsInfo MakeReadOnly()
    {
      this.smsContent_.MakeReadOnly();
      return this;
    }

    public static SmsInfo.Builder CreateBuilder()
    {
      return new SmsInfo.Builder();
    }

    public override SmsInfo.Builder ToBuilder()
    {
      return SmsInfo.CreateBuilder(this);
    }

    public override SmsInfo.Builder CreateBuilderForType()
    {
      return new SmsInfo.Builder();
    }

    public static SmsInfo.Builder CreateBuilder(SmsInfo prototype)
    {
      return new SmsInfo.Builder(prototype);
    }

    static SmsInfo()
    {
      FileDescriptor descriptor = GtReq.Descriptor;
    }

    [DebuggerNonUserCode]
    public sealed class Builder : GeneratedBuilder<SmsInfo, SmsInfo.Builder>
    {
      private bool resultIsReadOnly;
      private SmsInfo result;

      protected override SmsInfo.Builder ThisBuilder
      {
        get
        {
          return this;
        }
      }

      public Builder()
      {
        this.result = SmsInfo.DefaultInstance;
        this.resultIsReadOnly = true;
      }

      internal Builder(SmsInfo cloneFrom)
      {
        this.result = cloneFrom;
        this.resultIsReadOnly = true;
      }

      private SmsInfo PrepareBuilder()
      {
        if (this.resultIsReadOnly)
        {
          SmsInfo result = this.result;
          this.result = new SmsInfo();
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

      protected override SmsInfo MessageBeingBuilt
      {
        get
        {
          return this.PrepareBuilder();
        }
      }

      public override SmsInfo.Builder Clear()
      {
        this.result = SmsInfo.DefaultInstance;
        this.resultIsReadOnly = true;
        return this;
      }

      public override SmsInfo.Builder Clone()
      {
        if (this.resultIsReadOnly)
          return new SmsInfo.Builder(this.result);
        return new SmsInfo.Builder().MergeFrom(this.result);
      }

      public override MessageDescriptor DescriptorForType
      {
        get
        {
          return SmsInfo.Descriptor;
        }
      }

      public override SmsInfo DefaultInstanceForType
      {
        get
        {
          return SmsInfo.DefaultInstance;
        }
      }

      public override SmsInfo BuildPartial()
      {
        if (this.resultIsReadOnly)
          return this.result;
        this.resultIsReadOnly = true;
        return this.result.MakeReadOnly();
      }

      public override SmsInfo.Builder MergeFrom(IMessage other)
      {
        if (other is SmsInfo)
          return this.MergeFrom((SmsInfo) other);
        base.MergeFrom(other);
        return this;
      }

      public override SmsInfo.Builder MergeFrom(SmsInfo other)
      {
        if (other == SmsInfo.DefaultInstance)
          return this;
        this.PrepareBuilder();
        if (other.HasSmsTemplateId)
          this.SmsTemplateId = other.SmsTemplateId;
        if (other.smsContent_.Count != 0)
          this.result.smsContent_.Add((IEnumerable<SmsContentEntry>) other.smsContent_);
        if (other.HasOfflineSendtime)
          this.OfflineSendtime = other.OfflineSendtime;
        if (other.HasSmsSendDuration)
          this.SmsSendDuration = other.SmsSendDuration;
        if (other.HasSmsChecked)
          this.SmsChecked = other.SmsChecked;
        if (other.HasSmsCheckedErrorMsg)
          this.SmsCheckedErrorMsg = other.SmsCheckedErrorMsg;
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }

      public override SmsInfo.Builder MergeFrom(ICodedInputStream input)
      {
        return this.MergeFrom(input, ExtensionRegistry.Empty);
      }

      public override SmsInfo.Builder MergeFrom(
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
            int index = Array.BinarySearch<string>(SmsInfo._smsInfoFieldNames, fieldName, (IComparer<string>) StringComparer.Ordinal);
            if (index >= 0)
            {
              fieldTag = SmsInfo._smsInfoFieldTags[index];
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
            case 10:
              this.result.hasSmsTemplateId = input.ReadString(ref this.result.smsTemplateId_);
              continue;
            case 18:
              input.ReadMessageArray<SmsContentEntry>(fieldTag, fieldName, (ICollection<SmsContentEntry>) this.result.smsContent_, SmsContentEntry.DefaultInstance, extensionRegistry);
              continue;
            case 24:
              this.result.hasOfflineSendtime = input.ReadInt64(ref this.result.offlineSendtime_);
              continue;
            case 32:
              this.result.hasSmsSendDuration = input.ReadInt64(ref this.result.smsSendDuration_);
              continue;
            case 40:
              this.result.hasSmsChecked = input.ReadBool(ref this.result.smsChecked_);
              continue;
            case 50:
              this.result.hasSmsCheckedErrorMsg = input.ReadString(ref this.result.smsCheckedErrorMsg_);
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

      public bool HasSmsTemplateId
      {
        get
        {
          return this.result.hasSmsTemplateId;
        }
      }

      public string SmsTemplateId
      {
        get
        {
          return this.result.SmsTemplateId;
        }
        set
        {
          this.SetSmsTemplateId(value);
        }
      }

      public SmsInfo.Builder SetSmsTemplateId(string value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.hasSmsTemplateId = true;
        this.result.smsTemplateId_ = value;
        return this;
      }

      public SmsInfo.Builder ClearSmsTemplateId()
      {
        this.PrepareBuilder();
        this.result.hasSmsTemplateId = false;
        this.result.smsTemplateId_ = "";
        return this;
      }

      public IPopsicleList<SmsContentEntry> SmsContentList
      {
        get
        {
          return (IPopsicleList<SmsContentEntry>) this.PrepareBuilder().smsContent_;
        }
      }

      public int SmsContentCount
      {
        get
        {
          return this.result.SmsContentCount;
        }
      }

      public SmsContentEntry GetSmsContent(int index)
      {
        return this.result.GetSmsContent(index);
      }

      public SmsInfo.Builder SetSmsContent(int index, SmsContentEntry value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.smsContent_[index] = value;
        return this;
      }

      public SmsInfo.Builder SetSmsContent(
        int index,
        SmsContentEntry.Builder builderForValue)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) builderForValue, nameof (builderForValue));
        this.PrepareBuilder();
        this.result.smsContent_[index] = builderForValue.Build();
        return this;
      }

      public SmsInfo.Builder AddSmsContent(SmsContentEntry value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.smsContent_.Add(value);
        return this;
      }

      public SmsInfo.Builder AddSmsContent(SmsContentEntry.Builder builderForValue)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) builderForValue, nameof (builderForValue));
        this.PrepareBuilder();
        this.result.smsContent_.Add(builderForValue.Build());
        return this;
      }

      public SmsInfo.Builder AddRangeSmsContent(IEnumerable<SmsContentEntry> values)
      {
        this.PrepareBuilder();
        this.result.smsContent_.Add(values);
        return this;
      }

      public SmsInfo.Builder ClearSmsContent()
      {
        this.PrepareBuilder();
        this.result.smsContent_.Clear();
        return this;
      }

      public bool HasOfflineSendtime
      {
        get
        {
          return this.result.hasOfflineSendtime;
        }
      }

      public long OfflineSendtime
      {
        get
        {
          return this.result.OfflineSendtime;
        }
        set
        {
          this.SetOfflineSendtime(value);
        }
      }

      public SmsInfo.Builder SetOfflineSendtime(long value)
      {
        this.PrepareBuilder();
        this.result.hasOfflineSendtime = true;
        this.result.offlineSendtime_ = value;
        return this;
      }

      public SmsInfo.Builder ClearOfflineSendtime()
      {
        this.PrepareBuilder();
        this.result.hasOfflineSendtime = false;
        this.result.offlineSendtime_ = 0L;
        return this;
      }

      public bool HasSmsSendDuration
      {
        get
        {
          return this.result.hasSmsSendDuration;
        }
      }

      public long SmsSendDuration
      {
        get
        {
          return this.result.SmsSendDuration;
        }
        set
        {
          this.SetSmsSendDuration(value);
        }
      }

      public SmsInfo.Builder SetSmsSendDuration(long value)
      {
        this.PrepareBuilder();
        this.result.hasSmsSendDuration = true;
        this.result.smsSendDuration_ = value;
        return this;
      }

      public SmsInfo.Builder ClearSmsSendDuration()
      {
        this.PrepareBuilder();
        this.result.hasSmsSendDuration = false;
        this.result.smsSendDuration_ = 0L;
        return this;
      }

      public bool HasSmsChecked
      {
        get
        {
          return this.result.hasSmsChecked;
        }
      }

      public bool SmsChecked
      {
        get
        {
          return this.result.SmsChecked;
        }
        set
        {
          this.SetSmsChecked(value);
        }
      }

      public SmsInfo.Builder SetSmsChecked(bool value)
      {
        this.PrepareBuilder();
        this.result.hasSmsChecked = true;
        this.result.smsChecked_ = value;
        return this;
      }

      public SmsInfo.Builder ClearSmsChecked()
      {
        this.PrepareBuilder();
        this.result.hasSmsChecked = false;
        this.result.smsChecked_ = false;
        return this;
      }

      public bool HasSmsCheckedErrorMsg
      {
        get
        {
          return this.result.hasSmsCheckedErrorMsg;
        }
      }

      public string SmsCheckedErrorMsg
      {
        get
        {
          return this.result.SmsCheckedErrorMsg;
        }
        set
        {
          this.SetSmsCheckedErrorMsg(value);
        }
      }

      public SmsInfo.Builder SetSmsCheckedErrorMsg(string value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.hasSmsCheckedErrorMsg = true;
        this.result.smsCheckedErrorMsg_ = value;
        return this;
      }

      public SmsInfo.Builder ClearSmsCheckedErrorMsg()
      {
        this.PrepareBuilder();
        this.result.hasSmsCheckedErrorMsg = false;
        this.result.smsCheckedErrorMsg_ = "";
        return this;
      }
    }
  }
}
