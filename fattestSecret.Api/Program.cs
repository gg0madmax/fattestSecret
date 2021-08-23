using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System;
using System.Linq;
using Autofac.Extensions.DependencyInjection;
using Serilog;

namespace fattestSecret.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var isService = args.Contains("--windows-service");
            var builder = CreateWebHostBuilder(args);
            if (isService)
            {
                builder.UseWindowsService();
            }
            var host = builder.Build();
            host.Run();
        }

        public static IHostBuilder CreateWebHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            }).UseServiceProviderFactory(new AutofacServiceProviderFactory()).UseSerilog((context, c) => c.ReadFrom.Configuration(context.Configuration));
        }
    }
}
