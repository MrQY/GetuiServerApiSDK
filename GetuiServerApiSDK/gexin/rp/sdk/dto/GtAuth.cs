using System;
using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Descriptors;
using Google.ProtocolBuffers.FieldAccess;

namespace com.gexin.rp.sdk.dto
{
    [DebuggerNonUserCode]
    public sealed class GtAuth : GeneratedMessage<GtAuth, GtAuth.Builder>
    {
        public const int SignFieldNumber = 1;
        public const int AppkeyFieldNumber = 2;
        public const int TimestampFieldNumber = 3;
        public const int SeqIdFieldNumber = 4;

        private static readonly string[] _gtAuthFieldNames = new string[4]
        {
            "appkey",
            "seqId",
            "sign",
            "timestamp"
        };

        private static readonly uint[] _gtAuthFieldTags = new uint[4]
        {
            18U,
            34U,
            10U,
            24U
        };

        private string appkey_ = "";
        private int memoizedSerializedSize = -1;
        private string seqId_ = "";
        private string sign_ = "";
        private long timestamp_;

        static GtAuth()
        {
            var descriptor = GtReq.Descriptor;
        }

        private GtAuth()
        {
        }

        public static GtAuth DefaultInstance { get; } = new GtAuth().MakeReadOnly();

        public override GtAuth DefaultInstanceForType => DefaultInstance;

        protected override GtAuth ThisMessage => this;

        public static MessageDescriptor Descriptor => GtReq.internal__static_com_gexin_rp_sdk_dto_GtAuth__Descriptor;

        protected override FieldAccessorTable<GtAuth, Builder> InternalFieldAccessors =>
            GtReq.internal__static_com_gexin_rp_sdk_dto_GtAuth__FieldAccessorTable;

        public bool HasSign { get; private set; }

        public string Sign => sign_;

        public bool HasAppkey { get; private set; }

        public string Appkey => appkey_;

        public bool HasTimestamp { get; private set; }

        public long Timestamp => timestamp_;

        public bool HasSeqId { get; private set; }

        public string SeqId => seqId_;

        public override bool IsInitialized => HasSign && HasAppkey && HasTimestamp;

        public override int SerializedSize
        {
            get
            {
                var memoizedSerializedSize = this.memoizedSerializedSize;
                if (memoizedSerializedSize != -1)
                    return memoizedSerializedSize;
                var num1 = 0;
                if (HasSign)
                    num1 += CodedOutputStream.ComputeStringSize(1, Sign);
                if (HasAppkey)
                    num1 += CodedOutputStream.ComputeStringSize(2, Appkey);
                if (HasTimestamp)
                    num1 += CodedOutputStream.ComputeInt64Size(3, Timestamp);
                if (HasSeqId)
                    num1 += CodedOutputStream.ComputeStringSize(4, SeqId);
                var num2 = num1 + UnknownFields.SerializedSize;
                this.memoizedSerializedSize = num2;
                return num2;
            }
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            var serializedSize = SerializedSize;
            var gtAuthFieldNames = _gtAuthFieldNames;
            if (HasSign)
                output.WriteString(1, gtAuthFieldNames[2], Sign);
            if (HasAppkey)
                output.WriteString(2, gtAuthFieldNames[0], Appkey);
            if (HasTimestamp)
                output.WriteInt64(3, gtAuthFieldNames[3], Timestamp);
            if (HasSeqId)
                output.WriteString(4, gtAuthFieldNames[1], SeqId);
            UnknownFields.WriteTo(output);
        }

