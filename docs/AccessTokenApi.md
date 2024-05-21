# NovaLab.ApiClient.Api.AccessTokenApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**RefreshTokens**](AccessTokenApi.md#refreshtokens) | **GET** /api/{userId}/twitch/tokens/refresh |  |

<a name="refreshtokens"></a>
# **RefreshTokens**
> void RefreshTokens (string userId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using NovaLab.ApiClient.Api;
using NovaLab.ApiClient.Client;
using NovaLab.ApiClient.Model;

namespace Example
{
    public class RefreshTokensExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AccessTokenApi(config);
            var userId = "userId_example";  // string | 

            try
            {
                apiInstance.RefreshTokens(userId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccessTokenApi.RefreshTokens: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefreshTokensWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.RefreshTokensWithHttpInfo(userId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccessTokenApi.RefreshTokensWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string** |  |  |

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

