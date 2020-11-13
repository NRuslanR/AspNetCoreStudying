using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace AspNetCoreFromScratch
{
    public class ProductsLinkMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly LinkGenerator _linkGenerator;

        public ProductsLinkMiddleware(RequestDelegate next, LinkGenerator linkGenerator)
        {
            _next = next;
            _linkGenerator = linkGenerator;
        }

        public async Task Invoke(HttpContext context)
        {
            if (context.Request.Path.Value.Contains("products"))
            {
                var uri = _linkGenerator.GetPathByAction("List", "Products");

                context.Response.ContentType = "text/plain";

                await context.Response.WriteAsync($"Go to {uri} to see our products");
            }

            else await _next.Invoke(context);
        }
    }
}