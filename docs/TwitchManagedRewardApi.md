# NovaLab.ApiClient.Api.TwitchManagedRewardApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetManagedRewards**](TwitchManagedRewardApi.md#getmanagedrewards) | **GET** /api/{userId}/twitch/managed-rewards |  |
| [**PostManagedReward**](TwitchManagedRewardApi.md#postmanagedreward) | **POST** /api/{userId}/twitch/managed-rewards |  |

<a name="getmanagedrewards"></a>
# **GetManagedRewards**
> ApiResult GetManagedRewards (string userId, int? limit = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NovaLab.ApiClient.Api;
using NovaLab.ApiClient.Client;
using NovaLab.ApiClient.Model;

namespace Example
{
    public class GetManagedRewardsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new TwitchManagedRewardApi(config);
            var userId = "userId_example";  // string | 
            var limit = 56;  // int? |  (optional) 

            try
            {
                ApiResult result = apiInstance.GetManagedRewards(userId, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TwitchManagedRewardApi.GetManagedRewards: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetManagedRewardsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiResult> response = apiInstance.GetManagedRewardsWithHttpInfo(userId, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TwitchManagedRewardApi.GetManagedRewardsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string** |  |  |
| **limit** | **int?** |  | [optional]  |

### Return type

[**ApiResult**](ApiResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postmanagedreward"></a>
# **PostManagedReward**
> TwitchManagedRewardApiResult PostManagedReward (string userId, CreateCustomRewardsRequest? createCustomRewardsRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NovaLab.ApiClient.Api;
using NovaLab.ApiClient.Client;
using NovaLab.ApiClient.Model;

namespace Example
{
    public class PostManagedRewardExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new TwitchManagedRewardApi(config);
            var userId = "userId_example";  // string | 
            var createCustomRewardsRequest = new CreateCustomRewardsRequest?(); // CreateCustomRewardsRequest? |  (optional) 

            try
            {
                TwitchManagedRewardApiResult result = apiInstance.PostManagedReward(userId, createCustomRewardsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TwitchManagedRewardApi.PostManagedReward: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostManagedRewardWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<TwitchManagedRewardApiResult> response = apiInstance.PostManagedRewardWithHttpInfo(userId, createCustomRewardsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TwitchManagedRewardApi.PostManagedRewardWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string** |  |  |
| **createCustomRewardsRequest** | [**CreateCustomRewardsRequest?**](CreateCustomRewardsRequest?.md) |  | [optional]  |

### Return type

[**TwitchManagedRewardApiResult**](TwitchManagedRewardApiResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

