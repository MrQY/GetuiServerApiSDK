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
  public sealed class PushMMPSingleBatchMessage : GeneratedMessage<PushMMPSingleBatchMessage, PushMMPSingleBatchMessage.Builder>
  {
    private static readonly PushMMPSingleBatchMessage defaultInstance = new PushMMPSingleBatchMessage().MakeReadOnly();
    private static readonly string[] _pushMMPSingleBatchMessageFieldNames = new string[3]
    {
      "batchId",
      "batchItem",
      "isSync"
    };
    private static readonly uint[] _pushMMPSingleBatchMessageFieldTags = new uint[3]
    {
      10U,
      18U,
      24U
    };
    private string batchId_ = "";
    private PopsicleList<PushMMPSingleMessage> batchItem_ = new PopsicleList<PushMMPSingleMessage>();
    private bool isSync_ = true;
    private int memoizedSerializedSize = -1;
    public const int BatchIdFieldNumber = 1;
    private bool hasBatchId;
    public const int BatchItemFieldNumber = 2;
    public const int IsSyncFieldNumber = 3;
    private bool hasIsSync;

    private PushMMPSingleBatchMessage()
    {
    }

    public static PushMMPSingleBatchMessage DefaultInstance
    {
      get
      {
        return PushMMPSingleBatchMessage.defaultInstance;
      }
    }

    public override PushMMPSingleBatchMessage DefaultInstanceForType
    {
      get
      {
        return PushMMPSingleBatchMessage.DefaultInstance;
      }
    }

    protected override PushMMPSingleBatchMessage ThisMessage
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
        return GtReq.internal__static_com_gexin_rp_sdk_dto_PushMMPSingleBatchMessage__Descriptor;
      }
    }

    protected override FieldAccessorTable<PushMMPSingleBatchMessage, PushMMPSingleBatchMessage.Builder> InternalFieldAccessors
    {
      get
      {
        return GtReq.internal__static_com_gexin_rp_sdk_dto_PushMMPSingleBatchMessage__FieldAccessorTable;
      }
    }

    public bool HasBatchId
    {
      get
      {
        return this.hasBatchId;
      }
    }

    public string BatchId
    {
      get
      {
        return this.batchId_;
      }
    }

    public IList<PushMMPSingleMessage> BatchItemList
    {
      get
      {
        return (IList<PushMMPSingleMessage>) this.batchItem_;
      }
    }

    public int BatchItemCount
    {
      get
      {
        return this.batchItem_.Count;
      }
    }

    public PushMMPSingleMessage GetBatchItem(int index)
    {
      return this.batchItem_[index];
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
        if (!this.hasBatchId)
          return false;
        foreach (AbstractMessageLite<PushMMPSingleMessage, PushMMPSingleMessage.Builder> batchItem in (IEnumerable<PushMMPSingleMessage>) this.BatchItemList)
        {
          if (!batchItem.IsInitialized)
            return false;
        }
        return true;
      }
    }

    public override void WriteTo(ICodedOutputStream output)
    {
      int serializedSize = this.SerializedSize;
      string[] messageFieldNames = PushMMPSingleBatchMessage._pushMMPSingleBatchMessageFieldNames;
      if (this.hasBatchId)
        output.WriteString(1, messageFieldNames[0], this.BatchId);
      if (this.batchItem_.Count > 0)
        output.WriteMessageArray<PushMMPSingleMessage>(2, messageFieldNames[1], (IEnumerable<PushMMPSingleMessage>) this.batchItem_);
      if (this.hasIsSync)
        output.WriteBool(3, messageFieldNames[2], this.IsSync);
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
        if (this.hasBatchId)
          num1 += CodedOutputStream.ComputeStringSize(1, this.BatchId);
        foreach (PushMMPSingleMessage batchItem in (IEnumerable<PushMMPSingleMessage>) this.BatchItemList)
          num1 += CodedOutputStream.ComputeMessageSize(2, (IMessageLite) batchItem);
        if (this.hasIsSync)
          num1 += CodedOutputStream.ComputeBoolSize(3, this.IsSync);
        int num2 = num1 + this.UnknownFields.SerializedSize;
        this.memoizedSerializedSize = num2;
        return num2;
      }
    }

    public static PushMMPSingleBatchMessage ParseFrom(ByteString data)
    {
      return PushMMPSingleBatchMessage.CreateBuilder().MergeFrom(data).BuildParsed();
    }

    public static PushMMPSingleBatchMessage ParseFrom(
      ByteString data,
      ExtensionRegistry extensionRegistry)
    {
      return PushMMPSingleBatchMessage.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
    }

    public static PushMMPSingleBatchMessage ParseFrom(byte[] data)
    {
      return PushMMPSingleBatchMessage.CreateBuilder().MergeFrom(data).BuildParsed();
    }

    public static PushMMPSingleBatchMessage ParseFrom(
      byte[] data,
      ExtensionRegistry extensionRegistry)
    {
      return PushMMPSingleBatchMessage.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
    }

    public static PushMMPSingleBatchMessage ParseFrom(Stream input)
    {
      return PushMMPSingleBatchMessage.CreateBuilder().MergeFrom(input).BuildParsed();
    }

    public static PushMMPSingleBatchMessage ParseFrom(
      Stream input,
      ExtensionRegistry extensionRegistry)
    {
      return PushMMPSingleBatchMessage.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
    }

    public static PushMMPSingleBatchMessage ParseDelimitedFrom(Stream input)
    {
      return PushMMPSingleBatchMessage.CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }

    public static PushMMPSingleBatchMessage ParseDelimitedFrom(
      Stream input,
      ExtensionRegistry extensionRegistry)
    {
      return PushMMPSingleBatchMessage.CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }

    public static PushMMPSingleBatchMessage ParseFrom(
      ICodedInputStream input)
    {
      return PushMMPSingleBatchMessage.CreateBuilder().MergeFrom(input).BuildParsed();
    }

    public static PushMMPSingleBatchMessage ParseFrom(
      ICodedInputStream input,
      ExtensionRegistry extensionRegistry)
    {
      return PushMMPSingleBatchMessage.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
    }

    private PushMMPSingleBatchMessage MakeReadOnly()
    {
      this.batchItem_.MakeReadOnly();
      return this;
    }

    public static PushMMPSingleBatchMessage.Builder CreateBuilder()
    {
      return new PushMMPSingleBatchMessage.Builder();
    }

    public override PushMMPSingleBatchMessage.Builder ToBuilder()
    {
      return PushMMPSingleBatchMessage.CreateBuilder(this);
    }

    public override PushMMPSingleBatchMessage.Builder CreateBuilderForType()
    {
      return new PushMMPSingleBatchMessage.Builder();
    }

    public static PushMMPSingleBatchMessage.Builder CreateBuilder(
      PushMMPSingleBatchMessage prototype)
    {
      return new PushMMPSingleBatchMessage.Builder(prototype);
    }

    static PushMMPSingleBatchMessage()
    {
      FileDescriptor descriptor = GtReq.Descriptor;
    }

    [DebuggerNonUserCode]
    public sealed class Builder : GeneratedBuilder<PushMMPSingleBatchMessage, PushMMPSingleBatchMessage.Builder>
    {
      private bool resultIsReadOnly;
      private PushMMPSingleBatchMessage result;

      protected override PushMMPSingleBatchMessage.Builder ThisBuilder
      {
        get
        {
          return this;
        }
      }

      public Builder()
      {
        this.result = PushMMPSingleBatchMessage.DefaultInstance;
        this.resultIsReadOnly = true;
      }

      internal Builder(PushMMPSingleBatchMessage cloneFrom)
      {
        this.result = cloneFrom;
        this.resultIsReadOnly = true;
      }

      private PushMMPSingleBatchMessage PrepareBuilder()
      {
        if (this.resultIsReadOnly)
        {
          PushMMPSingleBatchMessage result = this.result;
          this.result = new PushMMPSingleBatchMessage();
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

      protected override PushMMPSingleBatchMessage MessageBeingBuilt
      {
        get
        {
          return this.PrepareBuilder();
        }
      }

      public override PushMMPSingleBatchMessage.Builder Clear()
      {
        this.result = PushMMPSingleBatchMessage.DefaultInstance;
        this.resultIsReadOnly = true;
        return this;
      }

      public override PushMMPSingleBatchMessage.Builder Clone()
      {
        if (this.resultIsReadOnly)
          return new PushMMPSingleBatchMessage.Builder(this.result);
        return new PushMMPSingleBatchMessage.Builder().MergeFrom(this.result);
      }

      public override MessageDescriptor DescriptorForType
      {
        get
        {
          return PushMMPSingleBatchMessage.Descriptor;
        }
      }

      public override PushMMPSingleBatchMessage DefaultInstanceForType
      {
        get
        {
          return PushMMPSingleBatchMessage.DefaultInstance;
        }
      }

      public override PushMMPSingleBatchMessage BuildPartial()
      {
        if (this.resultIsReadOnly)
          return this.result;
        this.resultIsReadOnly = true;
        return this.result.MakeReadOnly();
      }

      public override PushMMPSingleBatchMessage.Builder MergeFrom(
        IMessage other)
      {
        if (other is PushMMPSingleBatchMessage)
          return this.MergeFrom((PushMMPSingleBatchMessage) other);
        base.MergeFrom(other);
        return this;
      }

      public override PushMMPSingleBatchMessage.Builder MergeFrom(
        PushMMPSingleBatchMessage other)
      {
        if (other == PushMMPSingleBatchMessage.DefaultInstance)
          return this;
        this.PrepareBuilder();
        if (other.HasBatchId)
          this.BatchId = other.BatchId;
        if (other.batchItem_.Count != 0)
          this.result.batchItem_.Add((IEnumerable<PushMMPSingleMessage>) other.batchItem_);
        if (other.HasIsSync)
          this.IsSync = other.IsSync;
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }

      public override PushMMPSingleBatchMessage.Builder MergeFrom(
        ICodedInputStream input)
      {
        return this.MergeFrom(input, ExtensionRegistry.Empty);
      }

      public override PushMMPSingleBatchMessage.Builder MergeFrom(
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
            int index = Array.BinarySearch<string>(PushMMPSingleBatchMessage._pushMMPSingleBatchMessageFieldNames, fieldName, (IComparer<string>) StringComparer.Ordinal);
            if (index >= 0)
            {
              fieldTag = PushMMPSingleBatchMessage._pushMMPSingleBatchMessageFieldTags[index];
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
              this.result.hasBatchId = input.ReadString(ref this.result.batchId_);
              continue;
            case 18:
              input.ReadMessageArray<PushMMPSingleMessage>(fieldTag, fieldName, (ICollection<PushMMPSingleMessage>) this.result.batchItem_, PushMMPSingleMessage.DefaultInstance, extensionRegistry);
              continue;
            case 24:
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

      public bool HasBatchId
      {
        get
        {
          return this.result.hasBatchId;
        }
      }

      public string BatchId
      {
        get
        {
          return this.result.BatchId;
        }
        set
        {
          this.SetBatchId(value);
        }
      }

      public PushMMPSingleBatchMessage.Builder SetBatchId(string value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.hasBatchId = true;
        this.result.batchId_ = value;
        return this;
      }

      public PushMMPSingleBatchMessage.Builder ClearBatchId()
      {
        this.PrepareBuilder();
        this.result.hasBatchId = false;
        this.result.batchId_ = "";
        return this;
      }

      public IPopsicleList<PushMMPSingleMessage> BatchItemList
      {
        get
        {
          return (IPopsicleList<PushMMPSingleMessage>) this.PrepareBuilder().batchItem_;
        }
      }

      public int BatchItemCount
      {
        get
        {
          return this.result.BatchItemCount;
        }
      }

      public PushMMPSingleMessage GetBatchItem(int index)
      {
        return this.result.GetBatchItem(index);
      }

      public PushMMPSingleBatchMessage.Builder SetBatchItem(
        int index,
        PushMMPSingleMessage value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.batchItem_[index] = value;
        return this;
      }

      public PushMMPSingleBatchMessage.Builder SetBatchItem(
        int index,
        PushMMPSingleMessage.Builder builderForValue)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) builderForValue, nameof (builderForValue));
        this.PrepareBuilder();
        this.result.batchItem_[index] = builderForValue.Build();
        return this;
      }

      public PushMMPSingleBatchMessage.Builder AddBatchItem(
        PushMMPSingleMessage value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.batchItem_.Add(value);
        return this;
      }

      public PushMMPSingleBatchMessage.Builder AddBatchItem(
        PushMMPSingleMessage.Builder builderForValue)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) builderForValue, nameof (builderForValue));
        this.PrepareBuilder();
        this.result.batchItem_.Add(builderForValue.Build());
        return this;
      }

      public PushMMPSingleBatchMessage.Builder AddRangeBatchItem(
        IEnumerable<PushMMPSingleMessage> values)
      {
        this.PrepareBuilder();
        this.result.batchItem_.Add(values);
        return this;
      }

      public PushMMPSingleBatchMessage.Builder ClearBatchItem()
      {
        this.PrepareBuilder();
        this.result.batchItem_.Clear();
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

      public PushMMPSingleBatchMessage.Builder SetIsSync(bool value)
      {
        this.PrepareBuilder();
        this.result.hasIsSync = true;
        this.result.isSync_ = value;
        return this;
      }

      public PushMMPSingleBatchMessage.Builder ClearIsSync()
      {
        this.PrepareBuilder();
        this.result.hasIsSync = false;
        this.result.isSync_ = true;
        return this;
      }
    }
  }
}
