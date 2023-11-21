using CollegeManagement.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeManagement.Data.Repository
{
    public class StudentRepository
    {
        KmsContext KmsDbContext { get; set; }
        public StudentRepository()
        {
            this.KmsDbContext = new KmsContext();
        }
        public List<TblStudent> GetAllStudents()
        {
            return this.KmsDbContext.TblStudents.ToList();
        }
        public void AddStudent(TblStudent student)
        {
            this.KmsDbContext.TblStudents.Add(student);
            this.KmsDbContext.SaveChanges();
        }
        public void DeleteStudent(int studentId)
        {
            var studentNeedsTobeDeleted = this.KmsDbContext.TblStudents.Where(s => s.Id == studentId).FirstOrDefault();
            if (studentNeedsTobeDeleted != null)
            {
                this.KmsDbContext.Remove(studentNeedsTobeDeleted);
                this.KmsDbContext.SaveChanges();
            }
        }
        public TblStudent GetStudent(int studentId)
        {
            var a = this.KmsDbContext.TblStudents.Where(s => s.Id == studentId).FirstOrDefault();
            return a;
        }
    }
}
