# IO.Swagger.Api.DealersApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetDealer**](DealersApi.md#getdealer) | **GET** /api/{datasetId}/dealers/{dealerid} | Get information about a dealer


<a name="getdealer"></a>
# **GetDealer**
> DealersResponse GetDealer (string datasetId, int? dealerid)

Get information about a dealer

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDealerExample
    {
        public void main()
        {
            var apiInstance = new DealersApi();
            var datasetId = datasetId_example;  // string | 
            var dealerid = 56;  // int? | 

            try
            {
                // Get information about a dealer
                DealersResponse result = apiInstance.GetDealer(datasetId, dealerid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DealersApi.GetDealer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **datasetId** | **string**|  | 
 **dealerid** | **int?**|  | 

### Return type

[**DealersResponse**](DealersResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

