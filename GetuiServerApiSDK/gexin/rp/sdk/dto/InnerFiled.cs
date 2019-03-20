using System;
using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Descriptors;
using Google.ProtocolBuffers.FieldAccess;

namespace com.gexin.rp.sdk.dto
{
    [DebuggerNonUserCode]
    public sealed class InnerFiled : GeneratedMessage<InnerFiled, InnerFiled.Builder>
    {
        public const int KeyFieldNumber = 1;
        public const int ValFieldNumber = 2;
        public const int TypeFieldNumber = 3;

        private static readonly string[] _innerFiledFieldNames = new string[3]
        {
            "key",
            "type",
            "val"
        };

        private static readonly uint[] _innerFiledFieldTags = new uint[3]
        {
            10U,
            24U,
            18U
        };

        private string key_ = "";
        private int memoizedSerializedSize = -1;
        private Types.Type type_;
        private string val_ = "";

        static InnerFiled()
        {
            var descriptor = GtReq.Descriptor;
        }

        private InnerFiled()
        {
        }

        public static InnerFiled DefaultInstance { get; } = new InnerFiled().MakeReadOnly();

        public override InnerFiled DefaultInstanceForType => DefaultInstance;

        protected override InnerFiled ThisMessage => this;

        public static MessageDescriptor Descriptor =>
            GtReq.internal__static_com_gexin_rp_sdk_dto_InnerFiled__Descriptor;

        protected override FieldAccessorTable<InnerFiled, Builder> InternalFieldAccessors =>
            GtReq.internal__static_com_gexin_rp_sdk_dto_InnerFiled__FieldAccessorTable;

        public bool HasKey { get; private set; }

        public string Key => key_;

        public bool HasVal { get; private set; }

        public string Val => val_;

        public bool HasType { get; private set; }

        public Types.Type Type => type_;

        public override bool IsInitialized => HasKey && HasVal && HasType;

        public override int SerializedSize
        {
            get
            {
                var memoizedSerializedSize = this.memoizedSerializedSize;
                if (memoizedSerializedSize != -1)
                    return memoizedSerializedSize;
                var num1 = 0;
                if (HasKey)
                    num1 += CodedOutputStream.ComputeStringSize(1, Key);
                if (HasVal)
                    num1 += CodedOutputStream.ComputeStringSize(2, Val);
                if (HasType)
                    num1 += CodedOutputStream.ComputeEnumSize(3, (int) Type);
                var num2 = num1 + UnknownFields.SerializedSize;
                this.memoizedSerializedSize = num2;
                return num2;
            }
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            var serializedSize = SerializedSize;
            var innerFiledFieldNames = _innerFiledFieldNames;
            if (HasKey)
                output.WriteString(1, innerFiledFieldNames[0], Key);
            if (HasVal)
                output.WriteString(2, innerFiledFieldNames[2], Val);
            if (HasType)
                output.WriteEnum(3, innerFiledFieldNames[1], (int) Type, Type);
            UnknownFields.WriteTo(output);
        }

