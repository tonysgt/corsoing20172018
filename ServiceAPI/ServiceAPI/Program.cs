using Microsoft.AspNetCore.Hosting;
using ServiceAPI.Dal;
using System;
using System.Threading.Tasks;

namespace ServiceAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new StudentsDbContext())
            {
                // Create database
                context.Database.EnsureCreated();

               

                //context.Students.Add(s);
                //context.SaveChanges();


                //var student = context.Students.Find(1);
                //var student = context.Students.FirstOrDefault(x => x.Name == "Mario");

                //student.DateOfBirth = new DateTime(2012, 1, 4);
                //context.Students.Update(student);
                //context.Students.Remove(student);

                //context.SaveChanges();
                /*if (student != null)
                {
                    Console.WriteLine(student.Id + " " + student.Name + " " + student.DateOfBirth);
                    Console.ReadLine();
                }*/

            }

            var host = new WebHostBuilder() //serve per hostare una api
                .UseKestrel() //integreted webserver
                .UseStartup<Startup>() //service and request pipeline configuration
                //.UseUrls();
                .Build();
            host.Run();

            /*Task restService = host.RunAsync();

            //System.Diagnostics.Process.Start("chrome.exe", "http://localhost/netcoreapp2.0/corsoing/");
            System.Diagnostics.Process.Start("cmd", "/C start http://localhost/netcoreapp2.0/corsoing/");
            restService.Wait();*/
        }
    }
}
