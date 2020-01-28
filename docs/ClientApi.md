# IO.Swagger.Api.ClientApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Generate**](ClientApi.md#generate) | **GET** /client/{language} | 
[**Index**](ClientApi.md#index) | **GET** /client | 


<a name="generate"></a>
# **Generate**
> void Generate (string language)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GenerateExample
    {
        public void main()
        {
            var apiInstance = new ClientApi();
            var language = language_example;  // string | 

            try
            {
                apiInstance.Generate(language);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientApi.Generate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **language** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="index"></a>
# **Index**
> void Index ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class IndexExample
    {
        public void main()
        {
            var apiInstance = new ClientApi();

            try
            {
                apiInstance.Index();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientApi.Index: " + e.Message );
            }
        }
    }
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

