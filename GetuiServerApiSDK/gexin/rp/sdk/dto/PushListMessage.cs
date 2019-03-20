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
  public sealed class PushListMessage : GeneratedMessage<PushListMessage, PushListMessage.Builder>
  {
    private static readonly PushListMessage defaultInstance = new PushListMessage().MakeReadOnly();
    private static readonly string[] _pushListMessageFieldNames = new string[3]
    {
      "seqId",
      "targets",
      "taskId"
    };
    private static readonly uint[] _pushListMessageFieldTags = new uint[3]
    {
      10U,
      26U,
      18U
    };
    private string seqId_ = "";
    private string taskId_ = "";
    private PopsicleList<Target> targets_ = new PopsicleList<Target>();
    private int memoizedSerializedSize = -1;
    public const int SeqIdFieldNumber = 1;
    private bool hasSeqId;
    public const int TaskIdFieldNumber = 2;
    private bool hasTaskId;
    public const int TargetsFieldNumber = 3;

    private PushListMessage()
    {
    }

    public static PushListMessage DefaultInstance
    {
      get
      {
        return PushListMessage.defaultInstance;
      }
    }

    public override PushListMessage DefaultInstanceForType
    {
      get
      {
        return PushListMessage.DefaultInstance;
      }
    }

    protected override PushListMessage ThisMessage
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
        return GtReq.internal__static_com_gexin_rp_sdk_dto_PushListMessage__Descriptor;
      }
    }

    protected override FieldAccessorTable<PushListMessage, PushListMessage.Builder> InternalFieldAccessors
    {
      get
      {
        return GtReq.internal__static_com_gexin_rp_sdk_dto_PushListMessage__FieldAccessorTable;
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

    public IList<Target> TargetsList
    {
      get
      {
        return (IList<Target>) this.targets_;
      }
    }

    public int TargetsCount
    {
      get
      {
        return this.targets_.Count;
      }
    }

    public Target GetTargets(int index)
    {
      return this.targets_[index];
    }

    public override bool IsInitialized
    {
      get
      {
        if (!this.hasSeqId || !this.hasTaskId)
          return false;
        foreach (AbstractMessageLite<Target, Target.Builder> targets in (IEnumerable<Target>) this.TargetsList)
        {
          if (!targets.IsInitialized)
            return false;
        }
        return true;
      }
    }

    public override void WriteTo(ICodedOutputStream output)
    {
      int serializedSize = this.SerializedSize;
      string[] messageFieldNames = PushListMessage._pushListMessageFieldNames;
      if (this.hasSeqId)
        output.WriteString(1, messageFieldNames[0], this.SeqId);
      if (this.hasTaskId)
        output.WriteString(2, messageFieldNames[2], this.TaskId);
      if (this.targets_.Count > 0)
        output.WriteMessageArray<Target>(3, messageFieldNames[1], (IEnumerable<Target>) this.targets_);
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
        if (this.hasTaskId)
          num1 += CodedOutputStream.ComputeStringSize(2, this.TaskId);
        foreach (Target targets in (IEnumerable<Target>) this.TargetsList)
          num1 += CodedOutputStream.ComputeMessageSize(3, (IMessageLite) targets);
        int num2 = num1 + this.UnknownFields.SerializedSize;
        this.memoizedSerializedSize = num2;
        return num2;
      }
    }

    public static PushListMessage ParseFrom(ByteString data)
    {
      return PushListMessage.CreateBuilder().MergeFrom(data).BuildParsed();
    }

    public static PushListMessage ParseFrom(
      ByteString data,
      ExtensionRegistry extensionRegistry)
    {
      return PushListMessage.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
    }

    public static PushListMessage ParseFrom(byte[] data)
    {
      return PushListMessage.CreateBuilder().MergeFrom(data).BuildParsed();
    }

    public static PushListMessage ParseFrom(
      byte[] data,
      ExtensionRegistry extensionRegistry)
    {
      return PushListMessage.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
    }

    public static PushListMessage ParseFrom(Stream input)
    {
      return PushListMessage.CreateBuilder().MergeFrom(input).BuildParsed();
    }

    public static PushListMessage ParseFrom(
      Stream input,
      ExtensionRegistry extensionRegistry)
    {
      return PushListMessage.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
    }

    public static PushListMessage ParseDelimitedFrom(Stream input)
    {
      return PushListMessage.CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }

    public static PushListMessage ParseDelimitedFrom(
      Stream input,
      ExtensionRegistry extensionRegistry)
    {
      return PushListMessage.CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }

    public static PushListMessage ParseFrom(ICodedInputStream input)
    {
      return PushListMessage.CreateBuilder().MergeFrom(input).BuildParsed();
    }

    public static PushListMessage ParseFrom(
      ICodedInputStream input,
      ExtensionRegistry extensionRegistry)
    {
      return PushListMessage.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
    }

    private PushListMessage MakeReadOnly()
    {
      this.targets_.MakeReadOnly();
      return this;
    }

    public static PushListMessage.Builder CreateBuilder()
    {
      return new PushListMessage.Builder();
    }

    public override PushListMessage.Builder ToBuilder()
    {
      return PushListMessage.CreateBuilder(this);
    }

    public override PushListMessage.Builder CreateBuilderForType()
    {
      return new PushListMessage.Builder();
    }

    public static PushListMessage.Builder CreateBuilder(PushListMessage prototype)
    {
      return new PushListMessage.Builder(prototype);
    }

    static PushListMessage()
    {
      FileDescriptor descriptor = GtReq.Descriptor;
    }

    [DebuggerNonUserCode]
    public sealed class Builder : GeneratedBuilder<PushListMessage, PushListMessage.Builder>
    {
      private bool resultIsReadOnly;
      private PushListMessage result;

      protected override PushListMessage.Builder ThisBuilder
      {
        get
        {
          return this;
        }
      }

      public Builder()
      {
        this.result = PushListMessage.DefaultInstance;
        this.resultIsReadOnly = true;
      }

      internal Builder(PushListMessage cloneFrom)
      {
        this.result = cloneFrom;
        this.resultIsReadOnly = true;
      }

      private PushListMessage PrepareBuilder()
      {
        if (this.resultIsReadOnly)
        {
          PushListMessage result = this.result;
          this.result = new PushListMessage();
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

      protected override PushListMessage MessageBeingBuilt
      {
        get
        {
          return this.PrepareBuilder();
        }
      }

      public override PushListMessage.Builder Clear()
      {
        this.result = PushListMessage.DefaultInstance;
        this.resultIsReadOnly = true;
        return this;
      }

      public override PushListMessage.Builder Clone()
      {
        if (this.resultIsReadOnly)
          return new PushListMessage.Builder(this.result);
        return new PushListMessage.Builder().MergeFrom(this.result);
      }

      public override MessageDescriptor DescriptorForType
      {
        get
        {
          return PushListMessage.Descriptor;
        }
      }

      public override PushListMessage DefaultInstanceForType
      {
        get
        {
          return PushListMessage.DefaultInstance;
        }
      }

      public override PushListMessage BuildPartial()
      {
        if (this.resultIsReadOnly)
          return this.result;
        this.resultIsReadOnly = true;
        return this.result.MakeReadOnly();
      }

      public override PushListMessage.Builder MergeFrom(IMessage other)
      {
        if (other is PushListMessage)
          return this.MergeFrom((PushListMessage) other);
        base.MergeFrom(other);
        return this;
      }

      public override PushListMessage.Builder MergeFrom(PushListMessage other)
      {
        if (other == PushListMessage.DefaultInstance)
          return this;
        this.PrepareBuilder();
        if (other.HasSeqId)
          this.SeqId = other.SeqId;
        if (other.HasTaskId)
          this.TaskId = other.TaskId;
        if (other.targets_.Count != 0)
          this.result.targets_.Add((IEnumerable<Target>) other.targets_);
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }

      public override PushListMessage.Builder MergeFrom(ICodedInputStream input)
      {
        return this.MergeFrom(input, ExtensionRegistry.Empty);
      }

      public override PushListMessage.Builder MergeFrom(
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
            int index = Array.BinarySearch<string>(PushListMessage._pushListMessageFieldNames, fieldName, (IComparer<string>) StringComparer.Ordinal);
            if (index >= 0)
            {
              fieldTag = PushListMessage._pushListMessageFieldTags[index];
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
            case 18:
              this.result.hasTaskId = input.ReadString(ref this.result.taskId_);
              continue;
            case 26:
              input.ReadMessageArray<Target>(fieldTag, fieldName, (ICollection<Target>) this.result.targets_, Target.DefaultInstance, extensionRegistry);
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

      public PushListMessage.Builder SetSeqId(string value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.hasSeqId = true;
        this.result.seqId_ = value;
        return this;
      }

      public PushListMessage.Builder ClearSeqId()
      {
        this.PrepareBuilder();
        this.result.hasSeqId = false;
        this.result.seqId_ = "";
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

      public PushListMessage.Builder SetTaskId(string value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.hasTaskId = true;
        this.result.taskId_ = value;
        return this;
      }

      public PushListMessage.Builder ClearTaskId()
      {
        this.PrepareBuilder();
        this.result.hasTaskId = false;
        this.result.taskId_ = "";
        return this;
      }

      public IPopsicleList<Target> TargetsList
      {
        get
        {
          return (IPopsicleList<Target>) this.PrepareBuilder().targets_;
        }
      }

      public int TargetsCount
      {
        get
        {
          return this.result.TargetsCount;
        }
      }

      public Target GetTargets(int index)
      {
        return this.result.GetTargets(index);
      }

      public PushListMessage.Builder SetTargets(int index, Target value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.targets_[index] = value;
        return this;
      }

      public PushListMessage.Builder SetTargets(
        int index,
        Target.Builder builderForValue)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) builderForValue, nameof (builderForValue));
        this.PrepareBuilder();
        this.result.targets_[index] = builderForValue.Build();
        return this;
      }

      public PushListMessage.Builder AddTargets(Target value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.targets_.Add(value);
        return this;
      }

      public PushListMessage.Builder AddTargets(Target.Builder builderForValue)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) builderForValue, nameof (builderForValue));
        this.PrepareBuilder();
        this.result.targets_.Add(builderForValue.Build());
        return this;
      }

      public PushListMessage.Builder AddRangeTargets(IEnumerable<Target> values)
      {
        this.PrepareBuilder();
        this.result.targets_.Add(values);
        return this;
      }

      public PushListMessage.Builder ClearTargets()
      {
        this.PrepareBuilder();
        this.result.targets_.Clear();
        return this;
      }
    }
  }
}
