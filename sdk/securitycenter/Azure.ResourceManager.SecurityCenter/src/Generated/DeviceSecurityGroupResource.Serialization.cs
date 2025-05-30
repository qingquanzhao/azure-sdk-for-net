// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.SecurityCenter
{
    public partial class DeviceSecurityGroupResource : IJsonModel<DeviceSecurityGroupData>
    {
        private static DeviceSecurityGroupData s_dataDeserializationInstance;
        private static DeviceSecurityGroupData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<DeviceSecurityGroupData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<DeviceSecurityGroupData>)Data).Write(writer, options);

        DeviceSecurityGroupData IJsonModel<DeviceSecurityGroupData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<DeviceSecurityGroupData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<DeviceSecurityGroupData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<DeviceSecurityGroupData>(Data, options, AzureResourceManagerSecurityCenterContext.Default);

        DeviceSecurityGroupData IPersistableModel<DeviceSecurityGroupData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<DeviceSecurityGroupData>(data, options, AzureResourceManagerSecurityCenterContext.Default);

        string IPersistableModel<DeviceSecurityGroupData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<DeviceSecurityGroupData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
