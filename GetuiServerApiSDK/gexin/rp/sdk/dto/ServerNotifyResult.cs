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
  public sealed class ServerNotifyResult : GeneratedMessage<ServerNotifyResult, ServerNotifyResult.Builder>
  {
    private static readonly ServerNotifyResult defaultInstance = new ServerNotifyResult().MakeReadOnly();
    private static readonly string[] _serverNotifyResultFieldNames = new string[2]
    {
      "info",
      "seqId"
    };
    private static readonly uint[] _serverNotifyResultFieldTags = new uint[2]
    {
      18U,
      10U
    };
    private string seqId_ = "";
    private string info_ = "";
    private int memoizedSerializedSize = -1;
    public const int SeqIdFieldNumber = 1;
    private bool hasSeqId;
    public const int InfoFieldNumber = 2;
    private bool hasInfo;

    private ServerNotifyResult()
    {
    }

    public static ServerNotifyResult DefaultInstance
    {
      get
      {
        return ServerNotifyResult.defaultInstance;
      }
    }

    public override ServerNotifyResult DefaultInstanceForType
    {
      get
      {
        return ServerNotifyResult.DefaultInstance;
      }
    }

    protected override ServerNotifyResult ThisMessage
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
        return GtReq.internal__static_com_gexin_rp_sdk_dto_ServerNotifyResult__Descriptor;
      }
    }

    protected override FieldAccessorTable<ServerNotifyResult, ServerNotifyResult.Builder> InternalFieldAccessors
    {
      get
      {
        return GtReq.internal__static_com_gexin_rp_sdk_dto_ServerNotifyResult__FieldAccessorTable;
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

    public override bool IsInitialized
    {
      get
      {
        return this.hasSeqId;
      }
    }

    public override void WriteTo(ICodedOutputStream output)
    {
      int serializedSize = this.SerializedSize;
      string[] resultFieldNames = ServerNotifyResult._serverNotifyResultFieldNames;
      if (this.hasSeqId)
        output.WriteString(1, resultFieldNames[1], this.SeqId);
      if (this.hasInfo)
        output.WriteString(2, resultFieldNames[0], this.Info);
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
        if (this.hasInfo)
          num1 += CodedOutputStream.ComputeStringSize(2, this.Info);
        int num2 = num1 + this.UnknownFields.SerializedSize;
        this.memoizedSerializedSize = num2;
        return num2;
      }
    }

    public static ServerNotifyResult ParseFrom(ByteString data)
    {
      return ServerNotifyResult.CreateBuilder().MergeFrom(data).BuildParsed();
    }

    public static ServerNotifyResult ParseFrom(
      ByteString data,
      ExtensionRegistry extensionRegistry)
    {
      return ServerNotifyResult.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
    }

    public static ServerNotifyResult ParseFrom(byte[] data)
    {
      return ServerNotifyResult.CreateBuilder().MergeFrom(data).BuildParsed();
    }

    public static ServerNotifyResult ParseFrom(
      byte[] data,
      ExtensionRegistry extensionRegistry)
    {
      return ServerNotifyResult.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
    }

    public static ServerNotifyResult ParseFrom(Stream input)
    {
      return ServerNotifyResult.CreateBuilder().MergeFrom(input).BuildParsed();
    }

    public static ServerNotifyResult ParseFrom(
      Stream input,
      ExtensionRegistry extensionRegistry)
    {
      return ServerNotifyResult.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
    }

    public static ServerNotifyResult ParseDelimitedFrom(Stream input)
    {
      return ServerNotifyResult.CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }

    public static ServerNotifyResult ParseDelimitedFrom(
      Stream input,
      ExtensionRegistry extensionRegistry)
    {
      return ServerNotifyResult.CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }

    public static ServerNotifyResult ParseFrom(ICodedInputStream input)
    {
      return ServerNotifyResult.CreateBuilder().MergeFrom(input).BuildParsed();
    }

    public static ServerNotifyResult ParseFrom(
      ICodedInputStream input,
      ExtensionRegistry extensionRegistry)
    {
      return ServerNotifyResult.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
    }

    private ServerNotifyResult MakeReadOnly()
    {
      return this;
    }

    public static ServerNotifyResult.Builder CreateBuilder()
    {
      return new ServerNotifyResult.Builder();
    }

    public override ServerNotifyResult.Builder ToBuilder()
    {
      return ServerNotifyResult.CreateBuilder(this);
    }

    public override ServerNotifyResult.Builder CreateBuilderForType()
    {
      return new ServerNotifyResult.Builder();
    }

    public static ServerNotifyResult.Builder CreateBuilder(
      ServerNotifyResult prototype)
    {
      return new ServerNotifyResult.Builder(prototype);
    }

    static ServerNotifyResult()
    {
      FileDescriptor descriptor = GtReq.Descriptor;
    }

    [DebuggerNonUserCode]
    public sealed class Builder : GeneratedBuilder<ServerNotifyResult, ServerNotifyResult.Builder>
    {
      private bool resultIsReadOnly;
      private ServerNotifyResult result;

      protected override ServerNotifyResult.Builder ThisBuilder
      {
        get
        {
          return this;
        }
      }

      public Builder()
      {
        this.result = ServerNotifyResult.DefaultInstance;
        this.resultIsReadOnly = true;
      }

      internal Builder(ServerNotifyResult cloneFrom)
      {
        this.result = cloneFrom;
        this.resultIsReadOnly = true;
      }

      private ServerNotifyResult PrepareBuilder()
      {
        if (this.resultIsReadOnly)
        {
          ServerNotifyResult result = this.result;
          this.result = new ServerNotifyResult();
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

      protected override ServerNotifyResult MessageBeingBuilt
      {
        get
        {
          return this.PrepareBuilder();
        }
      }

      public override ServerNotifyResult.Builder Clear()
      {
        this.result = ServerNotifyResult.DefaultInstance;
        this.resultIsReadOnly = true;
        return this;
      }

      public override ServerNotifyResult.Builder Clone()
      {
        if (this.resultIsReadOnly)
          return new ServerNotifyResult.Builder(this.result);
        return new ServerNotifyResult.Builder().MergeFrom(this.result);
      }

      public override MessageDescriptor DescriptorForType
      {
        get
        {
          return ServerNotifyResult.Descriptor;
        }
      }

      public override ServerNotifyResult DefaultInstanceForType
      {
        get
        {
          return ServerNotifyResult.DefaultInstance;
        }
      }

      public override ServerNotifyResult BuildPartial()
      {
        if (this.resultIsReadOnly)
          return this.result;
        this.resultIsReadOnly = true;
        return this.result.MakeReadOnly();
      }

      public override ServerNotifyResult.Builder MergeFrom(IMessage other)
      {
        if (other is ServerNotifyResult)
          return this.MergeFrom((ServerNotifyResult) other);
        base.MergeFrom(other);
        return this;
      }

      public override ServerNotifyResult.Builder MergeFrom(
        ServerNotifyResult other)
      {
        if (other == ServerNotifyResult.DefaultInstance)
          return this;
        this.PrepareBuilder();
        if (other.HasSeqId)
          this.SeqId = other.SeqId;
        if (other.HasInfo)
          this.Info = other.Info;
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }

      public override ServerNotifyResult.Builder MergeFrom(ICodedInputStream input)
      {
        return this.MergeFrom(input, ExtensionRegistry.Empty);
      }

      public override ServerNotifyResult.Builder MergeFrom(
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
            int index = Array.BinarySearch<string>(ServerNotifyResult._serverNotifyResultFieldNames, fieldName, (IComparer<string>) StringComparer.Ordinal);
            if (index >= 0)
            {
              fieldTag = ServerNotifyResult._serverNotifyResultFieldTags[index];
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
              this.result.hasInfo = input.ReadString(ref this.result.info_);
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

      public ServerNotifyResult.Builder SetSeqId(string value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.hasSeqId = true;
        this.result.seqId_ = value;
        return this;
      }

      public ServerNotifyResult.Builder ClearSeqId()
      {
        this.PrepareBuilder();
        this.result.hasSeqId = false;
        this.result.seqId_ = "";
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

      public ServerNotifyResult.Builder SetInfo(string value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.hasInfo = true;
        this.result.info_ = value;
        return this;
      }

      public ServerNotifyResult.Builder ClearInfo()
      {
        this.PrepareBuilder();
        this.result.hasInfo = false;
        this.result.info_ = "";
        return this;
      }
    }
  }
}
