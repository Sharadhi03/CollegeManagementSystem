using System;
using System.Collections.Generic;

namespace CollegeManagement.Data.Entities;

public partial class TblAddress
{
    public int Id { get; set; }

    public string? AddressStreet1 { get; set; }

    public string? AddressStreet2 { get; set; }

    public string? AddressCity { get; set; }

    public string? AddressPin { get; set; }

    public virtual ICollection<TblStudent> TblStudents { get; } = new List<TblStudent>();
}
