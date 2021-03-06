// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class DataLakeStorageAccountDetails : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AccountUrl))
            {
                writer.WritePropertyName("accountUrl");
                writer.WriteStringValue(AccountUrl);
            }
            if (Optional.IsDefined(Filesystem))
            {
                writer.WritePropertyName("filesystem");
                writer.WriteStringValue(Filesystem);
            }
            writer.WriteEndObject();
        }

        internal static DataLakeStorageAccountDetails DeserializeDataLakeStorageAccountDetails(JsonElement element)
        {
            Optional<string> accountUrl = default;
            Optional<string> filesystem = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("accountUrl"))
                {
                    accountUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("filesystem"))
                {
                    filesystem = property.Value.GetString();
                    continue;
                }
            }
            return new DataLakeStorageAccountDetails(accountUrl.Value, filesystem.Value);
        }
    }
}
