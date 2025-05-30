// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> Details of an Entra user for gateway access. </summary>
    public partial class EntraUserInfo
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="EntraUserInfo"/>. </summary>
        public EntraUserInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="EntraUserInfo"/>. </summary>
        /// <param name="objectId"> The unique object ID of the Entra user or client ID of the enterprise applications. </param>
        /// <param name="displayName"> The display name of the Entra user. </param>
        /// <param name="upn"> The User Principal Name (UPN) of the Entra user. It may be empty in certain cases, such as for enterprise applications. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EntraUserInfo(string objectId, string displayName, string upn, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ObjectId = objectId;
            DisplayName = displayName;
            Upn = upn;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The unique object ID of the Entra user or client ID of the enterprise applications. </summary>
        public string ObjectId { get; set; }
        /// <summary> The display name of the Entra user. </summary>
        public string DisplayName { get; set; }
        /// <summary> The User Principal Name (UPN) of the Entra user. It may be empty in certain cases, such as for enterprise applications. </summary>
        public string Upn { get; set; }
    }
}
