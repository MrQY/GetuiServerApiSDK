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
  public sealed class StopBatchTask : GeneratedMessage<StopBatchTask, StopBatchTask.Builder>
  {
    private static readonly StopBatchTask defaultInstance = new StopBatchTask().MakeReadOnly();
    private static readonly string[] _stopBatchTaskFieldNames = new string[4]
    {
      "appId",
      "appkey",
      "seqId",
      "taskId"
    };
    private static readonly uint[] _stopBatchTaskFieldTags = new uint[4]
    {
      26U,
      18U,
      34U,
      10U
    };
    private string taskId_ = "";
    private string appkey_ = "";
    private string appId_ = "";
    private string seqId_ = "";
    private int memoizedSerializedSize = -1;
    public const int TaskIdFieldNumber = 1;
    private bool hasTaskId;
    public const int AppkeyFieldNumber = 2;
    private bool hasAppkey;
    public const int AppIdFieldNumber = 3;
    private bool hasAppId;
    public const int SeqIdFieldNumber = 4;
    private bool hasSeqId;

    private StopBatchTask()
    {
    }

    public static StopBatchTask DefaultInstance
    {
      get
      {
        return StopBatchTask.defaultInstance;
      }
    }

    public override StopBatchTask DefaultInstanceForType
    {
      get
      {
        return StopBatchTask.DefaultInstance;
      }
    }

    protected override StopBatchTask ThisMessage
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
        return GtReq.internal__static_com_gexin_rp_sdk_dto_StopBatchTask__Descriptor;
      }
    }

    protected override FieldAccessorTable<StopBatchTask, StopBatchTask.Builder> InternalFieldAccessors
    {
      get
      {
        return GtReq.internal__static_com_gexin_rp_sdk_dto_StopBatchTask__FieldAccessorTable;
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

    public bool HasAppkey
    {
      get
      {
        return this.hasAppkey;
      }
    }

    public string Appkey
    {
      get
      {
        return this.appkey_;
      }
    }

    public bool HasAppId
    {
      get
      {
        return this.hasAppId;
      }
    }

    public string AppId
    {
      get
      {
        return this.appId_;
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
        return this.hasTaskId && this.hasAppkey;
      }
    }

    public override void WriteTo(ICodedOutputStream output)
    {
      int serializedSize = this.SerializedSize;
      string[] batchTaskFieldNames = StopBatchTask._stopBatchTaskFieldNames;
      if (this.hasTaskId)
        output.WriteString(1, batchTaskFieldNames[3], this.TaskId);
      if (this.hasAppkey)
        output.WriteString(2, batchTaskFieldNames[1], this.Appkey);
      if (this.hasAppId)
        output.WriteString(3, batchTaskFieldNames[0], this.AppId);
      if (this.hasSeqId)
        output.WriteString(4, batchTaskFieldNames[2], this.SeqId);
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
        if (this.hasTaskId)
          num1 += CodedOutputStream.ComputeStringSize(1, this.TaskId);
        if (this.hasAppkey)
          num1 += CodedOutputStream.ComputeStringSize(2, this.Appkey);
        if (this.hasAppId)
          num1 += CodedOutputStream.ComputeStringSize(3, this.AppId);
        if (this.hasSeqId)
          num1 += CodedOutputStream.ComputeStringSize(4, this.SeqId);
        int num2 = num1 + this.UnknownFields.SerializedSize;
        this.memoizedSerializedSize = num2;
        return num2;
      }
    }

    public static StopBatchTask ParseFrom(ByteString data)
    {
      return StopBatchTask.CreateBuilder().MergeFrom(data).BuildParsed();
    }

    public static StopBatchTask ParseFrom(
      ByteString data,
      ExtensionRegistry extensionRegistry)
    {
      return StopBatchTask.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
    }

    public static StopBatchTask ParseFrom(byte[] data)
    {
      return StopBatchTask.CreateBuilder().MergeFrom(data).BuildParsed();
    }

    public static StopBatchTask ParseFrom(
      byte[] data,
      ExtensionRegistry extensionRegistry)
    {
      return StopBatchTask.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
    }

    public static StopBatchTask ParseFrom(Stream input)
    {
      return StopBatchTask.CreateBuilder().MergeFrom(input).BuildParsed();
    }

    public static StopBatchTask ParseFrom(
      Stream input,
      ExtensionRegistry extensionRegistry)
    {
      return StopBatchTask.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
    }

    public static StopBatchTask ParseDelimitedFrom(Stream input)
    {
      return StopBatchTask.CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }

    public static StopBatchTask ParseDelimitedFrom(
      Stream input,
      ExtensionRegistry extensionRegistry)
    {
      return StopBatchTask.CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }

    public static StopBatchTask ParseFrom(ICodedInputStream input)
    {
      return StopBatchTask.CreateBuilder().MergeFrom(input).BuildParsed();
    }

    public static StopBatchTask ParseFrom(
      ICodedInputStream input,
      ExtensionRegistry extensionRegistry)
    {
      return StopBatchTask.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
    }

    private StopBatchTask MakeReadOnly()
    {
      return this;
    }

    public static StopBatchTask.Builder CreateBuilder()
    {
      return new StopBatchTask.Builder();
    }

    public override StopBatchTask.Builder ToBuilder()
    {
      return StopBatchTask.CreateBuilder(this);
    }

    public override StopBatchTask.Builder CreateBuilderForType()
    {
      return new StopBatchTask.Builder();
    }

    public static StopBatchTask.Builder CreateBuilder(StopBatchTask prototype)
    {
      return new StopBatchTask.Builder(prototype);
    }

    static StopBatchTask()
    {
      FileDescriptor descriptor = GtReq.Descriptor;
    }

    [DebuggerNonUserCode]
    public sealed class Builder : GeneratedBuilder<StopBatchTask, StopBatchTask.Builder>
    {
      private bool resultIsReadOnly;
      private StopBatchTask result;

      protected override StopBatchTask.Builder ThisBuilder
      {
        get
        {
          return this;
        }
      }

      public Builder()
      {
        this.result = StopBatchTask.DefaultInstance;
        this.resultIsReadOnly = true;
      }

      internal Builder(StopBatchTask cloneFrom)
      {
        this.result = cloneFrom;
        this.resultIsReadOnly = true;
      }

      private StopBatchTask PrepareBuilder()
      {
        if (this.resultIsReadOnly)
        {
          StopBatchTask result = this.result;
          this.result = new StopBatchTask();
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

      protected override StopBatchTask MessageBeingBuilt
      {
        get
        {
          return this.PrepareBuilder();
        }
      }

      public override StopBatchTask.Builder Clear()
      {
        this.result = StopBatchTask.DefaultInstance;
        this.resultIsReadOnly = true;
        return this;
      }

      public override StopBatchTask.Builder Clone()
      {
        if (this.resultIsReadOnly)
          return new StopBatchTask.Builder(this.result);
        return new StopBatchTask.Builder().MergeFrom(this.result);
      }

      public override MessageDescriptor DescriptorForType
      {
        get
        {
          return StopBatchTask.Descriptor;
        }
      }

      public override StopBatchTask DefaultInstanceForType
      {
        get
        {
          return StopBatchTask.DefaultInstance;
        }
      }

      public override StopBatchTask BuildPartial()
      {
        if (this.resultIsReadOnly)
          return this.result;
        this.resultIsReadOnly = true;
        return this.result.MakeReadOnly();
      }

      public override StopBatchTask.Builder MergeFrom(IMessage other)
      {
        if (other is StopBatchTask)
          return this.MergeFrom((StopBatchTask) other);
        base.MergeFrom(other);
        return this;
      }

      public override StopBatchTask.Builder MergeFrom(StopBatchTask other)
      {
        if (other == StopBatchTask.DefaultInstance)
          return this;
        this.PrepareBuilder();
        if (other.HasTaskId)
          this.TaskId = other.TaskId;
        if (other.HasAppkey)
          this.Appkey = other.Appkey;
        if (other.HasAppId)
          this.AppId = other.AppId;
        if (other.HasSeqId)
          this.SeqId = other.SeqId;
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }

      public override StopBatchTask.Builder MergeFrom(ICodedInputStream input)
      {
        return this.MergeFrom(input, ExtensionRegistry.Empty);
      }

      public override StopBatchTask.Builder MergeFrom(
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
            int index = Array.BinarySearch<string>(StopBatchTask._stopBatchTaskFieldNames, fieldName, (IComparer<string>) StringComparer.Ordinal);
            if (index >= 0)
            {
              fieldTag = StopBatchTask._stopBatchTaskFieldTags[index];
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
              this.result.hasTaskId = input.ReadString(ref this.result.taskId_);
              continue;
            case 18:
              this.result.hasAppkey = input.ReadString(ref this.result.appkey_);
              continue;
            case 26:
              this.result.hasAppId = input.ReadString(ref this.result.appId_);
              continue;
            case 34:
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

      public StopBatchTask.Builder SetTaskId(string value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.hasTaskId = true;
        this.result.taskId_ = value;
        return this;
      }

      public StopBatchTask.Builder ClearTaskId()
      {
        this.PrepareBuilder();
        this.result.hasTaskId = false;
        this.result.taskId_ = "";
        return this;
      }

      public bool HasAppkey
      {
        get
        {
          return this.result.hasAppkey;
        }
      }

      public string Appkey
      {
        get
        {
          return this.result.Appkey;
        }
        set
        {
          this.SetAppkey(value);
        }
      }

      public StopBatchTask.Builder SetAppkey(string value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.hasAppkey = true;
        this.result.appkey_ = value;
        return this;
      }

      public StopBatchTask.Builder ClearAppkey()
      {
        this.PrepareBuilder();
        this.result.hasAppkey = false;
        this.result.appkey_ = "";
        return this;
      }

      public bool HasAppId
      {
        get
        {
          return this.result.hasAppId;
        }
      }

      public string AppId
      {
        get
        {
          return this.result.AppId;
        }
        set
        {
          this.SetAppId(value);
        }
      }

      public StopBatchTask.Builder SetAppId(string value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.hasAppId = true;
        this.result.appId_ = value;
        return this;
      }

      public StopBatchTask.Builder ClearAppId()
      {
        this.PrepareBuilder();
        this.result.hasAppId = false;
        this.result.appId_ = "";
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

      public StopBatchTask.Builder SetSeqId(string value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.hasSeqId = true;
        this.result.seqId_ = value;
        return this;
      }

      public StopBatchTask.Builder ClearSeqId()
      {
        this.PrepareBuilder();
        this.result.hasSeqId = false;
        this.result.seqId_ = "";
        return this;
      }
    }
  }
}
