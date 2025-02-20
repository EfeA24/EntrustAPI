using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface IRepositoryManager
    {
        IEmployeeRepository Employee { get; }
        IItemRepository Item { get; }
        IEntrustRepository Entrust { get; }
        void Save();

    }
}
