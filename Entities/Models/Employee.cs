using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required]
        [StringLength(100)]
        public string EmployeeName { get; set; } = null!;

        [StringLength(50)]
        public string? EmployeePosition { get; set; }

        [StringLength(50)]
        public string EmployeeDepartment { get; set; } = null!;
    }
}