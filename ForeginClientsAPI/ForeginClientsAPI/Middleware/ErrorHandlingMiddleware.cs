using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace ForeginClientsAPI.Middleware
{
    public class ErrorHandlingMiddleware : IMiddleware // Middleware for handling errors
    {
        public Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            throw new System.NotImplementedException();
        }
    }
}
