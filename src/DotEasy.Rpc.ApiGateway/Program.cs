﻿using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace DotEasy.Rpc.ApiGateway
{
    public class Program 
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) => WebHost.CreateDefaultBuilder(args)
            .ConfigureAppConfiguration((hostingContext, builder) =>
            {
                builder.SetBasePath(hostingContext.HostingEnvironment.ContentRootPath)
                    .AddJsonFile("Ocelot.json");
            })
            .UseStartup<Startup>();
    }
}