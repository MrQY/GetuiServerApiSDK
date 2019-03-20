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
  public sealed class SmsContentEntry : GeneratedMessage<SmsContentEntry, SmsContentEntry.Builder>
  {
    private static readonly SmsContentEntry defaultInstance = new SmsContentEntry().MakeReadOnly();
    private static readonly string[] _smsContentEntryFieldNames = new string[2]
    {
      "key",
      "value"
    };
    private static readonly uint[] _smsContentEntryFieldTags = new uint[2]
    {
      10U,
      18U
    };
    private string key_ = "";
    private string value_ = "";
    private int memoizedSerializedSize = -1;
    public const int KeyFieldNumber = 1;
    private bool hasKey;
    public const int ValueFieldNumber = 2;
    private bool hasValue;

    private SmsContentEntry()
    {
    }

    public static SmsContentEntry DefaultInstance
    {
      get
      {
        return SmsContentEntry.defaultInstance;
      }
    }

    public override SmsContentEntry DefaultInstanceForType
    {
      get
      {
        return SmsContentEntry.DefaultInstance;
      }
    }

    protected override SmsContentEntry ThisMessage
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
        return GtReq.internal__static_com_gexin_rp_sdk_dto_SmsContentEntry__Descriptor;
      }
    }

    protected override FieldAccessorTable<SmsContentEntry, SmsContentEntry.Builder> InternalFieldAccessors
    {
      get
      {
        return GtReq.internal__static_com_gexin_rp_sdk_dto_SmsContentEntry__FieldAccessorTable;
      }
    }

    public bool HasKey
    {
      get
      {
        return this.hasKey;
      }
    }

    public string Key
    {
      get
      {
        return this.key_;
      }
    }

    public bool HasValue
    {
      get
      {
        return this.hasValue;
      }
    }

    public string Value
    {
      get
      {
        return this.value_;
      }
    }

    public override bool IsInitialized
    {
      get
      {
        return this.hasKey && this.hasValue;
      }
    }

    public override void WriteTo(ICodedOutputStream output)
    {
      int serializedSize = this.SerializedSize;
      string[] contentEntryFieldNames = SmsContentEntry._smsContentEntryFieldNames;
      if (this.hasKey)
        output.WriteString(1, contentEntryFieldNames[0], this.Key);
      if (this.hasValue)
        output.WriteString(2, contentEntryFieldNames[1], this.Value);
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
        if (this.hasKey)
          num1 += CodedOutputStream.ComputeStringSize(1, this.Key);
        if (this.hasValue)
          num1 += CodedOutputStream.ComputeStringSize(2, this.Value);
        int num2 = num1 + this.UnknownFields.SerializedSize;
        this.memoizedSerializedSize = num2;
        return num2;
      }
    }

    public static SmsContentEntry ParseFrom(ByteString data)
    {
      return SmsContentEntry.CreateBuilder().MergeFrom(data).BuildParsed();
    }

    public static SmsContentEntry ParseFrom(
      ByteString data,
      ExtensionRegistry extensionRegistry)
    {
      return SmsContentEntry.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
    }

    public static SmsContentEntry ParseFrom(byte[] data)
    {
      return SmsContentEntry.CreateBuilder().MergeFrom(data).BuildParsed();
    }

    public static SmsContentEntry ParseFrom(
      byte[] data,
      ExtensionRegistry extensionRegistry)
    {
      return SmsContentEntry.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
    }

    public static SmsContentEntry ParseFrom(Stream input)
    {
      return SmsContentEntry.CreateBuilder().MergeFrom(input).BuildParsed();
    }

    public static SmsContentEntry ParseFrom(
      Stream input,
      ExtensionRegistry extensionRegistry)
    {
      return SmsContentEntry.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
    }

    public static SmsContentEntry ParseDelimitedFrom(Stream input)
    {
      return SmsContentEntry.CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }

    public static SmsContentEntry ParseDelimitedFrom(
      Stream input,
      ExtensionRegistry extensionRegistry)
    {
      return SmsContentEntry.CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }

    public static SmsContentEntry ParseFrom(ICodedInputStream input)
    {
      return SmsContentEntry.CreateBuilder().MergeFrom(input).BuildParsed();
    }

    public static SmsContentEntry ParseFrom(
      ICodedInputStream input,
      ExtensionRegistry extensionRegistry)
    {
      return SmsContentEntry.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
    }

    private SmsContentEntry MakeReadOnly()
    {
      return this;
    }

    public static SmsContentEntry.Builder CreateBuilder()
    {
      return new SmsContentEntry.Builder();
    }

    public override SmsContentEntry.Builder ToBuilder()
    {
      return SmsContentEntry.CreateBuilder(this);
    }

    public override SmsContentEntry.Builder CreateBuilderForType()
    {
      return new SmsContentEntry.Builder();
    }

    public static SmsContentEntry.Builder CreateBuilder(SmsContentEntry prototype)
    {
      return new SmsContentEntry.Builder(prototype);
    }

    static SmsContentEntry()
    {
      FileDescriptor descriptor = GtReq.Descriptor;
    }

    [DebuggerNonUserCode]
    public sealed class Builder : GeneratedBuilder<SmsContentEntry, SmsContentEntry.Builder>
    {
      private bool resultIsReadOnly;
      private SmsContentEntry result;

      protected override SmsContentEntry.Builder ThisBuilder
      {
        get
        {
          return this;
        }
      }

      public Builder()
      {
        this.result = SmsContentEntry.DefaultInstance;
        this.resultIsReadOnly = true;
      }

      internal Builder(SmsContentEntry cloneFrom)
      {
        this.result = cloneFrom;
        this.resultIsReadOnly = true;
      }

      private SmsContentEntry PrepareBuilder()
      {
        if (this.resultIsReadOnly)
        {
          SmsContentEntry result = this.result;
          this.result = new SmsContentEntry();
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

      protected override SmsContentEntry MessageBeingBuilt
      {
        get
        {
          return this.PrepareBuilder();
        }
      }

      public override SmsContentEntry.Builder Clear()
      {
        this.result = SmsContentEntry.DefaultInstance;
        this.resultIsReadOnly = true;
        return this;
      }

      public override SmsContentEntry.Builder Clone()
      {
        if (this.resultIsReadOnly)
          return new SmsContentEntry.Builder(this.result);
        return new SmsContentEntry.Builder().MergeFrom(this.result);
      }

      public override MessageDescriptor DescriptorForType
      {
        get
        {
          return SmsContentEntry.Descriptor;
        }
      }

      public override SmsContentEntry DefaultInstanceForType
      {
        get
        {
          return SmsContentEntry.DefaultInstance;
        }
      }

      public override SmsContentEntry BuildPartial()
      {
        if (this.resultIsReadOnly)
          return this.result;
        this.resultIsReadOnly = true;
        return this.result.MakeReadOnly();
      }

      public override SmsContentEntry.Builder MergeFrom(IMessage other)
      {
        if (other is SmsContentEntry)
          return this.MergeFrom((SmsContentEntry) other);
        base.MergeFrom(other);
        return this;
      }

      public override SmsContentEntry.Builder MergeFrom(SmsContentEntry other)
      {
        if (other == SmsContentEntry.DefaultInstance)
          return this;
        this.PrepareBuilder();
        if (other.HasKey)
          this.Key = other.Key;
        if (other.HasValue)
          this.Value = other.Value;
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }

      public override SmsContentEntry.Builder MergeFrom(ICodedInputStream input)
      {
        return this.MergeFrom(input, ExtensionRegistry.Empty);
      }

      public override SmsContentEntry.Builder MergeFrom(
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
            int index = Array.BinarySearch<string>(SmsContentEntry._smsContentEntryFieldNames, fieldName, (IComparer<string>) StringComparer.Ordinal);
            if (index >= 0)
            {
              fieldTag = SmsContentEntry._smsContentEntryFieldTags[index];
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
              this.result.hasKey = input.ReadString(ref this.result.key_);
              continue;
            case 18:
              this.result.hasValue = input.ReadString(ref this.result.value_);
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

      public bool HasKey
      {
        get
        {
          return this.result.hasKey;
        }
      }

      public string Key
      {
        get
        {
          return this.result.Key;
        }
        set
        {
          this.SetKey(value);
        }
      }

      public SmsContentEntry.Builder SetKey(string value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.hasKey = true;
        this.result.key_ = value;
        return this;
      }

      public SmsContentEntry.Builder ClearKey()
      {
        this.PrepareBuilder();
        this.result.hasKey = false;
        this.result.key_ = "";
        return this;
      }

      public bool HasValue
      {
        get
        {
          return this.result.hasValue;
        }
      }

      public string Value
      {
        get
        {
          return this.result.Value;
        }
        set
        {
          this.SetValue(value);
        }
      }

      public SmsContentEntry.Builder SetValue(string value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.hasValue = true;
        this.result.value_ = value;
        return this;
      }

      public SmsContentEntry.Builder ClearValue()
      {
        this.PrepareBuilder();
        this.result.hasValue = false;
        this.result.value_ = "";
        return this;
      }
    }
  }
}
