// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Billing
{
    public partial class BillingReservationResource : IJsonModel<BillingReservationData>
    {
        private static BillingReservationData s_dataDeserializationInstance;
        private static BillingReservationData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<BillingReservationData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<BillingReservationData>)Data).Write(writer, options);

        BillingReservationData IJsonModel<BillingReservationData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<BillingReservationData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<BillingReservationData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<BillingReservationData>(Data, options, AzureResourceManagerBillingContext.Default);

        BillingReservationData IPersistableModel<BillingReservationData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<BillingReservationData>(data, options, AzureResourceManagerBillingContext.Default);

        string IPersistableModel<BillingReservationData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<BillingReservationData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
