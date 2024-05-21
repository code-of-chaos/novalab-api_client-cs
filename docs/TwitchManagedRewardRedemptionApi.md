# NovaLab.ApiClient.Api.TwitchManagedRewardRedemptionApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiUserIdTwitchManagedRewardsRedemptionsGet**](TwitchManagedRewardRedemptionApi.md#apiuseridtwitchmanagedrewardsredemptionsget) | **GET** /api/{userId}/twitch/managed-rewards-redemptions |  |
| [**ApiUserIdTwitchManagedRewardsRedemptionsPost**](TwitchManagedRewardRedemptionApi.md#apiuseridtwitchmanagedrewardsredemptionspost) | **POST** /api/{userId}/twitch/managed-rewards-redemptions |  |

<a name="apiuseridtwitchmanagedrewardsredemptionsget"></a>
# **ApiUserIdTwitchManagedRewardsRedemptionsGet**
> void ApiUserIdTwitchManagedRewardsRedemptionsGet (string userId, Guid? rewardId = null, DateTime? after = null, int? limit = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NovaLab.ApiClient.Api;
using NovaLab.ApiClient.Client;
using NovaLab.ApiClient.Model;

namespace Example
{
    public class ApiUserIdTwitchManagedRewardsRedemptionsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new TwitchManagedRewardRedemptionApi(config);
            var userId = "userId_example";  // string | 
            var rewardId = "rewardId_example";  // Guid? |  (optional) 
            var after = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                apiInstance.ApiUserIdTwitchManagedRewardsRedemptionsGet(userId, rewardId, after, limit);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TwitchManagedRewardRedemptionApi.ApiUserIdTwitchManagedRewardsRedemptionsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiUserIdTwitchManagedRewardsRedemptionsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiUserIdTwitchManagedRewardsRedemptionsGetWithHttpInfo(userId, rewardId, after, limit);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TwitchManagedRewardRedemptionApi.ApiUserIdTwitchManagedRewardsRedemptionsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string** |  |  |
| **rewardId** | **Guid?** |  | [optional]  |
| **after** | **DateTime?** |  | [optional]  |
| **limit** | **int?** |  | [optional]  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiuseridtwitchmanagedrewardsredemptionspost"></a>
# **ApiUserIdTwitchManagedRewardsRedemptionsPost**
> void ApiUserIdTwitchManagedRewardsRedemptionsPost (string userId, TwitchManagedRewardRedemptionDto? twitchManagedRewardRedemptionDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NovaLab.ApiClient.Api;
using NovaLab.ApiClient.Client;
using NovaLab.ApiClient.Model;

namespace Example
{
    public class ApiUserIdTwitchManagedRewardsRedemptionsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new TwitchManagedRewardRedemptionApi(config);
            var userId = "userId_example";  // string | 
            var twitchManagedRewardRedemptionDto = new TwitchManagedRewardRedemptionDto?(); // TwitchManagedRewardRedemptionDto? |  (optional) 

            try
            {
                apiInstance.ApiUserIdTwitchManagedRewardsRedemptionsPost(userId, twitchManagedRewardRedemptionDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TwitchManagedRewardRedemptionApi.ApiUserIdTwitchManagedRewardsRedemptionsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiUserIdTwitchManagedRewardsRedemptionsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiUserIdTwitchManagedRewardsRedemptionsPostWithHttpInfo(userId, twitchManagedRewardRedemptionDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TwitchManagedRewardRedemptionApi.ApiUserIdTwitchManagedRewardsRedemptionsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string** |  |  |
| **twitchManagedRewardRedemptionDto** | [**TwitchManagedRewardRedemptionDto?**](TwitchManagedRewardRedemptionDto?.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

