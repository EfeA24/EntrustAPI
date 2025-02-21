using Entities.Models;
using Repositories.Contracts;
using Services.Contrats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class EmployeeManager : IEmployeeService
    {
        private readonly IRepositoryManager? _manager;

        public EmployeeManager(IRepositoryManager? manager)
        {
            _manager = manager;
        }

        public Employee CreateEmployee(Employee employee)
        {
            _manager.Employee.CreateEmployee(employee);
            _manager.Save();

            return employee;
        }

        public void DeleteEmployeeById(int id, Employee employee, bool trackChanges)
        {
            var entity = _manager.Employee.GetEmployeeById(id, trackChanges);
            if (entity == null)
            {
                throw new Exception("Employee not found");
            }
            _manager.Employee.DeleteEmployeeById(entity);
            _manager.Save();
        }

        public IEnumerable<Employee> GetAllEmployees(bool trackChanges)
        {
            return _manager.Employee.GetAllEmployees(trackChanges).ToList();
        }

        public Employee GetEmployeeById(int employeeId, bool trackChanges)
        {
            return _manager.Employee.GetEmployeeById(employeeId, trackChanges);
        }

        public void UpdateEmployee(int id, Employee employee, bool trackChanges)
        {
            var entity = _manager.Employee.GetEmployeeById(id, trackChanges);
            if (entity == null)
            {
                throw new Exception("Employee Not Found");
            }

            entity.EmployeeName = employee.EmployeeName;
            entity.EmployeePosition = employee.EmployeePosition;
            entity.EmployeeDepartment = employee.EmployeeDepartment;

            _manager.Employee.UpdateEmployee(entity);

        }
    }
}
