# NovaLab.ApiClient.Api.TrackedStreamSubjectApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteTrackedStreamSubject**](TrackedStreamSubjectApi.md#deletetrackedstreamsubject) | **DELETE** /api/twitch/tracked-stream-subject |  |
| [**GetTrackedStreamSubject**](TrackedStreamSubjectApi.md#gettrackedstreamsubject) | **GET** /api/twitch/tracked-stream-subject |  |
| [**GetTrackedStreamSubjects**](TrackedStreamSubjectApi.md#gettrackedstreamsubjects) | **GET** /api/twitch/tracked-stream-subject/all |  |
| [**SelectTrackedStreamSubject**](TrackedStreamSubjectApi.md#selecttrackedstreamsubject) | **POST** /api/twitch/tracked-stream-subject/select |  |
| [**UpsertTrackedStreamSubject**](TrackedStreamSubjectApi.md#upserttrackedstreamsubject) | **POST** /api/twitch/tracked-stream-subject |  |

<a id="deletetrackedstreamsubject"></a>
# **DeleteTrackedStreamSubject**
> BooleanIApiResult DeleteTrackedStreamSubject (Guid? subjectId = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NovaLab.ApiClient.Api;
using NovaLab.ApiClient.Client;
using NovaLab.ApiClient.Model;

namespace Example
{
    public class DeleteTrackedStreamSubjectExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new TrackedStreamSubjectApi(config);
            var subjectId = "subjectId_example";  // Guid? |  (optional) 

            try
            {
                BooleanIApiResult result = apiInstance.DeleteTrackedStreamSubject(subjectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TrackedStreamSubjectApi.DeleteTrackedStreamSubject: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteTrackedStreamSubjectWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<BooleanIApiResult> response = apiInstance.DeleteTrackedStreamSubjectWithHttpInfo(subjectId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TrackedStreamSubjectApi.DeleteTrackedStreamSubjectWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subjectId** | **Guid?** |  | [optional]  |

### Return type

[**BooleanIApiResult**](BooleanIApiResult.md)

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
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettrackedstreamsubject"></a>
# **GetTrackedStreamSubject**
> TrackedStreamSubjectDtoIApiResult GetTrackedStreamSubject (Guid? userId = null, Guid? subjectId = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NovaLab.ApiClient.Api;
using NovaLab.ApiClient.Client;
using NovaLab.ApiClient.Model;

namespace Example
{
    public class GetTrackedStreamSubjectExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new TrackedStreamSubjectApi(config);
            var userId = "userId_example";  // Guid? |  (optional) 
            var subjectId = "subjectId_example";  // Guid? |  (optional) 

            try
            {
                TrackedStreamSubjectDtoIApiResult result = apiInstance.GetTrackedStreamSubject(userId, subjectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TrackedStreamSubjectApi.GetTrackedStreamSubject: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTrackedStreamSubjectWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<TrackedStreamSubjectDtoIApiResult> response = apiInstance.GetTrackedStreamSubjectWithHttpInfo(userId, subjectId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TrackedStreamSubjectApi.GetTrackedStreamSubjectWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **Guid?** |  | [optional]  |
| **subjectId** | **Guid?** |  | [optional]  |

### Return type

[**TrackedStreamSubjectDtoIApiResult**](TrackedStreamSubjectDtoIApiResult.md)

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

<a id="gettrackedstreamsubjects"></a>
# **GetTrackedStreamSubjects**
> TrackedStreamSubjectDtoIApiResult GetTrackedStreamSubjects (Guid? userId = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NovaLab.ApiClient.Api;
using NovaLab.ApiClient.Client;
using NovaLab.ApiClient.Model;

namespace Example
{
    public class GetTrackedStreamSubjectsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new TrackedStreamSubjectApi(config);
            var userId = "userId_example";  // Guid? |  (optional) 

            try
            {
                TrackedStreamSubjectDtoIApiResult result = apiInstance.GetTrackedStreamSubjects(userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TrackedStreamSubjectApi.GetTrackedStreamSubjects: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTrackedStreamSubjectsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<TrackedStreamSubjectDtoIApiResult> response = apiInstance.GetTrackedStreamSubjectsWithHttpInfo(userId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TrackedStreamSubjectApi.GetTrackedStreamSubjectsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **Guid?** |  | [optional]  |

### Return type

[**TrackedStreamSubjectDtoIApiResult**](TrackedStreamSubjectDtoIApiResult.md)

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

<a id="selecttrackedstreamsubject"></a>
# **SelectTrackedStreamSubject**
> BooleanIApiResult SelectTrackedStreamSubject (Guid? userId = null, Guid? subjectId = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NovaLab.ApiClient.Api;
using NovaLab.ApiClient.Client;
using NovaLab.ApiClient.Model;

namespace Example
{
    public class SelectTrackedStreamSubjectExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new TrackedStreamSubjectApi(config);
            var userId = "userId_example";  // Guid? |  (optional) 
            var subjectId = "subjectId_example";  // Guid? |  (optional) 

            try
            {
                BooleanIApiResult result = apiInstance.SelectTrackedStreamSubject(userId, subjectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TrackedStreamSubjectApi.SelectTrackedStreamSubject: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SelectTrackedStreamSubjectWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<BooleanIApiResult> response = apiInstance.SelectTrackedStreamSubjectWithHttpInfo(userId, subjectId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TrackedStreamSubjectApi.SelectTrackedStreamSubjectWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **Guid?** |  | [optional]  |
| **subjectId** | **Guid?** |  | [optional]  |

### Return type

[**BooleanIApiResult**](BooleanIApiResult.md)

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
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="upserttrackedstreamsubject"></a>
# **UpsertTrackedStreamSubject**
> TrackedStreamSubjectDtoIApiResult UpsertTrackedStreamSubject (Guid? subjectId = null, TrackedStreamSubjectDtoPost? trackedStreamSubjectDtoPost = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NovaLab.ApiClient.Api;
using NovaLab.ApiClient.Client;
using NovaLab.ApiClient.Model;

namespace Example
{
    public class UpsertTrackedStreamSubjectExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new TrackedStreamSubjectApi(config);
            var subjectId = "subjectId_example";  // Guid? |  (optional) 
            var trackedStreamSubjectDtoPost = new TrackedStreamSubjectDtoPost?(); // TrackedStreamSubjectDtoPost? |  (optional) 

            try
            {
                TrackedStreamSubjectDtoIApiResult result = apiInstance.UpsertTrackedStreamSubject(subjectId, trackedStreamSubjectDtoPost);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TrackedStreamSubjectApi.UpsertTrackedStreamSubject: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertTrackedStreamSubjectWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<TrackedStreamSubjectDtoIApiResult> response = apiInstance.UpsertTrackedStreamSubjectWithHttpInfo(subjectId, trackedStreamSubjectDtoPost);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TrackedStreamSubjectApi.UpsertTrackedStreamSubjectWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subjectId** | **Guid?** |  | [optional]  |
| **trackedStreamSubjectDtoPost** | [**TrackedStreamSubjectDtoPost?**](TrackedStreamSubjectDtoPost?.md) |  | [optional]  |

### Return type

[**TrackedStreamSubjectDtoIApiResult**](TrackedStreamSubjectDtoIApiResult.md)

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

