using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Therefore.API.Http
{
    public class ApiResponse<T>
    {
        public bool IsSuccess { get; set; }
        public T? Data { get; }
        public string? ErrorMessage { get; }

        private ApiResponse(bool isSuccess, T? data, string? errorMessage)
        {
            IsSuccess = isSuccess;
            Data = data;
            ErrorMessage = errorMessage;
        }

        public static ApiResponse<T> Success(T data) => new(true, data, null);
        public static ApiResponse<T> Failure(string error) => new(false, default, error);
    }
}
