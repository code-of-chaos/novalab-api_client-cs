# NovaLab.ApiClient.Api.TwitchManagedStreamSubjectApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetManagedStreamSubjects**](TwitchManagedStreamSubjectApi.md#getmanagedstreamsubjects) | **GET** /api/twitch/managed-stream-subject |  |
| [**PostManagedStreamSubjects**](TwitchManagedStreamSubjectApi.md#postmanagedstreamsubjects) | **POST** /api/twitch/managed-stream-subject |  |
| [**PostSelectManagedStreamSubject**](TwitchManagedStreamSubjectApi.md#postselectmanagedstreamsubject) | **POST** /api/twitch/managed-stream-subject/select |  |

<a name="getmanagedstreamsubjects"></a>
# **GetManagedStreamSubjects**
> TwitchManagedStreamSubjectDtoApiResult GetManagedStreamSubjects (string? userId = null, int? limit = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NovaLab.ApiClient.Api;
using NovaLab.ApiClient.Client;
using NovaLab.ApiClient.Model;

namespace Example
{
    public class GetManagedStreamSubjectsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new TwitchManagedStreamSubjectApi(config);
            var userId = "userId_example";  // string? |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                TwitchManagedStreamSubjectDtoApiResult result = apiInstance.GetManagedStreamSubjects(userId, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TwitchManagedStreamSubjectApi.GetManagedStreamSubjects: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetManagedStreamSubjectsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<TwitchManagedStreamSubjectDtoApiResult> response = apiInstance.GetManagedStreamSubjectsWithHttpInfo(userId, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TwitchManagedStreamSubjectApi.GetManagedStreamSubjectsWithHttpInfo: " + e.Message);
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

[**TwitchManagedStreamSubjectDtoApiResult**](TwitchManagedStreamSubjectDtoApiResult.md)

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

<a name="postmanagedstreamsubjects"></a>
# **PostManagedStreamSubjects**
> ApiResult PostManagedStreamSubjects (PostTwitchManagedStreamSubjectDto? postTwitchManagedStreamSubjectDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NovaLab.ApiClient.Api;
using NovaLab.ApiClient.Client;
using NovaLab.ApiClient.Model;

namespace Example
{
    public class PostManagedStreamSubjectsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new TwitchManagedStreamSubjectApi(config);
            var postTwitchManagedStreamSubjectDto = new PostTwitchManagedStreamSubjectDto?(); // PostTwitchManagedStreamSubjectDto? |  (optional) 

            try
            {
                ApiResult result = apiInstance.PostManagedStreamSubjects(postTwitchManagedStreamSubjectDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TwitchManagedStreamSubjectApi.PostManagedStreamSubjects: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostManagedStreamSubjectsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiResult> response = apiInstance.PostManagedStreamSubjectsWithHttpInfo(postTwitchManagedStreamSubjectDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TwitchManagedStreamSubjectApi.PostManagedStreamSubjectsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **postTwitchManagedStreamSubjectDto** | [**PostTwitchManagedStreamSubjectDto?**](PostTwitchManagedStreamSubjectDto?.md) |  | [optional]  |

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

<a name="postselectmanagedstreamsubject"></a>
# **PostSelectManagedStreamSubject**
> ApiResult PostSelectManagedStreamSubject (string? userId = null, string? subjectName = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NovaLab.ApiClient.Api;
using NovaLab.ApiClient.Client;
using NovaLab.ApiClient.Model;

namespace Example
{
    public class PostSelectManagedStreamSubjectExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new TwitchManagedStreamSubjectApi(config);
            var userId = "userId_example";  // string? |  (optional) 
            var subjectName = "subjectName_example";  // string? |  (optional) 

            try
            {
                ApiResult result = apiInstance.PostSelectManagedStreamSubject(userId, subjectName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TwitchManagedStreamSubjectApi.PostSelectManagedStreamSubject: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostSelectManagedStreamSubjectWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiResult> response = apiInstance.PostSelectManagedStreamSubjectWithHttpInfo(userId, subjectName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TwitchManagedStreamSubjectApi.PostSelectManagedStreamSubjectWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string?** |  | [optional]  |
| **subjectName** | **string?** |  | [optional]  |

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

