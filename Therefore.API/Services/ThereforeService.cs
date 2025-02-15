using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Therefore.API.Constants;
using Therefore.API.Http;

namespace Therefore.API.Services
{
    public class ThereforeService : ApiClientBase
    {
        public ThereforeService(HttpClient httpClient, string baseUrl, string? tenant, AuthType authType, string apiKey, string? username = null) : base(httpClient, baseUrl, tenant, authType, apiKey, username = null) {}




    }   
}
