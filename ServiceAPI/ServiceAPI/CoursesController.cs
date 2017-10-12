using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ServiceAPI.Dal;
using Microsoft.EntityFrameworkCore;

namespace ServiceAPI
{
    [Route("api")]
    public class CoursesController:Controller
    {
       


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

        [HttpGet("courses")]
        public async Task<IActionResult> GetCourses()
        {
                using (var context = new StudentsDbContext())
                {
                    return Ok(await context.Courses.ToListAsync());
                }
          
        }


        [HttpDelete("courses")]
        public async Task<IActionResult> DeleteCourse([FromQuery]int id)
        {
            using (var context = new StudentsDbContext())
            {
                var course = await context.Courses.FirstOrDefaultAsync(x => x.Id == id);
                context.Courses.Remove(course);
                await context.SaveChangesAsync();
                return Ok();


            }
        }


        [HttpPost("courses")]
        public async Task<IActionResult> UpdateCourse([FromBody]Course course)
        {
            using (var context = new StudentsDbContext())
            {
                context.Courses.Update(course);
                await context.SaveChangesAsync();
                return Ok();
            }
        }
    }
}
