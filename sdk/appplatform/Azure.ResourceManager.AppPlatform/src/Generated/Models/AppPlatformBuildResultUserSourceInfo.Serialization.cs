// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class AppPlatformBuildResultUserSourceInfo : IUtf8JsonSerializable, IJsonModel<AppPlatformBuildResultUserSourceInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppPlatformBuildResultUserSourceInfo>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AppPlatformBuildResultUserSourceInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformBuildResultUserSourceInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppPlatformBuildResultUserSourceInfo)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(BuildResultId))
            {
                writer.WritePropertyName("buildResultId"u8);
                writer.WriteStringValue(BuildResultId);
            }
        }

        AppPlatformBuildResultUserSourceInfo IJsonModel<AppPlatformBuildResultUserSourceInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformBuildResultUserSourceInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppPlatformBuildResultUserSourceInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppPlatformBuildResultUserSourceInfo(document.RootElement, options);
        }

        internal static AppPlatformBuildResultUserSourceInfo DeserializeAppPlatformBuildResultUserSourceInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string buildResultId = default;
            string type = default;
            string version = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("buildResultId"u8))
                {
                    buildResultId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AppPlatformBuildResultUserSourceInfo(type, version, serializedAdditionalRawData, buildResultId);
        }

        BinaryData IPersistableModel<AppPlatformBuildResultUserSourceInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformBuildResultUserSourceInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerAppPlatformContext.Default);
                default:
                    throw new FormatException($"The model {nameof(AppPlatformBuildResultUserSourceInfo)} does not support writing '{options.Format}' format.");
            }
        }

        AppPlatformBuildResultUserSourceInfo IPersistableModel<AppPlatformBuildResultUserSourceInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformBuildResultUserSourceInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAppPlatformBuildResultUserSourceInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AppPlatformBuildResultUserSourceInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppPlatformBuildResultUserSourceInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
