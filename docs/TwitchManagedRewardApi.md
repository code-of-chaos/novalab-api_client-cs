# NovaLab.ApiClient.Api.TwitchManagedRewardApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetManagedRewards**](TwitchManagedRewardApi.md#getmanagedrewards) | **GET** /api/twitch/managed-rewards |  |
| [**PostManagedReward**](TwitchManagedRewardApi.md#postmanagedreward) | **POST** /api/twitch/managed-rewards |  |
| [**PostNewLastCleared**](TwitchManagedRewardApi.md#postnewlastcleared) | **POST** /api/twitch/managed-rewards/clear |  |

<a name="getmanagedrewards"></a>
# **GetManagedRewards**
> TwitchManagedRewardApiResult GetManagedRewards (string? userId = null, int? limit = null)



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
            var userId = "userId_example";  // string? |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                TwitchManagedRewardApiResult result = apiInstance.GetManagedRewards(userId, limit);
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
    ApiResponse<TwitchManagedRewardApiResult> response = apiInstance.GetManagedRewardsWithHttpInfo(userId, limit);
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
| **userId** | **string?** |  | [optional]  |
| **limit** | **int?** |  | [optional]  |

### Return type

[**TwitchManagedRewardApiResult**](TwitchManagedRewardApiResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postmanagedreward"></a>
# **PostManagedReward**
> ApiResult PostManagedReward (string? userId = null, PostManagedRewardDto? postManagedRewardDto = null)



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
            var userId = "userId_example";  // string? |  (optional) 
            var postManagedRewardDto = new PostManagedRewardDto?(); // PostManagedRewardDto? |  (optional) 

            try
            {
                ApiResult result = apiInstance.PostManagedReward(userId, postManagedRewardDto);
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
    ApiResponse<ApiResult> response = apiInstance.PostManagedRewardWithHttpInfo(userId, postManagedRewardDto);
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
| **userId** | **string?** |  | [optional]  |
| **postManagedRewardDto** | [**PostManagedRewardDto?**](PostManagedRewardDto?.md) |  | [optional]  |

### Return type

[**ApiResult**](ApiResult.md)

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

<a name="postnewlastcleared"></a>
# **PostNewLastCleared**
> ApiResult PostNewLastCleared (string? managedRewardId = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NovaLab.ApiClient.Api;
using NovaLab.ApiClient.Client;
using NovaLab.ApiClient.Model;

namespace Example
{
    public class PostNewLastClearedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new TwitchManagedRewardApi(config);
            var managedRewardId = "managedRewardId_example";  // string? |  (optional) 

            try
            {
                ApiResult result = apiInstance.PostNewLastCleared(managedRewardId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TwitchManagedRewardApi.PostNewLastCleared: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostNewLastClearedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiResult> response = apiInstance.PostNewLastClearedWithHttpInfo(managedRewardId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TwitchManagedRewardApi.PostNewLastClearedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **managedRewardId** | **string?** |  | [optional]  |

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
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

