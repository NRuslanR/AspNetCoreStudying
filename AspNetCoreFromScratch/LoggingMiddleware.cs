using System;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace AspNetCoreFromScratch
{
    public class LoggingMiddleware
    {
        private readonly RequestDelegate _next;
        
        public LoggingMiddleware(RequestDelegate next)
        {
            _next = next;
            
            Trace.AutoFlush = true;
        }
        
        public async Task Invoke(HttpContext context)
        {
            Trace.WriteLine(string.Join(Environment.NewLine, context.Request.Headers));

            await _next(context);
        }
    }
}