﻿using Microsoft.AspNetCore.Hosting;
using Orchard.Hosting;
using Orchard.Web;

namespace Orchard.Console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseDefaultHostingConfiguration(args)
                .UseKestrel()
                .UseStartup<Startup>()
                .Build();

            using (host)
            {
                host.Run();

                var orchardHost = new OrchardHost(host.Services, System.Console.In, System.Console.Out, args);
                orchardHost.Run();
            }
        }
    }
}