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
  public sealed class StartOSBatchTask : GeneratedMessage<StartOSBatchTask, StartOSBatchTask.Builder>
  {
    private static readonly StartOSBatchTask defaultInstance = new StartOSBatchTask().MakeReadOnly();
    private static readonly string[] _startOSBatchTaskFieldNames = new string[2]
    {
      "expire",
      "message"
    };
    private static readonly uint[] _startOSBatchTaskFieldTags = new uint[2]
    {
      16U,
      10U
    };
    private long expire_ = 72;
    private int memoizedSerializedSize = -1;
    public const int MessageFieldNumber = 1;
    private bool hasMessage;
    private OSMessage message_;
    public const int ExpireFieldNumber = 2;
    private bool hasExpire;

    private StartOSBatchTask()
    {
    }

    public static StartOSBatchTask DefaultInstance
    {
      get
      {
        return StartOSBatchTask.defaultInstance;
      }
    }

    public override StartOSBatchTask DefaultInstanceForType
    {
      get
      {
        return StartOSBatchTask.DefaultInstance;
      }
    }

    protected override StartOSBatchTask ThisMessage
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
        return GtReq.internal__static_com_gexin_rp_sdk_dto_StartOSBatchTask__Descriptor;
      }
    }

    protected override FieldAccessorTable<StartOSBatchTask, StartOSBatchTask.Builder> InternalFieldAccessors
    {
      get
      {
        return GtReq.internal__static_com_gexin_rp_sdk_dto_StartOSBatchTask__FieldAccessorTable;
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
      string[] batchTaskFieldNames = StartOSBatchTask._startOSBatchTaskFieldNames;
      if (this.hasMessage)
        output.WriteMessage(1, batchTaskFieldNames[1], (IMessageLite) this.Message);
      if (this.hasExpire)
        output.WriteInt64(2, batchTaskFieldNames[0], this.Expire);
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
        int num2 = num1 + this.UnknownFields.SerializedSize;
        this.memoizedSerializedSize = num2;
        return num2;
      }
    }

    public static StartOSBatchTask ParseFrom(ByteString data)
    {
      return StartOSBatchTask.CreateBuilder().MergeFrom(data).BuildParsed();
    }

    public static StartOSBatchTask ParseFrom(
      ByteString data,
      ExtensionRegistry extensionRegistry)
    {
      return StartOSBatchTask.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
    }

    public static StartOSBatchTask ParseFrom(byte[] data)
    {
      return StartOSBatchTask.CreateBuilder().MergeFrom(data).BuildParsed();
    }

    public static StartOSBatchTask ParseFrom(
      byte[] data,
      ExtensionRegistry extensionRegistry)
    {
      return StartOSBatchTask.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
    }

    public static StartOSBatchTask ParseFrom(Stream input)
    {
      return StartOSBatchTask.CreateBuilder().MergeFrom(input).BuildParsed();
    }

    public static StartOSBatchTask ParseFrom(
      Stream input,
      ExtensionRegistry extensionRegistry)
    {
      return StartOSBatchTask.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
    }

    public static StartOSBatchTask ParseDelimitedFrom(Stream input)
    {
      return StartOSBatchTask.CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }

    public static StartOSBatchTask ParseDelimitedFrom(
      Stream input,
      ExtensionRegistry extensionRegistry)
    {
      return StartOSBatchTask.CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }

    public static StartOSBatchTask ParseFrom(ICodedInputStream input)
    {
      return StartOSBatchTask.CreateBuilder().MergeFrom(input).BuildParsed();
    }

    public static StartOSBatchTask ParseFrom(
      ICodedInputStream input,
      ExtensionRegistry extensionRegistry)
    {
      return StartOSBatchTask.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
    }

    private StartOSBatchTask MakeReadOnly()
    {
      return this;
    }

    public static StartOSBatchTask.Builder CreateBuilder()
    {
      return new StartOSBatchTask.Builder();
    }

    public override StartOSBatchTask.Builder ToBuilder()
    {
      return StartOSBatchTask.CreateBuilder(this);
    }

    public override StartOSBatchTask.Builder CreateBuilderForType()
    {
      return new StartOSBatchTask.Builder();
    }

    public static StartOSBatchTask.Builder CreateBuilder(StartOSBatchTask prototype)
    {
      return new StartOSBatchTask.Builder(prototype);
    }

    static StartOSBatchTask()
    {
      FileDescriptor descriptor = GtReq.Descriptor;
    }

    [DebuggerNonUserCode]
    public sealed class Builder : GeneratedBuilder<StartOSBatchTask, StartOSBatchTask.Builder>
    {
      private bool resultIsReadOnly;
      private StartOSBatchTask result;

      protected override StartOSBatchTask.Builder ThisBuilder
      {
        get
        {
          return this;
        }
      }

      public Builder()
      {
        this.result = StartOSBatchTask.DefaultInstance;
        this.resultIsReadOnly = true;
      }

      internal Builder(StartOSBatchTask cloneFrom)
      {
        this.result = cloneFrom;
        this.resultIsReadOnly = true;
      }

      private StartOSBatchTask PrepareBuilder()
      {
        if (this.resultIsReadOnly)
        {
          StartOSBatchTask result = this.result;
          this.result = new StartOSBatchTask();
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

      protected override StartOSBatchTask MessageBeingBuilt
      {
        get
        {
          return this.PrepareBuilder();
        }
      }

      public override StartOSBatchTask.Builder Clear()
      {
        this.result = StartOSBatchTask.DefaultInstance;
        this.resultIsReadOnly = true;
        return this;
      }

      public override StartOSBatchTask.Builder Clone()
      {
        if (this.resultIsReadOnly)
          return new StartOSBatchTask.Builder(this.result);
        return new StartOSBatchTask.Builder().MergeFrom(this.result);
      }

      public override MessageDescriptor DescriptorForType
      {
        get
        {
          return StartOSBatchTask.Descriptor;
        }
      }

      public override StartOSBatchTask DefaultInstanceForType
      {
        get
        {
          return StartOSBatchTask.DefaultInstance;
        }
      }

      public override StartOSBatchTask BuildPartial()
      {
        if (this.resultIsReadOnly)
          return this.result;
        this.resultIsReadOnly = true;
        return this.result.MakeReadOnly();
      }

      public override StartOSBatchTask.Builder MergeFrom(IMessage other)
      {
        if (other is StartOSBatchTask)
          return this.MergeFrom((StartOSBatchTask) other);
        base.MergeFrom(other);
        return this;
      }

      public override StartOSBatchTask.Builder MergeFrom(StartOSBatchTask other)
      {
        if (other == StartOSBatchTask.DefaultInstance)
          return this;
        this.PrepareBuilder();
        if (other.HasMessage)
          this.MergeMessage(other.Message);
        if (other.HasExpire)
          this.Expire = other.Expire;
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }

      public override StartOSBatchTask.Builder MergeFrom(ICodedInputStream input)
      {
        return this.MergeFrom(input, ExtensionRegistry.Empty);
      }

      public override StartOSBatchTask.Builder MergeFrom(
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
            int index = Array.BinarySearch<string>(StartOSBatchTask._startOSBatchTaskFieldNames, fieldName, (IComparer<string>) StringComparer.Ordinal);
            if (index >= 0)
            {
              fieldTag = StartOSBatchTask._startOSBatchTaskFieldTags[index];
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
              OSMessage.Builder builder = OSMessage.CreateBuilder();
              if (this.result.hasMessage)
                builder.MergeFrom(this.Message);
              input.ReadMessage((IBuilderLite) builder, extensionRegistry);
              this.Message = builder.BuildPartial();
              continue;
            case 16:
              this.result.hasExpire = input.ReadInt64(ref this.result.expire_);
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

      public StartOSBatchTask.Builder SetMessage(OSMessage value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.hasMessage = true;
        this.result.message_ = value;
        return this;
      }

      public StartOSBatchTask.Builder SetMessage(OSMessage.Builder builderForValue)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) builderForValue, nameof (builderForValue));
        this.PrepareBuilder();
        this.result.hasMessage = true;
        this.result.message_ = builderForValue.Build();
        return this;
      }

      public StartOSBatchTask.Builder MergeMessage(OSMessage value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.message_ = !this.result.hasMessage || this.result.message_ == OSMessage.DefaultInstance ? value : OSMessage.CreateBuilder(this.result.message_).MergeFrom(value).BuildPartial();
        this.result.hasMessage = true;
        return this;
      }

      public StartOSBatchTask.Builder ClearMessage()
      {
        this.PrepareBuilder();
        this.result.hasMessage = false;
        this.result.message_ = (OSMessage) null;
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

      public StartOSBatchTask.Builder SetExpire(long value)
      {
        this.PrepareBuilder();
        this.result.hasExpire = true;
        this.result.expire_ = value;
        return this;
      }

      public StartOSBatchTask.Builder ClearExpire()
      {
        this.PrepareBuilder();
        this.result.hasExpire = false;
        this.result.expire_ = 72L;
        return this;
      }
    }
  }
}
