// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.RealtimeConversation
{
    internal abstract partial class InternalRealtimeToolChoiceObject
    {
        internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; set; }
        protected InternalRealtimeToolChoiceObject()
        {
        }

        internal InternalRealtimeToolChoiceObject(ConversationToolKind type, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Type = type;
            SerializedAdditionalRawData = serializedAdditionalRawData;
        }

        internal ConversationToolKind Type { get; set; }
    }
}