using System;
using System.Collections.Generic;

namespace Indv_SchoolDb.Models;

public partial class StaffOverview
{
    public string? StaffName { get; set; }

    public string? Position { get; set; }

    public string? DepartmentName { get; set; }

    public decimal? MonthlySalary { get; set; }

    public int? YearsEmployed { get; set; }
}
