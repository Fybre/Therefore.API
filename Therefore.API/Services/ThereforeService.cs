using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Therefore.API.Constants;
using Therefore.API.Http;
using Therefore.API.Http.Requests;
using Therefore.API.Http.Responses;

namespace Therefore.API.Services
{
    public class ThereforeService : ApiClientBase
    {
        public ThereforeService(HttpClient httpClient, string baseUrl, string? tenant, AuthType authType, string apiKey, string? username = null) : base(httpClient, baseUrl, tenant, authType, apiKey, username)
        {
        }

        public async Task<ApiResponse<ClaimWorkflowInstanceResponse>> ClaimWorkflowInstance(ClaimWorkflowInstanceRequest request)
        {
            return await PostAsync<ClaimWorkflowInstanceRequest, ClaimWorkflowInstanceResponse>(ApiEndpoints.ClaimWorkflowInstance, request);
        }

        public async Task<ApiResponse<CreateDocumentResponse>> CreateDocument(CreateDocumentRequest request)
        {
            return await PostAsync<CreateDocumentRequest, CreateDocumentResponse>(ApiEndpoints.CreateDocument, request);
        }

        public async Task<ApiResponse<CreateUserResponse>> CreateUser(CreateUserRequest request)
        {
            return await PostAsync<CreateUserRequest, CreateUserResponse>(ApiEndpoints.CreateUser, request);
        }

        public async Task<ApiResponse<ExecuteSingleQueryResponse>> ExecuteSingleQuery(ExecuteSingleQueryRequest request)
        {
            return await PostAsync<ExecuteSingleQueryRequest, ExecuteSingleQueryResponse>(ApiEndpoints.ExecuteSingleQuery, request);
        }

        public async Task<ApiResponse<FinishCurrentWorkflowTaskResponse>> FinishCurrentWorkflowTask(FinishCurrentWorkflowTaskRequest request)
        {
            return await PostAsync<FinishCurrentWorkflowTaskRequest, FinishCurrentWorkflowTaskResponse>(ApiEndpoints.FinishCurrentWorkflowTask, request);
        }

        public async Task<ApiResponse<GetWorkflowInstanceResponse>> GetWorkflowInstance(GetWorkflowInstanceRequest request)
        {
            return await PostAsync<GetWorkflowInstanceRequest,GetWorkflowInstanceResponse>(ApiEndpoints.GetWorkflowInstance, request);
        }

        public async Task<ApiResponse<GetWorkflowProcessResponse>> GetWorkflowProcess (GetWorkflowProcessRequest request)
        {
            return await PostAsync<GetWorkflowProcessRequest, GetWorkflowProcessResponse>(ApiEndpoints.GetWorkflowProcess, request);
        }
    }   
}
