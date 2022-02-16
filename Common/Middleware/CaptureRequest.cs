using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.IO;
using System.Threading.Tasks;

namespace TeamManagement.Common.Middleware
{
    public class CaptureRequest
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<CaptureRequest> _logger;

        public CaptureRequest(RequestDelegate next, ILogger<CaptureRequest> logger)
        {
            _next = next;
            _logger = logger;   
        }

        public async Task Invoke(HttpContext context)
        {
            _logger.LogTrace("Request begin");
            if (context != null && context.Request != null)
            {
                var requestBody = await new StreamReader(context.Request.Body).ReadToEndAsync();
                _logger.LogInformation(requestBody);
            }
            await _next(context);
        }
    }
}
