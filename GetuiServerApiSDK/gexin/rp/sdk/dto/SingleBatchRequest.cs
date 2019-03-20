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
  public sealed class SingleBatchRequest : GeneratedMessage<SingleBatchRequest, SingleBatchRequest.Builder>
  {
    private static readonly SingleBatchRequest defaultInstance = new SingleBatchRequest().MakeReadOnly();
    private static readonly string[] _singleBatchRequestFieldNames = new string[2]{ "batchId", "batchItem" };
    private static readonly uint[] _singleBatchRequestFieldTags = new uint[2]
    {
      10U,
      18U
    };
    private string batchId_ = "";
    private PopsicleList<SingleBatchItem> batchItem_ = new PopsicleList<SingleBatchItem>();
    private int memoizedSerializedSize = -1;
    public const int BatchIdFieldNumber = 1;
    private bool hasBatchId;
    public const int BatchItemFieldNumber = 2;

    private SingleBatchRequest()
    {
    }

    public static SingleBatchRequest DefaultInstance
    {
      get
      {
        return SingleBatchRequest.defaultInstance;
      }
    }

    public override SingleBatchRequest DefaultInstanceForType
    {
      get
      {
        return SingleBatchRequest.DefaultInstance;
      }
    }

    protected override SingleBatchRequest ThisMessage
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
        return GtReq.internal__static_com_gexin_rp_sdk_dto_SingleBatchRequest__Descriptor;
      }
    }

    protected override FieldAccessorTable<SingleBatchRequest, SingleBatchRequest.Builder> InternalFieldAccessors
    {
      get
      {
        return GtReq.internal__static_com_gexin_rp_sdk_dto_SingleBatchRequest__FieldAccessorTable;
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

    public IList<SingleBatchItem> BatchItemList
    {
      get
      {
        return (IList<SingleBatchItem>) this.batchItem_;
      }
    }

    public int BatchItemCount
    {
      get
      {
        return this.batchItem_.Count;
      }
    }

    public SingleBatchItem GetBatchItem(int index)
    {
      return this.batchItem_[index];
    }

    public override bool IsInitialized
    {
      get
      {
        if (!this.hasBatchId)
          return false;
        foreach (AbstractMessageLite<SingleBatchItem, SingleBatchItem.Builder> batchItem in (IEnumerable<SingleBatchItem>) this.BatchItemList)
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
      string[] requestFieldNames = SingleBatchRequest._singleBatchRequestFieldNames;
      if (this.hasBatchId)
        output.WriteString(1, requestFieldNames[0], this.BatchId);
      if (this.batchItem_.Count > 0)
        output.WriteMessageArray<SingleBatchItem>(2, requestFieldNames[1], (IEnumerable<SingleBatchItem>) this.batchItem_);
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
        foreach (SingleBatchItem batchItem in (IEnumerable<SingleBatchItem>) this.BatchItemList)
          num1 += CodedOutputStream.ComputeMessageSize(2, (IMessageLite) batchItem);
        int num2 = num1 + this.UnknownFields.SerializedSize;
        this.memoizedSerializedSize = num2;
        return num2;
      }
    }

    public static SingleBatchRequest ParseFrom(ByteString data)
    {
      return SingleBatchRequest.CreateBuilder().MergeFrom(data).BuildParsed();
    }

    public static SingleBatchRequest ParseFrom(
      ByteString data,
      ExtensionRegistry extensionRegistry)
    {
      return SingleBatchRequest.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
    }

    public static SingleBatchRequest ParseFrom(byte[] data)
    {
      return SingleBatchRequest.CreateBuilder().MergeFrom(data).BuildParsed();
    }

    public static SingleBatchRequest ParseFrom(
      byte[] data,
      ExtensionRegistry extensionRegistry)
    {
      return SingleBatchRequest.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
    }

    public static SingleBatchRequest ParseFrom(Stream input)
    {
      return SingleBatchRequest.CreateBuilder().MergeFrom(input).BuildParsed();
    }

    public static SingleBatchRequest ParseFrom(
      Stream input,
      ExtensionRegistry extensionRegistry)
    {
      return SingleBatchRequest.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
    }

    public static SingleBatchRequest ParseDelimitedFrom(Stream input)
    {
      return SingleBatchRequest.CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }

    public static SingleBatchRequest ParseDelimitedFrom(
      Stream input,
      ExtensionRegistry extensionRegistry)
    {
      return SingleBatchRequest.CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }

    public static SingleBatchRequest ParseFrom(ICodedInputStream input)
    {
      return SingleBatchRequest.CreateBuilder().MergeFrom(input).BuildParsed();
    }

    public static SingleBatchRequest ParseFrom(
      ICodedInputStream input,
      ExtensionRegistry extensionRegistry)
    {
      return SingleBatchRequest.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
    }

    private SingleBatchRequest MakeReadOnly()
    {
      this.batchItem_.MakeReadOnly();
      return this;
    }

    public static SingleBatchRequest.Builder CreateBuilder()
    {
      return new SingleBatchRequest.Builder();
    }

    public override SingleBatchRequest.Builder ToBuilder()
    {
      return SingleBatchRequest.CreateBuilder(this);
    }

    public override SingleBatchRequest.Builder CreateBuilderForType()
    {
      return new SingleBatchRequest.Builder();
    }

    public static SingleBatchRequest.Builder CreateBuilder(
      SingleBatchRequest prototype)
    {
      return new SingleBatchRequest.Builder(prototype);
    }

    static SingleBatchRequest()
    {
      FileDescriptor descriptor = GtReq.Descriptor;
    }

    [DebuggerNonUserCode]
    public sealed class Builder : GeneratedBuilder<SingleBatchRequest, SingleBatchRequest.Builder>
    {
      private bool resultIsReadOnly;
      private SingleBatchRequest result;

      protected override SingleBatchRequest.Builder ThisBuilder
      {
        get
        {
          return this;
        }
      }

      public Builder()
      {
        this.result = SingleBatchRequest.DefaultInstance;
        this.resultIsReadOnly = true;
      }

      internal Builder(SingleBatchRequest cloneFrom)
      {
        this.result = cloneFrom;
        this.resultIsReadOnly = true;
      }

      private SingleBatchRequest PrepareBuilder()
      {
        if (this.resultIsReadOnly)
        {
          SingleBatchRequest result = this.result;
          this.result = new SingleBatchRequest();
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

      protected override SingleBatchRequest MessageBeingBuilt
      {
        get
        {
          return this.PrepareBuilder();
        }
      }

      public override SingleBatchRequest.Builder Clear()
      {
        this.result = SingleBatchRequest.DefaultInstance;
        this.resultIsReadOnly = true;
        return this;
      }

      public override SingleBatchRequest.Builder Clone()
      {
        if (this.resultIsReadOnly)
          return new SingleBatchRequest.Builder(this.result);
        return new SingleBatchRequest.Builder().MergeFrom(this.result);
      }

      public override MessageDescriptor DescriptorForType
      {
        get
        {
          return SingleBatchRequest.Descriptor;
        }
      }

      public override SingleBatchRequest DefaultInstanceForType
      {
        get
        {
          return SingleBatchRequest.DefaultInstance;
        }
      }

      public override SingleBatchRequest BuildPartial()
      {
        if (this.resultIsReadOnly)
          return this.result;
        this.resultIsReadOnly = true;
        return this.result.MakeReadOnly();
      }

      public override SingleBatchRequest.Builder MergeFrom(IMessage other)
      {
        if (other is SingleBatchRequest)
          return this.MergeFrom((SingleBatchRequest) other);
        base.MergeFrom(other);
        return this;
      }

      public override SingleBatchRequest.Builder MergeFrom(
        SingleBatchRequest other)
      {
        if (other == SingleBatchRequest.DefaultInstance)
          return this;
        this.PrepareBuilder();
        if (other.HasBatchId)
          this.BatchId = other.BatchId;
        if (other.batchItem_.Count != 0)
          this.result.batchItem_.Add((IEnumerable<SingleBatchItem>) other.batchItem_);
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }

      public override SingleBatchRequest.Builder MergeFrom(ICodedInputStream input)
      {
        return this.MergeFrom(input, ExtensionRegistry.Empty);
      }

      public override SingleBatchRequest.Builder MergeFrom(
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
            int index = Array.BinarySearch<string>(SingleBatchRequest._singleBatchRequestFieldNames, fieldName, (IComparer<string>) StringComparer.Ordinal);
            if (index >= 0)
            {
              fieldTag = SingleBatchRequest._singleBatchRequestFieldTags[index];
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
              input.ReadMessageArray<SingleBatchItem>(fieldTag, fieldName, (ICollection<SingleBatchItem>) this.result.batchItem_, SingleBatchItem.DefaultInstance, extensionRegistry);
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

      public SingleBatchRequest.Builder SetBatchId(string value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.hasBatchId = true;
        this.result.batchId_ = value;
        return this;
      }

      public SingleBatchRequest.Builder ClearBatchId()
      {
        this.PrepareBuilder();
        this.result.hasBatchId = false;
        this.result.batchId_ = "";
        return this;
      }

      public IPopsicleList<SingleBatchItem> BatchItemList
      {
        get
        {
          return (IPopsicleList<SingleBatchItem>) this.PrepareBuilder().batchItem_;
        }
      }

      public int BatchItemCount
      {
        get
        {
          return this.result.BatchItemCount;
        }
      }

      public SingleBatchItem GetBatchItem(int index)
      {
        return this.result.GetBatchItem(index);
      }

      public SingleBatchRequest.Builder SetBatchItem(
        int index,
        SingleBatchItem value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.batchItem_[index] = value;
        return this;
      }

      public SingleBatchRequest.Builder SetBatchItem(
        int index,
        SingleBatchItem.Builder builderForValue)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) builderForValue, nameof (builderForValue));
        this.PrepareBuilder();
        this.result.batchItem_[index] = builderForValue.Build();
        return this;
      }

      public SingleBatchRequest.Builder AddBatchItem(SingleBatchItem value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.batchItem_.Add(value);
        return this;
      }

      public SingleBatchRequest.Builder AddBatchItem(
        SingleBatchItem.Builder builderForValue)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) builderForValue, nameof (builderForValue));
        this.PrepareBuilder();
        this.result.batchItem_.Add(builderForValue.Build());
        return this;
      }

      public SingleBatchRequest.Builder AddRangeBatchItem(
        IEnumerable<SingleBatchItem> values)
      {
        this.PrepareBuilder();
        this.result.batchItem_.Add(values);
        return this;
      }

      public SingleBatchRequest.Builder ClearBatchItem()
      {
        this.PrepareBuilder();
        this.result.batchItem_.Clear();
        return this;
      }
    }
  }
}
