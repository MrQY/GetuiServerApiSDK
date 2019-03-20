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
  public sealed class StartMMPBatchTask : GeneratedMessage<StartMMPBatchTask, StartMMPBatchTask.Builder>
  {
    private static readonly StartMMPBatchTask defaultInstance = new StartMMPBatchTask().MakeReadOnly();
    private static readonly string[] _startMMPBatchTaskFieldNames = new string[4]
    {
      "expire",
      "message",
      "seqId",
      "taskGroupName"
    };
    private static readonly uint[] _startMMPBatchTaskFieldTags = new uint[4]
    {
      16U,
      10U,
      26U,
      34U
    };
    private long expire_ = 72;
    private string seqId_ = "";
    private string taskGroupName_ = "";
    private int memoizedSerializedSize = -1;
    public const int MessageFieldNumber = 1;
    private bool hasMessage;
    private MMPMessage message_;
    public const int ExpireFieldNumber = 2;
    private bool hasExpire;
    public const int SeqIdFieldNumber = 3;
    private bool hasSeqId;
    public const int TaskGroupNameFieldNumber = 4;
    private bool hasTaskGroupName;

    private StartMMPBatchTask()
    {
    }

    public static StartMMPBatchTask DefaultInstance
    {
      get
      {
        return StartMMPBatchTask.defaultInstance;
      }
    }

    public override StartMMPBatchTask DefaultInstanceForType
    {
      get
      {
        return StartMMPBatchTask.DefaultInstance;
      }
    }

    protected override StartMMPBatchTask ThisMessage
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
        return GtReq.internal__static_com_gexin_rp_sdk_dto_StartMMPBatchTask__Descriptor;
      }
    }

    protected override FieldAccessorTable<StartMMPBatchTask, StartMMPBatchTask.Builder> InternalFieldAccessors
    {
      get
      {
        return GtReq.internal__static_com_gexin_rp_sdk_dto_StartMMPBatchTask__FieldAccessorTable;
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

    public bool HasExpire
    {
      get
      {
        return this.hasExpire;
      }
    }

    public long Expire
    {
      get
      {
        return this.expire_;
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

    public bool HasTaskGroupName
    {
      get
      {
        return this.hasTaskGroupName;
      }
    }

    public string TaskGroupName
    {
      get
      {
        return this.taskGroupName_;
      }
    }

    public override bool IsInitialized
    {
      get
      {
        return this.hasMessage && this.hasExpire && this.Message.IsInitialized;
      }
    }

    public override void WriteTo(ICodedOutputStream output)
    {
      int serializedSize = this.SerializedSize;
      string[] batchTaskFieldNames = StartMMPBatchTask._startMMPBatchTaskFieldNames;
      if (this.hasMessage)
        output.WriteMessage(1, batchTaskFieldNames[1], (IMessageLite) this.Message);
      if (this.hasExpire)
        output.WriteInt64(2, batchTaskFieldNames[0], this.Expire);
      if (this.hasSeqId)
        output.WriteString(3, batchTaskFieldNames[2], this.SeqId);
      if (this.hasTaskGroupName)
        output.WriteString(4, batchTaskFieldNames[3], this.TaskGroupName);
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
        if (this.hasExpire)
          num1 += CodedOutputStream.ComputeInt64Size(2, this.Expire);
        if (this.hasSeqId)
          num1 += CodedOutputStream.ComputeStringSize(3, this.SeqId);
        if (this.hasTaskGroupName)
          num1 += CodedOutputStream.ComputeStringSize(4, this.TaskGroupName);
        int num2 = num1 + this.UnknownFields.SerializedSize;
        this.memoizedSerializedSize = num2;
        return num2;
      }
    }

    public static StartMMPBatchTask ParseFrom(ByteString data)
    {
      return StartMMPBatchTask.CreateBuilder().MergeFrom(data).BuildParsed();
    }

    public static StartMMPBatchTask ParseFrom(
      ByteString data,
      ExtensionRegistry extensionRegistry)
    {
      return StartMMPBatchTask.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
    }

    public static StartMMPBatchTask ParseFrom(byte[] data)
    {
      return StartMMPBatchTask.CreateBuilder().MergeFrom(data).BuildParsed();
    }

    public static StartMMPBatchTask ParseFrom(
      byte[] data,
      ExtensionRegistry extensionRegistry)
    {
      return StartMMPBatchTask.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
    }

    public static StartMMPBatchTask ParseFrom(Stream input)
    {
      return StartMMPBatchTask.CreateBuilder().MergeFrom(input).BuildParsed();
    }

    public static StartMMPBatchTask ParseFrom(
      Stream input,
      ExtensionRegistry extensionRegistry)
    {
      return StartMMPBatchTask.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
    }

    public static StartMMPBatchTask ParseDelimitedFrom(Stream input)
    {
      return StartMMPBatchTask.CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }

    public static StartMMPBatchTask ParseDelimitedFrom(
      Stream input,
      ExtensionRegistry extensionRegistry)
    {
      return StartMMPBatchTask.CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }

    public static StartMMPBatchTask ParseFrom(ICodedInputStream input)
    {
      return StartMMPBatchTask.CreateBuilder().MergeFrom(input).BuildParsed();
    }

    public static StartMMPBatchTask ParseFrom(
      ICodedInputStream input,
      ExtensionRegistry extensionRegistry)
    {
      return StartMMPBatchTask.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
    }

    private StartMMPBatchTask MakeReadOnly()
    {
      return this;
    }

    public static StartMMPBatchTask.Builder CreateBuilder()
    {
      return new StartMMPBatchTask.Builder();
    }

    public override StartMMPBatchTask.Builder ToBuilder()
    {
      return StartMMPBatchTask.CreateBuilder(this);
    }

    public override StartMMPBatchTask.Builder CreateBuilderForType()
    {
      return new StartMMPBatchTask.Builder();
    }

    public static StartMMPBatchTask.Builder CreateBuilder(
      StartMMPBatchTask prototype)
    {
      return new StartMMPBatchTask.Builder(prototype);
    }

    static StartMMPBatchTask()
    {
      FileDescriptor descriptor = GtReq.Descriptor;
    }

    [DebuggerNonUserCode]
    public sealed class Builder : GeneratedBuilder<StartMMPBatchTask, StartMMPBatchTask.Builder>
    {
      private bool resultIsReadOnly;
      private StartMMPBatchTask result;

      protected override StartMMPBatchTask.Builder ThisBuilder
      {
        get
        {
          return this;
        }
      }

      public Builder()
      {
        this.result = StartMMPBatchTask.DefaultInstance;
        this.resultIsReadOnly = true;
      }

      internal Builder(StartMMPBatchTask cloneFrom)
      {
        this.result = cloneFrom;
        this.resultIsReadOnly = true;
      }

      private StartMMPBatchTask PrepareBuilder()
      {
        if (this.resultIsReadOnly)
        {
          StartMMPBatchTask result = this.result;
          this.result = new StartMMPBatchTask();
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

      protected override StartMMPBatchTask MessageBeingBuilt
      {
        get
        {
          return this.PrepareBuilder();
        }
      }

      public override StartMMPBatchTask.Builder Clear()
      {
        this.result = StartMMPBatchTask.DefaultInstance;
        this.resultIsReadOnly = true;
        return this;
      }

      public override StartMMPBatchTask.Builder Clone()
      {
        if (this.resultIsReadOnly)
          return new StartMMPBatchTask.Builder(this.result);
        return new StartMMPBatchTask.Builder().MergeFrom(this.result);
      }

      public override MessageDescriptor DescriptorForType
      {
        get
        {
          return StartMMPBatchTask.Descriptor;
        }
      }

      public override StartMMPBatchTask DefaultInstanceForType
      {
        get
        {
          return StartMMPBatchTask.DefaultInstance;
        }
      }

      public override StartMMPBatchTask BuildPartial()
      {
        if (this.resultIsReadOnly)
          return this.result;
        this.resultIsReadOnly = true;
        return this.result.MakeReadOnly();
      }

      public override StartMMPBatchTask.Builder MergeFrom(IMessage other)
      {
        if (other is StartMMPBatchTask)
          return this.MergeFrom((StartMMPBatchTask) other);
        base.MergeFrom(other);
        return this;
      }

      public override StartMMPBatchTask.Builder MergeFrom(StartMMPBatchTask other)
      {
        if (other == StartMMPBatchTask.DefaultInstance)
          return this;
        this.PrepareBuilder();
        if (other.HasMessage)
          this.MergeMessage(other.Message);
        if (other.HasExpire)
          this.Expire = other.Expire;
        if (other.HasSeqId)
          this.SeqId = other.SeqId;
        if (other.HasTaskGroupName)
          this.TaskGroupName = other.TaskGroupName;
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }

      public override StartMMPBatchTask.Builder MergeFrom(ICodedInputStream input)
      {
        return this.MergeFrom(input, ExtensionRegistry.Empty);
      }

      public override StartMMPBatchTask.Builder MergeFrom(
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
            int index = Array.BinarySearch<string>(StartMMPBatchTask._startMMPBatchTaskFieldNames, fieldName, (IComparer<string>) StringComparer.Ordinal);
            if (index >= 0)
            {
              fieldTag = StartMMPBatchTask._startMMPBatchTaskFieldTags[index];
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
            case 16:
              this.result.hasExpire = input.ReadInt64(ref this.result.expire_);
              continue;
            case 26:
              this.result.hasSeqId = input.ReadString(ref this.result.seqId_);
              continue;
            case 34:
              this.result.hasTaskGroupName = input.ReadString(ref this.result.taskGroupName_);
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

      public StartMMPBatchTask.Builder SetMessage(MMPMessage value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.hasMessage = true;
        this.result.message_ = value;
        return this;
      }

      public StartMMPBatchTask.Builder SetMessage(
        MMPMessage.Builder builderForValue)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) builderForValue, nameof (builderForValue));
        this.PrepareBuilder();
        this.result.hasMessage = true;
        this.result.message_ = builderForValue.Build();
        return this;
      }

      public StartMMPBatchTask.Builder MergeMessage(MMPMessage value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.message_ = !this.result.hasMessage || this.result.message_ == MMPMessage.DefaultInstance ? value : MMPMessage.CreateBuilder(this.result.message_).MergeFrom(value).BuildPartial();
        this.result.hasMessage = true;
        return this;
      }

      public StartMMPBatchTask.Builder ClearMessage()
      {
        this.PrepareBuilder();
        this.result.hasMessage = false;
        this.result.message_ = (MMPMessage) null;
        return this;
      }

      public bool HasExpire
      {
        get
        {
          return this.result.hasExpire;
        }
      }

      public long Expire
      {
        get
        {
          return this.result.Expire;
        }
        set
        {
          this.SetExpire(value);
        }
      }

      public StartMMPBatchTask.Builder SetExpire(long value)
      {
        this.PrepareBuilder();
        this.result.hasExpire = true;
        this.result.expire_ = value;
        return this;
      }

      public StartMMPBatchTask.Builder ClearExpire()
      {
        this.PrepareBuilder();
        this.result.hasExpire = false;
        this.result.expire_ = 72L;
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

      public StartMMPBatchTask.Builder SetSeqId(string value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.hasSeqId = true;
        this.result.seqId_ = value;
        return this;
      }

      public StartMMPBatchTask.Builder ClearSeqId()
      {
        this.PrepareBuilder();
        this.result.hasSeqId = false;
        this.result.seqId_ = "";
        return this;
      }

      public bool HasTaskGroupName
      {
        get
        {
          return this.result.hasTaskGroupName;
        }
      }

      public string TaskGroupName
      {
        get
        {
          return this.result.TaskGroupName;
        }
        set
        {
          this.SetTaskGroupName(value);
        }
      }

      public StartMMPBatchTask.Builder SetTaskGroupName(string value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.hasTaskGroupName = true;
        this.result.taskGroupName_ = value;
        return this;
      }

      public StartMMPBatchTask.Builder ClearTaskGroupName()
      {
        this.PrepareBuilder();
        this.result.hasTaskGroupName = false;
        this.result.taskGroupName_ = "";
        return this;
      }
    }
  }
}
