// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    public partial class BatchNetworkProfile : IUtf8JsonSerializable, IJsonModel<BatchNetworkProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BatchNetworkProfile>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<BatchNetworkProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchNetworkProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchNetworkProfile)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(AccountAccess))
            {
                writer.WritePropertyName("accountAccess"u8);
                writer.WriteObjectValue(AccountAccess, options);
            }
            if (Optional.IsDefined(NodeManagementAccess))
            {
                writer.WritePropertyName("nodeManagementAccess"u8);
                writer.WriteObjectValue(NodeManagementAccess, options);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value, ModelSerializationExtensions.JsonDocumentOptions))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        BatchNetworkProfile IJsonModel<BatchNetworkProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchNetworkProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchNetworkProfile)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBatchNetworkProfile(document.RootElement, options);
        }

        internal static BatchNetworkProfile DeserializeBatchNetworkProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            BatchEndpointAccessProfile accountAccess = default;
            BatchEndpointAccessProfile nodeManagementAccess = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("accountAccess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    accountAccess = BatchEndpointAccessProfile.DeserializeBatchEndpointAccessProfile(property.Value, options);
                    continue;
                }
                if (property.NameEquals("nodeManagementAccess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nodeManagementAccess = BatchEndpointAccessProfile.DeserializeBatchEndpointAccessProfile(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new BatchNetworkProfile(accountAccess, nodeManagementAccess, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BatchNetworkProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchNetworkProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerBatchContext.Default);
                default:
                    throw new FormatException($"The model {nameof(BatchNetworkProfile)} does not support writing '{options.Format}' format.");
            }
        }

        BatchNetworkProfile IPersistableModel<BatchNetworkProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchNetworkProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeBatchNetworkProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BatchNetworkProfile)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BatchNetworkProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