        public static InnerFiled ParseFrom(ByteString data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public static InnerFiled ParseFrom(
            ByteString data,
            ExtensionRegistry extensionRegistry)
        {
            return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
        }

        public static InnerFiled ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public static InnerFiled ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
        {
            return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
        }

        public static InnerFiled ParseFrom(Stream input)
        {
            return CreateBuilder().MergeFrom(input).BuildParsed();
        }

        public static InnerFiled ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
        {
            return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
        }

        public static InnerFiled ParseDelimitedFrom(Stream input)
        {
            return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
        }

        public static InnerFiled ParseDelimitedFrom(
            Stream input,
            ExtensionRegistry extensionRegistry)
        {
            return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
        }

        public static InnerFiled ParseFrom(ICodedInputStream input)
        {
            return CreateBuilder().MergeFrom(input).BuildParsed();
        }

        public static InnerFiled ParseFrom(
            ICodedInputStream input,
            ExtensionRegistry extensionRegistry)
        {
            return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
        }

        private InnerFiled MakeReadOnly()
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

        public static Builder CreateBuilder(InnerFiled prototype)
        {
            return new Builder(prototype);
        }

        [DebuggerNonUserCode]
        public static class Types
        {
            public enum Type
            {
                str,
                int32,
                int64,
                floa,
                doub,
                boole
            }
        }

        [DebuggerNonUserCode]
        public sealed class Builder : GeneratedBuilder<InnerFiled, Builder>
        {
            private InnerFiled result;
            private bool resultIsReadOnly;

            public Builder()
            {
                result = DefaultInstance;
                resultIsReadOnly = true;
            }

            internal Builder(InnerFiled cloneFrom)
            {
                result = cloneFrom;
                resultIsReadOnly = true;
            }

            protected override Builder ThisBuilder => this;

            public override bool IsInitialized => result.IsInitialized;

            protected override InnerFiled MessageBeingBuilt => PrepareBuilder();

            public override MessageDescriptor DescriptorForType => Descriptor;

            public override InnerFiled DefaultInstanceForType => DefaultInstance;

            public bool HasKey => result.HasKey;

            public string Key
            {
                get => result.Key;
                set => SetKey(value);
            }

            public bool HasVal => result.HasVal;

            public string Val
            {
                get => result.Val;
                set => SetVal(value);
            }

            public bool HasType => result.HasType;

            public Types.Type Type
            {
                get => result.Type;
                set => SetType(value);
            }

            private InnerFiled PrepareBuilder()
            {
                if (resultIsReadOnly)
                {
                    var result = this.result;
                    this.result = new InnerFiled();
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

            public override InnerFiled BuildPartial()
            {
                if (resultIsReadOnly)
                    return result;
                resultIsReadOnly = true;
                return result.MakeReadOnly();
            }

            public override Builder MergeFrom(IMessage other)
            {
                if (other is InnerFiled)
                    return MergeFrom((InnerFiled) other);
                base.MergeFrom(other);
                return this;
            }

            public override Builder MergeFrom(InnerFiled other)
            {
                if (other == DefaultInstance)
                    return this;
                PrepareBuilder();
                if (other.HasKey)
                    Key = other.Key;
                if (other.HasVal)
                    Val = other.Val;
                if (other.HasType)
                    Type = other.Type;
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
                        var index = Array.BinarySearch(_innerFiledFieldNames, fieldName, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            fieldTag = _innerFiledFieldTags[index];
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
                            result.HasKey = input.ReadString(ref result.key_);
                            continue;
                        case 18:
                            result.HasVal = input.ReadString(ref result.val_);
                            continue;
                        case 24:
                            object unknown;
                            if (input.ReadEnum(ref result.type_, out unknown))
                            {
                                result.HasType = true;
                                continue;
                            }

                            if (unknown is int)
                            {
                                if (unknownFields == null)
                                    unknownFields = UnknownFieldSet.CreateBuilder(UnknownFields);
                                unknownFields.MergeVarintField(3, (ulong) (int) unknown);
                            }

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

            public Builder SetKey(string value)
            {
                ThrowHelper.ThrowIfNull(value, nameof(value));
                PrepareBuilder();
                result.HasKey = true;
                result.key_ = value;
                return this;
            }

            public Builder ClearKey()
            {
                PrepareBuilder();
                result.HasKey = false;
                result.key_ = "";
                return this;
            }

            public Builder SetVal(string value)
            {
                ThrowHelper.ThrowIfNull(value, nameof(value));
                PrepareBuilder();
                result.HasVal = true;
                result.val_ = value;
                return this;
            }

            public Builder ClearVal()
            {
                PrepareBuilder();
                result.HasVal = false;
                result.val_ = "";
                return this;
            }

            public Builder SetType(Types.Type value)
            {
                PrepareBuilder();
                result.HasType = true;
                result.type_ = value;
                return this;
            }

            public Builder ClearType()
            {
                PrepareBuilder();
                result.HasType = false;
                result.type_ = Types.Type.str;
                return this;
            }
        }
    }
}