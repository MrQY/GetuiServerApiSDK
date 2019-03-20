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
  public sealed class StopBatchTaskResult : GeneratedMessage<StopBatchTaskResult, StopBatchTaskResult.Builder>
  {
    private static readonly StopBatchTaskResult defaultInstance = new StopBatchTaskResult().MakeReadOnly();
    private static readonly string[] _stopBatchTaskResultFieldNames = new string[3]
    {
      "info",
      "result",
      "seqId"
    };
    private static readonly uint[] _stopBatchTaskResultFieldTags = new uint[3]
    {
      18U,
      8U,
      26U
    };
    private string info_ = "";
    private string seqId_ = "";
    private int memoizedSerializedSize = -1;
    public const int ResultFieldNumber = 1;
    private bool hasResult;
    private bool result_;
    public const int InfoFieldNumber = 2;
    private bool hasInfo;
    public const int SeqIdFieldNumber = 3;
    private bool hasSeqId;

    private StopBatchTaskResult()
    {
    }

    public static StopBatchTaskResult DefaultInstance
    {
      get
      {
        return StopBatchTaskResult.defaultInstance;
      }
    }

    public override StopBatchTaskResult DefaultInstanceForType
    {
      get
      {
        return StopBatchTaskResult.DefaultInstance;
      }
    }

    protected override StopBatchTaskResult ThisMessage
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
        return GtReq.internal__static_com_gexin_rp_sdk_dto_StopBatchTaskResult__Descriptor;
      }
    }

    protected override FieldAccessorTable<StopBatchTaskResult, StopBatchTaskResult.Builder> InternalFieldAccessors
    {
      get
      {
        return GtReq.internal__static_com_gexin_rp_sdk_dto_StopBatchTaskResult__FieldAccessorTable;
      }
    }

    public bool HasResult
    {
      get
      {
        return this.hasResult;
      }
    }

    public bool Result
    {
      get
      {
        return this.result_;
      }
    }

    public bool HasInfo
    {
      get
      {
        return this.hasInfo;
      }
    }

    public string Info
    {
      get
      {
        return this.info_;
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

    public override bool IsInitialized
    {
      get
      {
        return this.hasResult;
      }
    }

    public override void WriteTo(ICodedOutputStream output)
    {
      int serializedSize = this.SerializedSize;
      string[] resultFieldNames = StopBatchTaskResult._stopBatchTaskResultFieldNames;
      if (this.hasResult)
        output.WriteBool(1, resultFieldNames[1], this.Result);
      if (this.hasInfo)
        output.WriteString(2, resultFieldNames[0], this.Info);
      if (this.hasSeqId)
        output.WriteString(3, resultFieldNames[2], this.SeqId);
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
        if (this.hasResult)
          num1 += CodedOutputStream.ComputeBoolSize(1, this.Result);
        if (this.hasInfo)
          num1 += CodedOutputStream.ComputeStringSize(2, this.Info);
        if (this.hasSeqId)
          num1 += CodedOutputStream.ComputeStringSize(3, this.SeqId);
        int num2 = num1 + this.UnknownFields.SerializedSize;
        this.memoizedSerializedSize = num2;
        return num2;
      }
    }

    public static StopBatchTaskResult ParseFrom(ByteString data)
    {
      return StopBatchTaskResult.CreateBuilder().MergeFrom(data).BuildParsed();
    }

    public static StopBatchTaskResult ParseFrom(
      ByteString data,
      ExtensionRegistry extensionRegistry)
    {
      return StopBatchTaskResult.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
    }

    public static StopBatchTaskResult ParseFrom(byte[] data)
    {
      return StopBatchTaskResult.CreateBuilder().MergeFrom(data).BuildParsed();
    }

    public static StopBatchTaskResult ParseFrom(
      byte[] data,
      ExtensionRegistry extensionRegistry)
    {
      return StopBatchTaskResult.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
    }

    public static StopBatchTaskResult ParseFrom(Stream input)
    {
      return StopBatchTaskResult.CreateBuilder().MergeFrom(input).BuildParsed();
    }

    public static StopBatchTaskResult ParseFrom(
      Stream input,
      ExtensionRegistry extensionRegistry)
    {
      return StopBatchTaskResult.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
    }

    public static StopBatchTaskResult ParseDelimitedFrom(Stream input)
    {
      return StopBatchTaskResult.CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }

    public static StopBatchTaskResult ParseDelimitedFrom(
      Stream input,
      ExtensionRegistry extensionRegistry)
    {
      return StopBatchTaskResult.CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }

    public static StopBatchTaskResult ParseFrom(ICodedInputStream input)
    {
      return StopBatchTaskResult.CreateBuilder().MergeFrom(input).BuildParsed();
    }

    public static StopBatchTaskResult ParseFrom(
      ICodedInputStream input,
      ExtensionRegistry extensionRegistry)
    {
      return StopBatchTaskResult.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
    }

    private StopBatchTaskResult MakeReadOnly()
    {
      return this;
    }

    public static StopBatchTaskResult.Builder CreateBuilder()
    {
      return new StopBatchTaskResult.Builder();
    }

    public override StopBatchTaskResult.Builder ToBuilder()
    {
      return StopBatchTaskResult.CreateBuilder(this);
    }

    public override StopBatchTaskResult.Builder CreateBuilderForType()
    {
      return new StopBatchTaskResult.Builder();
    }

    public static StopBatchTaskResult.Builder CreateBuilder(
      StopBatchTaskResult prototype)
    {
      return new StopBatchTaskResult.Builder(prototype);
    }

    static StopBatchTaskResult()
    {
      FileDescriptor descriptor = GtReq.Descriptor;
    }

    [DebuggerNonUserCode]
    public sealed class Builder : GeneratedBuilder<StopBatchTaskResult, StopBatchTaskResult.Builder>
    {
      private bool resultIsReadOnly;
      private StopBatchTaskResult result;

      protected override StopBatchTaskResult.Builder ThisBuilder
      {
        get
        {
          return this;
        }
      }

      public Builder()
      {
        this.result = StopBatchTaskResult.DefaultInstance;
        this.resultIsReadOnly = true;
      }

      internal Builder(StopBatchTaskResult cloneFrom)
      {
        this.result = cloneFrom;
        this.resultIsReadOnly = true;
      }

      private StopBatchTaskResult PrepareBuilder()
      {
        if (this.resultIsReadOnly)
        {
          StopBatchTaskResult result = this.result;
          this.result = new StopBatchTaskResult();
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

      protected override StopBatchTaskResult MessageBeingBuilt
      {
        get
        {
          return this.PrepareBuilder();
        }
      }

      public override StopBatchTaskResult.Builder Clear()
      {
        this.result = StopBatchTaskResult.DefaultInstance;
        this.resultIsReadOnly = true;
        return this;
      }

      public override StopBatchTaskResult.Builder Clone()
      {
        if (this.resultIsReadOnly)
          return new StopBatchTaskResult.Builder(this.result);
        return new StopBatchTaskResult.Builder().MergeFrom(this.result);
      }

      public override MessageDescriptor DescriptorForType
      {
        get
        {
          return StopBatchTaskResult.Descriptor;
        }
      }

      public override StopBatchTaskResult DefaultInstanceForType
      {
        get
        {
          return StopBatchTaskResult.DefaultInstance;
        }
      }

      public override StopBatchTaskResult BuildPartial()
      {
        if (this.resultIsReadOnly)
          return this.result;
        this.resultIsReadOnly = true;
        return this.result.MakeReadOnly();
      }

      public override StopBatchTaskResult.Builder MergeFrom(IMessage other)
      {
        if (other is StopBatchTaskResult)
          return this.MergeFrom((StopBatchTaskResult) other);
        base.MergeFrom(other);
        return this;
      }

      public override StopBatchTaskResult.Builder MergeFrom(
        StopBatchTaskResult other)
      {
        if (other == StopBatchTaskResult.DefaultInstance)
          return this;
        this.PrepareBuilder();
        if (other.HasResult)
          this.Result = other.Result;
        if (other.HasInfo)
          this.Info = other.Info;
        if (other.HasSeqId)
          this.SeqId = other.SeqId;
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }

      public override StopBatchTaskResult.Builder MergeFrom(
        ICodedInputStream input)
      {
        return this.MergeFrom(input, ExtensionRegistry.Empty);
      }

      public override StopBatchTaskResult.Builder MergeFrom(
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
            int index = Array.BinarySearch<string>(StopBatchTaskResult._stopBatchTaskResultFieldNames, fieldName, (IComparer<string>) StringComparer.Ordinal);
            if (index >= 0)
            {
              fieldTag = StopBatchTaskResult._stopBatchTaskResultFieldTags[index];
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
              this.result.hasResult = input.ReadBool(ref this.result.result_);
              continue;
            case 18:
              this.result.hasInfo = input.ReadString(ref this.result.info_);
              continue;
            case 26:
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

      public bool HasResult
      {
        get
        {
          return this.result.hasResult;
        }
      }

      public bool Result
      {
        get
        {
          return this.result.Result;
        }
        set
        {
          this.SetResult(value);
        }
      }

      public StopBatchTaskResult.Builder SetResult(bool value)
      {
        this.PrepareBuilder();
        this.result.hasResult = true;
        this.result.result_ = value;
        return this;
      }

      public StopBatchTaskResult.Builder ClearResult()
      {
        this.PrepareBuilder();
        this.result.hasResult = false;
        this.result.result_ = false;
        return this;
      }

      public bool HasInfo
      {
        get
        {
          return this.result.hasInfo;
        }
      }

      public string Info
      {
        get
        {
          return this.result.Info;
        }
        set
        {
          this.SetInfo(value);
        }
      }

      public StopBatchTaskResult.Builder SetInfo(string value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.hasInfo = true;
        this.result.info_ = value;
        return this;
      }

      public StopBatchTaskResult.Builder ClearInfo()
      {
        this.PrepareBuilder();
        this.result.hasInfo = false;
        this.result.info_ = "";
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

      public StopBatchTaskResult.Builder SetSeqId(string value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.hasSeqId = true;
        this.result.seqId_ = value;
        return this;
      }

      public StopBatchTaskResult.Builder ClearSeqId()
      {
        this.PrepareBuilder();
        this.result.hasSeqId = false;
        this.result.seqId_ = "";
        return this;
      }
    }
  }
}
