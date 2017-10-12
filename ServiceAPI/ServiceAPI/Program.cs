using Microsoft.AspNetCore.Hosting;
using System;
using System.Threading.Tasks;

namespace ServiceAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            using
            context.Database.EnsureCreated();


            /*var host = new WebHostBuilder() //serve per hostare una api
                .UseKestrel() //integreted webserver
                .UseStartup<Startup>() //service and request pipeline configuration
                //.UseUrls();
                .Build();

            Task restService = host.RunAsync();

            //System.Diagnostics.Process.Start("chrome.exe", "http://localhost/netcoreapp2.0/corsoing/");
            System.Diagnostics.Process.Start("cmd", "/C start http://localhost/netcoreapp2.0/corsoing/");
            restService.Wait();*/
        }
    }
}
