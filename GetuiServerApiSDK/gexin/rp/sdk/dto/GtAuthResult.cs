using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Collections;
using Google.ProtocolBuffers.Descriptors;
using Google.ProtocolBuffers.FieldAccess;

namespace com.gexin.rp.sdk.dto
{
    [DebuggerNonUserCode]
    public sealed class GtAuthResult : GeneratedMessage<GtAuthResult, GtAuthResult.Builder>
    {
        public const int CodeFieldNumber = 1;
        public const int RedirectAddressFieldNumber = 2;
        public const int SeqIdFieldNumber = 3;
        public const int InfoFieldNumber = 4;
        public const int AppidFieldNumber = 5;

        private static readonly string[] _gtAuthResultFieldNames = new string[5]
        {
            "appid",
            "code",
            "info",
            "redirectAddress",
            "seqId"
        };

        private static readonly uint[] _gtAuthResultFieldTags = new uint[5]
        {
            42U,
            8U,
            34U,
            18U,
            26U
        };

        private readonly PopsicleList<string> appid_ = new PopsicleList<string>();
        private int code_;
        private string info_ = "";
        private int memoizedSerializedSize = -1;
        private string redirectAddress_ = "";
        private string seqId_ = "";

        static GtAuthResult()
        {
            var descriptor = GtReq.Descriptor;
        }

        private GtAuthResult()
        {
        }

        public static GtAuthResult DefaultInstance { get; } = new GtAuthResult().MakeReadOnly();

        public override GtAuthResult DefaultInstanceForType => DefaultInstance;

        protected override GtAuthResult ThisMessage => this;

        public static MessageDescriptor Descriptor =>
            GtReq.internal__static_com_gexin_rp_sdk_dto_GtAuthResult__Descriptor;

        protected override FieldAccessorTable<GtAuthResult, Builder> InternalFieldAccessors =>
            GtReq.internal__static_com_gexin_rp_sdk_dto_GtAuthResult__FieldAccessorTable;

        public bool HasCode { get; private set; }

        public int Code => code_;

        public bool HasRedirectAddress { get; private set; }

        public string RedirectAddress => redirectAddress_;

        public bool HasSeqId { get; private set; }

        public string SeqId => seqId_;

        public bool HasInfo { get; private set; }

        public string Info => info_;

        public IList<string> AppidList => Lists.AsReadOnly(appid_);

        public int AppidCount => appid_.Count;

        public override bool IsInitialized => HasCode;

        public override int SerializedSize
        {
            get
            {
                var memoizedSerializedSize = this.memoizedSerializedSize;
                if (memoizedSerializedSize != -1)
                    return memoizedSerializedSize;
                var num1 = 0;
                if (HasCode)
                    num1 += CodedOutputStream.ComputeInt32Size(1, Code);
                if (HasRedirectAddress)
                    num1 += CodedOutputStream.ComputeStringSize(2, RedirectAddress);
                if (HasSeqId)
                    num1 += CodedOutputStream.ComputeStringSize(3, SeqId);
                if (HasInfo)
                    num1 += CodedOutputStream.ComputeStringSize(4, Info);
                var num2 = 0;
                foreach (var appid in AppidList)
                    num2 += CodedOutputStream.ComputeStringSizeNoTag(appid);
                var num3 = num1 + num2 + appid_.Count + UnknownFields.SerializedSize;
                this.memoizedSerializedSize = num3;
                return num3;
            }
        }

        public string GetAppid(int index)
        {
            return appid_[index];
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            var serializedSize = SerializedSize;
            var resultFieldNames = _gtAuthResultFieldNames;
            if (HasCode)
                output.WriteInt32(1, resultFieldNames[1], Code);
            if (HasRedirectAddress)
                output.WriteString(2, resultFieldNames[3], RedirectAddress);
            if (HasSeqId)
                output.WriteString(3, resultFieldNames[4], SeqId);
            if (HasInfo)
                output.WriteString(4, resultFieldNames[2], Info);
            if (appid_.Count > 0)
                output.WriteStringArray(5, resultFieldNames[0], appid_);
            UnknownFields.WriteTo(output);
        }

