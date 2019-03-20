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
  public sealed class ServerNotify : GeneratedMessage<ServerNotify, ServerNotify.Builder>
  {
    private static readonly ServerNotify defaultInstance = new ServerNotify().MakeReadOnly();
    private static readonly string[] _serverNotifyFieldNames = new string[4]
    {
      "extradata",
      "info",
      "seqId",
      "type"
    };
    private static readonly uint[] _serverNotifyFieldTags = new uint[4]
    {
      26U,
      18U,
      34U,
      8U
    };
    private string info_ = "";
    private ByteString extradata_ = ByteString.Empty;
    private string seqId_ = "";
    private int memoizedSerializedSize = -1;
    public const int TypeFieldNumber = 1;
    private bool hasType;
    private ServerNotify.Types.NotifyType type_;
    public const int InfoFieldNumber = 2;
    private bool hasInfo;
    public const int ExtradataFieldNumber = 3;
    private bool hasExtradata;
    public const int SeqIdFieldNumber = 4;
    private bool hasSeqId;

    private ServerNotify()
    {
    }

    public static ServerNotify DefaultInstance
    {
      get
      {
        return ServerNotify.defaultInstance;
      }
    }

    public override ServerNotify DefaultInstanceForType
    {
      get
      {
        return ServerNotify.DefaultInstance;
      }
    }

    protected override ServerNotify ThisMessage
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
        return GtReq.internal__static_com_gexin_rp_sdk_dto_ServerNotify__Descriptor;
      }
    }

    protected override FieldAccessorTable<ServerNotify, ServerNotify.Builder> InternalFieldAccessors
    {
      get
      {
        return GtReq.internal__static_com_gexin_rp_sdk_dto_ServerNotify__FieldAccessorTable;
      }
    }

    public bool HasType
    {
      get
      {
        return this.hasType;
      }
    }

    public ServerNotify.Types.NotifyType Type
    {
      get
      {
        return this.type_;
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

    public bool HasExtradata
    {
      get
      {
        return this.hasExtradata;
      }
    }

    public ByteString Extradata
    {
      get
      {
        return this.extradata_;
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
        return this.hasType;
      }
    }

    public override void WriteTo(ICodedOutputStream output)
    {
      int serializedSize = this.SerializedSize;
      string[] notifyFieldNames = ServerNotify._serverNotifyFieldNames;
      if (this.hasType)
        output.WriteEnum(1, notifyFieldNames[3], (int) this.Type, (object) this.Type);
      if (this.hasInfo)
        output.WriteString(2, notifyFieldNames[1], this.Info);
      if (this.hasExtradata)
        output.WriteBytes(3, notifyFieldNames[0], this.Extradata);
      if (this.hasSeqId)
        output.WriteString(4, notifyFieldNames[2], this.SeqId);
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
        if (this.hasType)
          num1 += CodedOutputStream.ComputeEnumSize(1, (int) this.Type);
        if (this.hasInfo)
          num1 += CodedOutputStream.ComputeStringSize(2, this.Info);
        if (this.hasExtradata)
          num1 += CodedOutputStream.ComputeBytesSize(3, this.Extradata);
        if (this.hasSeqId)
          num1 += CodedOutputStream.ComputeStringSize(4, this.SeqId);
        int num2 = num1 + this.UnknownFields.SerializedSize;
        this.memoizedSerializedSize = num2;
        return num2;
      }
    }

    public static ServerNotify ParseFrom(ByteString data)
    {
      return ServerNotify.CreateBuilder().MergeFrom(data).BuildParsed();
    }

    public static ServerNotify ParseFrom(
      ByteString data,
      ExtensionRegistry extensionRegistry)
    {
      return ServerNotify.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
    }

    public static ServerNotify ParseFrom(byte[] data)
    {
      return ServerNotify.CreateBuilder().MergeFrom(data).BuildParsed();
    }

    public static ServerNotify ParseFrom(
      byte[] data,
      ExtensionRegistry extensionRegistry)
    {
      return ServerNotify.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
    }

    public static ServerNotify ParseFrom(Stream input)
    {
      return ServerNotify.CreateBuilder().MergeFrom(input).BuildParsed();
    }

    public static ServerNotify ParseFrom(
      Stream input,
      ExtensionRegistry extensionRegistry)
    {
      return ServerNotify.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
    }

    public static ServerNotify ParseDelimitedFrom(Stream input)
    {
      return ServerNotify.CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }

    public static ServerNotify ParseDelimitedFrom(
      Stream input,
      ExtensionRegistry extensionRegistry)
    {
      return ServerNotify.CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }

    public static ServerNotify ParseFrom(ICodedInputStream input)
    {
      return ServerNotify.CreateBuilder().MergeFrom(input).BuildParsed();
    }

    public static ServerNotify ParseFrom(
      ICodedInputStream input,
      ExtensionRegistry extensionRegistry)
    {
      return ServerNotify.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
    }

    private ServerNotify MakeReadOnly()
    {
      return this;
    }

    public static ServerNotify.Builder CreateBuilder()
    {
      return new ServerNotify.Builder();
    }

    public override ServerNotify.Builder ToBuilder()
    {
      return ServerNotify.CreateBuilder(this);
    }

    public override ServerNotify.Builder CreateBuilderForType()
    {
      return new ServerNotify.Builder();
    }

    public static ServerNotify.Builder CreateBuilder(ServerNotify prototype)
    {
      return new ServerNotify.Builder(prototype);
    }

    static ServerNotify()
    {
      FileDescriptor descriptor = GtReq.Descriptor;
    }

    [DebuggerNonUserCode]
    public static class Types
    {
      public enum NotifyType
      {
        normal,
        serverListChanged,
        exception,
      }
    }

    [DebuggerNonUserCode]
    public sealed class Builder : GeneratedBuilder<ServerNotify, ServerNotify.Builder>
    {
      private bool resultIsReadOnly;
      private ServerNotify result;

      protected override ServerNotify.Builder ThisBuilder
      {
        get
        {
          return this;
        }
      }

      public Builder()
      {
        this.result = ServerNotify.DefaultInstance;
        this.resultIsReadOnly = true;
      }

      internal Builder(ServerNotify cloneFrom)
      {
        this.result = cloneFrom;
        this.resultIsReadOnly = true;
      }

      private ServerNotify PrepareBuilder()
      {
        if (this.resultIsReadOnly)
        {
          ServerNotify result = this.result;
          this.result = new ServerNotify();
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

      protected override ServerNotify MessageBeingBuilt
      {
        get
        {
          return this.PrepareBuilder();
        }
      }

      public override ServerNotify.Builder Clear()
      {
        this.result = ServerNotify.DefaultInstance;
        this.resultIsReadOnly = true;
        return this;
      }

      public override ServerNotify.Builder Clone()
      {
        if (this.resultIsReadOnly)
          return new ServerNotify.Builder(this.result);
        return new ServerNotify.Builder().MergeFrom(this.result);
      }

      public override MessageDescriptor DescriptorForType
      {
        get
        {
          return ServerNotify.Descriptor;
        }
      }

      public override ServerNotify DefaultInstanceForType
      {
        get
        {
          return ServerNotify.DefaultInstance;
        }
      }

      public override ServerNotify BuildPartial()
      {
        if (this.resultIsReadOnly)
          return this.result;
        this.resultIsReadOnly = true;
        return this.result.MakeReadOnly();
      }

      public override ServerNotify.Builder MergeFrom(IMessage other)
      {
        if (other is ServerNotify)
          return this.MergeFrom((ServerNotify) other);
        base.MergeFrom(other);
        return this;
      }

      public override ServerNotify.Builder MergeFrom(ServerNotify other)
      {
        if (other == ServerNotify.DefaultInstance)
          return this;
        this.PrepareBuilder();
        if (other.HasType)
          this.Type = other.Type;
        if (other.HasInfo)
          this.Info = other.Info;
        if (other.HasExtradata)
          this.Extradata = other.Extradata;
        if (other.HasSeqId)
          this.SeqId = other.SeqId;
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }

      public override ServerNotify.Builder MergeFrom(ICodedInputStream input)
      {
        return this.MergeFrom(input, ExtensionRegistry.Empty);
      }

      public override ServerNotify.Builder MergeFrom(
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
            int index = Array.BinarySearch<string>(ServerNotify._serverNotifyFieldNames, fieldName, (IComparer<string>) StringComparer.Ordinal);
            if (index >= 0)
            {
              fieldTag = ServerNotify._serverNotifyFieldTags[index];
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
              if (input.ReadEnum<ServerNotify.Types.NotifyType>(ref this.result.type_, out unknown))
              {
                this.result.hasType = true;
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
              this.result.hasInfo = input.ReadString(ref this.result.info_);
              continue;
            case 26:
              this.result.hasExtradata = input.ReadBytes(ref this.result.extradata_);
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

      public bool HasType
      {
        get
        {
          return this.result.hasType;
        }
      }

      public ServerNotify.Types.NotifyType Type
      {
        get
        {
          return this.result.Type;
        }
        set
        {
          this.SetType(value);
        }
      }

      public ServerNotify.Builder SetType(ServerNotify.Types.NotifyType value)
      {
        this.PrepareBuilder();
        this.result.hasType = true;
        this.result.type_ = value;
        return this;
      }

      public ServerNotify.Builder ClearType()
      {
        this.PrepareBuilder();
        this.result.hasType = false;
        this.result.type_ = ServerNotify.Types.NotifyType.normal;
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

      public ServerNotify.Builder SetInfo(string value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.hasInfo = true;
        this.result.info_ = value;
        return this;
      }

      public ServerNotify.Builder ClearInfo()
      {
        this.PrepareBuilder();
        this.result.hasInfo = false;
        this.result.info_ = "";
        return this;
      }

      public bool HasExtradata
      {
        get
        {
          return this.result.hasExtradata;
        }
      }

      public ByteString Extradata
      {
        get
        {
          return this.result.Extradata;
        }
        set
        {
          this.SetExtradata(value);
        }
      }

      public ServerNotify.Builder SetExtradata(ByteString value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.hasExtradata = true;
        this.result.extradata_ = value;
        return this;
      }

      public ServerNotify.Builder ClearExtradata()
      {
        this.PrepareBuilder();
        this.result.hasExtradata = false;
        this.result.extradata_ = ByteString.Empty;
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

      public ServerNotify.Builder SetSeqId(string value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.hasSeqId = true;
        this.result.seqId_ = value;
        return this;
      }

      public ServerNotify.Builder ClearSeqId()
      {
        this.PrepareBuilder();
        this.result.hasSeqId = false;
        this.result.seqId_ = "";
        return this;
      }
    }
  }
}
