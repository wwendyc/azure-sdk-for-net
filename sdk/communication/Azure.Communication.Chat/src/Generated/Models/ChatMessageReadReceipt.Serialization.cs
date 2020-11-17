// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.Chat
{
    public partial class ChatMessageReadReceipt
    {
        internal static ChatMessageReadReceipt DeserializeChatMessageReadReceipt(JsonElement element)
        {
            Optional<string> senderId = default;
            Optional<string> chatMessageId = default;
            Optional<DateTimeOffset> readOn = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("senderId"))
                {
                    senderId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("chatMessageId"))
                {
                    chatMessageId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("readOn"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    readOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new ChatMessageReadReceipt(senderId.Value, chatMessageId.Value, Optional.ToNullable(readOn));
        }
    }
}