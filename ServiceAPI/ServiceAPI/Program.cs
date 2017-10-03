using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

               /* Student s = new Student()
                {
                    Name = "Paolo",
                    DateOfBirth = new DateTime(2012, 1, 1)
                };
                context.Students.Add(s);
                context.SaveChanges();*/
                var student = context.Students.Find(1);
                //student.DateOfBirth = new DateTime(2012, 1, 4);
                context.Students.Update(student);


                context.SaveChanges();

                //Console.WriteLine(student.Id + " " + student.Name + " " + student.DateOfBirth);
                //Console.ReadLine();

            }


           
        }

        
       

            /*var host = new WebHostBuilder()
                    .UseKestrel()
                    .UseStartup<Startup>()
                    .Build();

            Task restService = host.RunAsync();

            //System.Diagnostics.Process.Start("chrome.exe", "http://localhost/netcoreapp2.0/corsoing/");
            System.Diagnostics.Process.Start("cmd", "/C start http://localhost/netcoreapp2.0/corsoing/");
            restService.Wait();*/
        }
    }

