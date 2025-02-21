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
    public class EntrustManager : IEntrustService
    {
        private readonly IRepositoryManager? _manager;

        public EntrustManager(IRepositoryManager? manager)
        {
            _manager = manager;
        }

        public Entrust CreateEntrust(Entrust entrust)
        {
            _manager.Entrust.CreateEntrust(entrust);
            _manager.Save();

            return entrust;
        }

        public void DeleteAllEntrust(Entrust entrust)
        {
            var allEntrusts = GetAllEntrusts(trackChanges: false).ToList();
            DeleteAllEntrust(entrust);
        }

        public void DeleteEntrustById(int entrustId, Entrust entrust, bool trackChanges)
        {
            var entity = _manager.Entrust.GetEntrustById(entrust.EntrustId, trackChanges);
        }

        public IEnumerable<Entrust> GetAllEntrusts(bool trackChanges)
        {
            return _manager.Entrust.GetAllEntrusts(trackChanges).ToList();
        }

        public Entrust GetEntrustById(int entrustId, Entrust entrust, bool trackChanges)
        {
            return _manager.Entrust.GetEntrustById(entrustId, trackChanges);
        }

        public void UpdateEntrust(int entrustId, Entrust entrust, bool trackChanges)
        {
            var entity = _manager.Entrust.GetEntrustById(entrustId, trackChanges);
            if (entity == null)
            {
                throw new Exception("Entrust not found");
            }

            entity.ItemId = entrust.ItemId;
            entity.EmployeeId = entrust.EmployeeId;

            _manager.Entrust.UpdateEntrust(entity);
            _manager.Save();
        }
    }
}
