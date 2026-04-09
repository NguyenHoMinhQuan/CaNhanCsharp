using System;
using System.Collections.Generic;

namespace DBFirst.Models;

public partial class Student
{
    public int StudentId { get; set; }

    public string FullName { get; set; } = null!;

    public string? Email { get; set; }

    public int? ClassId { get; set; }

    public virtual Class? Class { get; set; }
}
