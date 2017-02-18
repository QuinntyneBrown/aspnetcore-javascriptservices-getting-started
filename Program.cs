using System;
using static System.IO.Directory;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

namespace AspNetCoreJavaScriptServicesGettingStarted
{
    public class Program
    {
        static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                            .UseContentRoot(GetCurrentDirectory())
                            .UseKestrel()
                            .UseIISIntegration()
                            .UseStartup<Startup>()
                            .Build();

            host.Run();
        }
    }
}