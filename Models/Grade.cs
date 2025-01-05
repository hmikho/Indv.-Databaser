﻿using System;
using System.Collections.Generic;

namespace Indv_SchoolDb.Models;

public partial class Grade
{
    public int GradeId { get; set; }
    public int? StudentId { get; set; }
    public int? CourseId { get; set; }
    public string? Grade1 { get; set; }
    public DateOnly? Date { get; set; }
    public int? TeacherId { get; set; }

    public virtual Course? Course { get; set; }
    public virtual Student? Student { get; set; }
    public virtual Staff? Teacher { get; set; }
}

