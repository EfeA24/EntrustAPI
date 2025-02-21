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
        IEntrustRepository Entrust { get; }
        IItemRepository Item { get; }
        void Save();

    }
}
