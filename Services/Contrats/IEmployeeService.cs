using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contrats
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetAllEmployees(bool trackChanges);
        Employee GetEmployeeById(int employeeId, bool trackChanges);
        void CreateEmployee(Employee employee);
        void UpdateEmployee(Employee employee);
        void DeleteEmployeeById(Employee employee);
    }
}
