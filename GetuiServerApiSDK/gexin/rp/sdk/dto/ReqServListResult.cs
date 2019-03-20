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
  public sealed class ReqServListResult : GeneratedMessage<ReqServListResult, ReqServListResult.Builder>
  {
    private static readonly ReqServListResult defaultInstance = new ReqServListResult().MakeReadOnly();
    private static readonly string[] _reqServListResultFieldNames = new string[3]
    {
      "code",
      "host",
      "seqId"
    };
    private static readonly uint[] _reqServListResultFieldTags = new uint[3]
    {
      8U,
      18U,
      26U
    };
    private PopsicleList<string> host_ = new PopsicleList<string>();
    private string seqId_ = "";
    private int memoizedSerializedSize = -1;
    public const int CodeFieldNumber = 1;
    private bool hasCode;
    private int code_;
    public const int HostFieldNumber = 2;
    public const int SeqIdFieldNumber = 3;
    private bool hasSeqId;

    private ReqServListResult()
    {
    }

    public static ReqServListResult DefaultInstance
    {
      get
      {
        return ReqServListResult.defaultInstance;
      }
    }

    public override ReqServListResult DefaultInstanceForType
    {
      get
      {
        return ReqServListResult.DefaultInstance;
      }
    }

    protected override ReqServListResult ThisMessage
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
        return GtReq.internal__static_com_gexin_rp_sdk_dto_ReqServListResult__Descriptor;
      }
    }

    protected override FieldAccessorTable<ReqServListResult, ReqServListResult.Builder> InternalFieldAccessors
    {
      get
      {
        return GtReq.internal__static_com_gexin_rp_sdk_dto_ReqServListResult__FieldAccessorTable;
      }
    }

    public bool HasCode
    {
      get
      {
        return this.hasCode;
      }
    }

    public int Code
    {
      get
      {
        return this.code_;
      }
    }

    public IList<string> HostList
    {
      get
      {
        return Lists.AsReadOnly<string>((IList<string>) this.host_);
      }
    }

    public int HostCount
    {
      get
      {
        return this.host_.Count;
      }
    }

    public string GetHost(int index)
    {
      return this.host_[index];
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
        return this.hasCode;
      }
    }

    public override void WriteTo(ICodedOutputStream output)
    {
      int serializedSize = this.SerializedSize;
      string[] resultFieldNames = ReqServListResult._reqServListResultFieldNames;
      if (this.hasCode)
        output.WriteInt32(1, resultFieldNames[0], this.Code);
      if (this.host_.Count > 0)
        output.WriteStringArray(2, resultFieldNames[1], (IEnumerable<string>) this.host_);
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
        if (this.hasCode)
          num1 += CodedOutputStream.ComputeInt32Size(1, this.Code);
        int num2 = 0;
        foreach (string host in (IEnumerable<string>) this.HostList)
          num2 += CodedOutputStream.ComputeStringSizeNoTag(host);
        int num3 = num1 + num2 + this.host_.Count;
        if (this.hasSeqId)
          num3 += CodedOutputStream.ComputeStringSize(3, this.SeqId);
        int num4 = num3 + this.UnknownFields.SerializedSize;
        this.memoizedSerializedSize = num4;
        return num4;
      }
    }

    public static ReqServListResult ParseFrom(ByteString data)
    {
      return ReqServListResult.CreateBuilder().MergeFrom(data).BuildParsed();
    }

    public static ReqServListResult ParseFrom(
      ByteString data,
      ExtensionRegistry extensionRegistry)
    {
      return ReqServListResult.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
    }

    public static ReqServListResult ParseFrom(byte[] data)
    {
      return ReqServListResult.CreateBuilder().MergeFrom(data).BuildParsed();
    }

    public static ReqServListResult ParseFrom(
      byte[] data,
      ExtensionRegistry extensionRegistry)
    {
      return ReqServListResult.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
    }

    public static ReqServListResult ParseFrom(Stream input)
    {
      return ReqServListResult.CreateBuilder().MergeFrom(input).BuildParsed();
    }

    public static ReqServListResult ParseFrom(
      Stream input,
      ExtensionRegistry extensionRegistry)
    {
      return ReqServListResult.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
    }

    public static ReqServListResult ParseDelimitedFrom(Stream input)
    {
      return ReqServListResult.CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }

    public static ReqServListResult ParseDelimitedFrom(
      Stream input,
      ExtensionRegistry extensionRegistry)
    {
      return ReqServListResult.CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }

    public static ReqServListResult ParseFrom(ICodedInputStream input)
    {
      return ReqServListResult.CreateBuilder().MergeFrom(input).BuildParsed();
    }

    public static ReqServListResult ParseFrom(
      ICodedInputStream input,
      ExtensionRegistry extensionRegistry)
    {
      return ReqServListResult.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
    }

    private ReqServListResult MakeReadOnly()
    {
      this.host_.MakeReadOnly();
      return this;
    }

    public static ReqServListResult.Builder CreateBuilder()
    {
      return new ReqServListResult.Builder();
    }

    public override ReqServListResult.Builder ToBuilder()
    {
      return ReqServListResult.CreateBuilder(this);
    }

    public override ReqServListResult.Builder CreateBuilderForType()
    {
      return new ReqServListResult.Builder();
    }

    public static ReqServListResult.Builder CreateBuilder(
      ReqServListResult prototype)
    {
      return new ReqServListResult.Builder(prototype);
    }

    static ReqServListResult()
    {
      FileDescriptor descriptor = GtReq.Descriptor;
    }

    [DebuggerNonUserCode]
    public static class Types
    {
      public enum ReqServHostResultCode
      {
        successed,
        failed,
        busy,
      }
    }

    [DebuggerNonUserCode]
    public sealed class Builder : GeneratedBuilder<ReqServListResult, ReqServListResult.Builder>
    {
      private bool resultIsReadOnly;
      private ReqServListResult result;

      protected override ReqServListResult.Builder ThisBuilder
      {
        get
        {
          return this;
        }
      }

      public Builder()
      {
        this.result = ReqServListResult.DefaultInstance;
        this.resultIsReadOnly = true;
      }

      internal Builder(ReqServListResult cloneFrom)
      {
        this.result = cloneFrom;
        this.resultIsReadOnly = true;
      }

      private ReqServListResult PrepareBuilder()
      {
        if (this.resultIsReadOnly)
        {
          ReqServListResult result = this.result;
          this.result = new ReqServListResult();
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

      protected override ReqServListResult MessageBeingBuilt
      {
        get
        {
          return this.PrepareBuilder();
        }
      }

      public override ReqServListResult.Builder Clear()
      {
        this.result = ReqServListResult.DefaultInstance;
        this.resultIsReadOnly = true;
        return this;
      }

      public override ReqServListResult.Builder Clone()
      {
        if (this.resultIsReadOnly)
          return new ReqServListResult.Builder(this.result);
        return new ReqServListResult.Builder().MergeFrom(this.result);
      }

      public override MessageDescriptor DescriptorForType
      {
        get
        {
          return ReqServListResult.Descriptor;
        }
      }

      public override ReqServListResult DefaultInstanceForType
      {
        get
        {
          return ReqServListResult.DefaultInstance;
        }
      }

      public override ReqServListResult BuildPartial()
      {
        if (this.resultIsReadOnly)
          return this.result;
        this.resultIsReadOnly = true;
        return this.result.MakeReadOnly();
      }

      public override ReqServListResult.Builder MergeFrom(IMessage other)
      {
        if (other is ReqServListResult)
          return this.MergeFrom((ReqServListResult) other);
        base.MergeFrom(other);
        return this;
      }

      public override ReqServListResult.Builder MergeFrom(ReqServListResult other)
      {
        if (other == ReqServListResult.DefaultInstance)
          return this;
        this.PrepareBuilder();
        if (other.HasCode)
          this.Code = other.Code;
        if (other.host_.Count != 0)
          this.result.host_.Add((IEnumerable<string>) other.host_);
        if (other.HasSeqId)
          this.SeqId = other.SeqId;
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }

      public override ReqServListResult.Builder MergeFrom(ICodedInputStream input)
      {
        return this.MergeFrom(input, ExtensionRegistry.Empty);
      }

      public override ReqServListResult.Builder MergeFrom(
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
            int index = Array.BinarySearch<string>(ReqServListResult._reqServListResultFieldNames, fieldName, (IComparer<string>) StringComparer.Ordinal);
            if (index >= 0)
            {
              fieldTag = ReqServListResult._reqServListResultFieldTags[index];
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
              this.result.hasCode = input.ReadInt32(ref this.result.code_);
              continue;
            case 18:
              input.ReadStringArray(fieldTag, fieldName, (ICollection<string>) this.result.host_);
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

      public bool HasCode
      {
        get
        {
          return this.result.hasCode;
        }
      }

      public int Code
      {
        get
        {
          return this.result.Code;
        }
        set
        {
          this.SetCode(value);
        }
      }

      public ReqServListResult.Builder SetCode(int value)
      {
        this.PrepareBuilder();
        this.result.hasCode = true;
        this.result.code_ = value;
        return this;
      }

      public ReqServListResult.Builder ClearCode()
      {
        this.PrepareBuilder();
        this.result.hasCode = false;
        this.result.code_ = 0;
        return this;
      }

      public IPopsicleList<string> HostList
      {
        get
        {
          return (IPopsicleList<string>) this.PrepareBuilder().host_;
        }
      }

      public int HostCount
      {
        get
        {
          return this.result.HostCount;
        }
      }

      public string GetHost(int index)
      {
        return this.result.GetHost(index);
      }

      public ReqServListResult.Builder SetHost(int index, string value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.host_[index] = value;
        return this;
      }

      public ReqServListResult.Builder AddHost(string value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.host_.Add(value);
        return this;
      }

      public ReqServListResult.Builder AddRangeHost(IEnumerable<string> values)
      {
        this.PrepareBuilder();
        this.result.host_.Add(values);
        return this;
      }

      public ReqServListResult.Builder ClearHost()
      {
        this.PrepareBuilder();
        this.result.host_.Clear();
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

      public ReqServListResult.Builder SetSeqId(string value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.hasSeqId = true;
        this.result.seqId_ = value;
        return this;
      }

      public ReqServListResult.Builder ClearSeqId()
      {
        this.PrepareBuilder();
        this.result.hasSeqId = false;
        this.result.seqId_ = "";
        return this;
      }
    }
  }
}
