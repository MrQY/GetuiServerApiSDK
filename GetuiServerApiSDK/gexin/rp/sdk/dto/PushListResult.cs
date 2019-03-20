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
  public sealed class PushListResult : GeneratedMessage<PushListResult, PushListResult.Builder>
  {
    private static readonly PushListResult defaultInstance = new PushListResult().MakeReadOnly();
    private static readonly string[] _pushListResultFieldNames = new string[1]
    {
      "results"
    };
    private static readonly uint[] _pushListResultFieldTags = new uint[1]
    {
      10U
    };
    private PopsicleList<PushResult> results_ = new PopsicleList<PushResult>();
    private int memoizedSerializedSize = -1;
    public const int ResultsFieldNumber = 1;

    private PushListResult()
    {
    }

    public static PushListResult DefaultInstance
    {
      get
      {
        return PushListResult.defaultInstance;
      }
    }

    public override PushListResult DefaultInstanceForType
    {
      get
      {
        return PushListResult.DefaultInstance;
      }
    }

    protected override PushListResult ThisMessage
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
        return GtReq.internal__static_com_gexin_rp_sdk_dto_PushListResult__Descriptor;
      }
    }

    protected override FieldAccessorTable<PushListResult, PushListResult.Builder> InternalFieldAccessors
    {
      get
      {
        return GtReq.internal__static_com_gexin_rp_sdk_dto_PushListResult__FieldAccessorTable;
      }
    }

    public IList<PushResult> ResultsList
    {
      get
      {
        return (IList<PushResult>) this.results_;
      }
    }

    public int ResultsCount
    {
      get
      {
        return this.results_.Count;
      }
    }

    public PushResult GetResults(int index)
    {
      return this.results_[index];
    }

    public override bool IsInitialized
    {
      get
      {
        foreach (AbstractMessageLite<PushResult, PushResult.Builder> results in (IEnumerable<PushResult>) this.ResultsList)
        {
          if (!results.IsInitialized)
            return false;
        }
        return true;
      }
    }

    public override void WriteTo(ICodedOutputStream output)
    {
      int serializedSize = this.SerializedSize;
      string[] resultFieldNames = PushListResult._pushListResultFieldNames;
      if (this.results_.Count > 0)
        output.WriteMessageArray<PushResult>(1, resultFieldNames[0], (IEnumerable<PushResult>) this.results_);
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
        foreach (PushResult results in (IEnumerable<PushResult>) this.ResultsList)
          num1 += CodedOutputStream.ComputeMessageSize(1, (IMessageLite) results);
        int num2 = num1 + this.UnknownFields.SerializedSize;
        this.memoizedSerializedSize = num2;
        return num2;
      }
    }

    public static PushListResult ParseFrom(ByteString data)
    {
      return PushListResult.CreateBuilder().MergeFrom(data).BuildParsed();
    }

    public static PushListResult ParseFrom(
      ByteString data,
      ExtensionRegistry extensionRegistry)
    {
      return PushListResult.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
    }

    public static PushListResult ParseFrom(byte[] data)
    {
      return PushListResult.CreateBuilder().MergeFrom(data).BuildParsed();
    }

    public static PushListResult ParseFrom(
      byte[] data,
      ExtensionRegistry extensionRegistry)
    {
      return PushListResult.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
    }

    public static PushListResult ParseFrom(Stream input)
    {
      return PushListResult.CreateBuilder().MergeFrom(input).BuildParsed();
    }

    public static PushListResult ParseFrom(
      Stream input,
      ExtensionRegistry extensionRegistry)
    {
      return PushListResult.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
    }

    public static PushListResult ParseDelimitedFrom(Stream input)
    {
      return PushListResult.CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }

    public static PushListResult ParseDelimitedFrom(
      Stream input,
      ExtensionRegistry extensionRegistry)
    {
      return PushListResult.CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }

    public static PushListResult ParseFrom(ICodedInputStream input)
    {
      return PushListResult.CreateBuilder().MergeFrom(input).BuildParsed();
    }

    public static PushListResult ParseFrom(
      ICodedInputStream input,
      ExtensionRegistry extensionRegistry)
    {
      return PushListResult.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
    }

    private PushListResult MakeReadOnly()
    {
      this.results_.MakeReadOnly();
      return this;
    }

    public static PushListResult.Builder CreateBuilder()
    {
      return new PushListResult.Builder();
    }

    public override PushListResult.Builder ToBuilder()
    {
      return PushListResult.CreateBuilder(this);
    }

    public override PushListResult.Builder CreateBuilderForType()
    {
      return new PushListResult.Builder();
    }

    public static PushListResult.Builder CreateBuilder(PushListResult prototype)
    {
      return new PushListResult.Builder(prototype);
    }

    static PushListResult()
    {
      FileDescriptor descriptor = GtReq.Descriptor;
    }

    [DebuggerNonUserCode]
    public sealed class Builder : GeneratedBuilder<PushListResult, PushListResult.Builder>
    {
      private bool resultIsReadOnly;
      private PushListResult result;

      protected override PushListResult.Builder ThisBuilder
      {
        get
        {
          return this;
        }
      }

      public Builder()
      {
        this.result = PushListResult.DefaultInstance;
        this.resultIsReadOnly = true;
      }

      internal Builder(PushListResult cloneFrom)
      {
        this.result = cloneFrom;
        this.resultIsReadOnly = true;
      }

      private PushListResult PrepareBuilder()
      {
        if (this.resultIsReadOnly)
        {
          PushListResult result = this.result;
          this.result = new PushListResult();
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

      protected override PushListResult MessageBeingBuilt
      {
        get
        {
          return this.PrepareBuilder();
        }
      }

      public override PushListResult.Builder Clear()
      {
        this.result = PushListResult.DefaultInstance;
        this.resultIsReadOnly = true;
        return this;
      }

      public override PushListResult.Builder Clone()
      {
        if (this.resultIsReadOnly)
          return new PushListResult.Builder(this.result);
        return new PushListResult.Builder().MergeFrom(this.result);
      }

      public override MessageDescriptor DescriptorForType
      {
        get
        {
          return PushListResult.Descriptor;
        }
      }

      public override PushListResult DefaultInstanceForType
      {
        get
        {
          return PushListResult.DefaultInstance;
        }
      }

      public override PushListResult BuildPartial()
      {
        if (this.resultIsReadOnly)
          return this.result;
        this.resultIsReadOnly = true;
        return this.result.MakeReadOnly();
      }

      public override PushListResult.Builder MergeFrom(IMessage other)
      {
        if (other is PushListResult)
          return this.MergeFrom((PushListResult) other);
        base.MergeFrom(other);
        return this;
      }

      public override PushListResult.Builder MergeFrom(PushListResult other)
      {
        if (other == PushListResult.DefaultInstance)
          return this;
        this.PrepareBuilder();
        if (other.results_.Count != 0)
          this.result.results_.Add((IEnumerable<PushResult>) other.results_);
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }

      public override PushListResult.Builder MergeFrom(ICodedInputStream input)
      {
        return this.MergeFrom(input, ExtensionRegistry.Empty);
      }

      public override PushListResult.Builder MergeFrom(
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
            int index = Array.BinarySearch<string>(PushListResult._pushListResultFieldNames, fieldName, (IComparer<string>) StringComparer.Ordinal);
            if (index >= 0)
            {
              fieldTag = PushListResult._pushListResultFieldTags[index];
            }
            else
            {
              if (unknownFields == null)
                unknownFields = UnknownFieldSet.CreateBuilder(this.UnknownFields);
              this.ParseUnknownField(input, unknownFields, extensionRegistry, fieldTag, fieldName);
              continue;
            }
          }
          if (fieldTag == 0U)
            throw InvalidProtocolBufferException.InvalidTag();
          if (fieldTag != 10U)
          {
            if (WireFormat.IsEndGroupTag(fieldTag))
            {
              if (unknownFields != null)
                this.UnknownFields = unknownFields.Build();
              return this;
            }
            if (unknownFields == null)
              unknownFields = UnknownFieldSet.CreateBuilder(this.UnknownFields);
            this.ParseUnknownField(input, unknownFields, extensionRegistry, fieldTag, fieldName);
          }
          else
            input.ReadMessageArray<PushResult>(fieldTag, fieldName, (ICollection<PushResult>) this.result.results_, PushResult.DefaultInstance, extensionRegistry);
        }
        if (unknownFields != null)
          this.UnknownFields = unknownFields.Build();
        return this;
      }

      public IPopsicleList<PushResult> ResultsList
      {
        get
        {
          return (IPopsicleList<PushResult>) this.PrepareBuilder().results_;
        }
      }

      public int ResultsCount
      {
        get
        {
          return this.result.ResultsCount;
        }
      }

      public PushResult GetResults(int index)
      {
        return this.result.GetResults(index);
      }

      public PushListResult.Builder SetResults(int index, PushResult value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.results_[index] = value;
        return this;
      }

      public PushListResult.Builder SetResults(
        int index,
        PushResult.Builder builderForValue)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) builderForValue, nameof (builderForValue));
        this.PrepareBuilder();
        this.result.results_[index] = builderForValue.Build();
        return this;
      }

      public PushListResult.Builder AddResults(PushResult value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.results_.Add(value);
        return this;
      }

      public PushListResult.Builder AddResults(PushResult.Builder builderForValue)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) builderForValue, nameof (builderForValue));
        this.PrepareBuilder();
        this.result.results_.Add(builderForValue.Build());
        return this;
      }

      public PushListResult.Builder AddRangeResults(IEnumerable<PushResult> values)
      {
        this.PrepareBuilder();
        this.result.results_.Add(values);
        return this;
      }

      public PushListResult.Builder ClearResults()
      {
        this.PrepareBuilder();
        this.result.results_.Clear();
        return this;
      }
    }
  }
}
