// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.AppPlatform.Samples
{
    public partial class Sample_AppPlatformBuildResultCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_BuildServiceGetBuildResult()
        {
            // Generated from example definition: specification/appplatform/resource-manager/Microsoft.AppPlatform/stable/2022-12-01/examples/BuildService_GetBuildResult.json
            // this example is just showing the usage of "BuildService_GetBuildResult" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppPlatformBuildResource created on azure
            // for more information of creating AppPlatformBuildResource, please refer to the document of AppPlatformBuildResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string serviceName = "myservice";
            string buildServiceName = "default";
            string buildName = "mybuild";
            ResourceIdentifier appPlatformBuildResourceId = AppPlatformBuildResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, buildServiceName, buildName);
            AppPlatformBuildResource appPlatformBuild = client.GetAppPlatformBuildResource(appPlatformBuildResourceId);

            // get the collection of this AppPlatformBuildResultResource
            AppPlatformBuildResultCollection collection = appPlatformBuild.GetAppPlatformBuildResults();

            // invoke the operation
            string buildResultName = "123";
            AppPlatformBuildResultResource result = await collection.GetAsync(buildResultName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AppPlatformBuildResultData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_BuildServiceListBuildResults()
        {
            // Generated from example definition: specification/appplatform/resource-manager/Microsoft.AppPlatform/stable/2022-12-01/examples/BuildService_ListBuildResults.json
            // this example is just showing the usage of "BuildService_ListBuildResults" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppPlatformBuildResource created on azure
            // for more information of creating AppPlatformBuildResource, please refer to the document of AppPlatformBuildResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string serviceName = "myservice";
            string buildServiceName = "default";
            string buildName = "mybuild";
            ResourceIdentifier appPlatformBuildResourceId = AppPlatformBuildResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, buildServiceName, buildName);
            AppPlatformBuildResource appPlatformBuild = client.GetAppPlatformBuildResource(appPlatformBuildResourceId);

            // get the collection of this AppPlatformBuildResultResource
            AppPlatformBuildResultCollection collection = appPlatformBuild.GetAppPlatformBuildResults();

            // invoke the operation and iterate over the result
            await foreach (AppPlatformBuildResultResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AppPlatformBuildResultData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_BuildServiceGetBuildResult()
        {
            // Generated from example definition: specification/appplatform/resource-manager/Microsoft.AppPlatform/stable/2022-12-01/examples/BuildService_GetBuildResult.json
            // this example is just showing the usage of "BuildService_GetBuildResult" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppPlatformBuildResource created on azure
            // for more information of creating AppPlatformBuildResource, please refer to the document of AppPlatformBuildResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string serviceName = "myservice";
            string buildServiceName = "default";
            string buildName = "mybuild";
            ResourceIdentifier appPlatformBuildResourceId = AppPlatformBuildResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, buildServiceName, buildName);
            AppPlatformBuildResource appPlatformBuild = client.GetAppPlatformBuildResource(appPlatformBuildResourceId);

            // get the collection of this AppPlatformBuildResultResource
            AppPlatformBuildResultCollection collection = appPlatformBuild.GetAppPlatformBuildResults();

            // invoke the operation
            string buildResultName = "123";
            bool result = await collection.ExistsAsync(buildResultName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_BuildServiceGetBuildResult()
        {
            // Generated from example definition: specification/appplatform/resource-manager/Microsoft.AppPlatform/stable/2022-12-01/examples/BuildService_GetBuildResult.json
            // this example is just showing the usage of "BuildService_GetBuildResult" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppPlatformBuildResource created on azure
            // for more information of creating AppPlatformBuildResource, please refer to the document of AppPlatformBuildResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string serviceName = "myservice";
            string buildServiceName = "default";
            string buildName = "mybuild";
            ResourceIdentifier appPlatformBuildResourceId = AppPlatformBuildResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, buildServiceName, buildName);
            AppPlatformBuildResource appPlatformBuild = client.GetAppPlatformBuildResource(appPlatformBuildResourceId);

            // get the collection of this AppPlatformBuildResultResource
            AppPlatformBuildResultCollection collection = appPlatformBuild.GetAppPlatformBuildResults();

            // invoke the operation
            string buildResultName = "123";
            NullableResponse<AppPlatformBuildResultResource> response = await collection.GetIfExistsAsync(buildResultName);
            AppPlatformBuildResultResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AppPlatformBuildResultData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
