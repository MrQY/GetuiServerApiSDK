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
  public sealed class PushMMPSingleMessage : GeneratedMessage<PushMMPSingleMessage, PushMMPSingleMessage.Builder>
  {
    private static readonly PushMMPSingleMessage defaultInstance = new PushMMPSingleMessage().MakeReadOnly();
    private static readonly string[] _pushMMPSingleMessageFieldNames = new string[4]
    {
      "message",
      "requestId",
      "seqId",
      "target"
    };
    private static readonly uint[] _pushMMPSingleMessageFieldTags = new uint[4]
    {
      18U,
      34U,
      10U,
      26U
    };
    private string seqId_ = "";
    private string requestId_ = "";
    private int memoizedSerializedSize = -1;
    public const int SeqIdFieldNumber = 1;
    private bool hasSeqId;
    public const int MessageFieldNumber = 2;
    private bool hasMessage;
    private MMPMessage message_;
    public const int TargetFieldNumber = 3;
    private bool hasTarget;
    private Target target_;
    public const int RequestIdFieldNumber = 4;
    private bool hasRequestId;

    private PushMMPSingleMessage()
    {
    }

    public static PushMMPSingleMessage DefaultInstance
    {
      get
      {
        return PushMMPSingleMessage.defaultInstance;
      }
    }

    public override PushMMPSingleMessage DefaultInstanceForType
    {
      get
      {
        return PushMMPSingleMessage.DefaultInstance;
      }
    }

    protected override PushMMPSingleMessage ThisMessage
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
        return GtReq.internal__static_com_gexin_rp_sdk_dto_PushMMPSingleMessage__Descriptor;
      }
    }

    protected override FieldAccessorTable<PushMMPSingleMessage, PushMMPSingleMessage.Builder> InternalFieldAccessors
    {
      get
      {
        return GtReq.internal__static_com_gexin_rp_sdk_dto_PushMMPSingleMessage__FieldAccessorTable;
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

    public bool HasTarget
    {
      get
      {
        return this.hasTarget;
      }
    }

    public Target Target
    {
      get
      {
        return this.target_ ?? Target.DefaultInstance;
      }
    }

    public bool HasRequestId
    {
      get
      {
        return this.hasRequestId;
      }
    }

    public string RequestId
    {
      get
      {
        return this.requestId_;
      }
    }

    public override bool IsInitialized
    {
      get
      {
        return this.hasSeqId && this.hasMessage && (this.hasTarget && this.Message.IsInitialized) && this.Target.IsInitialized;
      }
    }

    public override void WriteTo(ICodedOutputStream output)
    {
      int serializedSize = this.SerializedSize;
      string[] messageFieldNames = PushMMPSingleMessage._pushMMPSingleMessageFieldNames;
      if (this.hasSeqId)
        output.WriteString(1, messageFieldNames[2], this.SeqId);
      if (this.hasMessage)
        output.WriteMessage(2, messageFieldNames[0], (IMessageLite) this.Message);
      if (this.hasTarget)
        output.WriteMessage(3, messageFieldNames[3], (IMessageLite) this.Target);
      if (this.hasRequestId)
        output.WriteString(4, messageFieldNames[1], this.RequestId);
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
        if (this.hasMessage)
          num1 += CodedOutputStream.ComputeMessageSize(2, (IMessageLite) this.Message);
        if (this.hasTarget)
          num1 += CodedOutputStream.ComputeMessageSize(3, (IMessageLite) this.Target);
        if (this.hasRequestId)
          num1 += CodedOutputStream.ComputeStringSize(4, this.RequestId);
        int num2 = num1 + this.UnknownFields.SerializedSize;
        this.memoizedSerializedSize = num2;
        return num2;
      }
    }

    public static PushMMPSingleMessage ParseFrom(ByteString data)
    {
      return PushMMPSingleMessage.CreateBuilder().MergeFrom(data).BuildParsed();
    }

    public static PushMMPSingleMessage ParseFrom(
      ByteString data,
      ExtensionRegistry extensionRegistry)
    {
      return PushMMPSingleMessage.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
    }

    public static PushMMPSingleMessage ParseFrom(byte[] data)
    {
      return PushMMPSingleMessage.CreateBuilder().MergeFrom(data).BuildParsed();
    }

    public static PushMMPSingleMessage ParseFrom(
      byte[] data,
      ExtensionRegistry extensionRegistry)
    {
      return PushMMPSingleMessage.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
    }

    public static PushMMPSingleMessage ParseFrom(Stream input)
    {
      return PushMMPSingleMessage.CreateBuilder().MergeFrom(input).BuildParsed();
    }

    public static PushMMPSingleMessage ParseFrom(
      Stream input,
      ExtensionRegistry extensionRegistry)
    {
      return PushMMPSingleMessage.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
    }

    public static PushMMPSingleMessage ParseDelimitedFrom(Stream input)
    {
      return PushMMPSingleMessage.CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }

    public static PushMMPSingleMessage ParseDelimitedFrom(
      Stream input,
      ExtensionRegistry extensionRegistry)
    {
      return PushMMPSingleMessage.CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }

    public static PushMMPSingleMessage ParseFrom(ICodedInputStream input)
    {
      return PushMMPSingleMessage.CreateBuilder().MergeFrom(input).BuildParsed();
    }

    public static PushMMPSingleMessage ParseFrom(
      ICodedInputStream input,
      ExtensionRegistry extensionRegistry)
    {
      return PushMMPSingleMessage.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
    }

    private PushMMPSingleMessage MakeReadOnly()
    {
      return this;
    }

    public static PushMMPSingleMessage.Builder CreateBuilder()
    {
      return new PushMMPSingleMessage.Builder();
    }

    public override PushMMPSingleMessage.Builder ToBuilder()
    {
      return PushMMPSingleMessage.CreateBuilder(this);
    }

    public override PushMMPSingleMessage.Builder CreateBuilderForType()
    {
      return new PushMMPSingleMessage.Builder();
    }

    public static PushMMPSingleMessage.Builder CreateBuilder(
      PushMMPSingleMessage prototype)
    {
      return new PushMMPSingleMessage.Builder(prototype);
    }

    static PushMMPSingleMessage()
    {
      FileDescriptor descriptor = GtReq.Descriptor;
    }

    [DebuggerNonUserCode]
    public sealed class Builder : GeneratedBuilder<PushMMPSingleMessage, PushMMPSingleMessage.Builder>
    {
      private bool resultIsReadOnly;
      private PushMMPSingleMessage result;

      protected override PushMMPSingleMessage.Builder ThisBuilder
      {
        get
        {
          return this;
        }
      }

      public Builder()
      {
        this.result = PushMMPSingleMessage.DefaultInstance;
        this.resultIsReadOnly = true;
      }

      internal Builder(PushMMPSingleMessage cloneFrom)
      {
        this.result = cloneFrom;
        this.resultIsReadOnly = true;
      }

      private PushMMPSingleMessage PrepareBuilder()
      {
        if (this.resultIsReadOnly)
        {
          PushMMPSingleMessage result = this.result;
          this.result = new PushMMPSingleMessage();
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

      protected override PushMMPSingleMessage MessageBeingBuilt
      {
        get
        {
          return this.PrepareBuilder();
        }
      }

      public override PushMMPSingleMessage.Builder Clear()
      {
        this.result = PushMMPSingleMessage.DefaultInstance;
        this.resultIsReadOnly = true;
        return this;
      }

      public override PushMMPSingleMessage.Builder Clone()
      {
        if (this.resultIsReadOnly)
          return new PushMMPSingleMessage.Builder(this.result);
        return new PushMMPSingleMessage.Builder().MergeFrom(this.result);
      }

      public override MessageDescriptor DescriptorForType
      {
        get
        {
          return PushMMPSingleMessage.Descriptor;
        }
      }

      public override PushMMPSingleMessage DefaultInstanceForType
      {
        get
        {
          return PushMMPSingleMessage.DefaultInstance;
        }
      }

      public override PushMMPSingleMessage BuildPartial()
      {
        if (this.resultIsReadOnly)
          return this.result;
        this.resultIsReadOnly = true;
        return this.result.MakeReadOnly();
      }

      public override PushMMPSingleMessage.Builder MergeFrom(IMessage other)
      {
        if (other is PushMMPSingleMessage)
          return this.MergeFrom((PushMMPSingleMessage) other);
        base.MergeFrom(other);
        return this;
      }

      public override PushMMPSingleMessage.Builder MergeFrom(
        PushMMPSingleMessage other)
      {
        if (other == PushMMPSingleMessage.DefaultInstance)
          return this;
        this.PrepareBuilder();
        if (other.HasSeqId)
          this.SeqId = other.SeqId;
        if (other.HasMessage)
          this.MergeMessage(other.Message);
        if (other.HasTarget)
          this.MergeTarget(other.Target);
        if (other.HasRequestId)
          this.RequestId = other.RequestId;
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }

      public override PushMMPSingleMessage.Builder MergeFrom(
        ICodedInputStream input)
      {
        return this.MergeFrom(input, ExtensionRegistry.Empty);
      }

      public override PushMMPSingleMessage.Builder MergeFrom(
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
            int index = Array.BinarySearch<string>(PushMMPSingleMessage._pushMMPSingleMessageFieldNames, fieldName, (IComparer<string>) StringComparer.Ordinal);
            if (index >= 0)
            {
              fieldTag = PushMMPSingleMessage._pushMMPSingleMessageFieldTags[index];
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
              MMPMessage.Builder builder1 = MMPMessage.CreateBuilder();
              if (this.result.hasMessage)
                builder1.MergeFrom(this.Message);
              input.ReadMessage((IBuilderLite) builder1, extensionRegistry);
              this.Message = builder1.BuildPartial();
              continue;
            case 26:
              Target.Builder builder2 = Target.CreateBuilder();
              if (this.result.hasTarget)
                builder2.MergeFrom(this.Target);
              input.ReadMessage((IBuilderLite) builder2, extensionRegistry);
              this.Target = builder2.BuildPartial();
              continue;
            case 34:
              this.result.hasRequestId = input.ReadString(ref this.result.requestId_);
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

      public PushMMPSingleMessage.Builder SetSeqId(string value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.hasSeqId = true;
        this.result.seqId_ = value;
        return this;
      }

      public PushMMPSingleMessage.Builder ClearSeqId()
      {
        this.PrepareBuilder();
        this.result.hasSeqId = false;
        this.result.seqId_ = "";
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

      public PushMMPSingleMessage.Builder SetMessage(MMPMessage value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.hasMessage = true;
        this.result.message_ = value;
        return this;
      }

      public PushMMPSingleMessage.Builder SetMessage(
        MMPMessage.Builder builderForValue)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) builderForValue, nameof (builderForValue));
        this.PrepareBuilder();
        this.result.hasMessage = true;
        this.result.message_ = builderForValue.Build();
        return this;
      }

      public PushMMPSingleMessage.Builder MergeMessage(MMPMessage value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.message_ = !this.result.hasMessage || this.result.message_ == MMPMessage.DefaultInstance ? value : MMPMessage.CreateBuilder(this.result.message_).MergeFrom(value).BuildPartial();
        this.result.hasMessage = true;
        return this;
      }

      public PushMMPSingleMessage.Builder ClearMessage()
      {
        this.PrepareBuilder();
        this.result.hasMessage = false;
        this.result.message_ = (MMPMessage) null;
        return this;
      }

      public bool HasTarget
      {
        get
        {
          return this.result.hasTarget;
        }
      }

      public Target Target
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

      public PushMMPSingleMessage.Builder SetTarget(Target value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.hasTarget = true;
        this.result.target_ = value;
        return this;
      }

      public PushMMPSingleMessage.Builder SetTarget(
        Target.Builder builderForValue)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) builderForValue, nameof (builderForValue));
        this.PrepareBuilder();
        this.result.hasTarget = true;
        this.result.target_ = builderForValue.Build();
        return this;
      }

      public PushMMPSingleMessage.Builder MergeTarget(Target value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.target_ = !this.result.hasTarget || this.result.target_ == Target.DefaultInstance ? value : Target.CreateBuilder(this.result.target_).MergeFrom(value).BuildPartial();
        this.result.hasTarget = true;
        return this;
      }

      public PushMMPSingleMessage.Builder ClearTarget()
      {
        this.PrepareBuilder();
        this.result.hasTarget = false;
        this.result.target_ = (Target) null;
        return this;
      }

      public bool HasRequestId
      {
        get
        {
          return this.result.hasRequestId;
        }
      }

      public string RequestId
      {
        get
        {
          return this.result.RequestId;
        }
        set
        {
          this.SetRequestId(value);
        }
      }

      public PushMMPSingleMessage.Builder SetRequestId(string value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.hasRequestId = true;
        this.result.requestId_ = value;
        return this;
      }

      public PushMMPSingleMessage.Builder ClearRequestId()
      {
        this.PrepareBuilder();
        this.result.hasRequestId = false;
        this.result.requestId_ = "";
        return this;
      }
    }
  }
}
