using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contrats
{
    public interface IEntrustService
    {
        IEnumerable<Entrust> GetAllEntrusts(bool trackChanges);
        Entrust GetEntrustById(int entrustId, Entrust entrust, bool trackChanges);
        Entrust CreateEntrust(Entrust entrust);
        void UpdateEntrust(int entrustId, Entrust entrust, bool trackChanges);
        void DeleteEntrustById(int entrustId, Entrust entrust, bool trackChanges);
        void DeleteAllEntrust(Entrust entrust);
    }
}
