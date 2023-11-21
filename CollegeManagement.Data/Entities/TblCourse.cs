using System;
using System.Collections.Generic;

namespace CollegeManagement.Data.Entities;

public partial class TblCourse
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public virtual ICollection<TblStudent> TblStudents { get; } = new List<TblStudent>();
}
