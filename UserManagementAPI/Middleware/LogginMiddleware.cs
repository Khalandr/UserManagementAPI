using Microsoft.AspNetCore.Http;
using System.Diagnostics;
using System.Threading.Tasks;

namespace UserManagementAPI.Middleware
{
    public class LoggingMiddleware
    {
        private readonly RequestDelegate _next;

        public LoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var stopwatch = Stopwatch.StartNew();
            Console.WriteLine($"Request: {context.Request.Method} {context.Request.Path}");
            await _next(context);
            stopwatch.Stop();
            Console.WriteLine($"Response: {context.Response.StatusCode} (Elapsed: {stopwatch.ElapsedMilliseconds}ms)");
        }
    }
}