        public static GtAuth ParseFrom(ByteString data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public static GtAuth ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
        {
            return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
        }

        public static GtAuth ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public static GtAuth ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
        {
            return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
        }

        public static GtAuth ParseFrom(Stream input)
        {
            return CreateBuilder().MergeFrom(input).BuildParsed();
        }

        public static GtAuth ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
        {
            return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
        }

        public static GtAuth ParseDelimitedFrom(Stream input)
        {
            return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
        }

        public static GtAuth ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
        {
            return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
        }

        public static GtAuth ParseFrom(ICodedInputStream input)
        {
            return CreateBuilder().MergeFrom(input).BuildParsed();
        }

        public static GtAuth ParseFrom(
            ICodedInputStream input,
            ExtensionRegistry extensionRegistry)
        {
            return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
        }

        private GtAuth MakeReadOnly()
        {
            return this;
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(GtAuth prototype)
        {
            return new Builder(prototype);
        }

        [DebuggerNonUserCode]
        public sealed class Builder : GeneratedBuilder<GtAuth, Builder>
        {
            private GtAuth result;
            private bool resultIsReadOnly;

            public Builder()
            {
                result = DefaultInstance;
                resultIsReadOnly = true;
            }

            internal Builder(GtAuth cloneFrom)
            {
                result = cloneFrom;
                resultIsReadOnly = true;
            }

            protected override Builder ThisBuilder => this;

            public override bool IsInitialized => result.IsInitialized;

            protected override GtAuth MessageBeingBuilt => PrepareBuilder();

            public override MessageDescriptor DescriptorForType => Descriptor;

            public override GtAuth DefaultInstanceForType => DefaultInstance;

            public bool HasSign => result.HasSign;

            public string Sign
            {
                get => result.Sign;
                set => SetSign(value);
            }

            public bool HasAppkey => result.HasAppkey;

            public string Appkey
            {
                get => result.Appkey;
                set => SetAppkey(value);
            }

            public bool HasTimestamp => result.HasTimestamp;

            public long Timestamp
            {
                get => result.Timestamp;
                set => SetTimestamp(value);
            }

            public bool HasSeqId => result.HasSeqId;

            public string SeqId
            {
                get => result.SeqId;
                set => SetSeqId(value);
            }

            private GtAuth PrepareBuilder()
            {
                if (resultIsReadOnly)
                {
                    var result = this.result;
                    this.result = new GtAuth();
                    resultIsReadOnly = false;
                    MergeFrom(result);
                }

                return this.result;
            }

            public override Builder Clear()
            {
                result = DefaultInstance;
                resultIsReadOnly = true;
                return this;
            }

            public override Builder Clone()
            {
                if (resultIsReadOnly)
                    return new Builder(result);
                return new Builder().MergeFrom(result);
            }

            public override GtAuth BuildPartial()
            {
                if (resultIsReadOnly)
                    return result;
                resultIsReadOnly = true;
                return result.MakeReadOnly();
            }

            public override Builder MergeFrom(IMessage other)
            {
                if (other is GtAuth)
                    return MergeFrom((GtAuth) other);
                base.MergeFrom(other);
                return this;
            }

            public override Builder MergeFrom(GtAuth other)
            {
                if (other == DefaultInstance)
                    return this;
                PrepareBuilder();
                if (other.HasSign)
                    Sign = other.Sign;
                if (other.HasAppkey)
                    Appkey = other.Appkey;
                if (other.HasTimestamp)
                    Timestamp = other.Timestamp;
                if (other.HasSeqId)
                    SeqId = other.SeqId;
                MergeUnknownFields(other.UnknownFields);
                return this;
            }

            public override Builder MergeFrom(ICodedInputStream input)
            {
                return MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override Builder MergeFrom(
                ICodedInputStream input,
                ExtensionRegistry extensionRegistry)
            {
                PrepareBuilder();
                UnknownFieldSet.Builder unknownFields = null;
                uint fieldTag;
                string fieldName;
                while (input.ReadTag(out fieldTag, out fieldName))
                {
                    if (fieldTag == 0U && fieldName != null)
                    {
                        var index = Array.BinarySearch(_gtAuthFieldNames, fieldName, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            fieldTag = _gtAuthFieldTags[index];
                        }
                        else
                        {
                            if (unknownFields == null)
                                unknownFields = UnknownFieldSet.CreateBuilder(UnknownFields);
                            ParseUnknownField(input, unknownFields, extensionRegistry, fieldTag, fieldName);
                            continue;
                        }
                    }

                    switch (fieldTag)
                    {
                        case 0:
                            throw InvalidProtocolBufferException.InvalidTag();
                        case 10:
                            result.HasSign = input.ReadString(ref result.sign_);
                            continue;
                        case 18:
                            result.HasAppkey = input.ReadString(ref result.appkey_);
                            continue;
                        case 24:
                            result.HasTimestamp = input.ReadInt64(ref result.timestamp_);
                            continue;
                        case 34:
                            result.HasSeqId = input.ReadString(ref result.seqId_);
                            continue;
                        default:
                            if (WireFormat.IsEndGroupTag(fieldTag))
                            {
                                if (unknownFields != null)
                                    UnknownFields = unknownFields.Build();
                                return this;
                            }

                            if (unknownFields == null)
                                unknownFields = UnknownFieldSet.CreateBuilder(UnknownFields);
                            ParseUnknownField(input, unknownFields, extensionRegistry, fieldTag, fieldName);
                            continue;
                    }
                }

                if (unknownFields != null)
                    UnknownFields = unknownFields.Build();
                return this;
            }

            public Builder SetSign(string value)
            {
                ThrowHelper.ThrowIfNull(value, nameof(value));
                PrepareBuilder();
                result.HasSign = true;
                result.sign_ = value;
                return this;
            }

            public Builder ClearSign()
            {
                PrepareBuilder();
                result.HasSign = false;
                result.sign_ = "";
                return this;
            }

            public Builder SetAppkey(string value)
            {
                ThrowHelper.ThrowIfNull(value, nameof(value));
                PrepareBuilder();
                result.HasAppkey = true;
                result.appkey_ = value;
                return this;
            }

            public Builder ClearAppkey()
            {
                PrepareBuilder();
                result.HasAppkey = false;
                result.appkey_ = "";
                return this;
            }

            public Builder SetTimestamp(long value)
            {
                PrepareBuilder();
                result.HasTimestamp = true;
                result.timestamp_ = value;
                return this;
            }

            public Builder ClearTimestamp()
            {
                PrepareBuilder();
                result.HasTimestamp = false;
                result.timestamp_ = 0L;
                return this;
            }

            public Builder SetSeqId(string value)
            {
                ThrowHelper.ThrowIfNull(value, nameof(value));
                PrepareBuilder();
                result.HasSeqId = true;
                result.seqId_ = value;
                return this;
            }

            public Builder ClearSeqId()
            {
                PrepareBuilder();
                result.HasSeqId = false;
                result.seqId_ = "";
                return this;
            }
        }
    }
}