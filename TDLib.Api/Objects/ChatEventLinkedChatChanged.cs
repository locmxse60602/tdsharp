using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        /// <summary>
        /// The linked chat of a supergroup was changed 
        /// </summary>
        public partial class ChatEventAction : Object
        {
            /// <summary>
            /// The linked chat of a supergroup was changed 
            /// </summary>
            public class ChatEventLinkedChatChanged : ChatEventAction
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "chatEventLinkedChatChanged";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Previous supergroup linked chat identifier 
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("old_linked_chat_id")]
                public long OldLinkedChatId { get; set; }

                /// <summary>
                /// New supergroup linked chat identifier
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("new_linked_chat_id")]
                public long NewLinkedChatId { get; set; }
            }
        }
    }
}