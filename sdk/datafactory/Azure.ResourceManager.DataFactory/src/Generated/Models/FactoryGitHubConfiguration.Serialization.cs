// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class FactoryGitHubConfiguration : IUtf8JsonSerializable, IJsonModel<FactoryGitHubConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FactoryGitHubConfiguration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<FactoryGitHubConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FactoryGitHubConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FactoryGitHubConfiguration)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(HostName))
            {
                writer.WritePropertyName("hostName"u8);
                writer.WriteStringValue(HostName);
            }
            if (Optional.IsDefined(ClientId))
            {
                writer.WritePropertyName("clientId"u8);
                writer.WriteStringValue(ClientId);
            }
            if (Optional.IsDefined(ClientSecret))
            {
                writer.WritePropertyName("clientSecret"u8);
                writer.WriteObjectValue(ClientSecret, options);
            }
        }

        FactoryGitHubConfiguration IJsonModel<FactoryGitHubConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FactoryGitHubConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FactoryGitHubConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFactoryGitHubConfiguration(document.RootElement, options);
        }

        internal static FactoryGitHubConfiguration DeserializeFactoryGitHubConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string hostName = default;
            string clientId = default;
            FactoryGitHubClientSecret clientSecret = default;
            string type = default;
            string accountName = default;
            string repositoryName = default;
            string collaborationBranch = default;
            string rootFolder = default;
            string lastCommitId = default;
            bool? disablePublish = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hostName"u8))
                {
                    hostName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientId"u8))
                {
                    clientId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientSecret"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    clientSecret = FactoryGitHubClientSecret.DeserializeFactoryGitHubClientSecret(property.Value, options);
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("accountName"u8))
                {
                    accountName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("repositoryName"u8))
                {
                    repositoryName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("collaborationBranch"u8))
                {
                    collaborationBranch = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rootFolder"u8))
                {
                    rootFolder = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastCommitId"u8))
                {
                    lastCommitId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("disablePublish"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    disablePublish = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new FactoryGitHubConfiguration(
                type,
                accountName,
                repositoryName,
                collaborationBranch,
                rootFolder,
                lastCommitId,
                disablePublish,
                serializedAdditionalRawData,
                hostName,
                clientId,
                clientSecret);
        }

        BinaryData IPersistableModel<FactoryGitHubConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FactoryGitHubConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerDataFactoryContext.Default);
                default:
                    throw new FormatException($"The model {nameof(FactoryGitHubConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        FactoryGitHubConfiguration IPersistableModel<FactoryGitHubConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FactoryGitHubConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeFactoryGitHubConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FactoryGitHubConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<FactoryGitHubConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
