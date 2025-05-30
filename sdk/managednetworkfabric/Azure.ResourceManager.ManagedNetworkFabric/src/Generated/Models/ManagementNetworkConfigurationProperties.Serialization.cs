// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    public partial class ManagementNetworkConfigurationProperties : IUtf8JsonSerializable, IJsonModel<ManagementNetworkConfigurationProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagementNetworkConfigurationProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ManagementNetworkConfigurationProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagementNetworkConfigurationProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagementNetworkConfigurationProperties)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("infrastructureVpnConfiguration"u8);
            writer.WriteObjectValue(InfrastructureVpnConfiguration, options);
            writer.WritePropertyName("workloadVpnConfiguration"u8);
            writer.WriteObjectValue(WorkloadVpnConfiguration, options);
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

        ManagementNetworkConfigurationProperties IJsonModel<ManagementNetworkConfigurationProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagementNetworkConfigurationProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagementNetworkConfigurationProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagementNetworkConfigurationProperties(document.RootElement, options);
        }

        internal static ManagementNetworkConfigurationProperties DeserializeManagementNetworkConfigurationProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            VpnConfigurationProperties infrastructureVpnConfiguration = default;
            VpnConfigurationProperties workloadVpnConfiguration = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("infrastructureVpnConfiguration"u8))
                {
                    infrastructureVpnConfiguration = VpnConfigurationProperties.DeserializeVpnConfigurationProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("workloadVpnConfiguration"u8))
                {
                    workloadVpnConfiguration = VpnConfigurationProperties.DeserializeVpnConfigurationProperties(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ManagementNetworkConfigurationProperties(infrastructureVpnConfiguration, workloadVpnConfiguration, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ManagementNetworkConfigurationProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagementNetworkConfigurationProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerManagedNetworkFabricContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ManagementNetworkConfigurationProperties)} does not support writing '{options.Format}' format.");
            }
        }

        ManagementNetworkConfigurationProperties IPersistableModel<ManagementNetworkConfigurationProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagementNetworkConfigurationProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeManagementNetworkConfigurationProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagementNetworkConfigurationProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagementNetworkConfigurationProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
