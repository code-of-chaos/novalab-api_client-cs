# NovaLab.ApiClient.Api.TwitchManagedRewardRedemptionApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetRedemptions**](TwitchManagedRewardRedemptionApi.md#getredemptions) | **GET** /api/twitch/managed-rewards-redemptions |  |
| [**PostRedemption**](TwitchManagedRewardRedemptionApi.md#postredemption) | **POST** /api/twitch/managed-rewards-redemptions |  |

<a name="getredemptions"></a>
# **GetRedemptions**
> TwitchManagedRewardRedemptionApiResult GetRedemptions (string? userId = null, Guid? rewardId = null, DateTime? after = null, int? limit = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NovaLab.ApiClient.Api;
using NovaLab.ApiClient.Client;
using NovaLab.ApiClient.Model;

namespace Example
{
    public class GetRedemptionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new TwitchManagedRewardRedemptionApi(config);
            var userId = "userId_example";  // string? |  (optional) 
            var rewardId = "rewardId_example";  // Guid? |  (optional) 
            var after = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                TwitchManagedRewardRedemptionApiResult result = apiInstance.GetRedemptions(userId, rewardId, after, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TwitchManagedRewardRedemptionApi.GetRedemptions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRedemptionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<TwitchManagedRewardRedemptionApiResult> response = apiInstance.GetRedemptionsWithHttpInfo(userId, rewardId, after, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TwitchManagedRewardRedemptionApi.GetRedemptionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string?** |  | [optional]  |
| **rewardId** | **Guid?** |  | [optional]  |
| **after** | **DateTime?** |  | [optional]  |
| **limit** | **int?** |  | [optional]  |

### Return type

[**TwitchManagedRewardRedemptionApiResult**](TwitchManagedRewardRedemptionApiResult.md)

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

<a name="postredemption"></a>
# **PostRedemption**
> ApiResult PostRedemption (TwitchManagedRewardRedemptionDto? twitchManagedRewardRedemptionDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NovaLab.ApiClient.Api;
using NovaLab.ApiClient.Client;
using NovaLab.ApiClient.Model;

namespace Example
{
    public class PostRedemptionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new TwitchManagedRewardRedemptionApi(config);
            var twitchManagedRewardRedemptionDto = new TwitchManagedRewardRedemptionDto?(); // TwitchManagedRewardRedemptionDto? |  (optional) 

            try
            {
                ApiResult result = apiInstance.PostRedemption(twitchManagedRewardRedemptionDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TwitchManagedRewardRedemptionApi.PostRedemption: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostRedemptionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiResult> response = apiInstance.PostRedemptionWithHttpInfo(twitchManagedRewardRedemptionDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TwitchManagedRewardRedemptionApi.PostRedemptionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **twitchManagedRewardRedemptionDto** | [**TwitchManagedRewardRedemptionDto?**](TwitchManagedRewardRedemptionDto?.md) |  | [optional]  |

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
| **400** | Bad Request |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

