// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.AppService
{
    public partial class SiteDiagnosticDetectorResource : IJsonModel<DetectorDefinitionResourceData>
    {
        private static DetectorDefinitionResourceData s_dataDeserializationInstance;
        private static DetectorDefinitionResourceData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<DetectorDefinitionResourceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<DetectorDefinitionResourceData>)Data).Write(writer, options);

        DetectorDefinitionResourceData IJsonModel<DetectorDefinitionResourceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<DetectorDefinitionResourceData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<DetectorDefinitionResourceData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<DetectorDefinitionResourceData>(Data, options, AzureResourceManagerAppServiceContext.Default);

        DetectorDefinitionResourceData IPersistableModel<DetectorDefinitionResourceData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<DetectorDefinitionResourceData>(data, options, AzureResourceManagerAppServiceContext.Default);

        string IPersistableModel<DetectorDefinitionResourceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<DetectorDefinitionResourceData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
