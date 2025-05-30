// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Blueprint
{
    public partial class BlueprintResource : IJsonModel<BlueprintData>
    {
        private static BlueprintData s_dataDeserializationInstance;
        private static BlueprintData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<BlueprintData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<BlueprintData>)Data).Write(writer, options);

        BlueprintData IJsonModel<BlueprintData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<BlueprintData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<BlueprintData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<BlueprintData>(Data, options, AzureResourceManagerBlueprintContext.Default);

        BlueprintData IPersistableModel<BlueprintData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<BlueprintData>(data, options, AzureResourceManagerBlueprintContext.Default);

        string IPersistableModel<BlueprintData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<BlueprintData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
