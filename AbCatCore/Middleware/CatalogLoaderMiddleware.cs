using EPCat.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AbCatCore.Middleware
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseCatalogLoader(
            this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CatalogLoaderMiddleware>();
        }
    }

    public class CatalogLoaderMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IConfiguration _config;

        public CatalogLoaderMiddleware(RequestDelegate next, IConfiguration config)
        {
            _next = next;
            _config = config;          
        }

        public async Task InvokeAsync(HttpContext context)
        {
            //CatalogLoaderHelper.ProcessScriptFile();
            await _next(context);           
        }


    }
}
