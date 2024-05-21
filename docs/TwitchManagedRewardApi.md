# NovaLab.ApiClient.Api.TwitchManagedRewardApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiUserIdTwitchManagedRewardsGet**](TwitchManagedRewardApi.md#apiuseridtwitchmanagedrewardsget) | **GET** /api/{userId}/twitch/managed-rewards |  |
| [**ApiUserIdTwitchManagedRewardsPost**](TwitchManagedRewardApi.md#apiuseridtwitchmanagedrewardspost) | **POST** /api/{userId}/twitch/managed-rewards |  |

<a name="apiuseridtwitchmanagedrewardsget"></a>
# **ApiUserIdTwitchManagedRewardsGet**
> void ApiUserIdTwitchManagedRewardsGet (string userId, int? limit = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NovaLab.ApiClient.Api;
using NovaLab.ApiClient.Client;
using NovaLab.ApiClient.Model;

namespace Example
{
    public class ApiUserIdTwitchManagedRewardsGetExample
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
                apiInstance.ApiUserIdTwitchManagedRewardsGet(userId, limit);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TwitchManagedRewardApi.ApiUserIdTwitchManagedRewardsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiUserIdTwitchManagedRewardsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiUserIdTwitchManagedRewardsGetWithHttpInfo(userId, limit);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TwitchManagedRewardApi.ApiUserIdTwitchManagedRewardsGetWithHttpInfo: " + e.Message);
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

<a name="apiuseridtwitchmanagedrewardspost"></a>
# **ApiUserIdTwitchManagedRewardsPost**
> void ApiUserIdTwitchManagedRewardsPost (string userId, CreateCustomRewardsRequest? createCustomRewardsRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NovaLab.ApiClient.Api;
using NovaLab.ApiClient.Client;
using NovaLab.ApiClient.Model;

namespace Example
{
    public class ApiUserIdTwitchManagedRewardsPostExample
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
                apiInstance.ApiUserIdTwitchManagedRewardsPost(userId, createCustomRewardsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TwitchManagedRewardApi.ApiUserIdTwitchManagedRewardsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiUserIdTwitchManagedRewardsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiUserIdTwitchManagedRewardsPostWithHttpInfo(userId, createCustomRewardsRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TwitchManagedRewardApi.ApiUserIdTwitchManagedRewardsPostWithHttpInfo: " + e.Message);
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

