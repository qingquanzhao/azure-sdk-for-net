// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.Messages.Models.Channels
{
    public partial class WhatsAppMessageTemplateBindingsButton : IUtf8JsonSerializable, IJsonModel<WhatsAppMessageTemplateBindingsButton>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WhatsAppMessageTemplateBindingsButton>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<WhatsAppMessageTemplateBindingsButton>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WhatsAppMessageTemplateBindingsButton>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WhatsAppMessageTemplateBindingsButton)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("subType"u8);
            writer.WriteStringValue(SubType);
            writer.WritePropertyName("refValue"u8);
            writer.WriteStringValue(RefValue);
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

        WhatsAppMessageTemplateBindingsButton IJsonModel<WhatsAppMessageTemplateBindingsButton>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WhatsAppMessageTemplateBindingsButton>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WhatsAppMessageTemplateBindingsButton)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWhatsAppMessageTemplateBindingsButton(document.RootElement, options);
        }

        internal static WhatsAppMessageTemplateBindingsButton DeserializeWhatsAppMessageTemplateBindingsButton(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string subType = default;
            string refValue = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("subType"u8))
                {
                    subType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("refValue"u8))
                {
                    refValue = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new WhatsAppMessageTemplateBindingsButton(subType, refValue, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<WhatsAppMessageTemplateBindingsButton>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WhatsAppMessageTemplateBindingsButton>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureCommunicationMessagesContext.Default);
                default:
                    throw new FormatException($"The model {nameof(WhatsAppMessageTemplateBindingsButton)} does not support writing '{options.Format}' format.");
            }
        }

        WhatsAppMessageTemplateBindingsButton IPersistableModel<WhatsAppMessageTemplateBindingsButton>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WhatsAppMessageTemplateBindingsButton>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeWhatsAppMessageTemplateBindingsButton(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WhatsAppMessageTemplateBindingsButton)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<WhatsAppMessageTemplateBindingsButton>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static WhatsAppMessageTemplateBindingsButton FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeWhatsAppMessageTemplateBindingsButton(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
