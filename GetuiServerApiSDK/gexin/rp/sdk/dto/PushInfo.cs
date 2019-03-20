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
  public sealed class PushInfo : GeneratedMessage<PushInfo, PushInfo.Builder>
  {
    private static readonly PushInfo defaultInstance = new PushInfo().MakeReadOnly();
    private static readonly string[] _pushInfoFieldNames = new string[16]
    {
      "actionKey",
      "actionLocKey",
      "apnJson",
      "badge",
      "contentAvailable",
      "invalidAPN",
      "invalidMPN",
      "launchImage",
      "locArgs",
      "locKey",
      "message",
      "mpnXml",
      "notifyInfo",
      "payload",
      "sound",
      "validNotify"
    };
    private static readonly uint[] _pushInfoFieldTags = new uint[16]
    {
      18U,
      66U,
      98U,
      34U,
      80U,
      88U,
      104U,
      74U,
      58U,
      50U,
      10U,
      114U,
      130U,
      42U,
      26U,
      120U
    };
    private string message_ = "";
    private string actionKey_ = "";
    private string sound_ = "";
    private string badge_ = "";
    private string payload_ = "";
    private string locKey_ = "";
    private string locArgs_ = "";
    private string actionLocKey_ = "";
    private string launchImage_ = "";
    private string apnJson_ = "";
    private string mpnXml_ = "";
    private int memoizedSerializedSize = -1;
    public const int MessageFieldNumber = 1;
    private bool hasMessage;
    public const int ActionKeyFieldNumber = 2;
    private bool hasActionKey;
    public const int SoundFieldNumber = 3;
    private bool hasSound;
    public const int BadgeFieldNumber = 4;
    private bool hasBadge;
    public const int PayloadFieldNumber = 5;
    private bool hasPayload;
    public const int LocKeyFieldNumber = 6;
    private bool hasLocKey;
    public const int LocArgsFieldNumber = 7;
    private bool hasLocArgs;
    public const int ActionLocKeyFieldNumber = 8;
    private bool hasActionLocKey;
    public const int LaunchImageFieldNumber = 9;
    private bool hasLaunchImage;
    public const int ContentAvailableFieldNumber = 10;
    private bool hasContentAvailable;
    private int contentAvailable_;
    public const int InvalidAPNFieldNumber = 11;
    private bool hasInvalidAPN;
    private bool invalidAPN_;
    public const int ApnJsonFieldNumber = 12;
    private bool hasApnJson;
    public const int InvalidMPNFieldNumber = 13;
    private bool hasInvalidMPN;
    private bool invalidMPN_;
    public const int MpnXmlFieldNumber = 14;
    private bool hasMpnXml;
    public const int ValidNotifyFieldNumber = 15;
    private bool hasValidNotify;
    private bool validNotify_;
    public const int NotifyInfoFieldNumber = 16;
    private bool hasNotifyInfo;
    private NotifyInfo notifyInfo_;

    private PushInfo()
    {
    }

    public static PushInfo DefaultInstance
    {
      get
      {
        return PushInfo.defaultInstance;
      }
    }

    public override PushInfo DefaultInstanceForType
    {
      get
      {
        return PushInfo.DefaultInstance;
      }
    }

    protected override PushInfo ThisMessage
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
        return GtReq.internal__static_com_gexin_rp_sdk_dto_PushInfo__Descriptor;
      }
    }

    protected override FieldAccessorTable<PushInfo, PushInfo.Builder> InternalFieldAccessors
    {
      get
      {
        return GtReq.internal__static_com_gexin_rp_sdk_dto_PushInfo__FieldAccessorTable;
      }
    }

    public bool HasMessage
    {
      get
      {
        return this.hasMessage;
      }
    }

    public string Message
    {
      get
      {
        return this.message_;
      }
    }

    public bool HasActionKey
    {
      get
      {
        return this.hasActionKey;
      }
    }

    public string ActionKey
    {
      get
      {
        return this.actionKey_;
      }
    }

    public bool HasSound
    {
      get
      {
        return this.hasSound;
      }
    }

    public string Sound
    {
      get
      {
        return this.sound_;
      }
    }

    public bool HasBadge
    {
      get
      {
        return this.hasBadge;
      }
    }

    public string Badge
    {
      get
      {
        return this.badge_;
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

    public bool HasLocKey
    {
      get
      {
        return this.hasLocKey;
      }
    }

    public string LocKey
    {
      get
      {
        return this.locKey_;
      }
    }

    public bool HasLocArgs
    {
      get
      {
        return this.hasLocArgs;
      }
    }

    public string LocArgs
    {
      get
      {
        return this.locArgs_;
      }
    }

    public bool HasActionLocKey
    {
      get
      {
        return this.hasActionLocKey;
      }
    }

    public string ActionLocKey
    {
      get
      {
        return this.actionLocKey_;
      }
    }

    public bool HasLaunchImage
    {
      get
      {
        return this.hasLaunchImage;
      }
    }

    public string LaunchImage
    {
      get
      {
        return this.launchImage_;
      }
    }

    public bool HasContentAvailable
    {
      get
      {
        return this.hasContentAvailable;
      }
    }

    public int ContentAvailable
    {
      get
      {
        return this.contentAvailable_;
      }
    }

    public bool HasInvalidAPN
    {
      get
      {
        return this.hasInvalidAPN;
      }
    }

    public bool InvalidAPN
    {
      get
      {
        return this.invalidAPN_;
      }
    }

    public bool HasApnJson
    {
      get
      {
        return this.hasApnJson;
      }
    }

    public string ApnJson
    {
      get
      {
        return this.apnJson_;
      }
    }

    public bool HasInvalidMPN
    {
      get
      {
        return this.hasInvalidMPN;
      }
    }

    public bool InvalidMPN
    {
      get
      {
        return this.invalidMPN_;
      }
    }

    public bool HasMpnXml
    {
      get
      {
        return this.hasMpnXml;
      }
    }

    public string MpnXml
    {
      get
      {
        return this.mpnXml_;
      }
    }

    public bool HasValidNotify
    {
      get
      {
        return this.hasValidNotify;
      }
    }

    public bool ValidNotify
    {
      get
      {
        return this.validNotify_;
      }
    }

    public bool HasNotifyInfo
    {
      get
      {
        return this.hasNotifyInfo;
      }
    }

    public NotifyInfo NotifyInfo
    {
      get
      {
        return this.notifyInfo_ ?? NotifyInfo.DefaultInstance;
      }
    }

    public override bool IsInitialized
    {
      get
      {
        return !this.HasNotifyInfo || this.NotifyInfo.IsInitialized;
      }
    }

    public override void WriteTo(ICodedOutputStream output)
    {
      int serializedSize = this.SerializedSize;
      string[] pushInfoFieldNames = PushInfo._pushInfoFieldNames;
      if (this.hasMessage)
        output.WriteString(1, pushInfoFieldNames[10], this.Message);
      if (this.hasActionKey)
        output.WriteString(2, pushInfoFieldNames[0], this.ActionKey);
      if (this.hasSound)
        output.WriteString(3, pushInfoFieldNames[14], this.Sound);
      if (this.hasBadge)
        output.WriteString(4, pushInfoFieldNames[3], this.Badge);
      if (this.hasPayload)
        output.WriteString(5, pushInfoFieldNames[13], this.Payload);
      if (this.hasLocKey)
        output.WriteString(6, pushInfoFieldNames[9], this.LocKey);
      if (this.hasLocArgs)
        output.WriteString(7, pushInfoFieldNames[8], this.LocArgs);
      if (this.hasActionLocKey)
        output.WriteString(8, pushInfoFieldNames[1], this.ActionLocKey);
      if (this.hasLaunchImage)
        output.WriteString(9, pushInfoFieldNames[7], this.LaunchImage);
      if (this.hasContentAvailable)
        output.WriteInt32(10, pushInfoFieldNames[4], this.ContentAvailable);
      if (this.hasInvalidAPN)
        output.WriteBool(11, pushInfoFieldNames[5], this.InvalidAPN);
      if (this.hasApnJson)
        output.WriteString(12, pushInfoFieldNames[2], this.ApnJson);
      if (this.hasInvalidMPN)
        output.WriteBool(13, pushInfoFieldNames[6], this.InvalidMPN);
      if (this.hasMpnXml)
        output.WriteString(14, pushInfoFieldNames[11], this.MpnXml);
      if (this.hasValidNotify)
        output.WriteBool(15, pushInfoFieldNames[15], this.ValidNotify);
      if (this.hasNotifyInfo)
        output.WriteMessage(16, pushInfoFieldNames[12], (IMessageLite) this.NotifyInfo);
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
          num1 += CodedOutputStream.ComputeStringSize(1, this.Message);
        if (this.hasActionKey)
          num1 += CodedOutputStream.ComputeStringSize(2, this.ActionKey);
        if (this.hasSound)
          num1 += CodedOutputStream.ComputeStringSize(3, this.Sound);
        if (this.hasBadge)
          num1 += CodedOutputStream.ComputeStringSize(4, this.Badge);
        if (this.hasPayload)
          num1 += CodedOutputStream.ComputeStringSize(5, this.Payload);
        if (this.hasLocKey)
          num1 += CodedOutputStream.ComputeStringSize(6, this.LocKey);
        if (this.hasLocArgs)
          num1 += CodedOutputStream.ComputeStringSize(7, this.LocArgs);
        if (this.hasActionLocKey)
          num1 += CodedOutputStream.ComputeStringSize(8, this.ActionLocKey);
        if (this.hasLaunchImage)
          num1 += CodedOutputStream.ComputeStringSize(9, this.LaunchImage);
        if (this.hasContentAvailable)
          num1 += CodedOutputStream.ComputeInt32Size(10, this.ContentAvailable);
        if (this.hasInvalidAPN)
          num1 += CodedOutputStream.ComputeBoolSize(11, this.InvalidAPN);
        if (this.hasApnJson)
          num1 += CodedOutputStream.ComputeStringSize(12, this.ApnJson);
        if (this.hasInvalidMPN)
          num1 += CodedOutputStream.ComputeBoolSize(13, this.InvalidMPN);
        if (this.hasMpnXml)
          num1 += CodedOutputStream.ComputeStringSize(14, this.MpnXml);
        if (this.hasValidNotify)
          num1 += CodedOutputStream.ComputeBoolSize(15, this.ValidNotify);
        if (this.hasNotifyInfo)
          num1 += CodedOutputStream.ComputeMessageSize(16, (IMessageLite) this.NotifyInfo);
        int num2 = num1 + this.UnknownFields.SerializedSize;
        this.memoizedSerializedSize = num2;
        return num2;
      }
    }

    public static PushInfo ParseFrom(ByteString data)
    {
      return PushInfo.CreateBuilder().MergeFrom(data).BuildParsed();
    }

    public static PushInfo ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
    {
      return PushInfo.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
    }

    public static PushInfo ParseFrom(byte[] data)
    {
      return PushInfo.CreateBuilder().MergeFrom(data).BuildParsed();
    }

    public static PushInfo ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
    {
      return PushInfo.CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
    }

    public static PushInfo ParseFrom(Stream input)
    {
      return PushInfo.CreateBuilder().MergeFrom(input).BuildParsed();
    }

    public static PushInfo ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
    {
      return PushInfo.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
    }

    public static PushInfo ParseDelimitedFrom(Stream input)
    {
      return PushInfo.CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }

    public static PushInfo ParseDelimitedFrom(
      Stream input,
      ExtensionRegistry extensionRegistry)
    {
      return PushInfo.CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }

    public static PushInfo ParseFrom(ICodedInputStream input)
    {
      return PushInfo.CreateBuilder().MergeFrom(input).BuildParsed();
    }

    public static PushInfo ParseFrom(
      ICodedInputStream input,
      ExtensionRegistry extensionRegistry)
    {
      return PushInfo.CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
    }

    private PushInfo MakeReadOnly()
    {
      return this;
    }

    public static PushInfo.Builder CreateBuilder()
    {
      return new PushInfo.Builder();
    }

    public override PushInfo.Builder ToBuilder()
    {
      return PushInfo.CreateBuilder(this);
    }

    public override PushInfo.Builder CreateBuilderForType()
    {
      return new PushInfo.Builder();
    }

    public static PushInfo.Builder CreateBuilder(PushInfo prototype)
    {
      return new PushInfo.Builder(prototype);
    }

    static PushInfo()
    {
      FileDescriptor descriptor = GtReq.Descriptor;
    }

    [DebuggerNonUserCode]
    public sealed class Builder : GeneratedBuilder<PushInfo, PushInfo.Builder>
    {
      private bool resultIsReadOnly;
      private PushInfo result;

      protected override PushInfo.Builder ThisBuilder
      {
        get
        {
          return this;
        }
      }

      public Builder()
      {
        this.result = PushInfo.DefaultInstance;
        this.resultIsReadOnly = true;
      }

      internal Builder(PushInfo cloneFrom)
      {
        this.result = cloneFrom;
        this.resultIsReadOnly = true;
      }

      private PushInfo PrepareBuilder()
      {
        if (this.resultIsReadOnly)
        {
          PushInfo result = this.result;
          this.result = new PushInfo();
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

      protected override PushInfo MessageBeingBuilt
      {
        get
        {
          return this.PrepareBuilder();
        }
      }

      public override PushInfo.Builder Clear()
      {
        this.result = PushInfo.DefaultInstance;
        this.resultIsReadOnly = true;
        return this;
      }

      public override PushInfo.Builder Clone()
      {
        if (this.resultIsReadOnly)
          return new PushInfo.Builder(this.result);
        return new PushInfo.Builder().MergeFrom(this.result);
      }

      public override MessageDescriptor DescriptorForType
      {
        get
        {
          return PushInfo.Descriptor;
        }
      }

      public override PushInfo DefaultInstanceForType
      {
        get
        {
          return PushInfo.DefaultInstance;
        }
      }

      public override PushInfo BuildPartial()
      {
        if (this.resultIsReadOnly)
          return this.result;
        this.resultIsReadOnly = true;
        return this.result.MakeReadOnly();
      }

      public override PushInfo.Builder MergeFrom(IMessage other)
      {
        if (other is PushInfo)
          return this.MergeFrom((PushInfo) other);
        base.MergeFrom(other);
        return this;
      }

      public override PushInfo.Builder MergeFrom(PushInfo other)
      {
        if (other == PushInfo.DefaultInstance)
          return this;
        this.PrepareBuilder();
        if (other.HasMessage)
          this.Message = other.Message;
        if (other.HasActionKey)
          this.ActionKey = other.ActionKey;
        if (other.HasSound)
          this.Sound = other.Sound;
        if (other.HasBadge)
          this.Badge = other.Badge;
        if (other.HasPayload)
          this.Payload = other.Payload;
        if (other.HasLocKey)
          this.LocKey = other.LocKey;
        if (other.HasLocArgs)
          this.LocArgs = other.LocArgs;
        if (other.HasActionLocKey)
          this.ActionLocKey = other.ActionLocKey;
        if (other.HasLaunchImage)
          this.LaunchImage = other.LaunchImage;
        if (other.HasContentAvailable)
          this.ContentAvailable = other.ContentAvailable;
        if (other.HasInvalidAPN)
          this.InvalidAPN = other.InvalidAPN;
        if (other.HasApnJson)
          this.ApnJson = other.ApnJson;
        if (other.HasInvalidMPN)
          this.InvalidMPN = other.InvalidMPN;
        if (other.HasMpnXml)
          this.MpnXml = other.MpnXml;
        if (other.HasValidNotify)
          this.ValidNotify = other.ValidNotify;
        if (other.HasNotifyInfo)
          this.MergeNotifyInfo(other.NotifyInfo);
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }

      public override PushInfo.Builder MergeFrom(ICodedInputStream input)
      {
        return this.MergeFrom(input, ExtensionRegistry.Empty);
      }

      public override PushInfo.Builder MergeFrom(
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
            int index = Array.BinarySearch<string>(PushInfo._pushInfoFieldNames, fieldName, (IComparer<string>) StringComparer.Ordinal);
            if (index >= 0)
            {
              fieldTag = PushInfo._pushInfoFieldTags[index];
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
              this.result.hasMessage = input.ReadString(ref this.result.message_);
              continue;
            case 18:
              this.result.hasActionKey = input.ReadString(ref this.result.actionKey_);
              continue;
            case 26:
              this.result.hasSound = input.ReadString(ref this.result.sound_);
              continue;
            case 34:
              this.result.hasBadge = input.ReadString(ref this.result.badge_);
              continue;
            case 42:
              this.result.hasPayload = input.ReadString(ref this.result.payload_);
              continue;
            case 50:
              this.result.hasLocKey = input.ReadString(ref this.result.locKey_);
              continue;
            case 58:
              this.result.hasLocArgs = input.ReadString(ref this.result.locArgs_);
              continue;
            case 66:
              this.result.hasActionLocKey = input.ReadString(ref this.result.actionLocKey_);
              continue;
            case 74:
              this.result.hasLaunchImage = input.ReadString(ref this.result.launchImage_);
              continue;
            case 80:
              this.result.hasContentAvailable = input.ReadInt32(ref this.result.contentAvailable_);
              continue;
            case 88:
              this.result.hasInvalidAPN = input.ReadBool(ref this.result.invalidAPN_);
              continue;
            case 98:
              this.result.hasApnJson = input.ReadString(ref this.result.apnJson_);
              continue;
            case 104:
              this.result.hasInvalidMPN = input.ReadBool(ref this.result.invalidMPN_);
              continue;
            case 114:
              this.result.hasMpnXml = input.ReadString(ref this.result.mpnXml_);
              continue;
            case 120:
              this.result.hasValidNotify = input.ReadBool(ref this.result.validNotify_);
              continue;
            case 130:
              NotifyInfo.Builder builder = NotifyInfo.CreateBuilder();
              if (this.result.hasNotifyInfo)
                builder.MergeFrom(this.NotifyInfo);
              input.ReadMessage((IBuilderLite) builder, extensionRegistry);
              this.NotifyInfo = builder.BuildPartial();
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

      public string Message
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

      public PushInfo.Builder SetMessage(string value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.hasMessage = true;
        this.result.message_ = value;
        return this;
      }

      public PushInfo.Builder ClearMessage()
      {
        this.PrepareBuilder();
        this.result.hasMessage = false;
        this.result.message_ = "";
        return this;
      }

      public bool HasActionKey
      {
        get
        {
          return this.result.hasActionKey;
        }
      }

      public string ActionKey
      {
        get
        {
          return this.result.ActionKey;
        }
        set
        {
          this.SetActionKey(value);
        }
      }

      public PushInfo.Builder SetActionKey(string value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.hasActionKey = true;
        this.result.actionKey_ = value;
        return this;
      }

      public PushInfo.Builder ClearActionKey()
      {
        this.PrepareBuilder();
        this.result.hasActionKey = false;
        this.result.actionKey_ = "";
        return this;
      }

      public bool HasSound
      {
        get
        {
          return this.result.hasSound;
        }
      }

      public string Sound
      {
        get
        {
          return this.result.Sound;
        }
        set
        {
          this.SetSound(value);
        }
      }

      public PushInfo.Builder SetSound(string value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.hasSound = true;
        this.result.sound_ = value;
        return this;
      }

      public PushInfo.Builder ClearSound()
      {
        this.PrepareBuilder();
        this.result.hasSound = false;
        this.result.sound_ = "";
        return this;
      }

      public bool HasBadge
      {
        get
        {
          return this.result.hasBadge;
        }
      }

      public string Badge
      {
        get
        {
          return this.result.Badge;
        }
        set
        {
          this.SetBadge(value);
        }
      }

      public PushInfo.Builder SetBadge(string value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.hasBadge = true;
        this.result.badge_ = value;
        return this;
      }

      public PushInfo.Builder ClearBadge()
      {
        this.PrepareBuilder();
        this.result.hasBadge = false;
        this.result.badge_ = "";
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

      public PushInfo.Builder SetPayload(string value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.hasPayload = true;
        this.result.payload_ = value;
        return this;
      }

      public PushInfo.Builder ClearPayload()
      {
        this.PrepareBuilder();
        this.result.hasPayload = false;
        this.result.payload_ = "";
        return this;
      }

      public bool HasLocKey
      {
        get
        {
          return this.result.hasLocKey;
        }
      }

      public string LocKey
      {
        get
        {
          return this.result.LocKey;
        }
        set
        {
          this.SetLocKey(value);
        }
      }

      public PushInfo.Builder SetLocKey(string value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.hasLocKey = true;
        this.result.locKey_ = value;
        return this;
      }

      public PushInfo.Builder ClearLocKey()
      {
        this.PrepareBuilder();
        this.result.hasLocKey = false;
        this.result.locKey_ = "";
        return this;
      }

      public bool HasLocArgs
      {
        get
        {
          return this.result.hasLocArgs;
        }
      }

      public string LocArgs
      {
        get
        {
          return this.result.LocArgs;
        }
        set
        {
          this.SetLocArgs(value);
        }
      }

      public PushInfo.Builder SetLocArgs(string value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.hasLocArgs = true;
        this.result.locArgs_ = value;
        return this;
      }

      public PushInfo.Builder ClearLocArgs()
      {
        this.PrepareBuilder();
        this.result.hasLocArgs = false;
        this.result.locArgs_ = "";
        return this;
      }

      public bool HasActionLocKey
      {
        get
        {
          return this.result.hasActionLocKey;
        }
      }

      public string ActionLocKey
      {
        get
        {
          return this.result.ActionLocKey;
        }
        set
        {
          this.SetActionLocKey(value);
        }
      }

      public PushInfo.Builder SetActionLocKey(string value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.hasActionLocKey = true;
        this.result.actionLocKey_ = value;
        return this;
      }

      public PushInfo.Builder ClearActionLocKey()
      {
        this.PrepareBuilder();
        this.result.hasActionLocKey = false;
        this.result.actionLocKey_ = "";
        return this;
      }

      public bool HasLaunchImage
      {
        get
        {
          return this.result.hasLaunchImage;
        }
      }

      public string LaunchImage
      {
        get
        {
          return this.result.LaunchImage;
        }
        set
        {
          this.SetLaunchImage(value);
        }
      }

      public PushInfo.Builder SetLaunchImage(string value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.hasLaunchImage = true;
        this.result.launchImage_ = value;
        return this;
      }

      public PushInfo.Builder ClearLaunchImage()
      {
        this.PrepareBuilder();
        this.result.hasLaunchImage = false;
        this.result.launchImage_ = "";
        return this;
      }

      public bool HasContentAvailable
      {
        get
        {
          return this.result.hasContentAvailable;
        }
      }

      public int ContentAvailable
      {
        get
        {
          return this.result.ContentAvailable;
        }
        set
        {
          this.SetContentAvailable(value);
        }
      }

      public PushInfo.Builder SetContentAvailable(int value)
      {
        this.PrepareBuilder();
        this.result.hasContentAvailable = true;
        this.result.contentAvailable_ = value;
        return this;
      }

      public PushInfo.Builder ClearContentAvailable()
      {
        this.PrepareBuilder();
        this.result.hasContentAvailable = false;
        this.result.contentAvailable_ = 0;
        return this;
      }

      public bool HasInvalidAPN
      {
        get
        {
          return this.result.hasInvalidAPN;
        }
      }

      public bool InvalidAPN
      {
        get
        {
          return this.result.InvalidAPN;
        }
        set
        {
          this.SetInvalidAPN(value);
        }
      }

      public PushInfo.Builder SetInvalidAPN(bool value)
      {
        this.PrepareBuilder();
        this.result.hasInvalidAPN = true;
        this.result.invalidAPN_ = value;
        return this;
      }

      public PushInfo.Builder ClearInvalidAPN()
      {
        this.PrepareBuilder();
        this.result.hasInvalidAPN = false;
        this.result.invalidAPN_ = false;
        return this;
      }

      public bool HasApnJson
      {
        get
        {
          return this.result.hasApnJson;
        }
      }

      public string ApnJson
      {
        get
        {
          return this.result.ApnJson;
        }
        set
        {
          this.SetApnJson(value);
        }
      }

      public PushInfo.Builder SetApnJson(string value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.hasApnJson = true;
        this.result.apnJson_ = value;
        return this;
      }

      public PushInfo.Builder ClearApnJson()
      {
        this.PrepareBuilder();
        this.result.hasApnJson = false;
        this.result.apnJson_ = "";
        return this;
      }

      public bool HasInvalidMPN
      {
        get
        {
          return this.result.hasInvalidMPN;
        }
      }

      public bool InvalidMPN
      {
        get
        {
          return this.result.InvalidMPN;
        }
        set
        {
          this.SetInvalidMPN(value);
        }
      }

      public PushInfo.Builder SetInvalidMPN(bool value)
      {
        this.PrepareBuilder();
        this.result.hasInvalidMPN = true;
        this.result.invalidMPN_ = value;
        return this;
      }

      public PushInfo.Builder ClearInvalidMPN()
      {
        this.PrepareBuilder();
        this.result.hasInvalidMPN = false;
        this.result.invalidMPN_ = false;
        return this;
      }

      public bool HasMpnXml
      {
        get
        {
          return this.result.hasMpnXml;
        }
      }

      public string MpnXml
      {
        get
        {
          return this.result.MpnXml;
        }
        set
        {
          this.SetMpnXml(value);
        }
      }

      public PushInfo.Builder SetMpnXml(string value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.hasMpnXml = true;
        this.result.mpnXml_ = value;
        return this;
      }

      public PushInfo.Builder ClearMpnXml()
      {
        this.PrepareBuilder();
        this.result.hasMpnXml = false;
        this.result.mpnXml_ = "";
        return this;
      }

      public bool HasValidNotify
      {
        get
        {
          return this.result.hasValidNotify;
        }
      }

      public bool ValidNotify
      {
        get
        {
          return this.result.ValidNotify;
        }
        set
        {
          this.SetValidNotify(value);
        }
      }

      public PushInfo.Builder SetValidNotify(bool value)
      {
        this.PrepareBuilder();
        this.result.hasValidNotify = true;
        this.result.validNotify_ = value;
        return this;
      }

      public PushInfo.Builder ClearValidNotify()
      {
        this.PrepareBuilder();
        this.result.hasValidNotify = false;
        this.result.validNotify_ = false;
        return this;
      }

      public bool HasNotifyInfo
      {
        get
        {
          return this.result.hasNotifyInfo;
        }
      }

      public NotifyInfo NotifyInfo
      {
        get
        {
          return this.result.NotifyInfo;
        }
        set
        {
          this.SetNotifyInfo(value);
        }
      }

      public PushInfo.Builder SetNotifyInfo(NotifyInfo value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.hasNotifyInfo = true;
        this.result.notifyInfo_ = value;
        return this;
      }

      public PushInfo.Builder SetNotifyInfo(NotifyInfo.Builder builderForValue)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) builderForValue, nameof (builderForValue));
        this.PrepareBuilder();
        this.result.hasNotifyInfo = true;
        this.result.notifyInfo_ = builderForValue.Build();
        return this;
      }

      public PushInfo.Builder MergeNotifyInfo(NotifyInfo value)
      {
        Google.ProtocolBuffers.ThrowHelper.ThrowIfNull((object) value, nameof (value));
        this.PrepareBuilder();
        this.result.notifyInfo_ = !this.result.hasNotifyInfo || this.result.notifyInfo_ == NotifyInfo.DefaultInstance ? value : NotifyInfo.CreateBuilder(this.result.notifyInfo_).MergeFrom(value).BuildPartial();
        this.result.hasNotifyInfo = true;
        return this;
      }

      public PushInfo.Builder ClearNotifyInfo()
      {
        this.PrepareBuilder();
        this.result.hasNotifyInfo = false;
        this.result.notifyInfo_ = (NotifyInfo) null;
        return this;
      }
    }
  }
}
