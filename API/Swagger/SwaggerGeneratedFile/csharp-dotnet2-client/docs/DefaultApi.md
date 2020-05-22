# IO.Swagger.Api.DefaultApi

All URIs are relative to *http://localhost/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MoviePut**](DefaultApi.md#movieput) | **PUT** /movie | 
[**MoviesGet**](DefaultApi.md#moviesget) | **GET** /movies | 


<a name="movieput"></a>
# **MoviePut**
> Message MoviePut (Movie movie)



Add Movie to the library

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MoviePutExample
    {
        public void main()
        {
            
            var apiInstance = new DefaultApi();
            var movie = new Movie(); // Movie | Movie you want to update

            try
            {
                Message result = apiInstance.MoviePut(movie);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.MoviePut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **movie** | [**Movie**](Movie.md)| Movie you want to update | 

### Return type

[**Message**](Message.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="moviesget"></a>
# **MoviesGet**
> List<Movie> MoviesGet ()



Returns all the movie from the list

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MoviesGetExample
    {
        public void main()
        {
            
            var apiInstance = new DefaultApi();

            try
            {
                List&lt;Movie&gt; result = apiInstance.MoviesGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.MoviesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Movie>**](Movie.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

