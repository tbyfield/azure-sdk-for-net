// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Security.KeyVault.Administration.Models
{
    internal partial class SASTokenParameter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("storageResourceUri"u8);
            writer.WriteStringValue(StorageResourceUri);
            writer.WritePropertyName("token"u8);
            writer.WriteStringValue(Token);
            writer.WriteEndObject();
        }
    }
}
