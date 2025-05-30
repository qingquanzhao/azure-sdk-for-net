// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.OracleDatabase.Models
{
    public partial class CloudExadataInfrastructureUpdateProperties : IUtf8JsonSerializable, IJsonModel<CloudExadataInfrastructureUpdateProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CloudExadataInfrastructureUpdateProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CloudExadataInfrastructureUpdateProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudExadataInfrastructureUpdateProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CloudExadataInfrastructureUpdateProperties)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(ComputeCount))
            {
                writer.WritePropertyName("computeCount"u8);
                writer.WriteNumberValue(ComputeCount.Value);
            }
            if (Optional.IsDefined(StorageCount))
            {
                writer.WritePropertyName("storageCount"u8);
                writer.WriteNumberValue(StorageCount.Value);
            }
            if (Optional.IsDefined(MaintenanceWindow))
            {
                writer.WritePropertyName("maintenanceWindow"u8);
                writer.WriteObjectValue(MaintenanceWindow, options);
            }
            if (Optional.IsCollectionDefined(CustomerContacts))
            {
                writer.WritePropertyName("customerContacts"u8);
                writer.WriteStartArray();
                foreach (var item in CustomerContacts)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
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

        CloudExadataInfrastructureUpdateProperties IJsonModel<CloudExadataInfrastructureUpdateProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudExadataInfrastructureUpdateProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CloudExadataInfrastructureUpdateProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCloudExadataInfrastructureUpdateProperties(document.RootElement, options);
        }

        internal static CloudExadataInfrastructureUpdateProperties DeserializeCloudExadataInfrastructureUpdateProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? computeCount = default;
            int? storageCount = default;
            OracleDatabaseMaintenanceWindow maintenanceWindow = default;
            IList<OracleCustomerContact> customerContacts = default;
            string displayName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("computeCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    computeCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("storageCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maintenanceWindow"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maintenanceWindow = OracleDatabaseMaintenanceWindow.DeserializeOracleDatabaseMaintenanceWindow(property.Value, options);
                    continue;
                }
                if (property.NameEquals("customerContacts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<OracleCustomerContact> array = new List<OracleCustomerContact>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(OracleCustomerContact.DeserializeOracleCustomerContact(item, options));
                    }
                    customerContacts = array;
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new CloudExadataInfrastructureUpdateProperties(
                computeCount,
                storageCount,
                maintenanceWindow,
                customerContacts ?? new ChangeTrackingList<OracleCustomerContact>(),
                displayName,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CloudExadataInfrastructureUpdateProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudExadataInfrastructureUpdateProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerOracleDatabaseContext.Default);
                default:
                    throw new FormatException($"The model {nameof(CloudExadataInfrastructureUpdateProperties)} does not support writing '{options.Format}' format.");
            }
        }

        CloudExadataInfrastructureUpdateProperties IPersistableModel<CloudExadataInfrastructureUpdateProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudExadataInfrastructureUpdateProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeCloudExadataInfrastructureUpdateProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CloudExadataInfrastructureUpdateProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CloudExadataInfrastructureUpdateProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
