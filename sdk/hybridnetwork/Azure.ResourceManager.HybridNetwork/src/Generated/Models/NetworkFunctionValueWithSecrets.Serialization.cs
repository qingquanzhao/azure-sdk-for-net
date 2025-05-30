// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    public partial class NetworkFunctionValueWithSecrets : IUtf8JsonSerializable, IJsonModel<NetworkFunctionValueWithSecrets>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkFunctionValueWithSecrets>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<NetworkFunctionValueWithSecrets>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkFunctionValueWithSecrets>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkFunctionValueWithSecrets)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(SecretDeploymentValues))
            {
                writer.WritePropertyName("secretDeploymentValues"u8);
                writer.WriteStringValue(SecretDeploymentValues);
            }
        }

        NetworkFunctionValueWithSecrets IJsonModel<NetworkFunctionValueWithSecrets>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkFunctionValueWithSecrets>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkFunctionValueWithSecrets)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkFunctionValueWithSecrets(document.RootElement, options);
        }

        internal static NetworkFunctionValueWithSecrets DeserializeNetworkFunctionValueWithSecrets(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string secretDeploymentValues = default;
            ProvisioningState? provisioningState = default;
            string publisherName = default;
            PublisherScope? publisherScope = default;
            string networkFunctionDefinitionGroupName = default;
            string networkFunctionDefinitionVersion = default;
            string networkFunctionDefinitionOfferingLocation = default;
            DeploymentResourceIdReference networkFunctionDefinitionVersionResourceReference = default;
            NfviType? nfviType = default;
            ResourceIdentifier nfviId = default;
            bool? allowSoftwareUpdate = default;
            NetworkFunctionConfigurationType configurationType = default;
            IList<string> roleOverrideValues = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("secretDeploymentValues"u8))
                {
                    secretDeploymentValues = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("publisherName"u8))
                {
                    publisherName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("publisherScope"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publisherScope = new PublisherScope(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("networkFunctionDefinitionGroupName"u8))
                {
                    networkFunctionDefinitionGroupName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("networkFunctionDefinitionVersion"u8))
                {
                    networkFunctionDefinitionVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("networkFunctionDefinitionOfferingLocation"u8))
                {
                    networkFunctionDefinitionOfferingLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("networkFunctionDefinitionVersionResourceReference"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    networkFunctionDefinitionVersionResourceReference = DeploymentResourceIdReference.DeserializeDeploymentResourceIdReference(property.Value, options);
                    continue;
                }
                if (property.NameEquals("nfviType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nfviType = new NfviType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("nfviId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nfviId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("allowSoftwareUpdate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allowSoftwareUpdate = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("configurationType"u8))
                {
                    configurationType = new NetworkFunctionConfigurationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("roleOverrideValues"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    roleOverrideValues = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new NetworkFunctionValueWithSecrets(
                provisioningState,
                publisherName,
                publisherScope,
                networkFunctionDefinitionGroupName,
                networkFunctionDefinitionVersion,
                networkFunctionDefinitionOfferingLocation,
                networkFunctionDefinitionVersionResourceReference,
                nfviType,
                nfviId,
                allowSoftwareUpdate,
                configurationType,
                roleOverrideValues ?? new ChangeTrackingList<string>(),
                serializedAdditionalRawData,
                secretDeploymentValues);
        }

        BinaryData IPersistableModel<NetworkFunctionValueWithSecrets>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkFunctionValueWithSecrets>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerHybridNetworkContext.Default);
                default:
                    throw new FormatException($"The model {nameof(NetworkFunctionValueWithSecrets)} does not support writing '{options.Format}' format.");
            }
        }

        NetworkFunctionValueWithSecrets IPersistableModel<NetworkFunctionValueWithSecrets>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkFunctionValueWithSecrets>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeNetworkFunctionValueWithSecrets(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetworkFunctionValueWithSecrets)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetworkFunctionValueWithSecrets>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
