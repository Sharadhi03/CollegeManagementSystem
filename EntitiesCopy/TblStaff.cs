using System;
using System.Collections.Generic;

namespace CollegeManagement.Data.Entities;

public partial class TblStaff
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? EmailAddress { get; set; }

    public int? Age { get; set; }
}
