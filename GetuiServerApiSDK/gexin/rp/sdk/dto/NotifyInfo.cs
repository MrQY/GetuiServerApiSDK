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
  public sealed class NotifyInfo : GeneratedMessage<NotifyInfo, NotifyInfo.Builder>
  {
    private static readonly NotifyInfo defaultInstance = new NotifyInfo().MakeReadOnly();
    private static readonly string[] _notifyInfoFieldNames = new string[7]
    {
      "content",
      "intent",
      "notifyId",
      "payload",
      "title",
      "type",
      "url"
    };
    private static readonly uint[] _notifyInfoFieldTags = new uint[7]
    {
      18U,
      34U,
      58U,
      26U,
      10U,
      48U,
      42U
    };
    private string title_ = "";
    private string content_ = "";
    private string payload_ = "";
    private string intent_ = "";
    private string url_ = "";
    private string notifyId_ = "";
    private int memoizedSerializedSize = -1;
    public const int TitleFieldNumber = 1;
    private bool hasTitle;
    public const int ContentFieldNumber = 2;
    private bool hasContent;
    public const int PayloadFieldNumber = 3;
    private bool hasPayload;
    public const int IntentFieldNumber = 4;
    private bool hasIntent;
    public const int UrlFieldNumber = 5;
    private bool hasUrl;
    public const int TypeFieldNumber = 6;
    private bool hasType;
    private NotifyInfo.Types.Type type_;
    public const int NotifyIdFieldNumber = 7;
    private bool hasNotifyId;

    private NotifyInfo()
    {
    }

    public static NotifyInfo DefaultInstance
    {
      get
      {
        return NotifyInfo.defaultInstance;
      }
    }

    public override NotifyInfo DefaultInstanceForType
    {
      get
      {
        return NotifyInfo.DefaultInstance;
      }
    }

    protected override NotifyInfo ThisMessage
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
        return GtReq.internal__static_com_gexin_rp_sdk_dto_NotifyInfo__Descriptor;
      }
    }

    protected override FieldAccessorTable<NotifyInfo, NotifyInfo.Builder> InternalFieldAccessors
    {
      get
      {
        return GtReq.internal__static_com_gexin_rp_sdk_dto_NotifyInfo__FieldAccessorTable;
      }
    }

    public bool HasTitle
    {
      get
      {
        return this.hasTitle;
      }
    }

    public string Title
    {
      get
      {
        return this.title_;
      }
    }

    public bool HasContent
    {
      get
      {
        return this.hasContent;
      }
    }

    public string Content
    {
      get
      {
        return this.content_;
      }
    }

    public bool HasPayload
    {
      get
      {
        return this.hasPayload;
      }
    }

    public string Payload
    {
      get
      {
        return this.payload_;
      }
    }

    public bool HasIntent
    {
      get
      {
        return this.hasIntent;
      }
    }

    public string Intent
    {
      get
      {
        return this.intent_;
      }
    }

    public bool HasUrl
    {
      get
      {
        return this.hasUrl;
      }
    }

    public string Url
    {
      get
      {
        return this.url_;
      }
    }

    public bool HasType
    {
      get
      {
        return this.hasType;
      }
    }

    public NotifyInfo.Types.Type Type
    {
      get
      {
        return this.type_;
      }
    }

    public bool HasNotifyId
    {
      get
      {
        return this.hasNotifyId;
      }
    }

    public string NotifyId
    {
      get
      {
        return this.notifyId_;
      }
    }

    public override bool IsInitialized
    {
      get
      {
        return this.hasTitle && this.hasContent;
      }
    }

    public override void WriteTo(ICodedOutputStream output)
    {
      int serializedSize = this.SerializedSize;
      string[] notifyInfoFieldNames = NotifyInfo._notifyInfoFieldNames;
      if (this.hasTitle)
        output.WriteString(1, notifyInfoFieldNames[4], this.Title);
      if (this.hasContent)
        output.WriteString(2, notifyInfoFieldNames[0], this.Content);
      if (this.hasPayload)
        output.WriteString(3, notifyInfoFieldNames[3], this.Payload);
      if (this.hasIntent)
        output.WriteString(4, notifyInfoFieldNames[1], this.Intent);
      if (this.hasUrl)
        output.WriteString(5, notifyInfoFieldNames[6], this.Url);
      if (this.hasType)
        output.WriteEnum(6, notifyInfoFieldNames[5], (int) this.Type, (object) this.Type);
      if (this.hasNotifyId)
        output.WriteString(7, notifyInfoFieldNames[2], this.NotifyId);
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
        if (this.hasTitle)
          num1 += CodedOutputStream.ComputeStringSize(1, this.Title);
        if (this.hasContent)
          num1 += CodedOutputStream.ComputeStringSize(2, this.Content);
        if (this.hasPayload)
          num1 += CodedOutputStream.ComputeStringSize(3, this.Payload);
        if (this.hasIntent)
          num1 += CodedOutputStream.ComputeStringSize(4, this.Intent);
        if (this.hasUrl)
          num1 += CodedOutputStream.ComputeStringSize(5, this.Url);
        if (this.hasType)
          num1 += CodedOutputStream.ComputeEnumSize(6, (int) this.Type);
        if (this.hasNotifyId)
          num1 += CodedOutputStream.ComputeStringSize(7, this.NotifyId);
        int num2 = num1 + this.UnknownFields.SerializedSize;
        this.memoizedSerializedSize = num2;
        return num2;
      }
    }

    public static NotifyInfo ParseFrom(ByteString data)
    {
      return NotifyInfo.CreateBuilder().MergeFrom(data).BuildParsed();
    }

    public static NotifyInfo ParseFrom(
      ByteString data,
      ExtensionRegistry extensionRegistry)
    {
      return NotifyInfo.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
    }

    public static NotifyInfo ParseFrom(byte[] data)
    {
      return NotifyInfo.CreateBuilder().MergeFrom(data).BuildParsed();
    }

    public static NotifyInfo ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
    {
      return NotifyInfo.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
    }

    public static NotifyInfo ParseFrom(Stream input)
    {
      return NotifyInfo.CreateBuilder().MergeFrom(input).BuildParsed();
    }

    public static NotifyInfo ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
    {
      return NotifyInfo.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
    }

    public static NotifyInfo ParseDelimitedFrom(Stream input)
    {
      return NotifyInfo.CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }

    public static NotifyInfo ParseDelimitedFrom(
      Stream input,
      ExtensionRegistry extensionRegistry)
    {
      return NotifyInfo.CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }

    public static NotifyInfo ParseFrom(ICodedInputStream input)
    {
      return NotifyInfo.CreateBuilder().MergeFrom(input).BuildParsed();
    }

    public static NotifyInfo ParseFrom(
      ICodedInputStream input,
      ExtensionRegistry extensionRegistry)
    {
      return NotifyInfo.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
    }

    private NotifyInfo MakeReadOnly()
    {
      return this;
    }

    public static NotifyInfo.Builder CreateBuilder()
    {
      return new NotifyInfo.Builder();
    }

    public override NotifyInfo.Builder ToBuilder()
    {
      return NotifyInfo.CreateBuilder(this);
    }

    public override NotifyInfo.Builder CreateBuilderForType()
    {
      return new NotifyInfo.Builder();
    }

    public static NotifyInfo.Builder CreateBuilder(NotifyInfo prototype)
    {
      return new NotifyInfo.Builder(prototype);
    }

    static NotifyInfo()
    {
      FileDescriptor descriptor = GtReq.Descriptor;
    }

    [DebuggerNonUserCode]
    public static class Types
    {
      public enum Type
      {
        _payload,
        _intent,
        _url,
      }
    }

    [DebuggerNonUserCode]
    public sealed class Builder : GeneratedBuilder<NotifyInfo, NotifyInfo.Builder>
    {
      private bool resultIsReadOnly;
      private NotifyInfo result;

      protected override NotifyInfo.Builder ThisBuilder
      {
        get
        {
          return this;
        }
      }

      public Builder()
      {
        this.result = NotifyInfo.DefaultInstance;
        this.resultIsReadOnly = true;
      }

      internal Builder(NotifyInfo cloneFrom)
      {
        this.result = cloneFrom;
        this.resultIsReadOnly = true;
      }

      private NotifyInfo PrepareBuilder()
      {
        if (this.resultIsReadOnly)
        {
          NotifyInfo result = this.result;
          this.result = new NotifyInfo();
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

      protected override NotifyInfo MessageBeingBuilt
      {
        get
        {
          return this.PrepareBuilder();
        }
      }

      public override NotifyInfo.Builder Clear()
      {
        this.result = NotifyInfo.DefaultInstance;
        this.resultIsReadOnly = true;
        return this;
      }

      public override NotifyInfo.Builder Clone()
      {
        if (this.resultIsReadOnly)
          return new NotifyInfo.Builder(this.result);
        return new NotifyInfo.Builder().MergeFrom(this.result);
      }

      public override MessageDescriptor DescriptorForType
      {
        get
        {
          return NotifyInfo.Descriptor;
        }
      }

      public override NotifyInfo DefaultInstanceForType
      {
        get
        {
          return NotifyInfo.DefaultInstance;
        }
      }

      public override NotifyInfo BuildPartial()
      {
        if (this.resultIsReadOnly)
          return this.result;
        this.resultIsReadOnly = true;
        return this.result.MakeReadOnly();
      }

      public override NotifyInfo.Builder MergeFrom(IMessage other)
      {
        if (other is NotifyInfo)
          return this.MergeFrom((NotifyInfo) other);
        base.MergeFrom(other);
        return this;
      }

      public override NotifyInfo.Builder MergeFrom(NotifyInfo other)
      {
        if (other == NotifyInfo.DefaultInstance)
          return this;
        this.PrepareBuilder();
        if (other.HasTitle)
          this.Title = other.Title;
        if (other.HasContent)
          this.Content = other.Content;
        if (other.HasPayload)
          this.Payload = other.Payload;
        if (other.HasIntent)
          this.Intent = other.Intent;
        if (other.HasUrl)
          this.Url = other.Url;
        if (other.HasType)
          this.Type = other.Type;
        if (other.HasNotifyId)
          this.NotifyId = other.NotifyId;
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }

      public override NotifyInfo.Builder MergeFrom(ICodedInputStream input)
      {
        return this.MergeFrom(input, ExtensionRegistry.Empty);
      }

      public override NotifyInfo.Builder MergeFrom(
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
            int index = Array.BinarySearch<string>(NotifyInfo._notifyInfoFieldNames, fieldName, (IComparer<string>) StringComparer.Ordinal);
            if (index >= 0)
            {
              fieldTag = NotifyInfo._notifyInfoFieldTags[index];
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
              this.result.hasTitle = input.ReadString(ref this.result.title_);
              continue;
            case 18:
              this.result.hasContent = input.ReadString(ref this.result.content_);
              continue;
            case 26:
              this.result.hasPayload = input.ReadString(ref this.result.payload_);
              continue;
            case 34:
              this.result.hasIntent = input.ReadString(ref this.result.intent_);
              continue;
            case 42:
              this.result.hasUrl = input.ReadString(ref this.result.url_);
              continue;
            case 48:
              object unknown;
              if (input.ReadEnum<NotifyInfo.Types.Type>(ref this.result.type_, out unknown))
              {
                this.result.hasType = true;
                continue;
              }
              if (unknown is int)
              {
                if (unknownFields == null)
                  unknownFields = UnknownFieldSet.CreateBuilder(this.UnknownFields);
                unknownFields.MergeVarintField(6, (ulong) (int) unknown);
                continue;
              }
              continue;
            case 58:
              this.result.hasNotifyId = input.ReadString(ref this.result.notifyId_);
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

      public bool HasTitle
      {
        get
        {
          return this.result.hasTitle;
        }
      }

      public string Title
      {
        get
        {
          return this.result.Title;
        }
        set
        {
          this.SetTitle(value);
        }
      }

      public NotifyInfo.Builder SetTitle(string value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.hasTitle = true;
        this.result.title_ = value;
        return this;
      }

      public NotifyInfo.Builder ClearTitle()
      {
        this.PrepareBuilder();
        this.result.hasTitle = false;
        this.result.title_ = "";
        return this;
      }

      public bool HasContent
      {
        get
        {
          return this.result.hasContent;
        }
      }

      public string Content
      {
        get
        {
          return this.result.Content;
        }
        set
        {
          this.SetContent(value);
        }
      }

      public NotifyInfo.Builder SetContent(string value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.hasContent = true;
        this.result.content_ = value;
        return this;
      }

      public NotifyInfo.Builder ClearContent()
      {
        this.PrepareBuilder();
        this.result.hasContent = false;
        this.result.content_ = "";
        return this;
      }

      public bool HasPayload
      {
        get
        {
          return this.result.hasPayload;
        }
      }

      public string Payload
      {
        get
        {
          return this.result.Payload;
        }
        set
        {
          this.SetPayload(value);
        }
      }

      public NotifyInfo.Builder SetPayload(string value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.hasPayload = true;
        this.result.payload_ = value;
        return this;
      }

      public NotifyInfo.Builder ClearPayload()
      {
        this.PrepareBuilder();
        this.result.hasPayload = false;
        this.result.payload_ = "";
        return this;
      }

      public bool HasIntent
      {
        get
        {
          return this.result.hasIntent;
        }
      }

      public string Intent
      {
        get
        {
          return this.result.Intent;
        }
        set
        {
          this.SetIntent(value);
        }
      }

      public NotifyInfo.Builder SetIntent(string value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.hasIntent = true;
        this.result.intent_ = value;
        return this;
      }

      public NotifyInfo.Builder ClearIntent()
      {
        this.PrepareBuilder();
        this.result.hasIntent = false;
        this.result.intent_ = "";
        return this;
      }

      public bool HasUrl
      {
        get
        {
          return this.result.hasUrl;
        }
      }

      public string Url
      {
        get
        {
          return this.result.Url;
        }
        set
        {
          this.SetUrl(value);
        }
      }

      public NotifyInfo.Builder SetUrl(string value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.hasUrl = true;
        this.result.url_ = value;
        return this;
      }

      public NotifyInfo.Builder ClearUrl()
      {
        this.PrepareBuilder();
        this.result.hasUrl = false;
        this.result.url_ = "";
        return this;
      }

      public bool HasType
      {
        get
        {
          return this.result.hasType;
        }
      }

      public NotifyInfo.Types.Type Type
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

      public NotifyInfo.Builder SetType(NotifyInfo.Types.Type value)
      {
        this.PrepareBuilder();
        this.result.hasType = true;
        this.result.type_ = value;
        return this;
      }

      public NotifyInfo.Builder ClearType()
      {
        this.PrepareBuilder();
        this.result.hasType = false;
        this.result.type_ = NotifyInfo.Types.Type._payload;
        return this;
      }

      public bool HasNotifyId
      {
        get
        {
          return this.result.hasNotifyId;
        }
      }

      public string NotifyId
      {
        get
        {
          return this.result.NotifyId;
        }
        set
        {
          this.SetNotifyId(value);
        }
      }

      public NotifyInfo.Builder SetNotifyId(string value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.hasNotifyId = true;
        this.result.notifyId_ = value;
        return this;
      }

      public NotifyInfo.Builder ClearNotifyId()
      {
        this.PrepareBuilder();
        this.result.hasNotifyId = false;
        this.result.notifyId_ = "";
        return this;
      }
    }
  }
}
