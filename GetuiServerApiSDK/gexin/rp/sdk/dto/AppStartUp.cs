using System;
using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Descriptors;
using Google.ProtocolBuffers.FieldAccess;

namespace com.gexin.rp.sdk.dto
{
    [DebuggerNonUserCode]
    public sealed class AppStartUp : GeneratedMessage<AppStartUp, AppStartUp.Builder>
    {
        public const int AndroidFieldNumber = 1;
        public const int SymbiaFieldNumber = 2;
        public const int IosFieldNumber = 3;

        private static readonly string[] _appStartUpFieldNames = new string[3]
        {
            "android",
            "ios",
            "symbia"
        };

        private static readonly uint[] _appStartUpFieldTags = new uint[3]
        {
            10U,
            26U,
            18U
        };

        private string android_ = "";
        private string ios_ = "";
        private int memoizedSerializedSize = -1;
        private string symbia_ = "";

        static AppStartUp()
        {
            var descriptor = GtReq.Descriptor;
        }

        private AppStartUp()
        {
        }

        public static AppStartUp DefaultInstance { get; } = new AppStartUp().MakeReadOnly();

        public override AppStartUp DefaultInstanceForType => DefaultInstance;

        protected override AppStartUp ThisMessage => this;

        public static MessageDescriptor Descriptor =>
            GtReq.internal__static_com_gexin_rp_sdk_dto_AppStartUp__Descriptor;

        protected override FieldAccessorTable<AppStartUp, Builder> InternalFieldAccessors =>
            GtReq.internal__static_com_gexin_rp_sdk_dto_AppStartUp__FieldAccessorTable;

        public bool HasAndroid { get; private set; }

        public string Android => android_;

        public bool HasSymbia { get; private set; }

        public string Symbia => symbia_;

        public bool HasIos { get; private set; }

        public string Ios => ios_;

        public override bool IsInitialized => true;

        public override int SerializedSize
        {
            get
            {
                var memoizedSerializedSize = this.memoizedSerializedSize;
                if (memoizedSerializedSize != -1)
                    return memoizedSerializedSize;
                var num1 = 0;
                if (HasAndroid)
                    num1 += CodedOutputStream.ComputeStringSize(1, Android);
                if (HasSymbia)
                    num1 += CodedOutputStream.ComputeStringSize(2, Symbia);
                if (HasIos)
                    num1 += CodedOutputStream.ComputeStringSize(3, Ios);
                var num2 = num1 + UnknownFields.SerializedSize;
                this.memoizedSerializedSize = num2;
                return num2;
            }
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            var serializedSize = SerializedSize;
            var startUpFieldNames = _appStartUpFieldNames;
            if (HasAndroid)
                output.WriteString(1, startUpFieldNames[0], Android);
            if (HasSymbia)
                output.WriteString(2, startUpFieldNames[2], Symbia);
            if (HasIos)
                output.WriteString(3, startUpFieldNames[1], Ios);
            UnknownFields.WriteTo(output);
        }

        public static AppStartUp ParseFrom(ByteString data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public static AppStartUp ParseFrom(
            ByteString data,
            ExtensionRegistry extensionRegistry)
        {
            return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
        }

        public static AppStartUp ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public static AppStartUp ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
        {
            return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
        }

        public static AppStartUp ParseFrom(Stream input)
        {
            return CreateBuilder().MergeFrom(input).BuildParsed();
        }

        public static AppStartUp ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
        {
            return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
        }

        public static AppStartUp ParseDelimitedFrom(Stream input)
        {
            return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
        }

        public static AppStartUp ParseDelimitedFrom(
            Stream input,
            ExtensionRegistry extensionRegistry)
        {
            return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
        }

        public static AppStartUp ParseFrom(ICodedInputStream input)
        {
            return CreateBuilder().MergeFrom(input).BuildParsed();
        }

        public static AppStartUp ParseFrom(
            ICodedInputStream input,
            ExtensionRegistry extensionRegistry)
        {
            return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
        }

        private AppStartUp MakeReadOnly()
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

        public static Builder CreateBuilder(AppStartUp prototype)
        {
            return new Builder(prototype);
        }

        [DebuggerNonUserCode]
        public sealed class Builder : GeneratedBuilder<AppStartUp, Builder>
        {
            private AppStartUp result;
            private bool resultIsReadOnly;

            public Builder()
            {
                result = DefaultInstance;
                resultIsReadOnly = true;
            }

            internal Builder(AppStartUp cloneFrom)
            {
                result = cloneFrom;
                resultIsReadOnly = true;
            }

            protected override Builder ThisBuilder => this;

            public override bool IsInitialized => result.IsInitialized;

            protected override AppStartUp MessageBeingBuilt => PrepareBuilder();

            public override MessageDescriptor DescriptorForType => Descriptor;

            public override AppStartUp DefaultInstanceForType => DefaultInstance;

            public bool HasAndroid => result.HasAndroid;

            public string Android
            {
                get => result.Android;
                set => SetAndroid(value);
            }

            public bool HasSymbia => result.HasSymbia;

            public string Symbia
            {
                get => result.Symbia;
                set => SetSymbia(value);
            }

            public bool HasIos => result.HasIos;

            public string Ios
            {
                get => result.Ios;
                set => SetIos(value);
            }

            private AppStartUp PrepareBuilder()
            {
                if (resultIsReadOnly)
                {
                    var result = this.result;
                    this.result = new AppStartUp();
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

            public override AppStartUp BuildPartial()
            {
                if (resultIsReadOnly)
                    return result;
                resultIsReadOnly = true;
                return result.MakeReadOnly();
            }

            public override Builder MergeFrom(IMessage other)
            {
                if (other is AppStartUp)
                    return MergeFrom((AppStartUp) other);
                base.MergeFrom(other);
                return this;
            }

            public override Builder MergeFrom(AppStartUp other)
            {
                if (other == DefaultInstance)
                    return this;
                PrepareBuilder();
                if (other.HasAndroid)
                    Android = other.Android;
                if (other.HasSymbia)
                    Symbia = other.Symbia;
                if (other.HasIos)
                    Ios = other.Ios;
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
                        var index = Array.BinarySearch(_appStartUpFieldNames, fieldName, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            fieldTag = _appStartUpFieldTags[index];
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
                            result.HasAndroid = input.ReadString(ref result.android_);
                            continue;
                        case 18:
                            result.HasSymbia = input.ReadString(ref result.symbia_);
                            continue;
                        case 26:
                            result.HasIos = input.ReadString(ref result.ios_);
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

            public Builder SetAndroid(string value)
            {
                ThrowHelper.ThrowIfNull(value, nameof(value));
                PrepareBuilder();
                result.HasAndroid = true;
                result.android_ = value;
                return this;
            }

            public Builder ClearAndroid()
            {
                PrepareBuilder();
                result.HasAndroid = false;
                result.android_ = "";
                return this;
            }

            public Builder SetSymbia(string value)
            {
                ThrowHelper.ThrowIfNull(value, nameof(value));
                PrepareBuilder();
                result.HasSymbia = true;
                result.symbia_ = value;
                return this;
            }

            public Builder ClearSymbia()
            {
                PrepareBuilder();
                result.HasSymbia = false;
                result.symbia_ = "";
                return this;
            }

            public Builder SetIos(string value)
            {
                ThrowHelper.ThrowIfNull(value, nameof(value));
                PrepareBuilder();
                result.HasIos = true;
                result.ios_ = value;
                return this;
            }

            public Builder ClearIos()
            {
                PrepareBuilder();
                result.HasIos = false;
                result.ios_ = "";
                return this;
            }
        }
    }
}