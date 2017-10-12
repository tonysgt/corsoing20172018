using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ServiceAPI.Dal;

namespace ServiceAPI
{
    [Route("api")]
    public class CoursesController:Controller
    {
        [HttpGet("setup")]
        public IActionResult SetupDatabase()
        {
            lock (setupLock)
            {
                using (var context = new StudentsDbContext())
                {
                    // Create database
                    context.Database.EnsureCreated();
                }
                return Ok("database created");
            }
        }


        [HttpPut("courses")]
        public async Task<IActionResult> CreateCourses([FromBody]Course course)
        {
            using (var context = new StudentsDbContext())
            {
                context.Courses.Add(course);

                await context.SaveChangesAsync();

                return Ok();
            }
        }
    }
}
