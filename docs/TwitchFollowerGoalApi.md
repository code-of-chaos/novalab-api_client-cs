# NovaLab.ApiClient.Api.TwitchFollowerGoalApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetFollowerGoals**](TwitchFollowerGoalApi.md#getfollowergoals) | **GET** /api/twitch/followers/follower-goal |  |
| [**PostFollowerGoal**](TwitchFollowerGoalApi.md#postfollowergoal) | **POST** /api/twitch/followers/follower-goal |  |

<a name="getfollowergoals"></a>
# **GetFollowerGoals**
> FollowerGoalDtoApiResult GetFollowerGoals (string? userId = null, List<Guid>? goalIds = null, int? limit = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NovaLab.ApiClient.Api;
using NovaLab.ApiClient.Client;
using NovaLab.ApiClient.Model;

namespace Example
{
    public class GetFollowerGoalsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new TwitchFollowerGoalApi(config);
            var userId = "userId_example";  // string? |  (optional) 
            var goalIds = new List<Guid>?(); // List<Guid>? |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                FollowerGoalDtoApiResult result = apiInstance.GetFollowerGoals(userId, goalIds, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TwitchFollowerGoalApi.GetFollowerGoals: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFollowerGoalsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<FollowerGoalDtoApiResult> response = apiInstance.GetFollowerGoalsWithHttpInfo(userId, goalIds, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TwitchFollowerGoalApi.GetFollowerGoalsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string?** |  | [optional]  |
| **goalIds** | [**List&lt;Guid&gt;?**](Guid.md) |  | [optional]  |
| **limit** | **int?** |  | [optional]  |

### Return type

[**FollowerGoalDtoApiResult**](FollowerGoalDtoApiResult.md)

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

<a name="postfollowergoal"></a>
# **PostFollowerGoal**
> FollowerGoalDtoApiResult PostFollowerGoal (PostFollowerGoalDto? postFollowerGoalDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NovaLab.ApiClient.Api;
using NovaLab.ApiClient.Client;
using NovaLab.ApiClient.Model;

namespace Example
{
    public class PostFollowerGoalExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new TwitchFollowerGoalApi(config);
            var postFollowerGoalDto = new PostFollowerGoalDto?(); // PostFollowerGoalDto? |  (optional) 

            try
            {
                FollowerGoalDtoApiResult result = apiInstance.PostFollowerGoal(postFollowerGoalDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TwitchFollowerGoalApi.PostFollowerGoal: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostFollowerGoalWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<FollowerGoalDtoApiResult> response = apiInstance.PostFollowerGoalWithHttpInfo(postFollowerGoalDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TwitchFollowerGoalApi.PostFollowerGoalWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **postFollowerGoalDto** | [**PostFollowerGoalDto?**](PostFollowerGoalDto?.md) |  | [optional]  |

### Return type

[**FollowerGoalDtoApiResult**](FollowerGoalDtoApiResult.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

