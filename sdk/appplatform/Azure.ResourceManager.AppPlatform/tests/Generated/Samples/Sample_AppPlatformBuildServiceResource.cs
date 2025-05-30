// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.AppPlatform.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.AppPlatform.Samples
{
    public partial class Sample_AppPlatformBuildServiceResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_BuildServiceGetBuildService()
        {
            // Generated from example definition: specification/appplatform/resource-manager/Microsoft.AppPlatform/stable/2022-12-01/examples/BuildService_GetBuildService.json
            // this example is just showing the usage of "BuildService_GetBuildService" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppPlatformBuildServiceResource created on azure
            // for more information of creating AppPlatformBuildServiceResource, please refer to the document of AppPlatformBuildServiceResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string serviceName = "myservice";
            string buildServiceName = "default";
            ResourceIdentifier appPlatformBuildServiceResourceId = AppPlatformBuildServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, buildServiceName);
            AppPlatformBuildServiceResource appPlatformBuildService = client.GetAppPlatformBuildServiceResource(appPlatformBuildServiceResourceId);

            // invoke the operation
            AppPlatformBuildServiceResource result = await appPlatformBuildService.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AppPlatformBuildServiceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetResourceUploadUri_BuildServiceGetResourceUploadUrl()
        {
            // Generated from example definition: specification/appplatform/resource-manager/Microsoft.AppPlatform/stable/2022-12-01/examples/BuildService_GetResourceUploadUrl.json
            // this example is just showing the usage of "BuildService_GetResourceUploadUri" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppPlatformBuildServiceResource created on azure
            // for more information of creating AppPlatformBuildServiceResource, please refer to the document of AppPlatformBuildServiceResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string serviceName = "myservice";
            string buildServiceName = "default";
            ResourceIdentifier appPlatformBuildServiceResourceId = AppPlatformBuildServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, buildServiceName);
            AppPlatformBuildServiceResource appPlatformBuildService = client.GetAppPlatformBuildServiceResource(appPlatformBuildServiceResourceId);

            // invoke the operation
            AppPlatformResourceUploadResult result = await appPlatformBuildService.GetResourceUploadUriAsync();

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
