// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.IoT.Hub.Service.Models
{
    public partial class DeviceJobStatistics
    {
        internal static DeviceJobStatistics DeserializeDeviceJobStatistics(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? deviceCount = default;
            int? failedCount = default;
            int? succeededCount = default;
            int? runningCount = default;
            int? pendingCount = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("deviceCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deviceCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("failedCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    failedCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("succeededCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    succeededCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("runningCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    runningCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("pendingCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pendingCount = property.Value.GetInt32();
                    continue;
                }
            }
            return new DeviceJobStatistics(deviceCount, failedCount, succeededCount, runningCount, pendingCount);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DeviceJobStatistics FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeDeviceJobStatistics(document.RootElement);
        }
    }
}
