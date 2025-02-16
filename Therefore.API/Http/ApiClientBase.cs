using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Therefore.API.Constants;
using Newtonsoft.Json;

namespace Therefore.API.Http
{
    public abstract class ApiClientBase
    {
        private readonly HttpClient _httpClient;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="httpClient">Inject the HttpClient for the requests</param>
        /// <param name="baseUrl">Base URL ie https://tenant.thereforeonline.com</param>
        /// <param name="authType">Type of authentication</param>
        /// <param name="apiKey">Api key or password</param>
        /// <param name="username">Username if Basic Auth is used</param>
        /// <exception cref="ArgumentException"></exception>
        protected ApiClientBase(HttpClient httpClient, string baseUrl, string? tenant, AuthType authType, string apiKey, string? username = null)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri(baseUrl);

            if (tenant != null )
            {
                _httpClient.DefaultRequestHeaders.Add("TenantName", tenant);
            }

            switch (authType)
            {
                case AuthType.Bearer:
                    _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
                    break;

                case AuthType.Basic when username != null:
                    var credentials = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{username}:{apiKey}"));
                    _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", credentials);
                    break;

                default:
                    throw new ArgumentException("Invalid authentication type or missing username for Basic auth.");
            }
        }

        protected async Task<ApiResponse<TResponse>> GetAsync<TResponse>(string endpoint)
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(endpoint);

                if (!response.IsSuccessStatusCode)
                {
                    string errorMessage = await response.Content.ReadAsStringAsync();
                    return ApiResponse<TResponse>.Failure($"HTTP {response.StatusCode}: {errorMessage}");
                }
                var responseString = await response.Content.ReadAsStringAsync();
                var responseData = JsonConvert.DeserializeObject<TResponse>(responseString);
                return responseData != null
                    ? ApiResponse<TResponse>.Success(responseData)
                    : ApiResponse<TResponse>.Failure("Response was empty.");
            }
            catch (Exception ex)
            {
                return ApiResponse<TResponse>.Failure($"Exception: {ex.Message}");
            }
        }

        /// <summary>
        /// Sends a POST request with a JSON body and returns an ApiResponse<TResponse>.
        /// </summary>
        protected async Task<ApiResponse<TResponse>> PostAsync<TRequest, TResponse>(string endpoint, TRequest request)
        {
            try
            {
                string json = JsonConvert.SerializeObject(request);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await _httpClient.PostAsync(endpoint, content);
                if (!response.IsSuccessStatusCode)
                {
                    string errorMessage = await response.Content.ReadAsStringAsync();
                    return ApiResponse<TResponse>.Failure($"HTTP {response.StatusCode}: {errorMessage}");
                }
                var responseString = await response.Content.ReadAsStringAsync();
                var responseData = JsonConvert.DeserializeObject<TResponse>(responseString);
                return responseData != null
                    ? ApiResponse<TResponse>.Success(responseData)
                    : ApiResponse<TResponse>.Failure("Response was empty.");
            }
            catch (Exception ex)
            {
                return ApiResponse<TResponse>.Failure($"Exception: {ex.Message}");
            }
        }
    }
}
