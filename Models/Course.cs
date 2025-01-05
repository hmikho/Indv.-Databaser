using System;
using System.Collections.Generic;

namespace Indv_SchoolDb.Models;

public partial class Course
{
    public int CourseId { get; set; }

    public string? CourseName { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<Grade> Grades { get; set; } = new List<Grade>();
}
