using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EfCore
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly ApplicationDbContext _context;
        private IEmployeeRepository _employeeRepository;
        private IItemRepository _itemRepository;
        private IEntrustRepository _entrustRepository;

        public RepositoryManager(ApplicationDbContext context)
        {
            _context = context;
            _employeeRepository = new EmployeeRepository(_context);
            _itemRepository = new ItemRepository(_context);
            _entrustRepository = new EntrustRepository(_context);
        }

        public IEmployeeRepository Employee => new EmployeeRepository(_context);
        public IItemRepository Item => new ItemRepository(_context);
        public IEntrustRepository Entrust => new EntrustRepository(_context);

        public void Save()
        {
            _context.SaveChanges();
        }
    }

}
