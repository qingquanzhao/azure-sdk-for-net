// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.NetApp
{
    public partial class NetAppVolumeGroupResource : IJsonModel<NetAppVolumeGroupData>
    {
        private static NetAppVolumeGroupData s_dataDeserializationInstance;
        private static NetAppVolumeGroupData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<NetAppVolumeGroupData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<NetAppVolumeGroupData>)Data).Write(writer, options);

        NetAppVolumeGroupData IJsonModel<NetAppVolumeGroupData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<NetAppVolumeGroupData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<NetAppVolumeGroupData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<NetAppVolumeGroupData>(Data, options, AzureResourceManagerNetAppContext.Default);

        NetAppVolumeGroupData IPersistableModel<NetAppVolumeGroupData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<NetAppVolumeGroupData>(data, options, AzureResourceManagerNetAppContext.Default);

        string IPersistableModel<NetAppVolumeGroupData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<NetAppVolumeGroupData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