        public static GtAuthResult ParseFrom(ByteString data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public static GtAuthResult ParseFrom(
            ByteString data,
            ExtensionRegistry extensionRegistry)
        {
            return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
        }

        public static GtAuthResult ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public static GtAuthResult ParseFrom(
            byte[] data,
            ExtensionRegistry extensionRegistry)
        {
            return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
        }

        public static GtAuthResult ParseFrom(Stream input)
        {
            return CreateBuilder().MergeFrom(input).BuildParsed();
        }

        public static GtAuthResult ParseFrom(
            Stream input,
            ExtensionRegistry extensionRegistry)
        {
            return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
        }

        public static GtAuthResult ParseDelimitedFrom(Stream input)
        {
            return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
        }

        public static GtAuthResult ParseDelimitedFrom(
            Stream input,
            ExtensionRegistry extensionRegistry)
        {
            return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
        }

        public static GtAuthResult ParseFrom(ICodedInputStream input)
        {
            return CreateBuilder().MergeFrom(input).BuildParsed();
        }

        public static GtAuthResult ParseFrom(
            ICodedInputStream input,
            ExtensionRegistry extensionRegistry)
        {
            return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
        }

        private GtAuthResult MakeReadOnly()
        {
            appid_.MakeReadOnly();
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

        public static Builder CreateBuilder(GtAuthResult prototype)
        {
            return new Builder(prototype);
        }

        [DebuggerNonUserCode]
        public static class Types
        {
            public enum GtAuthResultCode
            {
                successed,
                failed_noSign,
                failed_noAppkey,
                failed_noTimestamp,
                failed_AuthIllegal,
                redirect
            }
        }

        [DebuggerNonUserCode]
        public sealed class Builder : GeneratedBuilder<GtAuthResult, Builder>
        {
            private GtAuthResult result;
            private bool resultIsReadOnly;

            public Builder()
            {
                result = DefaultInstance;
                resultIsReadOnly = true;
            }

            internal Builder(GtAuthResult cloneFrom)
            {
                result = cloneFrom;
                resultIsReadOnly = true;
            }

            protected override Builder ThisBuilder => this;

            public override bool IsInitialized => result.IsInitialized;

            protected override GtAuthResult MessageBeingBuilt => PrepareBuilder();

            public override MessageDescriptor DescriptorForType => Descriptor;

            public override GtAuthResult DefaultInstanceForType => DefaultInstance;

            public bool HasCode => result.HasCode;

            public int Code
            {
                get => result.Code;
                set => SetCode(value);
            }

            public bool HasRedirectAddress => result.HasRedirectAddress;

            public string RedirectAddress
            {
                get => result.RedirectAddress;
                set => SetRedirectAddress(value);
            }

            public bool HasSeqId => result.HasSeqId;

            public string SeqId
            {
                get => result.SeqId;
                set => SetSeqId(value);
            }

            public bool HasInfo => result.HasInfo;

            public string Info
            {
                get => result.Info;
                set => SetInfo(value);
            }

            public IPopsicleList<string> AppidList => PrepareBuilder().appid_;

            public int AppidCount => result.AppidCount;

            private GtAuthResult PrepareBuilder()
            {
                if (resultIsReadOnly)
                {
                    var result = this.result;
                    this.result = new GtAuthResult();
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

            public override GtAuthResult BuildPartial()
            {
                if (resultIsReadOnly)
                    return result;
                resultIsReadOnly = true;
                return result.MakeReadOnly();
            }

            public override Builder MergeFrom(IMessage other)
            {
                if (other is GtAuthResult)
                    return MergeFrom((GtAuthResult) other);
                base.MergeFrom(other);
                return this;
            }

            public override Builder MergeFrom(GtAuthResult other)
            {
                if (other == DefaultInstance)
                    return this;
                PrepareBuilder();
                if (other.HasCode)
                    Code = other.Code;
                if (other.HasRedirectAddress)
                    RedirectAddress = other.RedirectAddress;
                if (other.HasSeqId)
                    SeqId = other.SeqId;
                if (other.HasInfo)
                    Info = other.Info;
                if (other.appid_.Count != 0)
                    result.appid_.Add(other.appid_);
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
                var unknownFields = (UnknownFieldSet.Builder) null;
                uint fieldTag;
                string fieldName;
                while (input.ReadTag(out fieldTag, out fieldName))
                {
                    if (fieldTag == 0U && fieldName != null)
                    {
                        var index = Array.BinarySearch(_gtAuthResultFieldNames, fieldName, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            fieldTag = _gtAuthResultFieldTags[index];
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
                        case 8:
                            result.HasCode = input.ReadInt32(ref result.code_);
                            continue;
                        case 18:
                            result.HasRedirectAddress = input.ReadString(ref result.redirectAddress_);
                            continue;
                        case 26:
                            result.HasSeqId = input.ReadString(ref result.seqId_);
                            continue;
                        case 34:
                            result.HasInfo = input.ReadString(ref result.info_);
                            continue;
                        case 42:
                            input.ReadStringArray(fieldTag, fieldName, result.appid_);
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

            public Builder SetCode(int value)
            {
                PrepareBuilder();
                result.HasCode = true;
                result.code_ = value;
                return this;
            }

            public Builder ClearCode()
            {
                PrepareBuilder();
                result.HasCode = false;
                result.code_ = 0;
                return this;
            }

            public Builder SetRedirectAddress(string value)
            {
                ThrowHelper.ThrowIfNull(value, nameof(value));
                PrepareBuilder();
                result.HasRedirectAddress = true;
                result.redirectAddress_ = value;
                return this;
            }

            public Builder ClearRedirectAddress()
            {
                PrepareBuilder();
                result.HasRedirectAddress = false;
                result.redirectAddress_ = "";
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

            public Builder SetInfo(string value)
            {
                ThrowHelper.ThrowIfNull(value, nameof(value));
                PrepareBuilder();
                result.HasInfo = true;
                result.info_ = value;
                return this;
            }

            public Builder ClearInfo()
            {
                PrepareBuilder();
                result.HasInfo = false;
                result.info_ = "";
                return this;
            }

            public string GetAppid(int index)
            {
                return result.GetAppid(index);
            }

            public Builder SetAppid(int index, string value)
            {
                ThrowHelper.ThrowIfNull(value, nameof(value));
                PrepareBuilder();
                result.appid_[index] = value;
                return this;
            }

            public Builder AddAppid(string value)
            {
                ThrowHelper.ThrowIfNull(value, nameof(value));
                PrepareBuilder();
                result.appid_.Add(value);
                return this;
            }

            public Builder AddRangeAppid(IEnumerable<string> values)
            {
                PrepareBuilder();
                result.appid_.Add(values);
                return this;
            }

            public Builder ClearAppid()
            {
                PrepareBuilder();
                result.appid_.Clear();
                return this;
            }
        }
    }
}