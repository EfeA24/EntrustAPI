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
        Entrust GetEntrustById(int entrustId, bool trackChanges);
        void CreateEntrust(Entrust entrust);
        void UpdateEntrust(Entrust entrust);
        void DeleteEntrustById(Entrust entrust);
        void DeleteAllEntrust(Entrust entrust);
    }
}
