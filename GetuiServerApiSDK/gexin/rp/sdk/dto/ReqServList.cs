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
  public sealed class ReqServList : GeneratedMessage<ReqServList, ReqServList.Builder>
  {
    private static readonly ReqServList defaultInstance = new ReqServList().MakeReadOnly();
    private static readonly string[] _reqServListFieldNames = new string[2]
    {
      "seqId",
      "timestamp"
    };
    private static readonly uint[] _reqServListFieldTags = new uint[2]
    {
      10U,
      24U
    };
    private string seqId_ = "";
    private int memoizedSerializedSize = -1;
    public const int SeqIdFieldNumber = 1;
    private bool hasSeqId;
    public const int TimestampFieldNumber = 3;
    private bool hasTimestamp;
    private long timestamp_;

    private ReqServList()
    {
    }

    public static ReqServList DefaultInstance
    {
      get
      {
        return ReqServList.defaultInstance;
      }
    }

    public override ReqServList DefaultInstanceForType
    {
      get
      {
        return ReqServList.DefaultInstance;
      }
    }

    protected override ReqServList ThisMessage
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
        return GtReq.internal__static_com_gexin_rp_sdk_dto_ReqServList__Descriptor;
      }
    }

    protected override FieldAccessorTable<ReqServList, ReqServList.Builder> InternalFieldAccessors
    {
      get
      {
        return GtReq.internal__static_com_gexin_rp_sdk_dto_ReqServList__FieldAccessorTable;
      }
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

    public bool HasTimestamp
    {
      get
      {
        return this.hasTimestamp;
      }
    }

    public long Timestamp
    {
      get
      {
        return this.timestamp_;
      }
    }

    public override bool IsInitialized
    {
      get
      {
        return this.hasTimestamp;
      }
    }

    public override void WriteTo(ICodedOutputStream output)
    {
      int serializedSize = this.SerializedSize;
      string[] servListFieldNames = ReqServList._reqServListFieldNames;
      if (this.hasSeqId)
        output.WriteString(1, servListFieldNames[0], this.SeqId);
      if (this.hasTimestamp)
        output.WriteInt64(3, servListFieldNames[1], this.Timestamp);
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
          num1 += CodedOutputStream.ComputeStringSize(1, this.SeqId);
        if (this.hasTimestamp)
          num1 += CodedOutputStream.ComputeInt64Size(3, this.Timestamp);
        int num2 = num1 + this.UnknownFields.SerializedSize;
        this.memoizedSerializedSize = num2;
        return num2;
      }
    }

    public static ReqServList ParseFrom(ByteString data)
    {
      return ReqServList.CreateBuilder().MergeFrom(data).BuildParsed();
    }

    public static ReqServList ParseFrom(
      ByteString data,
      ExtensionRegistry extensionRegistry)
    {
      return ReqServList.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
    }

    public static ReqServList ParseFrom(byte[] data)
    {
      return ReqServList.CreateBuilder().MergeFrom(data).BuildParsed();
    }

    public static ReqServList ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
    {
      return ReqServList.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
    }

    public static ReqServList ParseFrom(Stream input)
    {
      return ReqServList.CreateBuilder().MergeFrom(input).BuildParsed();
    }

    public static ReqServList ParseFrom(
      Stream input,
      ExtensionRegistry extensionRegistry)
    {
      return ReqServList.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
    }

    public static ReqServList ParseDelimitedFrom(Stream input)
    {
      return ReqServList.CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }

    public static ReqServList ParseDelimitedFrom(
      Stream input,
      ExtensionRegistry extensionRegistry)
    {
      return ReqServList.CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }

    public static ReqServList ParseFrom(ICodedInputStream input)
    {
      return ReqServList.CreateBuilder().MergeFrom(input).BuildParsed();
    }

    public static ReqServList ParseFrom(
      ICodedInputStream input,
      ExtensionRegistry extensionRegistry)
    {
      return ReqServList.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
    }

    private ReqServList MakeReadOnly()
    {
      return this;
    }

    public static ReqServList.Builder CreateBuilder()
    {
      return new ReqServList.Builder();
    }

    public override ReqServList.Builder ToBuilder()
    {
      return ReqServList.CreateBuilder(this);
    }

    public override ReqServList.Builder CreateBuilderForType()
    {
      return new ReqServList.Builder();
    }

    public static ReqServList.Builder CreateBuilder(ReqServList prototype)
    {
      return new ReqServList.Builder(prototype);
    }

    static ReqServList()
    {
      FileDescriptor descriptor = GtReq.Descriptor;
    }

    [DebuggerNonUserCode]
    public sealed class Builder : GeneratedBuilder<ReqServList, ReqServList.Builder>
    {
      private bool resultIsReadOnly;
      private ReqServList result;

      protected override ReqServList.Builder ThisBuilder
      {
        get
        {
          return this;
        }
      }

      public Builder()
      {
        this.result = ReqServList.DefaultInstance;
        this.resultIsReadOnly = true;
      }

      internal Builder(ReqServList cloneFrom)
      {
        this.result = cloneFrom;
        this.resultIsReadOnly = true;
      }

      private ReqServList PrepareBuilder()
      {
        if (this.resultIsReadOnly)
        {
          ReqServList result = this.result;
          this.result = new ReqServList();
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

      protected override ReqServList MessageBeingBuilt
      {
        get
        {
          return this.PrepareBuilder();
        }
      }

      public override ReqServList.Builder Clear()
      {
        this.result = ReqServList.DefaultInstance;
        this.resultIsReadOnly = true;
        return this;
      }

      public override ReqServList.Builder Clone()
      {
        if (this.resultIsReadOnly)
          return new ReqServList.Builder(this.result);
        return new ReqServList.Builder().MergeFrom(this.result);
      }

      public override MessageDescriptor DescriptorForType
      {
        get
        {
          return ReqServList.Descriptor;
        }
      }

      public override ReqServList DefaultInstanceForType
      {
        get
        {
          return ReqServList.DefaultInstance;
        }
      }

      public override ReqServList BuildPartial()
      {
        if (this.resultIsReadOnly)
          return this.result;
        this.resultIsReadOnly = true;
        return this.result.MakeReadOnly();
      }

      public override ReqServList.Builder MergeFrom(IMessage other)
      {
        if (other is ReqServList)
          return this.MergeFrom((ReqServList) other);
        base.MergeFrom(other);
        return this;
      }

      public override ReqServList.Builder MergeFrom(ReqServList other)
      {
        if (other == ReqServList.DefaultInstance)
          return this;
        this.PrepareBuilder();
        if (other.HasSeqId)
          this.SeqId = other.SeqId;
        if (other.HasTimestamp)
          this.Timestamp = other.Timestamp;
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }

      public override ReqServList.Builder MergeFrom(ICodedInputStream input)
      {
        return this.MergeFrom(input, ExtensionRegistry.Empty);
      }

      public override ReqServList.Builder MergeFrom(
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
            int index = Array.BinarySearch<string>(ReqServList._reqServListFieldNames, fieldName, (IComparer<string>) StringComparer.Ordinal);
            if (index >= 0)
            {
              fieldTag = ReqServList._reqServListFieldTags[index];
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
              this.result.hasSeqId = input.ReadString(ref this.result.seqId_);
              continue;
            case 24:
              this.result.hasTimestamp = input.ReadInt64(ref this.result.timestamp_);
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

      public ReqServList.Builder SetSeqId(string value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.hasSeqId = true;
        this.result.seqId_ = value;
        return this;
      }

      public ReqServList.Builder ClearSeqId()
      {
        this.PrepareBuilder();
        this.result.hasSeqId = false;
        this.result.seqId_ = "";
        return this;
      }

      public bool HasTimestamp
      {
        get
        {
          return this.result.hasTimestamp;
        }
      }

      public long Timestamp
      {
        get
        {
          return this.result.Timestamp;
        }
        set
        {
          this.SetTimestamp(value);
        }
      }

      public ReqServList.Builder SetTimestamp(long value)
      {
        this.PrepareBuilder();
        this.result.hasTimestamp = true;
        this.result.timestamp_ = value;
        return this;
      }

      public ReqServList.Builder ClearTimestamp()
      {
        this.PrepareBuilder();
        this.result.hasTimestamp = false;
        this.result.timestamp_ = 0L;
        return this;
      }
    }
  }
}
