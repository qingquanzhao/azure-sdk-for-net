// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.OperationalInsights.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.OperationalInsights.Samples
{
    public partial class Sample_OperationalInsightsSavedSearchCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_SavedSearchCreateOrUpdate()
        {
            // Generated from example definition: specification/operationalinsights/resource-manager/Microsoft.OperationalInsights/stable/2025-02-01/examples/WorkspacesSavedSearchesCreateOrUpdate.json
            // this example is just showing the usage of "SavedSearches_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this OperationalInsightsWorkspaceResource created on azure
            // for more information of creating OperationalInsightsWorkspaceResource, please refer to the document of OperationalInsightsWorkspaceResource
            string subscriptionId = "00000000-0000-0000-0000-00000000000";
            string resourceGroupName = "TestRG";
            string workspaceName = "TestWS";
            ResourceIdentifier operationalInsightsWorkspaceResourceId = OperationalInsightsWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            OperationalInsightsWorkspaceResource operationalInsightsWorkspace = client.GetOperationalInsightsWorkspaceResource(operationalInsightsWorkspaceResourceId);

            // get the collection of this OperationalInsightsSavedSearchResource
            OperationalInsightsSavedSearchCollection collection = operationalInsightsWorkspace.GetOperationalInsightsSavedSearches();

            // invoke the operation
            string savedSearchId = "00000000-0000-0000-0000-00000000000";
            OperationalInsightsSavedSearchData data = new OperationalInsightsSavedSearchData("Saved Search Test Category", "Create or Update Saved Search Test", "Heartbeat | summarize Count() by Computer | take a")
            {
                FunctionAlias = "heartbeat_func",
                FunctionParameters = "a:int=1",
                Version = 2L,
                Tags = { new OperationalInsightsTag("Group", "Computer") },
            };
            ArmOperation<OperationalInsightsSavedSearchResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, savedSearchId, data);
            OperationalInsightsSavedSearchResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            OperationalInsightsSavedSearchData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_SavedSearchesGet()
        {
            // Generated from example definition: specification/operationalinsights/resource-manager/Microsoft.OperationalInsights/stable/2025-02-01/examples/WorkspacesSavedSearchesGet.json
            // this example is just showing the usage of "SavedSearches_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this OperationalInsightsWorkspaceResource created on azure
            // for more information of creating OperationalInsightsWorkspaceResource, please refer to the document of OperationalInsightsWorkspaceResource
            string subscriptionId = "00000000-0000-0000-0000-00000000000";
            string resourceGroupName = "TestRG";
            string workspaceName = "TestWS";
            ResourceIdentifier operationalInsightsWorkspaceResourceId = OperationalInsightsWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            OperationalInsightsWorkspaceResource operationalInsightsWorkspace = client.GetOperationalInsightsWorkspaceResource(operationalInsightsWorkspaceResourceId);

            // get the collection of this OperationalInsightsSavedSearchResource
            OperationalInsightsSavedSearchCollection collection = operationalInsightsWorkspace.GetOperationalInsightsSavedSearches();

            // invoke the operation
            string savedSearchId = "00000000-0000-0000-0000-00000000000";
            OperationalInsightsSavedSearchResource result = await collection.GetAsync(savedSearchId);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            OperationalInsightsSavedSearchData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_SavedSearchesList()
        {
            // Generated from example definition: specification/operationalinsights/resource-manager/Microsoft.OperationalInsights/stable/2025-02-01/examples/SavedSearchesListByWorkspace.json
            // this example is just showing the usage of "SavedSearches_ListByWorkspace" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this OperationalInsightsWorkspaceResource created on azure
            // for more information of creating OperationalInsightsWorkspaceResource, please refer to the document of OperationalInsightsWorkspaceResource
            string subscriptionId = "00000000-0000-0000-0000-00000000000";
            string resourceGroupName = "TestRG";
            string workspaceName = "TestWS";
            ResourceIdentifier operationalInsightsWorkspaceResourceId = OperationalInsightsWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            OperationalInsightsWorkspaceResource operationalInsightsWorkspace = client.GetOperationalInsightsWorkspaceResource(operationalInsightsWorkspaceResourceId);

            // get the collection of this OperationalInsightsSavedSearchResource
            OperationalInsightsSavedSearchCollection collection = operationalInsightsWorkspace.GetOperationalInsightsSavedSearches();

            // invoke the operation and iterate over the result
            await foreach (OperationalInsightsSavedSearchResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                OperationalInsightsSavedSearchData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_SavedSearchesGet()
        {
            // Generated from example definition: specification/operationalinsights/resource-manager/Microsoft.OperationalInsights/stable/2025-02-01/examples/WorkspacesSavedSearchesGet.json
            // this example is just showing the usage of "SavedSearches_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this OperationalInsightsWorkspaceResource created on azure
            // for more information of creating OperationalInsightsWorkspaceResource, please refer to the document of OperationalInsightsWorkspaceResource
            string subscriptionId = "00000000-0000-0000-0000-00000000000";
            string resourceGroupName = "TestRG";
            string workspaceName = "TestWS";
            ResourceIdentifier operationalInsightsWorkspaceResourceId = OperationalInsightsWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            OperationalInsightsWorkspaceResource operationalInsightsWorkspace = client.GetOperationalInsightsWorkspaceResource(operationalInsightsWorkspaceResourceId);

            // get the collection of this OperationalInsightsSavedSearchResource
            OperationalInsightsSavedSearchCollection collection = operationalInsightsWorkspace.GetOperationalInsightsSavedSearches();

            // invoke the operation
            string savedSearchId = "00000000-0000-0000-0000-00000000000";
            bool result = await collection.ExistsAsync(savedSearchId);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_SavedSearchesGet()
        {
            // Generated from example definition: specification/operationalinsights/resource-manager/Microsoft.OperationalInsights/stable/2025-02-01/examples/WorkspacesSavedSearchesGet.json
            // this example is just showing the usage of "SavedSearches_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this OperationalInsightsWorkspaceResource created on azure
            // for more information of creating OperationalInsightsWorkspaceResource, please refer to the document of OperationalInsightsWorkspaceResource
            string subscriptionId = "00000000-0000-0000-0000-00000000000";
            string resourceGroupName = "TestRG";
            string workspaceName = "TestWS";
            ResourceIdentifier operationalInsightsWorkspaceResourceId = OperationalInsightsWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            OperationalInsightsWorkspaceResource operationalInsightsWorkspace = client.GetOperationalInsightsWorkspaceResource(operationalInsightsWorkspaceResourceId);

            // get the collection of this OperationalInsightsSavedSearchResource
            OperationalInsightsSavedSearchCollection collection = operationalInsightsWorkspace.GetOperationalInsightsSavedSearches();

            // invoke the operation
            string savedSearchId = "00000000-0000-0000-0000-00000000000";
            NullableResponse<OperationalInsightsSavedSearchResource> response = await collection.GetIfExistsAsync(savedSearchId);
            OperationalInsightsSavedSearchResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                OperationalInsightsSavedSearchData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
