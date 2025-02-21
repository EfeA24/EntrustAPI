using Services.Contrats;

namespace Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly IEmployeeService _employeeService;
        private readonly IEntrustService _entrustService;
        private readonly IItemService _itemService;

        public ServiceManager(IEmployeeService employeeService, IEntrustService entrustService, IItemService itemService)
        {
            _employeeService = employeeService;
            _entrustService = entrustService;
            _itemService = itemService;
        }

        public IEmployeeService EmployeeService => _employeeService;
        public IEntrustService EntrustService => _entrustService;
        public IItemService ItemService => _itemService;
    }
}