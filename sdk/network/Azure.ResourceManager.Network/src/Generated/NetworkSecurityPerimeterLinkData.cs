// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing the NetworkSecurityPerimeterLink data model.
    /// The network security perimeter link resource
    /// </summary>
    public partial class NetworkSecurityPerimeterLinkData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="NetworkSecurityPerimeterLinkData"/>. </summary>
        public NetworkSecurityPerimeterLinkData()
        {
            LocalInboundProfiles = new ChangeTrackingList<string>();
            LocalOutboundProfiles = new ChangeTrackingList<string>();
            RemoteInboundProfiles = new ChangeTrackingList<string>();
            RemoteOutboundProfiles = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkSecurityPerimeterLinkData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> The provisioning state of the NSP Link resource. </param>
        /// <param name="autoApprovedRemotePerimeterResourceId"> Perimeter ARM Id for the remote NSP with which the link gets created in Auto-approval mode. It should be used when the NSP admin have Microsoft.Network/networkSecurityPerimeters/linkPerimeter/action permission on the remote NSP resource. </param>
        /// <param name="remotePerimeterGuid"> Remote NSP Guid with which the link gets created. </param>
        /// <param name="remotePerimeterLocation"> Remote NSP location with which the link gets created. </param>
        /// <param name="localInboundProfiles"> Local Inbound profile names to which Inbound is allowed. Use ['*'] to allow inbound to all profiles. </param>
        /// <param name="localOutboundProfiles"> Local Outbound profile names from which Outbound is allowed. In current version, it is readonly property and it's value is set to ['*'] to allow outbound from all profiles. In later version, user will be able to modify it. </param>
        /// <param name="remoteInboundProfiles"> Remote Inbound profile names to which Inbound is allowed. Use ['*'] to allow inbound to all profiles. This property can only be updated in auto-approval mode. </param>
        /// <param name="remoteOutboundProfiles"> Remote Outbound profile names from which Outbound is allowed. In current version, it is readonly property and it's value is set to ['*'] to allow outbound from all profiles. In later version, user will be able to modify it. </param>
        /// <param name="description"> A message passed to the owner of the remote NSP link resource with this connection request. In case of Auto-approved flow, it is default to 'Auto Approved'. Restricted to 140 chars. </param>
        /// <param name="status"> The NSP link state. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkSecurityPerimeterLinkData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, NetworkSecurityPerimeterLinkProvisioningState? provisioningState, ResourceIdentifier autoApprovedRemotePerimeterResourceId, Guid? remotePerimeterGuid, string remotePerimeterLocation, IList<string> localInboundProfiles, IReadOnlyList<string> localOutboundProfiles, IList<string> remoteInboundProfiles, IReadOnlyList<string> remoteOutboundProfiles, string description, NetworkSecurityPerimeterLinkStatus? status, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            ProvisioningState = provisioningState;
            AutoApprovedRemotePerimeterResourceId = autoApprovedRemotePerimeterResourceId;
            RemotePerimeterGuid = remotePerimeterGuid;
            RemotePerimeterLocation = remotePerimeterLocation;
            LocalInboundProfiles = localInboundProfiles;
            LocalOutboundProfiles = localOutboundProfiles;
            RemoteInboundProfiles = remoteInboundProfiles;
            RemoteOutboundProfiles = remoteOutboundProfiles;
            Description = description;
            Status = status;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The provisioning state of the NSP Link resource. </summary>
        public NetworkSecurityPerimeterLinkProvisioningState? ProvisioningState { get; }
        /// <summary> Perimeter ARM Id for the remote NSP with which the link gets created in Auto-approval mode. It should be used when the NSP admin have Microsoft.Network/networkSecurityPerimeters/linkPerimeter/action permission on the remote NSP resource. </summary>
        public ResourceIdentifier AutoApprovedRemotePerimeterResourceId { get; set; }
        /// <summary> Remote NSP Guid with which the link gets created. </summary>
        public Guid? RemotePerimeterGuid { get; }
        /// <summary> Remote NSP location with which the link gets created. </summary>
        public string RemotePerimeterLocation { get; }
        /// <summary> Local Inbound profile names to which Inbound is allowed. Use ['*'] to allow inbound to all profiles. </summary>
        public IList<string> LocalInboundProfiles { get; }
        /// <summary> Local Outbound profile names from which Outbound is allowed. In current version, it is readonly property and it's value is set to ['*'] to allow outbound from all profiles. In later version, user will be able to modify it. </summary>
        public IReadOnlyList<string> LocalOutboundProfiles { get; }
        /// <summary> Remote Inbound profile names to which Inbound is allowed. Use ['*'] to allow inbound to all profiles. This property can only be updated in auto-approval mode. </summary>
        public IList<string> RemoteInboundProfiles { get; }
        /// <summary> Remote Outbound profile names from which Outbound is allowed. In current version, it is readonly property and it's value is set to ['*'] to allow outbound from all profiles. In later version, user will be able to modify it. </summary>
        public IReadOnlyList<string> RemoteOutboundProfiles { get; }
        /// <summary> A message passed to the owner of the remote NSP link resource with this connection request. In case of Auto-approved flow, it is default to 'Auto Approved'. Restricted to 140 chars. </summary>
        public string Description { get; set; }
        /// <summary> The NSP link state. </summary>
        public NetworkSecurityPerimeterLinkStatus? Status { get; }
    }
}
