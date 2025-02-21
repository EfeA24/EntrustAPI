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
        Employee CreateEmployee(Employee employee);
        void UpdateEmployee(int id, Employee employee, bool trackChanges);
        void DeleteEmployeeById(int id, bool trackChanges);
    }
}
