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
  public sealed class PushResult : GeneratedMessage<PushResult, PushResult.Builder>
  {
    private static readonly PushResult defaultInstance = new PushResult().MakeReadOnly();
    private static readonly string[] _pushResultFieldNames = new string[8]
    {
      "batchId",
      "info",
      "messageId",
      "result",
      "seqId",
      "target",
      "taskId",
      "traceId"
    };
    private static readonly uint[] _pushResultFieldTags = new uint[8]
    {
      66U,
      50U,
      26U,
      8U,
      34U,
      42U,
      18U,
      58U
    };
    private string taskId_ = "";
    private string messageId_ = "";
    private string seqId_ = "";
    private string target_ = "";
    private string info_ = "";
    private string traceId_ = "";
    private string batchId_ = "";
    private int memoizedSerializedSize = -1;
    public const int ResultFieldNumber = 1;
    private bool hasResult;
    private PushResult.Types.EPushResult result_;
    public const int TaskIdFieldNumber = 2;
    private bool hasTaskId;
    public const int MessageIdFieldNumber = 3;
    private bool hasMessageId;
    public const int SeqIdFieldNumber = 4;
    private bool hasSeqId;
    public const int TargetFieldNumber = 5;
    private bool hasTarget;
    public const int InfoFieldNumber = 6;
    private bool hasInfo;
    public const int TraceIdFieldNumber = 7;
    private bool hasTraceId;
    public const int BatchIdFieldNumber = 8;
    private bool hasBatchId;

    private PushResult()
    {
    }

    public static PushResult DefaultInstance
    {
      get
      {
        return PushResult.defaultInstance;
      }
    }

    public override PushResult DefaultInstanceForType
    {
      get
      {
        return PushResult.DefaultInstance;
      }
    }

    protected override PushResult ThisMessage
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
        return GtReq.internal__static_com_gexin_rp_sdk_dto_PushResult__Descriptor;
      }
    }

    protected override FieldAccessorTable<PushResult, PushResult.Builder> InternalFieldAccessors
    {
      get
      {
        return GtReq.internal__static_com_gexin_rp_sdk_dto_PushResult__FieldAccessorTable;
      }
    }

    public bool HasResult
    {
      get
      {
        return this.hasResult;
      }
    }

    public PushResult.Types.EPushResult Result
    {
      get
      {
        return this.result_;
      }
    }

    public bool HasTaskId
    {
      get
      {
        return this.hasTaskId;
      }
    }

    public string TaskId
    {
      get
      {
        return this.taskId_;
      }
    }

    public bool HasMessageId
    {
      get
      {
        return this.hasMessageId;
      }
    }

    public string MessageId
    {
      get
      {
        return this.messageId_;
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

    public bool HasTarget
    {
      get
      {
        return this.hasTarget;
      }
    }

    public string Target
    {
      get
      {
        return this.target_;
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

    public bool HasTraceId
    {
      get
      {
        return this.hasTraceId;
      }
    }

    public string TraceId
    {
      get
      {
        return this.traceId_;
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

    public override bool IsInitialized
    {
      get
      {
        return this.hasResult && this.hasTaskId && (this.hasMessageId && this.hasSeqId) && this.hasTarget;
      }
    }

    public override void WriteTo(ICodedOutputStream output)
    {
      int serializedSize = this.SerializedSize;
      string[] resultFieldNames = PushResult._pushResultFieldNames;
      if (this.hasResult)
        output.WriteEnum(1, resultFieldNames[3], (int) this.Result, (object) this.Result);
      if (this.hasTaskId)
        output.WriteString(2, resultFieldNames[6], this.TaskId);
      if (this.hasMessageId)
        output.WriteString(3, resultFieldNames[2], this.MessageId);
      if (this.hasSeqId)
        output.WriteString(4, resultFieldNames[4], this.SeqId);
      if (this.hasTarget)
        output.WriteString(5, resultFieldNames[5], this.Target);
      if (this.hasInfo)
        output.WriteString(6, resultFieldNames[1], this.Info);
      if (this.hasTraceId)
        output.WriteString(7, resultFieldNames[7], this.TraceId);
      if (this.hasBatchId)
        output.WriteString(8, resultFieldNames[0], this.BatchId);
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
          num1 += CodedOutputStream.ComputeEnumSize(1, (int) this.Result);
        if (this.hasTaskId)
          num1 += CodedOutputStream.ComputeStringSize(2, this.TaskId);
        if (this.hasMessageId)
          num1 += CodedOutputStream.ComputeStringSize(3, this.MessageId);
        if (this.hasSeqId)
          num1 += CodedOutputStream.ComputeStringSize(4, this.SeqId);
        if (this.hasTarget)
          num1 += CodedOutputStream.ComputeStringSize(5, this.Target);
        if (this.hasInfo)
          num1 += CodedOutputStream.ComputeStringSize(6, this.Info);
        if (this.hasTraceId)
          num1 += CodedOutputStream.ComputeStringSize(7, this.TraceId);
        if (this.hasBatchId)
          num1 += CodedOutputStream.ComputeStringSize(8, this.BatchId);
        int num2 = num1 + this.UnknownFields.SerializedSize;
        this.memoizedSerializedSize = num2;
        return num2;
      }
    }

    public static PushResult ParseFrom(ByteString data)
    {
      return PushResult.CreateBuilder().MergeFrom(data).BuildParsed();
    }

    public static PushResult ParseFrom(
      ByteString data,
      ExtensionRegistry extensionRegistry)
    {
      return PushResult.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
    }

    public static PushResult ParseFrom(byte[] data)
    {
      return PushResult.CreateBuilder().MergeFrom(data).BuildParsed();
    }

    public static PushResult ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
    {
      return PushResult.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
    }

    public static PushResult ParseFrom(Stream input)
    {
      return PushResult.CreateBuilder().MergeFrom(input).BuildParsed();
    }

    public static PushResult ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
    {
      return PushResult.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
    }

    public static PushResult ParseDelimitedFrom(Stream input)
    {
      return PushResult.CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }

    public static PushResult ParseDelimitedFrom(
      Stream input,
      ExtensionRegistry extensionRegistry)
    {
      return PushResult.CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }

    public static PushResult ParseFrom(ICodedInputStream input)
    {
      return PushResult.CreateBuilder().MergeFrom(input).BuildParsed();
    }

    public static PushResult ParseFrom(
      ICodedInputStream input,
      ExtensionRegistry extensionRegistry)
    {
      return PushResult.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
    }

    private PushResult MakeReadOnly()
    {
      return this;
    }

    public static PushResult.Builder CreateBuilder()
    {
      return new PushResult.Builder();
    }

    public override PushResult.Builder ToBuilder()
    {
      return PushResult.CreateBuilder(this);
    }

    public override PushResult.Builder CreateBuilderForType()
    {
      return new PushResult.Builder();
    }

    public static PushResult.Builder CreateBuilder(PushResult prototype)
    {
      return new PushResult.Builder(prototype);
    }

    static PushResult()
    {
      FileDescriptor descriptor = GtReq.Descriptor;
    }

    [DebuggerNonUserCode]
    public static class Types
    {
      public enum EPushResult
      {
        successed_online,
        successed_offline,
        successed_ignore,
        failed,
        busy,
        success_startBatch,
        success_endBatch,
        successed_async,
      }
    }

    [DebuggerNonUserCode]
    public sealed class Builder : GeneratedBuilder<PushResult, PushResult.Builder>
    {
      private bool resultIsReadOnly;
      private PushResult result;

      protected override PushResult.Builder ThisBuilder
      {
        get
        {
          return this;
        }
      }

      public Builder()
      {
        this.result = PushResult.DefaultInstance;
        this.resultIsReadOnly = true;
      }

      internal Builder(PushResult cloneFrom)
      {
        this.result = cloneFrom;
        this.resultIsReadOnly = true;
      }

      private PushResult PrepareBuilder()
      {
        if (this.resultIsReadOnly)
        {
          PushResult result = this.result;
          this.result = new PushResult();
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

      protected override PushResult MessageBeingBuilt
      {
        get
        {
          return this.PrepareBuilder();
        }
      }

      public override PushResult.Builder Clear()
      {
        this.result = PushResult.DefaultInstance;
        this.resultIsReadOnly = true;
        return this;
      }

      public override PushResult.Builder Clone()
      {
        if (this.resultIsReadOnly)
          return new PushResult.Builder(this.result);
        return new PushResult.Builder().MergeFrom(this.result);
      }

      public override MessageDescriptor DescriptorForType
      {
        get
        {
          return PushResult.Descriptor;
        }
      }

      public override PushResult DefaultInstanceForType
      {
        get
        {
          return PushResult.DefaultInstance;
        }
      }

      public override PushResult BuildPartial()
      {
        if (this.resultIsReadOnly)
          return this.result;
        this.resultIsReadOnly = true;
        return this.result.MakeReadOnly();
      }

      public override PushResult.Builder MergeFrom(IMessage other)
      {
        if (other is PushResult)
          return this.MergeFrom((PushResult) other);
        base.MergeFrom(other);
        return this;
      }

      public override PushResult.Builder MergeFrom(PushResult other)
      {
        if (other == PushResult.DefaultInstance)
          return this;
        this.PrepareBuilder();
        if (other.HasResult)
          this.Result = other.Result;
        if (other.HasTaskId)
          this.TaskId = other.TaskId;
        if (other.HasMessageId)
          this.MessageId = other.MessageId;
        if (other.HasSeqId)
          this.SeqId = other.SeqId;
        if (other.HasTarget)
          this.Target = other.Target;
        if (other.HasInfo)
          this.Info = other.Info;
        if (other.HasTraceId)
          this.TraceId = other.TraceId;
        if (other.HasBatchId)
          this.BatchId = other.BatchId;
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }

      public override PushResult.Builder MergeFrom(ICodedInputStream input)
      {
        return this.MergeFrom(input, ExtensionRegistry.Empty);
      }

      public override PushResult.Builder MergeFrom(
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
            int index = Array.BinarySearch<string>(PushResult._pushResultFieldNames, fieldName, (IComparer<string>) StringComparer.Ordinal);
            if (index >= 0)
            {
              fieldTag = PushResult._pushResultFieldTags[index];
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
              object unknown;
              if (input.ReadEnum<PushResult.Types.EPushResult>(ref this.result.result_, out unknown))
              {
                this.result.hasResult = true;
                continue;
              }
              if (unknown is int)
              {
                if (unknownFields == null)
                  unknownFields = UnknownFieldSet.CreateBuilder(this.UnknownFields);
                unknownFields.MergeVarintField(1, (ulong) (int) unknown);
                continue;
              }
              continue;
            case 18:
              this.result.hasTaskId = input.ReadString(ref this.result.taskId_);
              continue;
            case 26:
              this.result.hasMessageId = input.ReadString(ref this.result.messageId_);
              continue;
            case 34:
              this.result.hasSeqId = input.ReadString(ref this.result.seqId_);
              continue;
            case 42:
              this.result.hasTarget = input.ReadString(ref this.result.target_);
              continue;
            case 50:
              this.result.hasInfo = input.ReadString(ref this.result.info_);
              continue;
            case 58:
              this.result.hasTraceId = input.ReadString(ref this.result.traceId_);
              continue;
            case 66:
              this.result.hasBatchId = input.ReadString(ref this.result.batchId_);
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

      public PushResult.Types.EPushResult Result
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

      public PushResult.Builder SetResult(PushResult.Types.EPushResult value)
      {
        this.PrepareBuilder();
        this.result.hasResult = true;
        this.result.result_ = value;
        return this;
      }

      public PushResult.Builder ClearResult()
      {
        this.PrepareBuilder();
        this.result.hasResult = false;
        this.result.result_ = PushResult.Types.EPushResult.successed_online;
        return this;
      }

      public bool HasTaskId
      {
        get
        {
          return this.result.hasTaskId;
        }
      }

      public string TaskId
      {
        get
        {
          return this.result.TaskId;
        }
        set
        {
          this.SetTaskId(value);
        }
      }

      public PushResult.Builder SetTaskId(string value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.hasTaskId = true;
        this.result.taskId_ = value;
        return this;
      }

      public PushResult.Builder ClearTaskId()
      {
        this.PrepareBuilder();
        this.result.hasTaskId = false;
        this.result.taskId_ = "";
        return this;
      }

      public bool HasMessageId
      {
        get
        {
          return this.result.hasMessageId;
        }
      }

      public string MessageId
      {
        get
        {
          return this.result.MessageId;
        }
        set
        {
          this.SetMessageId(value);
        }
      }

      public PushResult.Builder SetMessageId(string value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.hasMessageId = true;
        this.result.messageId_ = value;
        return this;
      }

      public PushResult.Builder ClearMessageId()
      {
        this.PrepareBuilder();
        this.result.hasMessageId = false;
        this.result.messageId_ = "";
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

      public PushResult.Builder SetSeqId(string value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.hasSeqId = true;
        this.result.seqId_ = value;
        return this;
      }

      public PushResult.Builder ClearSeqId()
      {
        this.PrepareBuilder();
        this.result.hasSeqId = false;
        this.result.seqId_ = "";
        return this;
      }

      public bool HasTarget
      {
        get
        {
          return this.result.hasTarget;
        }
      }

      public string Target
      {
        get
        {
          return this.result.Target;
        }
        set
        {
          this.SetTarget(value);
        }
      }

      public PushResult.Builder SetTarget(string value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.hasTarget = true;
        this.result.target_ = value;
        return this;
      }

      public PushResult.Builder ClearTarget()
      {
        this.PrepareBuilder();
        this.result.hasTarget = false;
        this.result.target_ = "";
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

      public PushResult.Builder SetInfo(string value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.hasInfo = true;
        this.result.info_ = value;
        return this;
      }

      public PushResult.Builder ClearInfo()
      {
        this.PrepareBuilder();
        this.result.hasInfo = false;
        this.result.info_ = "";
        return this;
      }

      public bool HasTraceId
      {
        get
        {
          return this.result.hasTraceId;
        }
      }

      public string TraceId
      {
        get
        {
          return this.result.TraceId;
        }
        set
        {
          this.SetTraceId(value);
        }
      }

      public PushResult.Builder SetTraceId(string value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.hasTraceId = true;
        this.result.traceId_ = value;
        return this;
      }

      public PushResult.Builder ClearTraceId()
      {
        this.PrepareBuilder();
        this.result.hasTraceId = false;
        this.result.traceId_ = "";
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

      public PushResult.Builder SetBatchId(string value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.hasBatchId = true;
        this.result.batchId_ = value;
        return this;
      }

      public PushResult.Builder ClearBatchId()
      {
        this.PrepareBuilder();
        this.result.hasBatchId = false;
        this.result.batchId_ = "";
        return this;
      }
    }
  }
}
