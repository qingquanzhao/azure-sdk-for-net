// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.AppContainers
{
    public partial class ContainerAppJobDetectorPropertyResource : IJsonModel<ContainerAppJobData>
    {
        private static ContainerAppJobData s_dataDeserializationInstance;
        private static ContainerAppJobData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<ContainerAppJobData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ContainerAppJobData>)Data).Write(writer, options);

        ContainerAppJobData IJsonModel<ContainerAppJobData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ContainerAppJobData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<ContainerAppJobData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<ContainerAppJobData>(Data, options, AzureResourceManagerAppContainersContext.Default);

        ContainerAppJobData IPersistableModel<ContainerAppJobData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ContainerAppJobData>(data, options, AzureResourceManagerAppContainersContext.Default);

        string IPersistableModel<ContainerAppJobData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ContainerAppJobData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
