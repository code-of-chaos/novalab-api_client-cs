# NovaLab.ApiClient - the C# library for the NovaLab API

An ASP.NET Core Web API for managing your streams

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: v1
- SDK version: 1.0.0
- Build package: org.openapitools.codegen.languages.CSharpNetCoreClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported

<a name="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.13.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 13.0.1 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742).
NOTE: RestSharp for .Net Core creates a new socket for each api call, which can lead to a socket exhaustion problem. See [RestSharp#1406](https://github.com/restsharp/RestSharp/issues/1406).

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using NovaLab.ApiClient.Api;
using NovaLab.ApiClient.Client;
using NovaLab.ApiClient.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out NovaLab.ApiClient.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="usage"></a>
## Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

<a name="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NovaLab.ApiClient.Api;
using NovaLab.ApiClient.Client;
using NovaLab.ApiClient.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AccessTokenApi(config);
            var userId = "userId_example";  // string? |  (optional) 

            try
            {
                ApiResult result = apiInstance.RefreshTokens(userId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AccessTokenApi.RefreshTokens: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *http://localhost*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AccessTokenApi* | [**RefreshTokens**](docs/AccessTokenApi.md#refreshtokens) | **GET** /api/twitch/tokens/refresh | 
*NovaLabVersion1000CultureneutralPublicKeyTokennullApi* | [**AccountLogoutPost**](docs/NovaLabVersion1000CultureneutralPublicKeyTokennullApi.md#accountlogoutpost) | **POST** /Account/Logout | 
*NovaLabVersion1000CultureneutralPublicKeyTokennullApi* | [**AccountManageDownloadPersonalDataPost**](docs/NovaLabVersion1000CultureneutralPublicKeyTokennullApi.md#accountmanagedownloadpersonaldatapost) | **POST** /Account/Manage/DownloadPersonalData | 
*NovaLabVersion1000CultureneutralPublicKeyTokennullApi* | [**AccountManageLinkExternalLoginPost**](docs/NovaLabVersion1000CultureneutralPublicKeyTokennullApi.md#accountmanagelinkexternalloginpost) | **POST** /Account/Manage/LinkExternalLogin | 
*NovaLabVersion1000CultureneutralPublicKeyTokennullApi* | [**AccountPerformExternalLoginPost**](docs/NovaLabVersion1000CultureneutralPublicKeyTokennullApi.md#accountperformexternalloginpost) | **POST** /Account/PerformExternalLogin | 
*TwitchManagedRewardApi* | [**GetManagedRewards**](docs/TwitchManagedRewardApi.md#getmanagedrewards) | **GET** /api/twitch/managed-rewards | 
*TwitchManagedRewardApi* | [**PostManagedReward**](docs/TwitchManagedRewardApi.md#postmanagedreward) | **POST** /api/twitch/managed-rewards | 
*TwitchManagedRewardApi* | [**PostNewLastCleared**](docs/TwitchManagedRewardApi.md#postnewlastcleared) | **POST** /api/twitch/managed-rewards/clear | 
*TwitchManagedRewardRedemptionApi* | [**GetRedemptions**](docs/TwitchManagedRewardRedemptionApi.md#getredemptions) | **GET** /api/twitch/managed-rewards-redemptions | 
*TwitchManagedRewardRedemptionApi* | [**PostRedemption**](docs/TwitchManagedRewardRedemptionApi.md#postredemption) | **POST** /api/twitch/managed-rewards-redemptions | 


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.ApiResult](docs/ApiResult.md)
 - [Model.CreateCustomRewardsRequest](docs/CreateCustomRewardsRequest.md)
 - [Model.HttpStatusCode](docs/HttpStatusCode.md)
 - [Model.NovaLabUser](docs/NovaLabUser.md)
 - [Model.PostManagedRewardDto](docs/PostManagedRewardDto.md)
 - [Model.TwitchManagedReward](docs/TwitchManagedReward.md)
 - [Model.TwitchManagedRewardApiResult](docs/TwitchManagedRewardApiResult.md)
 - [Model.TwitchManagedRewardRedemption](docs/TwitchManagedRewardRedemption.md)
 - [Model.TwitchManagedRewardRedemptionApiResult](docs/TwitchManagedRewardRedemptionApiResult.md)
 - [Model.TwitchManagedRewardRedemptionDto](docs/TwitchManagedRewardRedemptionDto.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

All endpoints do not require authorization.
