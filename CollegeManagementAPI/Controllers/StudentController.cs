using CollegeManagement.Data.Entities;
using CollegeManagement.Data.Repository;
using CollegeManagementAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Metrics;

namespace CollegeManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public StudentRepository StudentRepository { get; set; }

        public StudentController()
        {
            this.StudentRepository = new StudentRepository();
        }
        [HttpGet]
        public List<TblStudent> GetAllStudents()
        {
            return this.StudentRepository.GetAllStudents();
        }
        [HttpPost]
        public void AddStudent(Student student)
        {
            TblStudent tblstudent = new TblStudent();
            tblstudent.Id = 1;
            tblstudent.Name = student.Name;
            tblstudent.Usn = student.USN;
            //tblstudent.Address = student.Address;
            tblstudent.CourseId = student.CourseId;
            tblstudent.CollegeName = student.CollegeName;
            tblstudent.Age = student.Age;
            tblstudent.BirthDate = student.BirthDate;
            this.StudentRepository.AddStudent(tblstudent);
        }
        [HttpDelete]
        public void DeleteStudent(int studentId)
        {
            this.StudentRepository.DeleteStudent(studentId);
        }
        [HttpGet("{studentId:int}")]
        public TblStudent GetStudent(int studentId, int courseId)
        {
            return StudentRepository.GetStudent(studentId);
        }

    }
}
