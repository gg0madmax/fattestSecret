using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fattestSecret.Api.HealthChecks
{
    public class HealthCheckResponseWriter
    {
        private static readonly JsonSerializerSettings SerializerSettings = new JsonSerializerSettings
        {
            Converters = new List<JsonConverter> { new StringEnumConverter() }
        };

        public static async Task WriteResponse(HttpContext httpContext, HealthReport healthReport)
        {
            httpContext.Response.ContentType = "application/json";
            var json = JsonConvert.SerializeObject(healthReport, SerializerSettings);
            await httpContext.Response.WriteAsync(json);
        }
    }
}
