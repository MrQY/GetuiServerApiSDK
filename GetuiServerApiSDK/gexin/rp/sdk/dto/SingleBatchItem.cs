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
  public sealed class SingleBatchItem : GeneratedMessage<SingleBatchItem, SingleBatchItem.Builder>
  {
    private static readonly SingleBatchItem defaultInstance = new SingleBatchItem().MakeReadOnly();
    private static readonly string[] _singleBatchItemFieldNames = new string[2]{ "data", "seqId" };
    private static readonly uint[] _singleBatchItemFieldTags = new uint[2]{ 18U, 8U };
    private string data_ = "";
    private int memoizedSerializedSize = -1;
    public const int SeqIdFieldNumber = 1;
    private bool hasSeqId;
    private int seqId_;
    public const int DataFieldNumber = 2;
    private bool hasData;

    private SingleBatchItem()
    {
    }

    public static SingleBatchItem DefaultInstance
    {
      get
      {
        return SingleBatchItem.defaultInstance;
      }
    }

    public override SingleBatchItem DefaultInstanceForType
    {
      get
      {
        return SingleBatchItem.DefaultInstance;
      }
    }

    protected override SingleBatchItem ThisMessage
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
        return GtReq.internal__static_com_gexin_rp_sdk_dto_SingleBatchItem__Descriptor;
      }
    }

    protected override FieldAccessorTable<SingleBatchItem, SingleBatchItem.Builder> InternalFieldAccessors
    {
      get
      {
        return GtReq.internal__static_com_gexin_rp_sdk_dto_SingleBatchItem__FieldAccessorTable;
      }
    }

    public bool HasSeqId
    {
      get
      {
        return this.hasSeqId;
      }
    }

    public int SeqId
    {
      get
      {
        return this.seqId_;
      }
    }

    public bool HasData
    {
      get
      {
        return this.hasData;
      }
    }

    public string Data
    {
      get
      {
        return this.data_;
      }
    }

    public override bool IsInitialized
    {
      get
      {
        return this.hasSeqId && this.hasData;
      }
    }

    public override void WriteTo(ICodedOutputStream output)
    {
      int serializedSize = this.SerializedSize;
      string[] batchItemFieldNames = SingleBatchItem._singleBatchItemFieldNames;
      if (this.hasSeqId)
        output.WriteInt32(1, batchItemFieldNames[1], this.SeqId);
      if (this.hasData)
        output.WriteString(2, batchItemFieldNames[0], this.Data);
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
        if (this.hasSeqId)
          num1 += CodedOutputStream.ComputeInt32Size(1, this.SeqId);
        if (this.hasData)
          num1 += CodedOutputStream.ComputeStringSize(2, this.Data);
        int num2 = num1 + this.UnknownFields.SerializedSize;
        this.memoizedSerializedSize = num2;
        return num2;
      }
    }

    public static SingleBatchItem ParseFrom(ByteString data)
    {
      return SingleBatchItem.CreateBuilder().MergeFrom(data).BuildParsed();
    }

    public static SingleBatchItem ParseFrom(
      ByteString data,
      ExtensionRegistry extensionRegistry)
    {
      return SingleBatchItem.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
    }

    public static SingleBatchItem ParseFrom(byte[] data)
    {
      return SingleBatchItem.CreateBuilder().MergeFrom(data).BuildParsed();
    }

    public static SingleBatchItem ParseFrom(
      byte[] data,
      ExtensionRegistry extensionRegistry)
    {
      return SingleBatchItem.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
    }

    public static SingleBatchItem ParseFrom(Stream input)
    {
      return SingleBatchItem.CreateBuilder().MergeFrom(input).BuildParsed();
    }

    public static SingleBatchItem ParseFrom(
      Stream input,
      ExtensionRegistry extensionRegistry)
    {
      return SingleBatchItem.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
    }

    public static SingleBatchItem ParseDelimitedFrom(Stream input)
    {
      return SingleBatchItem.CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }

    public static SingleBatchItem ParseDelimitedFrom(
      Stream input,
      ExtensionRegistry extensionRegistry)
    {
      return SingleBatchItem.CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }

    public static SingleBatchItem ParseFrom(ICodedInputStream input)
    {
      return SingleBatchItem.CreateBuilder().MergeFrom(input).BuildParsed();
    }

    public static SingleBatchItem ParseFrom(
      ICodedInputStream input,
      ExtensionRegistry extensionRegistry)
    {
      return SingleBatchItem.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
    }

    private SingleBatchItem MakeReadOnly()
    {
      return this;
    }

    public static SingleBatchItem.Builder CreateBuilder()
    {
      return new SingleBatchItem.Builder();
    }

    public override SingleBatchItem.Builder ToBuilder()
    {
      return SingleBatchItem.CreateBuilder(this);
    }

    public override SingleBatchItem.Builder CreateBuilderForType()
    {
      return new SingleBatchItem.Builder();
    }

    public static SingleBatchItem.Builder CreateBuilder(SingleBatchItem prototype)
    {
      return new SingleBatchItem.Builder(prototype);
    }

    static SingleBatchItem()
    {
      FileDescriptor descriptor = GtReq.Descriptor;
    }

    [DebuggerNonUserCode]
    public sealed class Builder : GeneratedBuilder<SingleBatchItem, SingleBatchItem.Builder>
    {
      private bool resultIsReadOnly;
      private SingleBatchItem result;

      protected override SingleBatchItem.Builder ThisBuilder
      {
        get
        {
          return this;
        }
      }

      public Builder()
      {
        this.result = SingleBatchItem.DefaultInstance;
        this.resultIsReadOnly = true;
      }

      internal Builder(SingleBatchItem cloneFrom)
      {
        this.result = cloneFrom;
        this.resultIsReadOnly = true;
      }

      private SingleBatchItem PrepareBuilder()
      {
        if (this.resultIsReadOnly)
        {
          SingleBatchItem result = this.result;
          this.result = new SingleBatchItem();
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

      protected override SingleBatchItem MessageBeingBuilt
      {
        get
        {
          return this.PrepareBuilder();
        }
      }

      public override SingleBatchItem.Builder Clear()
      {
        this.result = SingleBatchItem.DefaultInstance;
        this.resultIsReadOnly = true;
        return this;
      }

      public override SingleBatchItem.Builder Clone()
      {
        if (this.resultIsReadOnly)
          return new SingleBatchItem.Builder(this.result);
        return new SingleBatchItem.Builder().MergeFrom(this.result);
      }

      public override MessageDescriptor DescriptorForType
      {
        get
        {
          return SingleBatchItem.Descriptor;
        }
      }

      public override SingleBatchItem DefaultInstanceForType
      {
        get
        {
          return SingleBatchItem.DefaultInstance;
        }
      }

      public override SingleBatchItem BuildPartial()
      {
        if (this.resultIsReadOnly)
          return this.result;
        this.resultIsReadOnly = true;
        return this.result.MakeReadOnly();
      }

      public override SingleBatchItem.Builder MergeFrom(IMessage other)
      {
        if (other is SingleBatchItem)
          return this.MergeFrom((SingleBatchItem) other);
        base.MergeFrom(other);
        return this;
      }

      public override SingleBatchItem.Builder MergeFrom(SingleBatchItem other)
      {
        if (other == SingleBatchItem.DefaultInstance)
          return this;
        this.PrepareBuilder();
        if (other.HasSeqId)
          this.SeqId = other.SeqId;
        if (other.HasData)
          this.Data = other.Data;
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }

      public override SingleBatchItem.Builder MergeFrom(ICodedInputStream input)
      {
        return this.MergeFrom(input, ExtensionRegistry.Empty);
      }

      public override SingleBatchItem.Builder MergeFrom(
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
            int index = Array.BinarySearch<string>(SingleBatchItem._singleBatchItemFieldNames, fieldName, (IComparer<string>) StringComparer.Ordinal);
            if (index >= 0)
            {
              fieldTag = SingleBatchItem._singleBatchItemFieldTags[index];
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
            case 8:
              this.result.hasSeqId = input.ReadInt32(ref this.result.seqId_);
              continue;
            case 18:
              this.result.hasData = input.ReadString(ref this.result.data_);
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

      public bool HasSeqId
      {
        get
        {
          return this.result.hasSeqId;
        }
      }

      public int SeqId
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

      public SingleBatchItem.Builder SetSeqId(int value)
      {
        this.PrepareBuilder();
        this.result.hasSeqId = true;
        this.result.seqId_ = value;
        return this;
      }

      public SingleBatchItem.Builder ClearSeqId()
      {
        this.PrepareBuilder();
        this.result.hasSeqId = false;
        this.result.seqId_ = 0;
        return this;
      }

      public bool HasData
      {
        get
        {
          return this.result.hasData;
        }
      }

      public string Data
      {
        get
        {
          return this.result.Data;
        }
        set
        {
          this.SetData(value);
        }
      }

      public SingleBatchItem.Builder SetData(string value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.hasData = true;
        this.result.data_ = value;
        return this;
      }

      public SingleBatchItem.Builder ClearData()
      {
        this.PrepareBuilder();
        this.result.hasData = false;
        this.result.data_ = "";
        return this;
      }
    }
  }
}
