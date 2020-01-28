# IO.Swagger.Api.VehiclesApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetIds**](VehiclesApi.md#getids) | **GET** /api/{datasetId}/vehicles | Get a list of all vehicleids in dataset
[**GetVehicle**](VehiclesApi.md#getvehicle) | **GET** /api/{datasetId}/vehicles/{vehicleid} | Get information about a vehicle


<a name="getids"></a>
# **GetIds**
> VehicleIdsResponse GetIds (string datasetId)

Get a list of all vehicleids in dataset

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetIdsExample
    {
        public void main()
        {
            var apiInstance = new VehiclesApi();
            var datasetId = datasetId_example;  // string | 

            try
            {
                // Get a list of all vehicleids in dataset
                VehicleIdsResponse result = apiInstance.GetIds(datasetId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VehiclesApi.GetIds: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **datasetId** | **string**|  | 

### Return type

[**VehicleIdsResponse**](VehicleIdsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvehicle"></a>
# **GetVehicle**
> VehicleResponse GetVehicle (string datasetId, int? vehicleid)

Get information about a vehicle

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetVehicleExample
    {
        public void main()
        {
            var apiInstance = new VehiclesApi();
            var datasetId = datasetId_example;  // string | 
            var vehicleid = 56;  // int? | 

            try
            {
                // Get information about a vehicle
                VehicleResponse result = apiInstance.GetVehicle(datasetId, vehicleid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VehiclesApi.GetVehicle: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **datasetId** | **string**|  | 
 **vehicleid** | **int?**|  | 

### Return type

[**VehicleResponse**](VehicleResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

