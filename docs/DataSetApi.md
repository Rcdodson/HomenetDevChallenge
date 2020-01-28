# IO.Swagger.Api.DataSetApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCheat**](DataSetApi.md#getcheat) | **GET** /api/{datasetId}/cheat | Get correct answer for dataset (cheat)
[**GetDataSetId**](DataSetApi.md#getdatasetid) | **GET** /api/datasetId | Creates new dataset and returns its ID
[**PostAnswer**](DataSetApi.md#postanswer) | **POST** /api/{datasetId}/answer | Submit answer for dataset


<a name="getcheat"></a>
# **GetCheat**
> Answer GetCheat (string datasetId)

Get correct answer for dataset (cheat)

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCheatExample
    {
        public void main()
        {
            var apiInstance = new DataSetApi();
            var datasetId = datasetId_example;  // string | 

            try
            {
                // Get correct answer for dataset (cheat)
                Answer result = apiInstance.GetCheat(datasetId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSetApi.GetCheat: " + e.Message );
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

[**Answer**](Answer.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdatasetid"></a>
# **GetDataSetId**
> DatasetIdResponse GetDataSetId ()

Creates new dataset and returns its ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDataSetIdExample
    {
        public void main()
        {
            var apiInstance = new DataSetApi();

            try
            {
                // Creates new dataset and returns its ID
                DatasetIdResponse result = apiInstance.GetDataSetId();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSetApi.GetDataSetId: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**DatasetIdResponse**](DatasetIdResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postanswer"></a>
# **PostAnswer**
> AnswerResponse PostAnswer (string datasetId, Answer answer = null)

Submit answer for dataset

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostAnswerExample
    {
        public void main()
        {
            var apiInstance = new DataSetApi();
            var datasetId = datasetId_example;  // string | 
            var answer = new Answer(); // Answer |  (optional) 

            try
            {
                // Submit answer for dataset
                AnswerResponse result = apiInstance.PostAnswer(datasetId, answer);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSetApi.PostAnswer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **datasetId** | **string**|  | 
 **answer** | [**Answer**](Answer.md)|  | [optional] 

### Return type

[**AnswerResponse**](AnswerResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

