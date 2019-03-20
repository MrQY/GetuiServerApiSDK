using System;
using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Descriptors;
using Google.ProtocolBuffers.FieldAccess;

namespace com.gexin.rp.sdk.dto
{
    [DebuggerNonUserCode]
    public sealed class EndBatchTask : GeneratedMessage<EndBatchTask, EndBatchTask.Builder>
    {
        public const int TaskIdFieldNumber = 1;
        public const int SeqIdFieldNumber = 2;

        private static readonly string[] _endBatchTaskFieldNames = new string[2]
        {
            "seqId",
            "taskId"
        };

        private static readonly uint[] _endBatchTaskFieldTags = new uint[2]
        {
            18U,
            10U
        };

        private int memoizedSerializedSize = -1;
        private string seqId_ = "";
        private string taskId_ = "";

        static EndBatchTask()
        {
            var descriptor = GtReq.Descriptor;
        }

        private EndBatchTask()
        {
        }

        public static EndBatchTask DefaultInstance { get; } = new EndBatchTask().MakeReadOnly();

        public override EndBatchTask DefaultInstanceForType => DefaultInstance;

        protected override EndBatchTask ThisMessage => this;

        public static MessageDescriptor Descriptor =>
            GtReq.internal__static_com_gexin_rp_sdk_dto_EndBatchTask__Descriptor;

        protected override FieldAccessorTable<EndBatchTask, Builder> InternalFieldAccessors =>
            GtReq.internal__static_com_gexin_rp_sdk_dto_EndBatchTask__FieldAccessorTable;

        public bool HasTaskId { get; private set; }

        public string TaskId => taskId_;

        public bool HasSeqId { get; private set; }

        public string SeqId => seqId_;

        public override bool IsInitialized => HasTaskId;

        public override int SerializedSize
        {
            get
            {
                var memoizedSerializedSize = this.memoizedSerializedSize;
                if (memoizedSerializedSize != -1)
                    return memoizedSerializedSize;
                var num1 = 0;
                if (HasTaskId)
                    num1 += CodedOutputStream.ComputeStringSize(1, TaskId);
                if (HasSeqId)
                    num1 += CodedOutputStream.ComputeStringSize(2, SeqId);
                var num2 = num1 + UnknownFields.SerializedSize;
                this.memoizedSerializedSize = num2;
                return num2;
            }
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            var serializedSize = SerializedSize;
            var batchTaskFieldNames = _endBatchTaskFieldNames;
            if (HasTaskId)
                output.WriteString(1, batchTaskFieldNames[1], TaskId);
            if (HasSeqId)
                output.WriteString(2, batchTaskFieldNames[0], SeqId);
            UnknownFields.WriteTo(output);
        }

        public static EndBatchTask ParseFrom(ByteString data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public static EndBatchTask ParseFrom(
            ByteString data,
            ExtensionRegistry extensionRegistry)
        {
            return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
        }

        public static EndBatchTask ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public static EndBatchTask ParseFrom(
            byte[] data,
            ExtensionRegistry extensionRegistry)
        {
            return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
        }

        public static EndBatchTask ParseFrom(Stream input)
        {
            return CreateBuilder().MergeFrom(input).BuildParsed();
        }

        public static EndBatchTask ParseFrom(
            Stream input,
            ExtensionRegistry extensionRegistry)
        {
            return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
        }

        public static EndBatchTask ParseDelimitedFrom(Stream input)
        {
            return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
        }

        public static EndBatchTask ParseDelimitedFrom(
            Stream input,
            ExtensionRegistry extensionRegistry)
        {
            return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
        }

        public static EndBatchTask ParseFrom(ICodedInputStream input)
        {
            return CreateBuilder().MergeFrom(input).BuildParsed();
        }

        public static EndBatchTask ParseFrom(
            ICodedInputStream input,
            ExtensionRegistry extensionRegistry)
        {
            return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
        }

        private EndBatchTask MakeReadOnly()
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

        public static Builder CreateBuilder(EndBatchTask prototype)
        {
            return new Builder(prototype);
        }

        [DebuggerNonUserCode]
        public sealed class Builder : GeneratedBuilder<EndBatchTask, Builder>
        {
            private EndBatchTask result;
            private bool resultIsReadOnly;

            public Builder()
            {
                result = DefaultInstance;
                resultIsReadOnly = true;
            }

            internal Builder(EndBatchTask cloneFrom)
            {
                result = cloneFrom;
                resultIsReadOnly = true;
            }

            protected override Builder ThisBuilder => this;

            public override bool IsInitialized => result.IsInitialized;

            protected override EndBatchTask MessageBeingBuilt => PrepareBuilder();

            public override MessageDescriptor DescriptorForType => Descriptor;

            public override EndBatchTask DefaultInstanceForType => DefaultInstance;

            public bool HasTaskId => result.HasTaskId;

            public string TaskId
            {
                get => result.TaskId;
                set => SetTaskId(value);
            }

            public bool HasSeqId => result.HasSeqId;

            public string SeqId
            {
                get => result.SeqId;
                set => SetSeqId(value);
            }

            private EndBatchTask PrepareBuilder()
            {
                if (resultIsReadOnly)
                {
                    var result = this.result;
                    this.result = new EndBatchTask();
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

            public override EndBatchTask BuildPartial()
            {
                if (resultIsReadOnly)
                    return result;
                resultIsReadOnly = true;
                return result.MakeReadOnly();
            }

            public override Builder MergeFrom(IMessage other)
            {
                if (other is EndBatchTask)
                    return MergeFrom((EndBatchTask) other);
                base.MergeFrom(other);
                return this;
            }

            public override Builder MergeFrom(EndBatchTask other)
            {
                if (other == DefaultInstance)
                    return this;
                PrepareBuilder();
                if (other.HasTaskId)
                    TaskId = other.TaskId;
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
                        var index = Array.BinarySearch(_endBatchTaskFieldNames, fieldName, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            fieldTag = _endBatchTaskFieldTags[index];
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
                            result.HasTaskId = input.ReadString(ref result.taskId_);
                            continue;
                        case 18:
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

            public Builder SetTaskId(string value)
            {
                ThrowHelper.ThrowIfNull(value, nameof(value));
                PrepareBuilder();
                result.HasTaskId = true;
                result.taskId_ = value;
                return this;
            }

            public Builder ClearTaskId()
            {
                PrepareBuilder();
                result.HasTaskId = false;
                result.taskId_ = "";
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