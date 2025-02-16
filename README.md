# Therefore.API
**c# client for the Therefore REST API (https://therefore.net/)**

## Basic Use ##
Inject or Instantiate ThereforeService (Therefore.API/Services/) with the following:
- httpClient - HttpClient for connections
- baseURL - base Therefore URI such as https://tenant.thereforeonline.com
- tenant - Tenant name, such as myclient
- authType - Authentication type to use, either Bearer or Basic
- apiKey - Bearer token or the password for the user if Basic auth
- username - (optional) if Basic Auth, the password for the user
  
Call `ThereforeService.Method(RequestType request)`

Will return an ApiResponse (Http/ApiResponse.cs) with the following:
- IsSuccess - if the call succeeded (200 response)
- Data - The response data of type T (from Http/Responses)
- ErrorMessage - Any error message returned from the server if an error occurred
