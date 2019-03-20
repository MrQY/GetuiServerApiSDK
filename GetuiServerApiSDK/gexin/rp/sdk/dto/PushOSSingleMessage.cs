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
  public sealed class PushOSSingleMessage : GeneratedMessage<PushOSSingleMessage, PushOSSingleMessage.Builder>
  {
    private static readonly PushOSSingleMessage defaultInstance = new PushOSSingleMessage().MakeReadOnly();
    private static readonly string[] _pushOSSingleMessageFieldNames = new string[3]
    {
      "message",
      "seqId",
      "target"
    };
    private static readonly uint[] _pushOSSingleMessageFieldTags = new uint[3]
    {
      18U,
      10U,
      26U
    };
    private string seqId_ = "";
    private int memoizedSerializedSize = -1;
    public const int SeqIdFieldNumber = 1;
    private bool hasSeqId;
    public const int MessageFieldNumber = 2;
    private bool hasMessage;
    private OSMessage message_;
    public const int TargetFieldNumber = 3;
    private bool hasTarget;
    private Target target_;

    private PushOSSingleMessage()
    {
    }

    public static PushOSSingleMessage DefaultInstance
    {
      get
      {
        return PushOSSingleMessage.defaultInstance;
      }
    }

    public override PushOSSingleMessage DefaultInstanceForType
    {
      get
      {
        return PushOSSingleMessage.DefaultInstance;
      }
    }

    protected override PushOSSingleMessage ThisMessage
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
        return GtReq.internal__static_com_gexin_rp_sdk_dto_PushOSSingleMessage__Descriptor;
      }
    }

    protected override FieldAccessorTable<PushOSSingleMessage, PushOSSingleMessage.Builder> InternalFieldAccessors
    {
      get
      {
        return GtReq.internal__static_com_gexin_rp_sdk_dto_PushOSSingleMessage__FieldAccessorTable;
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

    public OSMessage Message
    {
      get
      {
        return this.message_ ?? OSMessage.DefaultInstance;
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
      string[] messageFieldNames = PushOSSingleMessage._pushOSSingleMessageFieldNames;
      if (this.hasSeqId)
        output.WriteString(1, messageFieldNames[1], this.SeqId);
      if (this.hasMessage)
        output.WriteMessage(2, messageFieldNames[0], (IMessageLite) this.Message);
      if (this.hasTarget)
        output.WriteMessage(3, messageFieldNames[2], (IMessageLite) this.Target);
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
        int num2 = num1 + this.UnknownFields.SerializedSize;
        this.memoizedSerializedSize = num2;
        return num2;
      }
    }

    public static PushOSSingleMessage ParseFrom(ByteString data)
    {
      return PushOSSingleMessage.CreateBuilder().MergeFrom(data).BuildParsed();
    }

    public static PushOSSingleMessage ParseFrom(
      ByteString data,
      ExtensionRegistry extensionRegistry)
    {
      return PushOSSingleMessage.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
    }

    public static PushOSSingleMessage ParseFrom(byte[] data)
    {
      return PushOSSingleMessage.CreateBuilder().MergeFrom(data).BuildParsed();
    }

    public static PushOSSingleMessage ParseFrom(
      byte[] data,
      ExtensionRegistry extensionRegistry)
    {
      return PushOSSingleMessage.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
    }

    public static PushOSSingleMessage ParseFrom(Stream input)
    {
      return PushOSSingleMessage.CreateBuilder().MergeFrom(input).BuildParsed();
    }

    public static PushOSSingleMessage ParseFrom(
      Stream input,
      ExtensionRegistry extensionRegistry)
    {
      return PushOSSingleMessage.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
    }

    public static PushOSSingleMessage ParseDelimitedFrom(Stream input)
    {
      return PushOSSingleMessage.CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }

    public static PushOSSingleMessage ParseDelimitedFrom(
      Stream input,
      ExtensionRegistry extensionRegistry)
    {
      return PushOSSingleMessage.CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }

    public static PushOSSingleMessage ParseFrom(ICodedInputStream input)
    {
      return PushOSSingleMessage.CreateBuilder().MergeFrom(input).BuildParsed();
    }

    public static PushOSSingleMessage ParseFrom(
      ICodedInputStream input,
      ExtensionRegistry extensionRegistry)
    {
      return PushOSSingleMessage.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
    }

    private PushOSSingleMessage MakeReadOnly()
    {
      return this;
    }

    public static PushOSSingleMessage.Builder CreateBuilder()
    {
      return new PushOSSingleMessage.Builder();
    }

    public override PushOSSingleMessage.Builder ToBuilder()
    {
      return PushOSSingleMessage.CreateBuilder(this);
    }

    public override PushOSSingleMessage.Builder CreateBuilderForType()
    {
      return new PushOSSingleMessage.Builder();
    }

    public static PushOSSingleMessage.Builder CreateBuilder(
      PushOSSingleMessage prototype)
    {
      return new PushOSSingleMessage.Builder(prototype);
    }

    static PushOSSingleMessage()
    {
      FileDescriptor descriptor = GtReq.Descriptor;
    }

    [DebuggerNonUserCode]
    public sealed class Builder : GeneratedBuilder<PushOSSingleMessage, PushOSSingleMessage.Builder>
    {
      private bool resultIsReadOnly;
      private PushOSSingleMessage result;

      protected override PushOSSingleMessage.Builder ThisBuilder
      {
        get
        {
          return this;
        }
      }

      public Builder()
      {
        this.result = PushOSSingleMessage.DefaultInstance;
        this.resultIsReadOnly = true;
      }

      internal Builder(PushOSSingleMessage cloneFrom)
      {
        this.result = cloneFrom;
        this.resultIsReadOnly = true;
      }

      private PushOSSingleMessage PrepareBuilder()
      {
        if (this.resultIsReadOnly)
        {
          PushOSSingleMessage result = this.result;
          this.result = new PushOSSingleMessage();
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

      protected override PushOSSingleMessage MessageBeingBuilt
      {
        get
        {
          return this.PrepareBuilder();
        }
      }

      public override PushOSSingleMessage.Builder Clear()
      {
        this.result = PushOSSingleMessage.DefaultInstance;
        this.resultIsReadOnly = true;
        return this;
      }

      public override PushOSSingleMessage.Builder Clone()
      {
        if (this.resultIsReadOnly)
          return new PushOSSingleMessage.Builder(this.result);
        return new PushOSSingleMessage.Builder().MergeFrom(this.result);
      }

      public override MessageDescriptor DescriptorForType
      {
        get
        {
          return PushOSSingleMessage.Descriptor;
        }
      }

      public override PushOSSingleMessage DefaultInstanceForType
      {
        get
        {
          return PushOSSingleMessage.DefaultInstance;
        }
      }

      public override PushOSSingleMessage BuildPartial()
      {
        if (this.resultIsReadOnly)
          return this.result;
        this.resultIsReadOnly = true;
        return this.result.MakeReadOnly();
      }

      public override PushOSSingleMessage.Builder MergeFrom(IMessage other)
      {
        if (other is PushOSSingleMessage)
          return this.MergeFrom((PushOSSingleMessage) other);
        base.MergeFrom(other);
        return this;
      }

      public override PushOSSingleMessage.Builder MergeFrom(
        PushOSSingleMessage other)
      {
        if (other == PushOSSingleMessage.DefaultInstance)
          return this;
        this.PrepareBuilder();
        if (other.HasSeqId)
          this.SeqId = other.SeqId;
        if (other.HasMessage)
          this.MergeMessage(other.Message);
        if (other.HasTarget)
          this.MergeTarget(other.Target);
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }

      public override PushOSSingleMessage.Builder MergeFrom(
        ICodedInputStream input)
      {
        return this.MergeFrom(input, ExtensionRegistry.Empty);
      }

      public override PushOSSingleMessage.Builder MergeFrom(
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
            int index = Array.BinarySearch<string>(PushOSSingleMessage._pushOSSingleMessageFieldNames, fieldName, (IComparer<string>) StringComparer.Ordinal);
            if (index >= 0)
            {
              fieldTag = PushOSSingleMessage._pushOSSingleMessageFieldTags[index];
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
              OSMessage.Builder builder1 = OSMessage.CreateBuilder();
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

      public PushOSSingleMessage.Builder SetSeqId(string value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.hasSeqId = true;
        this.result.seqId_ = value;
        return this;
      }

      public PushOSSingleMessage.Builder ClearSeqId()
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

      public OSMessage Message
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

      public PushOSSingleMessage.Builder SetMessage(OSMessage value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.hasMessage = true;
        this.result.message_ = value;
        return this;
      }

      public PushOSSingleMessage.Builder SetMessage(
        OSMessage.Builder builderForValue)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) builderForValue, nameof (builderForValue));
        this.PrepareBuilder();
        this.result.hasMessage = true;
        this.result.message_ = builderForValue.Build();
        return this;
      }

      public PushOSSingleMessage.Builder MergeMessage(OSMessage value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.message_ = !this.result.hasMessage || this.result.message_ == OSMessage.DefaultInstance ? value : OSMessage.CreateBuilder(this.result.message_).MergeFrom(value).BuildPartial();
        this.result.hasMessage = true;
        return this;
      }

      public PushOSSingleMessage.Builder ClearMessage()
      {
        this.PrepareBuilder();
        this.result.hasMessage = false;
        this.result.message_ = (OSMessage) null;
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

      public PushOSSingleMessage.Builder SetTarget(Target value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.hasTarget = true;
        this.result.target_ = value;
        return this;
      }

      public PushOSSingleMessage.Builder SetTarget(Target.Builder builderForValue)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) builderForValue, nameof (builderForValue));
        this.PrepareBuilder();
        this.result.hasTarget = true;
        this.result.target_ = builderForValue.Build();
        return this;
      }

      public PushOSSingleMessage.Builder MergeTarget(Target value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.target_ = !this.result.hasTarget || this.result.target_ == Target.DefaultInstance ? value : Target.CreateBuilder(this.result.target_).MergeFrom(value).BuildPartial();
        this.result.hasTarget = true;
        return this;
      }

      public PushOSSingleMessage.Builder ClearTarget()
      {
        this.PrepareBuilder();
        this.result.hasTarget = false;
        this.result.target_ = (Target) null;
        return this;
      }
    }
  }
}
