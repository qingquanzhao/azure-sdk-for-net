// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class WorkloadRecoveryPoint : IUtf8JsonSerializable, IJsonModel<WorkloadRecoveryPoint>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WorkloadRecoveryPoint>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<WorkloadRecoveryPoint>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkloadRecoveryPoint>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WorkloadRecoveryPoint)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(RecoveryPointCreatedOn))
            {
                writer.WritePropertyName("recoveryPointTimeInUTC"u8);
                writer.WriteStringValue(RecoveryPointCreatedOn.Value, "O");
            }
            if (Optional.IsDefined(RestorePointType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(RestorePointType.Value.ToString());
            }
            if (Optional.IsCollectionDefined(RecoveryPointTierDetails))
            {
                writer.WritePropertyName("recoveryPointTierDetails"u8);
                writer.WriteStartArray();
                foreach (var item in RecoveryPointTierDetails)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(RecoveryPointMoveReadinessInfo))
            {
                writer.WritePropertyName("recoveryPointMoveReadinessInfo"u8);
                writer.WriteStartObject();
                foreach (var item in RecoveryPointMoveReadinessInfo)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value, options);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(RecoveryPointProperties))
            {
                writer.WritePropertyName("recoveryPointProperties"u8);
                writer.WriteObjectValue(RecoveryPointProperties, options);
            }
        }

        WorkloadRecoveryPoint IJsonModel<WorkloadRecoveryPoint>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkloadRecoveryPoint>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WorkloadRecoveryPoint)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWorkloadRecoveryPoint(document.RootElement, options);
        }

        internal static WorkloadRecoveryPoint DeserializeWorkloadRecoveryPoint(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("objectType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureWorkloadPointInTimeRecoveryPoint": return WorkloadPointInTimeRecoveryPoint.DeserializeWorkloadPointInTimeRecoveryPoint(element, options);
                    case "AzureWorkloadSAPAsePointInTimeRecoveryPoint": return WorkloadSapAsePointInTimeRecoveryPoint.DeserializeWorkloadSapAsePointInTimeRecoveryPoint(element, options);
                    case "AzureWorkloadSAPAseRecoveryPoint": return WorkloadSapAseRecoveryPoint.DeserializeWorkloadSapAseRecoveryPoint(element, options);
                    case "AzureWorkloadSAPHanaPointInTimeRecoveryPoint": return WorkloadSapHanaPointInTimeRecoveryPoint.DeserializeWorkloadSapHanaPointInTimeRecoveryPoint(element, options);
                    case "AzureWorkloadSAPHanaRecoveryPoint": return WorkloadSapHanaRecoveryPoint.DeserializeWorkloadSapHanaRecoveryPoint(element, options);
                    case "AzureWorkloadSQLPointInTimeRecoveryPoint": return WorkloadSqlPointInTimeRecoveryPoint.DeserializeWorkloadSqlPointInTimeRecoveryPoint(element, options);
                    case "AzureWorkloadSQLRecoveryPoint": return WorkloadSqlRecoveryPoint.DeserializeWorkloadSqlRecoveryPoint(element, options);
                }
            }
            DateTimeOffset? recoveryPointTimeInUTC = default;
            RestorePointType? type = default;
            IList<RecoveryPointTierInformationV2> recoveryPointTierDetails = default;
            IDictionary<string, RecoveryPointMoveReadinessInfo> recoveryPointMoveReadinessInfo = default;
            RecoveryPointProperties recoveryPointProperties = default;
            string objectType = "AzureWorkloadRecoveryPoint";
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recoveryPointTimeInUTC"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryPointTimeInUTC = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new RestorePointType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recoveryPointTierDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RecoveryPointTierInformationV2> array = new List<RecoveryPointTierInformationV2>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RecoveryPointTierInformationV2.DeserializeRecoveryPointTierInformationV2(item, options));
                    }
                    recoveryPointTierDetails = array;
                    continue;
                }
                if (property.NameEquals("recoveryPointMoveReadinessInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, RecoveryPointMoveReadinessInfo> dictionary = new Dictionary<string, RecoveryPointMoveReadinessInfo>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, Models.RecoveryPointMoveReadinessInfo.DeserializeRecoveryPointMoveReadinessInfo(property0.Value, options));
                    }
                    recoveryPointMoveReadinessInfo = dictionary;
                    continue;
                }
                if (property.NameEquals("recoveryPointProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryPointProperties = RecoveryPointProperties.DeserializeRecoveryPointProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("objectType"u8))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new WorkloadRecoveryPoint(
                objectType,
                serializedAdditionalRawData,
                recoveryPointTimeInUTC,
                type,
                recoveryPointTierDetails ?? new ChangeTrackingList<RecoveryPointTierInformationV2>(),
                recoveryPointMoveReadinessInfo ?? new ChangeTrackingDictionary<string, RecoveryPointMoveReadinessInfo>(),
                recoveryPointProperties);
        }

        BinaryData IPersistableModel<WorkloadRecoveryPoint>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkloadRecoveryPoint>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerRecoveryServicesBackupContext.Default);
                default:
                    throw new FormatException($"The model {nameof(WorkloadRecoveryPoint)} does not support writing '{options.Format}' format.");
            }
        }

        WorkloadRecoveryPoint IPersistableModel<WorkloadRecoveryPoint>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkloadRecoveryPoint>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeWorkloadRecoveryPoint(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WorkloadRecoveryPoint)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<WorkloadRecoveryPoint>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
