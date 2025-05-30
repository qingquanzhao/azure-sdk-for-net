// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Grafana
{
    public partial class ManagedPrivateEndpointModelResource : IJsonModel<ManagedPrivateEndpointModelData>
    {
        private static ManagedPrivateEndpointModelData s_dataDeserializationInstance;
        private static ManagedPrivateEndpointModelData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<ManagedPrivateEndpointModelData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ManagedPrivateEndpointModelData>)Data).Write(writer, options);

        ManagedPrivateEndpointModelData IJsonModel<ManagedPrivateEndpointModelData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ManagedPrivateEndpointModelData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<ManagedPrivateEndpointModelData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<ManagedPrivateEndpointModelData>(Data, options, AzureResourceManagerGrafanaContext.Default);

        ManagedPrivateEndpointModelData IPersistableModel<ManagedPrivateEndpointModelData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ManagedPrivateEndpointModelData>(data, options, AzureResourceManagerGrafanaContext.Default);

        string IPersistableModel<ManagedPrivateEndpointModelData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ManagedPrivateEndpointModelData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
