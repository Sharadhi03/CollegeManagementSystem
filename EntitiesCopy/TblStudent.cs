using System;
using System.Collections.Generic;

namespace CollegeManagement.Data.Entities;

public partial class TblStudent
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string USN { get; set; }
    public string AddressId { get; set; }

    public int? CourseId { get; set; }

    public string? CollegeName { get; set; }

    public int? Age { get; set; }

    public DateTime? BirthDate { get; set; }

    public virtual TblCourse? Course { get; set; }
    public virtual TblAddress? Address { get; set; }
}
