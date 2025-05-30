// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Sql
{
    public partial class SqlServerBlobAuditingPolicyResource : IJsonModel<SqlServerBlobAuditingPolicyData>
    {
        private static SqlServerBlobAuditingPolicyData s_dataDeserializationInstance;
        private static SqlServerBlobAuditingPolicyData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<SqlServerBlobAuditingPolicyData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<SqlServerBlobAuditingPolicyData>)Data).Write(writer, options);

        SqlServerBlobAuditingPolicyData IJsonModel<SqlServerBlobAuditingPolicyData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<SqlServerBlobAuditingPolicyData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<SqlServerBlobAuditingPolicyData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<SqlServerBlobAuditingPolicyData>(Data, options, AzureResourceManagerSqlContext.Default);

        SqlServerBlobAuditingPolicyData IPersistableModel<SqlServerBlobAuditingPolicyData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<SqlServerBlobAuditingPolicyData>(data, options, AzureResourceManagerSqlContext.Default);

        string IPersistableModel<SqlServerBlobAuditingPolicyData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<SqlServerBlobAuditingPolicyData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
