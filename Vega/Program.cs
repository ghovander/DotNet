using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace WebApplicationBasic
{
    public class Program
    {
    /*   ASP.NET Core applications are just console apps due to the Main entry point into the application.
    First, the host must be established with various configurations and then the web application will be run.
    two implementations of In-Process HTTP Servers: Kestrel - Cross-Platform (Cross-platform) and WebListener (Windows-only)
    Details: 
    UseKestrel() = Server to be used as web host.
    UseContentRoot(Directory.GetCurrentDirectory()) = Points to directory for web host to use for content
    UseIISIntegration() = Configures port and base path Kestrel server should listen on
    UseStartup<Startup>() = Specifies the startup type (Includes all configurations: JSON App Configs, Runtime Services, HTTP Request Pipeline)
    Build() = Builds the application
    Run() = Starts the applications
    */
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}
