using System.ComponentModel.DataAnnotations;
using System.Net;

namespace CollegeManagementAPI.Models
{
    public class Student
    {
        public int Id { get; set; }
        [MaxLength(20)]
        public string Name { get; set; }
        public string USN { get; set; }
        public Address Address { get; set; }
        public int CourseId { get; set; }
        [MaxLength(20)]
        public string CollegeName { get; set; }
        [Range(21, 25)]
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
