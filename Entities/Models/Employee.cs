using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    class Employee
    {
        [Key]
        public int EmployeeId{ get; set; }
        public string EmployeeName { get; set; }
        public string EmployeePosition { get; set; }
        public string EmployeeDepartment { get; set; }
    }
}
