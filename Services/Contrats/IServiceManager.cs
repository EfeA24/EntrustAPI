using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contrats
{
    public interface IServiceManager
    {
        IEmployeeService EmployeeService { get; }
        IEntrustService EntrustService { get; }
        IItemService ItemService { get; }
    }
}
