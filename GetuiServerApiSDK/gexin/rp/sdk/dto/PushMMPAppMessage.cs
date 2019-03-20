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
  public sealed class PushMMPAppMessage : GeneratedMessage<PushMMPAppMessage, PushMMPAppMessage.Builder>
  {
    private static readonly PushMMPAppMessage defaultInstance = new PushMMPAppMessage().MakeReadOnly();
    private static readonly string[] _pushMMPAppMessageFieldNames = new string[5]
    {
      "appIdList",
      "message",
      "phoneTypeList",
      "provinceList",
      "seqId"
    };
    private static readonly uint[] _pushMMPAppMessageFieldTags = new uint[5]
    {
      18U,
      10U,
      26U,
      34U,
      42U
    };
    private PopsicleList<string> appIdList_ = new PopsicleList<string>();
    private PopsicleList<string> phoneTypeList_ = new PopsicleList<string>();
    private PopsicleList<string> provinceList_ = new PopsicleList<string>();
    private string seqId_ = "";
    private int memoizedSerializedSize = -1;
    public const int MessageFieldNumber = 1;
    private bool hasMessage;
    private MMPMessage message_;
    public const int AppIdListFieldNumber = 2;
    public const int PhoneTypeListFieldNumber = 3;
    public const int ProvinceListFieldNumber = 4;
    public const int SeqIdFieldNumber = 5;
    private bool hasSeqId;

    private PushMMPAppMessage()
    {
    }

    public static PushMMPAppMessage DefaultInstance
    {
      get
      {
        return PushMMPAppMessage.defaultInstance;
      }
    }

    public override PushMMPAppMessage DefaultInstanceForType
    {
      get
      {
        return PushMMPAppMessage.DefaultInstance;
      }
    }

    protected override PushMMPAppMessage ThisMessage
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
        return GtReq.internal__static_com_gexin_rp_sdk_dto_PushMMPAppMessage__Descriptor;
      }
    }

    protected override FieldAccessorTable<PushMMPAppMessage, PushMMPAppMessage.Builder> InternalFieldAccessors
    {
      get
      {
        return GtReq.internal__static_com_gexin_rp_sdk_dto_PushMMPAppMessage__FieldAccessorTable;
      }
    }

    public bool HasMessage
    {
      get
      {
        return this.hasMessage;
      }
    }

    public MMPMessage Message
    {
      get
      {
        return this.message_ ?? MMPMessage.DefaultInstance;
      }
    }

    public IList<string> AppIdListList
    {
      get
      {
        return Lists.AsReadOnly<string>((IList<string>) this.appIdList_);
      }
    }

    public int AppIdListCount
    {
      get
      {
        return this.appIdList_.Count;
      }
    }

    public string GetAppIdList(int index)
    {
      return this.appIdList_[index];
    }

    public IList<string> PhoneTypeListList
    {
      get
      {
        return Lists.AsReadOnly<string>((IList<string>) this.phoneTypeList_);
      }
    }

    public int PhoneTypeListCount
    {
      get
      {
        return this.phoneTypeList_.Count;
      }
    }

    public string GetPhoneTypeList(int index)
    {
      return this.phoneTypeList_[index];
    }

    public IList<string> ProvinceListList
    {
      get
      {
        return Lists.AsReadOnly<string>((IList<string>) this.provinceList_);
      }
    }

    public int ProvinceListCount
    {
      get
      {
        return this.provinceList_.Count;
      }
    }

    public string GetProvinceList(int index)
    {
      return this.provinceList_[index];
    }

    public bool HasSeqId
    {
      get
      {
        return this.hasSeqId;
      }
    }

    public string SeqId
    {
      get
      {
        return this.seqId_;
      }
    }

    public override bool IsInitialized
    {
      get
      {
        return this.hasMessage && this.Message.IsInitialized;
      }
    }

    public override void WriteTo(ICodedOutputStream output)
    {
      int serializedSize = this.SerializedSize;
      string[] messageFieldNames = PushMMPAppMessage._pushMMPAppMessageFieldNames;
      if (this.hasMessage)
        output.WriteMessage(1, messageFieldNames[1], (IMessageLite) this.Message);
      if (this.appIdList_.Count > 0)
        output.WriteStringArray(2, messageFieldNames[0], (IEnumerable<string>) this.appIdList_);
      if (this.phoneTypeList_.Count > 0)
        output.WriteStringArray(3, messageFieldNames[2], (IEnumerable<string>) this.phoneTypeList_);
      if (this.provinceList_.Count > 0)
        output.WriteStringArray(4, messageFieldNames[3], (IEnumerable<string>) this.provinceList_);
      if (this.hasSeqId)
        output.WriteString(5, messageFieldNames[4], this.SeqId);
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
        if (this.hasMessage)
          num1 += CodedOutputStream.ComputeMessageSize(1, (IMessageLite) this.Message);
        int num2 = 0;
        foreach (string appIdList in (IEnumerable<string>) this.AppIdListList)
          num2 += CodedOutputStream.ComputeStringSizeNoTag(appIdList);
        int num3 = num1 + num2 + this.appIdList_.Count;
        int num4 = 0;
        foreach (string phoneTypeList in (IEnumerable<string>) this.PhoneTypeListList)
          num4 += CodedOutputStream.ComputeStringSizeNoTag(phoneTypeList);
        int num5 = num3 + num4 + this.phoneTypeList_.Count;
        int num6 = 0;
        foreach (string provinceList in (IEnumerable<string>) this.ProvinceListList)
          num6 += CodedOutputStream.ComputeStringSizeNoTag(provinceList);
        int num7 = num5 + num6 + this.provinceList_.Count;
        if (this.hasSeqId)
          num7 += CodedOutputStream.ComputeStringSize(5, this.SeqId);
        int num8 = num7 + this.UnknownFields.SerializedSize;
        this.memoizedSerializedSize = num8;
        return num8;
      }
    }

    public static PushMMPAppMessage ParseFrom(ByteString data)
    {
      return PushMMPAppMessage.CreateBuilder().MergeFrom(data).BuildParsed();
    }

    public static PushMMPAppMessage ParseFrom(
      ByteString data,
      ExtensionRegistry extensionRegistry)
    {
      return PushMMPAppMessage.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
    }

    public static PushMMPAppMessage ParseFrom(byte[] data)
    {
      return PushMMPAppMessage.CreateBuilder().MergeFrom(data).BuildParsed();
    }

    public static PushMMPAppMessage ParseFrom(
      byte[] data,
      ExtensionRegistry extensionRegistry)
    {
      return PushMMPAppMessage.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
    }

    public static PushMMPAppMessage ParseFrom(Stream input)
    {
      return PushMMPAppMessage.CreateBuilder().MergeFrom(input).BuildParsed();
    }

    public static PushMMPAppMessage ParseFrom(
      Stream input,
      ExtensionRegistry extensionRegistry)
    {
      return PushMMPAppMessage.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
    }

    public static PushMMPAppMessage ParseDelimitedFrom(Stream input)
    {
      return PushMMPAppMessage.CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }

    public static PushMMPAppMessage ParseDelimitedFrom(
      Stream input,
      ExtensionRegistry extensionRegistry)
    {
      return PushMMPAppMessage.CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }

    public static PushMMPAppMessage ParseFrom(ICodedInputStream input)
    {
      return PushMMPAppMessage.CreateBuilder().MergeFrom(input).BuildParsed();
    }

    public static PushMMPAppMessage ParseFrom(
      ICodedInputStream input,
      ExtensionRegistry extensionRegistry)
    {
      return PushMMPAppMessage.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
    }

    private PushMMPAppMessage MakeReadOnly()
    {
      this.appIdList_.MakeReadOnly();
      this.phoneTypeList_.MakeReadOnly();
      this.provinceList_.MakeReadOnly();
      return this;
    }

    public static PushMMPAppMessage.Builder CreateBuilder()
    {
      return new PushMMPAppMessage.Builder();
    }

    public override PushMMPAppMessage.Builder ToBuilder()
    {
      return PushMMPAppMessage.CreateBuilder(this);
    }

    public override PushMMPAppMessage.Builder CreateBuilderForType()
    {
      return new PushMMPAppMessage.Builder();
    }

    public static PushMMPAppMessage.Builder CreateBuilder(
      PushMMPAppMessage prototype)
    {
      return new PushMMPAppMessage.Builder(prototype);
    }

    static PushMMPAppMessage()
    {
      FileDescriptor descriptor = GtReq.Descriptor;
    }

    [DebuggerNonUserCode]
    public sealed class Builder : GeneratedBuilder<PushMMPAppMessage, PushMMPAppMessage.Builder>
    {
      private bool resultIsReadOnly;
      private PushMMPAppMessage result;

      protected override PushMMPAppMessage.Builder ThisBuilder
      {
        get
        {
          return this;
        }
      }

      public Builder()
      {
        this.result = PushMMPAppMessage.DefaultInstance;
        this.resultIsReadOnly = true;
      }

      internal Builder(PushMMPAppMessage cloneFrom)
      {
        this.result = cloneFrom;
        this.resultIsReadOnly = true;
      }

      private PushMMPAppMessage PrepareBuilder()
      {
        if (this.resultIsReadOnly)
        {
          PushMMPAppMessage result = this.result;
          this.result = new PushMMPAppMessage();
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

      protected override PushMMPAppMessage MessageBeingBuilt
      {
        get
        {
          return this.PrepareBuilder();
        }
      }

      public override PushMMPAppMessage.Builder Clear()
      {
        this.result = PushMMPAppMessage.DefaultInstance;
        this.resultIsReadOnly = true;
        return this;
      }

      public override PushMMPAppMessage.Builder Clone()
      {
        if (this.resultIsReadOnly)
          return new PushMMPAppMessage.Builder(this.result);
        return new PushMMPAppMessage.Builder().MergeFrom(this.result);
      }

      public override MessageDescriptor DescriptorForType
      {
        get
        {
          return PushMMPAppMessage.Descriptor;
        }
      }

      public override PushMMPAppMessage DefaultInstanceForType
      {
        get
        {
          return PushMMPAppMessage.DefaultInstance;
        }
      }

      public override PushMMPAppMessage BuildPartial()
      {
        if (this.resultIsReadOnly)
          return this.result;
        this.resultIsReadOnly = true;
        return this.result.MakeReadOnly();
      }

      public override PushMMPAppMessage.Builder MergeFrom(IMessage other)
      {
        if (other is PushMMPAppMessage)
          return this.MergeFrom((PushMMPAppMessage) other);
        base.MergeFrom(other);
        return this;
      }

      public override PushMMPAppMessage.Builder MergeFrom(PushMMPAppMessage other)
      {
        if (other == PushMMPAppMessage.DefaultInstance)
          return this;
        this.PrepareBuilder();
        if (other.HasMessage)
          this.MergeMessage(other.Message);
        if (other.appIdList_.Count != 0)
          this.result.appIdList_.Add((IEnumerable<string>) other.appIdList_);
        if (other.phoneTypeList_.Count != 0)
          this.result.phoneTypeList_.Add((IEnumerable<string>) other.phoneTypeList_);
        if (other.provinceList_.Count != 0)
          this.result.provinceList_.Add((IEnumerable<string>) other.provinceList_);
        if (other.HasSeqId)
          this.SeqId = other.SeqId;
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }

      public override PushMMPAppMessage.Builder MergeFrom(ICodedInputStream input)
      {
        return this.MergeFrom(input, ExtensionRegistry.Empty);
      }

      public override PushMMPAppMessage.Builder MergeFrom(
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
            int index = Array.BinarySearch<string>(PushMMPAppMessage._pushMMPAppMessageFieldNames, fieldName, (IComparer<string>) StringComparer.Ordinal);
            if (index >= 0)
            {
              fieldTag = PushMMPAppMessage._pushMMPAppMessageFieldTags[index];
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
              MMPMessage.Builder builder = MMPMessage.CreateBuilder();
              if (this.result.hasMessage)
                builder.MergeFrom(this.Message);
              input.ReadMessage((IBuilderLite) builder, extensionRegistry);
              this.Message = builder.BuildPartial();
              continue;
            case 18:
              input.ReadStringArray(fieldTag, fieldName, (ICollection<string>) this.result.appIdList_);
              continue;
            case 26:
              input.ReadStringArray(fieldTag, fieldName, (ICollection<string>) this.result.phoneTypeList_);
              continue;
            case 34:
              input.ReadStringArray(fieldTag, fieldName, (ICollection<string>) this.result.provinceList_);
              continue;
            case 42:
              this.result.hasSeqId = input.ReadString(ref this.result.seqId_);
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

      public bool HasMessage
      {
        get
        {
          return this.result.hasMessage;
        }
      }

      public MMPMessage Message
      {
        get
        {
          return this.result.Message;
        }
        set
        {
          this.SetMessage(value);
        }
      }

      public PushMMPAppMessage.Builder SetMessage(MMPMessage value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.hasMessage = true;
        this.result.message_ = value;
        return this;
      }

      public PushMMPAppMessage.Builder SetMessage(
        MMPMessage.Builder builderForValue)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) builderForValue, nameof (builderForValue));
        this.PrepareBuilder();
        this.result.hasMessage = true;
        this.result.message_ = builderForValue.Build();
        return this;
      }

      public PushMMPAppMessage.Builder MergeMessage(MMPMessage value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.message_ = !this.result.hasMessage || this.result.message_ == MMPMessage.DefaultInstance ? value : MMPMessage.CreateBuilder(this.result.message_).MergeFrom(value).BuildPartial();
        this.result.hasMessage = true;
        return this;
      }

      public PushMMPAppMessage.Builder ClearMessage()
      {
        this.PrepareBuilder();
        this.result.hasMessage = false;
        this.result.message_ = (MMPMessage) null;
        return this;
      }

      public IPopsicleList<string> AppIdListList
      {
        get
        {
          return (IPopsicleList<string>) this.PrepareBuilder().appIdList_;
        }
      }

      public int AppIdListCount
      {
        get
        {
          return this.result.AppIdListCount;
        }
      }

      public string GetAppIdList(int index)
      {
        return this.result.GetAppIdList(index);
      }

      public PushMMPAppMessage.Builder SetAppIdList(int index, string value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.appIdList_[index] = value;
        return this;
      }

      public PushMMPAppMessage.Builder AddAppIdList(string value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.appIdList_.Add(value);
        return this;
      }

      public PushMMPAppMessage.Builder AddRangeAppIdList(IEnumerable<string> values)
      {
        this.PrepareBuilder();
        this.result.appIdList_.Add(values);
        return this;
      }

      public PushMMPAppMessage.Builder ClearAppIdList()
      {
        this.PrepareBuilder();
        this.result.appIdList_.Clear();
        return this;
      }

      public IPopsicleList<string> PhoneTypeListList
      {
        get
        {
          return (IPopsicleList<string>) this.PrepareBuilder().phoneTypeList_;
        }
      }

      public int PhoneTypeListCount
      {
        get
        {
          return this.result.PhoneTypeListCount;
        }
      }

      public string GetPhoneTypeList(int index)
      {
        return this.result.GetPhoneTypeList(index);
      }

      public PushMMPAppMessage.Builder SetPhoneTypeList(int index, string value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.phoneTypeList_[index] = value;
        return this;
      }

      public PushMMPAppMessage.Builder AddPhoneTypeList(string value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.phoneTypeList_.Add(value);
        return this;
      }

      public PushMMPAppMessage.Builder AddRangePhoneTypeList(
        IEnumerable<string> values)
      {
        this.PrepareBuilder();
        this.result.phoneTypeList_.Add(values);
        return this;
      }

      public PushMMPAppMessage.Builder ClearPhoneTypeList()
      {
        this.PrepareBuilder();
        this.result.phoneTypeList_.Clear();
        return this;
      }

      public IPopsicleList<string> ProvinceListList
      {
        get
        {
          return (IPopsicleList<string>) this.PrepareBuilder().provinceList_;
        }
      }

      public int ProvinceListCount
      {
        get
        {
          return this.result.ProvinceListCount;
        }
      }

      public string GetProvinceList(int index)
      {
        return this.result.GetProvinceList(index);
      }

      public PushMMPAppMessage.Builder SetProvinceList(int index, string value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.provinceList_[index] = value;
        return this;
      }

      public PushMMPAppMessage.Builder AddProvinceList(string value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.provinceList_.Add(value);
        return this;
      }

      public PushMMPAppMessage.Builder AddRangeProvinceList(
        IEnumerable<string> values)
      {
        this.PrepareBuilder();
        this.result.provinceList_.Add(values);
        return this;
      }

      public PushMMPAppMessage.Builder ClearProvinceList()
      {
        this.PrepareBuilder();
        this.result.provinceList_.Clear();
        return this;
      }

      public bool HasSeqId
      {
        get
        {
          return this.result.hasSeqId;
        }
      }

      public string SeqId
      {
        get
        {
          return this.result.SeqId;
        }
        set
        {
          this.SetSeqId(value);
        }
      }

      public PushMMPAppMessage.Builder SetSeqId(string value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.hasSeqId = true;
        this.result.seqId_ = value;
        return this;
      }

      public PushMMPAppMessage.Builder ClearSeqId()
      {
        this.PrepareBuilder();
        this.result.hasSeqId = false;
        this.result.seqId_ = "";
        return this;
      }
    }
  }
}
