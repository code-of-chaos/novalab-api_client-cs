# NovaLab.ApiClient.Api.NovaLabVersion1000CultureneutralPublicKeyTokennullApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AccountLogoutPost**](NovaLabVersion1000CultureneutralPublicKeyTokennullApi.md#accountlogoutpost) | **POST** /Account/Logout |  |
| [**AccountManageDownloadPersonalDataPost**](NovaLabVersion1000CultureneutralPublicKeyTokennullApi.md#accountmanagedownloadpersonaldatapost) | **POST** /Account/Manage/DownloadPersonalData |  |
| [**AccountManageLinkExternalLoginPost**](NovaLabVersion1000CultureneutralPublicKeyTokennullApi.md#accountmanagelinkexternalloginpost) | **POST** /Account/Manage/LinkExternalLogin |  |
| [**AccountPerformExternalLoginPost**](NovaLabVersion1000CultureneutralPublicKeyTokennullApi.md#accountperformexternalloginpost) | **POST** /Account/PerformExternalLogin |  |

<a name="accountlogoutpost"></a>
# **AccountLogoutPost**
> void AccountLogoutPost (string returnUrl)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NovaLab.ApiClient.Api;
using NovaLab.ApiClient.Client;
using NovaLab.ApiClient.Model;

namespace Example
{
    public class AccountLogoutPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new NovaLabVersion1000CultureneutralPublicKeyTokennullApi(config);
            var returnUrl = "returnUrl_example";  // string | 

            try
            {
                apiInstance.AccountLogoutPost(returnUrl);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NovaLabVersion1000CultureneutralPublicKeyTokennullApi.AccountLogoutPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AccountLogoutPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AccountLogoutPostWithHttpInfo(returnUrl);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NovaLabVersion1000CultureneutralPublicKeyTokennullApi.AccountLogoutPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **returnUrl** | **string** |  |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data, application/x-www-form-urlencoded
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountmanagedownloadpersonaldatapost"></a>
# **AccountManageDownloadPersonalDataPost**
> void AccountManageDownloadPersonalDataPost ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NovaLab.ApiClient.Api;
using NovaLab.ApiClient.Client;
using NovaLab.ApiClient.Model;

namespace Example
{
    public class AccountManageDownloadPersonalDataPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new NovaLabVersion1000CultureneutralPublicKeyTokennullApi(config);

            try
            {
                apiInstance.AccountManageDownloadPersonalDataPost();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NovaLabVersion1000CultureneutralPublicKeyTokennullApi.AccountManageDownloadPersonalDataPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AccountManageDownloadPersonalDataPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AccountManageDownloadPersonalDataPostWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NovaLabVersion1000CultureneutralPublicKeyTokennullApi.AccountManageDownloadPersonalDataPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
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

<a name="accountmanagelinkexternalloginpost"></a>
# **AccountManageLinkExternalLoginPost**
> void AccountManageLinkExternalLoginPost (string provider)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NovaLab.ApiClient.Api;
using NovaLab.ApiClient.Client;
using NovaLab.ApiClient.Model;

namespace Example
{
    public class AccountManageLinkExternalLoginPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new NovaLabVersion1000CultureneutralPublicKeyTokennullApi(config);
            var provider = "provider_example";  // string | 

            try
            {
                apiInstance.AccountManageLinkExternalLoginPost(provider);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NovaLabVersion1000CultureneutralPublicKeyTokennullApi.AccountManageLinkExternalLoginPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AccountManageLinkExternalLoginPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AccountManageLinkExternalLoginPostWithHttpInfo(provider);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NovaLabVersion1000CultureneutralPublicKeyTokennullApi.AccountManageLinkExternalLoginPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **provider** | **string** |  |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data, application/x-www-form-urlencoded
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountperformexternalloginpost"></a>
# **AccountPerformExternalLoginPost**
> void AccountPerformExternalLoginPost (string provider, string returnUrl)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NovaLab.ApiClient.Api;
using NovaLab.ApiClient.Client;
using NovaLab.ApiClient.Model;

namespace Example
{
    public class AccountPerformExternalLoginPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new NovaLabVersion1000CultureneutralPublicKeyTokennullApi(config);
            var provider = "provider_example";  // string | 
            var returnUrl = "returnUrl_example";  // string | 

            try
            {
                apiInstance.AccountPerformExternalLoginPost(provider, returnUrl);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NovaLabVersion1000CultureneutralPublicKeyTokennullApi.AccountPerformExternalLoginPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AccountPerformExternalLoginPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AccountPerformExternalLoginPostWithHttpInfo(provider, returnUrl);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NovaLabVersion1000CultureneutralPublicKeyTokennullApi.AccountPerformExternalLoginPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **provider** | **string** |  |  |
| **returnUrl** | **string** |  |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data, application/x-www-form-urlencoded
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

