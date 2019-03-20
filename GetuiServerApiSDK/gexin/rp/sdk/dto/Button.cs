using System;
using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Descriptors;
using Google.ProtocolBuffers.FieldAccess;

namespace com.gexin.rp.sdk.dto
{
    [DebuggerNonUserCode]
    public sealed class Button : GeneratedMessage<Button, Button.Builder>
    {
        public const int TextFieldNumber = 1;
        public const int NextFieldNumber = 2;

        private static readonly string[] _buttonFieldNames = new string[2]
        {
            "next",
            "text"
        };

        private static readonly uint[] _buttonFieldTags = new uint[2]
        {
            16U,
            10U
        };

        private int memoizedSerializedSize = -1;
        private int next_;
        private string text_ = "";

        static Button()
        {
            var descriptor = GtReq.Descriptor;
        }

        private Button()
        {
        }

        public static Button DefaultInstance { get; } = new Button().MakeReadOnly();

        public override Button DefaultInstanceForType => DefaultInstance;

        protected override Button ThisMessage => this;

        public static MessageDescriptor Descriptor => GtReq.internal__static_com_gexin_rp_sdk_dto_Button__Descriptor;

        protected override FieldAccessorTable<Button, Builder> InternalFieldAccessors =>
            GtReq.internal__static_com_gexin_rp_sdk_dto_Button__FieldAccessorTable;

        public bool HasText { get; private set; }

        public string Text => text_;

        public bool HasNext { get; private set; }

        public int Next => next_;

        public override bool IsInitialized => true;

        public override int SerializedSize
        {
            get
            {
                var memoizedSerializedSize = this.memoizedSerializedSize;
                if (memoizedSerializedSize != -1)
                    return memoizedSerializedSize;
                var num1 = 0;
                if (HasText)
                    num1 += CodedOutputStream.ComputeStringSize(1, Text);
                if (HasNext)
                    num1 += CodedOutputStream.ComputeInt32Size(2, Next);
                var num2 = num1 + UnknownFields.SerializedSize;
                this.memoizedSerializedSize = num2;
                return num2;
            }
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            var serializedSize = SerializedSize;
            var buttonFieldNames = _buttonFieldNames;
            if (HasText)
                output.WriteString(1, buttonFieldNames[1], Text);
            if (HasNext)
                output.WriteInt32(2, buttonFieldNames[0], Next);
            UnknownFields.WriteTo(output);
        }

        public static Button ParseFrom(ByteString data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public static Button ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
        {
            return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
        }

        public static Button ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public static Button ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
        {
            return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
        }

        public static Button ParseFrom(Stream input)
        {
            return CreateBuilder().MergeFrom(input).BuildParsed();
        }

        public static Button ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
        {
            return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
        }

        public static Button ParseDelimitedFrom(Stream input)
        {
            return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
        }

        public static Button ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
        {
            return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
        }

        public static Button ParseFrom(ICodedInputStream input)
        {
            return CreateBuilder().MergeFrom(input).BuildParsed();
        }

        public static Button ParseFrom(
            ICodedInputStream input,
            ExtensionRegistry extensionRegistry)
        {
            return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
        }

        private Button MakeReadOnly()
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

        public static Builder CreateBuilder(Button prototype)
        {
            return new Builder(prototype);
        }

        [DebuggerNonUserCode]
        public sealed class Builder : GeneratedBuilder<Button, Builder>
        {
            private Button result;
            private bool resultIsReadOnly;

            public Builder()
            {
                result = DefaultInstance;
                resultIsReadOnly = true;
            }

            internal Builder(Button cloneFrom)
            {
                result = cloneFrom;
                resultIsReadOnly = true;
            }

            protected override Builder ThisBuilder => this;

            public override bool IsInitialized => result.IsInitialized;

            protected override Button MessageBeingBuilt => PrepareBuilder();

            public override MessageDescriptor DescriptorForType => Descriptor;

            public override Button DefaultInstanceForType => DefaultInstance;

            public bool HasText => result.HasText;

            public string Text
            {
                get => result.Text;
                set => SetText(value);
            }

            public bool HasNext => result.HasNext;

            public int Next
            {
                get => result.Next;
                set => SetNext(value);
            }

            private Button PrepareBuilder()
            {
                if (resultIsReadOnly)
                {
                    var result = this.result;
                    this.result = new Button();
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

            public override Button BuildPartial()
            {
                if (resultIsReadOnly)
                    return result;
                resultIsReadOnly = true;
                return result.MakeReadOnly();
            }

            public override Builder MergeFrom(IMessage other)
            {
                if (other is Button)
                    return MergeFrom((Button) other);
                base.MergeFrom(other);
                return this;
            }

            public override Builder MergeFrom(Button other)
            {
                if (other == DefaultInstance)
                    return this;
                PrepareBuilder();
                if (other.HasText)
                    Text = other.Text;
                if (other.HasNext)
                    Next = other.Next;
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
                        var index = Array.BinarySearch(_buttonFieldNames, fieldName, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            fieldTag = _buttonFieldTags[index];
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
                            result.HasText = input.ReadString(ref result.text_);
                            continue;
                        case 16:
                            result.HasNext = input.ReadInt32(ref result.next_);
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

            public Builder SetText(string value)
            {
                ThrowHelper.ThrowIfNull(value, nameof(value));
                PrepareBuilder();
                result.HasText = true;
                result.text_ = value;
                return this;
            }

            public Builder ClearText()
            {
                PrepareBuilder();
                result.HasText = false;
                result.text_ = "";
                return this;
            }

            public Builder SetNext(int value)
            {
                PrepareBuilder();
                result.HasNext = true;
                result.next_ = value;
                return this;
            }

            public Builder ClearNext()
            {
                PrepareBuilder();
                result.HasNext = false;
                result.next_ = 0;
                return this;
            }
        }
    }
}