using CollegeManagementAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CollegeManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private static List<Staff> stafflist = new List<Staff>()
        {
            new Staff
            {
                Id=676,
                FirstName="Bob",
                LastName="Marley",
                EmailAddress="bobmarley@gmail.com",
                Age=42
            },
            new Staff
            {
               Id=857,
               FirstName="Historia",
               LastName="Reiss",
               EmailAddress="historiareiss@gmail.com",
               Age=30
            },
        };
        [HttpGet]
        public List<Staff> GetAllStaff()
        {
            return stafflist;
        }

        [HttpPost]
        public void AddStaff(Staff staff)
        {
            stafflist.Add(staff);
        }
        [HttpDelete]
        public void DeleteStaff(int staffId)
        {
            var stafftobeDeleted = stafflist.Where(t => t.Id == staffId).FirstOrDefault();
            stafflist.Remove(stafftobeDeleted);
        }
        [HttpGet("staffId:int")]
        public Staff GetStaffById(int staffId)
        {
            var StaffBy = stafflist.Where(t => t.Id == staffId).FirstOrDefault();
            return StaffBy;
        }
    }
}
