using Entities.Models;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EfCore
{
    public class EmployeeRepository : RepositoryBase<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(ApplicationDbContext context) : base(context)
        {
        }

        public void CreateEmployee(Employee employee)
        {
            Create(employee);
        }

        public void DeleteEmployeeById(Employee employee)
        {
            Delete(employee);
        }

        public IQueryable<Employee> GetAllEmployees(bool trackChanges)
        {
            return FindAll(trackChanges)
                .OrderBy(x => x.EmployeeName);
        }

        public Employee GetEmployeeById(int employeeId, bool trackChanges)
        {
            return FindByCondition(x => x.EmployeeId.Equals(employeeId), trackChanges)
                .SingleOrDefault();
        }

        public void UpdateEmployee(Employee employee)
        {
            Update(employee);
        }
    }
}
