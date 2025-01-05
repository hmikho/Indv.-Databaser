using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema; 

namespace Indv_SchoolDb.Models
{
    [Table("Staff")] 
    public partial class Staff
    {
        public int StaffId { get; set; }
        public string? Name { get; set; }
        public string Position { get; set; }
        public DateOnly? EmploymentDate { get; set; }
        public int? DepartmentId { get; set; }
        public decimal? MonthlySalary { get; set; }
        public virtual ICollection<Grade> Grades { get; set; } = new List<Grade>();
        public virtual Department? Department { get; set; }
    }
}
