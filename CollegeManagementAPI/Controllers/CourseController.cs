using CollegeManagementAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CollegeManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private static List<Course> courselist = new List<Course>()
        {
            new Course
            {
                Id=123,
                Name="Computer Science",
                StartDate=new DateTime(2021,12,30),
                EndDate=new DateTime(2025,06,30)
            },
            new Course
            {
               Id=126,
               Name="Artificial Intillegence & ML",
               StartDate=new DateTime(2020,09,1),
               EndDate=new DateTime(2024,08,31)
            },
        };
        [HttpGet]
        public List<Course> GetAllCourses()
        {
            return courselist;
        }

        [HttpPost]
        public void AddCourse(Course course)
        {
            courselist.Add(course);
        }
        [HttpDelete]
        public void DeleteCourse(int courseId)
        {
            var coursetobeDeleted = courselist.Where(c => c.Id == courseId).FirstOrDefault();
            courselist.Remove(coursetobeDeleted);
        }
        [HttpGet("{courseId}:int")]
        public Course GetCourseById(int courseId)
        {
            var CourseBy = courselist.Where(c => c.Id == courseId).FirstOrDefault();
            return CourseBy;
        }
    }
}
