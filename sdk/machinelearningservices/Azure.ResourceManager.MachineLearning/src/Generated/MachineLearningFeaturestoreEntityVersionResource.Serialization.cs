// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.MachineLearning
{
    public partial class MachineLearningFeaturestoreEntityVersionResource : IJsonModel<MachineLearningFeaturestoreEntityVersionData>
    {
        private static MachineLearningFeaturestoreEntityVersionData s_dataDeserializationInstance;
        private static MachineLearningFeaturestoreEntityVersionData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<MachineLearningFeaturestoreEntityVersionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<MachineLearningFeaturestoreEntityVersionData>)Data).Write(writer, options);

        MachineLearningFeaturestoreEntityVersionData IJsonModel<MachineLearningFeaturestoreEntityVersionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<MachineLearningFeaturestoreEntityVersionData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<MachineLearningFeaturestoreEntityVersionData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<MachineLearningFeaturestoreEntityVersionData>(Data, options, AzureResourceManagerMachineLearningContext.Default);

        MachineLearningFeaturestoreEntityVersionData IPersistableModel<MachineLearningFeaturestoreEntityVersionData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<MachineLearningFeaturestoreEntityVersionData>(data, options, AzureResourceManagerMachineLearningContext.Default);

        string IPersistableModel<MachineLearningFeaturestoreEntityVersionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<MachineLearningFeaturestoreEntityVersionData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
