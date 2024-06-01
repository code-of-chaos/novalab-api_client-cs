# NovaLab.ApiClient.Api.TwitchNewFollowerApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetNewFollowers**](TwitchNewFollowerApi.md#getnewfollowers) | **GET** /api/twitch/followers/new-follower |  |
| [**PostNewFollower**](TwitchNewFollowerApi.md#postnewfollower) | **POST** /api/twitch/followers/new-follower |  |

<a name="getnewfollowers"></a>
# **GetNewFollowers**
> NewFollowerDtoApiResult GetNewFollowers (string? userId = null, Guid? goalId = null, DateTime? fromDate = null, int? limit = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NovaLab.ApiClient.Api;
using NovaLab.ApiClient.Client;
using NovaLab.ApiClient.Model;

namespace Example
{
    public class GetNewFollowersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new TwitchNewFollowerApi(config);
            var userId = "userId_example";  // string? |  (optional) 
            var goalId = "goalId_example";  // Guid? |  (optional) 
            var fromDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                NewFollowerDtoApiResult result = apiInstance.GetNewFollowers(userId, goalId, fromDate, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TwitchNewFollowerApi.GetNewFollowers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetNewFollowersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<NewFollowerDtoApiResult> response = apiInstance.GetNewFollowersWithHttpInfo(userId, goalId, fromDate, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TwitchNewFollowerApi.GetNewFollowersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string?** |  | [optional]  |
| **goalId** | **Guid?** |  | [optional]  |
| **fromDate** | **DateTime?** |  | [optional]  |
| **limit** | **int?** |  | [optional]  |

### Return type

[**NewFollowerDtoApiResult**](NewFollowerDtoApiResult.md)

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

<a name="postnewfollower"></a>
# **PostNewFollower**
> NewFollowerDtoApiResult PostNewFollower (PostNewFollowerDto? postNewFollowerDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NovaLab.ApiClient.Api;
using NovaLab.ApiClient.Client;
using NovaLab.ApiClient.Model;

namespace Example
{
    public class PostNewFollowerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new TwitchNewFollowerApi(config);
            var postNewFollowerDto = new PostNewFollowerDto?(); // PostNewFollowerDto? |  (optional) 

            try
            {
                NewFollowerDtoApiResult result = apiInstance.PostNewFollower(postNewFollowerDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TwitchNewFollowerApi.PostNewFollower: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostNewFollowerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<NewFollowerDtoApiResult> response = apiInstance.PostNewFollowerWithHttpInfo(postNewFollowerDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TwitchNewFollowerApi.PostNewFollowerWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **postNewFollowerDto** | [**PostNewFollowerDto?**](PostNewFollowerDto?.md) |  | [optional]  |

### Return type

[**NewFollowerDtoApiResult**](NewFollowerDtoApiResult.md)

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

