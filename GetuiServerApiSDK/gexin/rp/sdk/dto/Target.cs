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
  public sealed class Target : GeneratedMessage<Target, Target.Builder>
  {
    private static readonly Target defaultInstance = new Target().MakeReadOnly();
    private static readonly string[] _targetFieldNames = new string[3]
    {
      "alias",
      "appId",
      "clientId"
    };
    private static readonly uint[] _targetFieldTags = new uint[3]
    {
      26U,
      10U,
      18U
    };
    private string appId_ = "";
    private string clientId_ = "";
    private string alias_ = "";
    private int memoizedSerializedSize = -1;
    public const int AppIdFieldNumber = 1;
    private bool hasAppId;
    public const int ClientIdFieldNumber = 2;
    private bool hasClientId;
    public const int AliasFieldNumber = 3;
    private bool hasAlias;

    private Target()
    {
    }

    public static Target DefaultInstance
    {
      get
      {
        return Target.defaultInstance;
      }
    }

    public override Target DefaultInstanceForType
    {
      get
      {
        return Target.DefaultInstance;
      }
    }

    protected override Target ThisMessage
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
        return GtReq.internal__static_com_gexin_rp_sdk_dto_Target__Descriptor;
      }
    }

    protected override FieldAccessorTable<Target, Target.Builder> InternalFieldAccessors
    {
      get
      {
        return GtReq.internal__static_com_gexin_rp_sdk_dto_Target__FieldAccessorTable;
      }
    }

    public bool HasAppId
    {
      get
      {
        return this.hasAppId;
      }
    }

    public string AppId
    {
      get
      {
        return this.appId_;
      }
    }

    public bool HasClientId
    {
      get
      {
        return this.hasClientId;
      }
    }

    public string ClientId
    {
      get
      {
        return this.clientId_;
      }
    }

    public bool HasAlias
    {
      get
      {
        return this.hasAlias;
      }
    }

    public string Alias
    {
      get
      {
        return this.alias_;
      }
    }

    public override bool IsInitialized
    {
      get
      {
        return this.hasAppId && this.hasClientId;
      }
    }

    public override void WriteTo(ICodedOutputStream output)
    {
      int serializedSize = this.SerializedSize;
      string[] targetFieldNames = Target._targetFieldNames;
      if (this.hasAppId)
        output.WriteString(1, targetFieldNames[1], this.AppId);
      if (this.hasClientId)
        output.WriteString(2, targetFieldNames[2], this.ClientId);
      if (this.hasAlias)
        output.WriteString(3, targetFieldNames[0], this.Alias);
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
        if (this.hasAppId)
          num1 += CodedOutputStream.ComputeStringSize(1, this.AppId);
        if (this.hasClientId)
          num1 += CodedOutputStream.ComputeStringSize(2, this.ClientId);
        if (this.hasAlias)
          num1 += CodedOutputStream.ComputeStringSize(3, this.Alias);
        int num2 = num1 + this.UnknownFields.SerializedSize;
        this.memoizedSerializedSize = num2;
        return num2;
      }
    }

    public static Target ParseFrom(ByteString data)
    {
      return Target.CreateBuilder().MergeFrom(data).BuildParsed();
    }

    public static Target ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
    {
      return Target.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
    }

    public static Target ParseFrom(byte[] data)
    {
      return Target.CreateBuilder().MergeFrom(data).BuildParsed();
    }

    public static Target ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
    {
      return Target.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
    }

    public static Target ParseFrom(Stream input)
    {
      return Target.CreateBuilder().MergeFrom(input).BuildParsed();
    }

    public static Target ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
    {
      return Target.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
    }

    public static Target ParseDelimitedFrom(Stream input)
    {
      return Target.CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }

    public static Target ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
    {
      return Target.CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }

    public static Target ParseFrom(ICodedInputStream input)
    {
      return Target.CreateBuilder().MergeFrom(input).BuildParsed();
    }

    public static Target ParseFrom(
      ICodedInputStream input,
      ExtensionRegistry extensionRegistry)
    {
      return Target.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
    }

    private Target MakeReadOnly()
    {
      return this;
    }

    public static Target.Builder CreateBuilder()
    {
      return new Target.Builder();
    }

    public override Target.Builder ToBuilder()
    {
      return Target.CreateBuilder(this);
    }

    public override Target.Builder CreateBuilderForType()
    {
      return new Target.Builder();
    }

    public static Target.Builder CreateBuilder(Target prototype)
    {
      return new Target.Builder(prototype);
    }

    static Target()
    {
      FileDescriptor descriptor = GtReq.Descriptor;
    }

    [DebuggerNonUserCode]
    public sealed class Builder : GeneratedBuilder<Target, Target.Builder>
    {
      private bool resultIsReadOnly;
      private Target result;

      protected override Target.Builder ThisBuilder
      {
        get
        {
          return this;
        }
      }

      public Builder()
      {
        this.result = Target.DefaultInstance;
        this.resultIsReadOnly = true;
      }

      internal Builder(Target cloneFrom)
      {
        this.result = cloneFrom;
        this.resultIsReadOnly = true;
      }

      private Target PrepareBuilder()
      {
        if (this.resultIsReadOnly)
        {
          Target result = this.result;
          this.result = new Target();
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

      protected override Target MessageBeingBuilt
      {
        get
        {
          return this.PrepareBuilder();
        }
      }

      public override Target.Builder Clear()
      {
        this.result = Target.DefaultInstance;
        this.resultIsReadOnly = true;
        return this;
      }

      public override Target.Builder Clone()
      {
        if (this.resultIsReadOnly)
          return new Target.Builder(this.result);
        return new Target.Builder().MergeFrom(this.result);
      }

      public override MessageDescriptor DescriptorForType
      {
        get
        {
          return Target.Descriptor;
        }
      }

      public override Target DefaultInstanceForType
      {
        get
        {
          return Target.DefaultInstance;
        }
      }

      public override Target BuildPartial()
      {
        if (this.resultIsReadOnly)
          return this.result;
        this.resultIsReadOnly = true;
        return this.result.MakeReadOnly();
      }

      public override Target.Builder MergeFrom(IMessage other)
      {
        if (other is Target)
          return this.MergeFrom((Target) other);
        base.MergeFrom(other);
        return this;
      }

      public override Target.Builder MergeFrom(Target other)
      {
        if (other == Target.DefaultInstance)
          return this;
        this.PrepareBuilder();
        if (other.HasAppId)
          this.AppId = other.AppId;
        if (other.HasClientId)
          this.ClientId = other.ClientId;
        if (other.HasAlias)
          this.Alias = other.Alias;
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }

      public override Target.Builder MergeFrom(ICodedInputStream input)
      {
        return this.MergeFrom(input, ExtensionRegistry.Empty);
      }

      public override Target.Builder MergeFrom(
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
            int index = Array.BinarySearch<string>(Target._targetFieldNames, fieldName, (IComparer<string>) StringComparer.Ordinal);
            if (index >= 0)
            {
              fieldTag = Target._targetFieldTags[index];
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
              this.result.hasAppId = input.ReadString(ref this.result.appId_);
              continue;
            case 18:
              this.result.hasClientId = input.ReadString(ref this.result.clientId_);
              continue;
            case 26:
              this.result.hasAlias = input.ReadString(ref this.result.alias_);
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

      public bool HasAppId
      {
        get
        {
          return this.result.hasAppId;
        }
      }

      public string AppId
      {
        get
        {
          return this.result.AppId;
        }
        set
        {
          this.SetAppId(value);
        }
      }

      public Target.Builder SetAppId(string value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.hasAppId = true;
        this.result.appId_ = value;
        return this;
      }

      public Target.Builder ClearAppId()
      {
        this.PrepareBuilder();
        this.result.hasAppId = false;
        this.result.appId_ = "";
        return this;
      }

      public bool HasClientId
      {
        get
        {
          return this.result.hasClientId;
        }
      }

      public string ClientId
      {
        get
        {
          return this.result.ClientId;
        }
        set
        {
          this.SetClientId(value);
        }
      }

      public Target.Builder SetClientId(string value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.hasClientId = true;
        this.result.clientId_ = value;
        return this;
      }

      public Target.Builder ClearClientId()
      {
        this.PrepareBuilder();
        this.result.hasClientId = false;
        this.result.clientId_ = "";
        return this;
      }

      public bool HasAlias
      {
        get
        {
          return this.result.hasAlias;
        }
      }

      public string Alias
      {
        get
        {
          return this.result.Alias;
        }
        set
        {
          this.SetAlias(value);
        }
      }

      public Target.Builder SetAlias(string value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.hasAlias = true;
        this.result.alias_ = value;
        return this;
      }

      public Target.Builder ClearAlias()
      {
        this.PrepareBuilder();
        this.result.hasAlias = false;
        this.result.alias_ = "";
        return this;
      }
    }
  }
}
