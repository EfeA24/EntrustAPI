using Entities.Models;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EfCore
{
    public class EntrustRepository : RepositoryBase<Entrust>, IEntrustRepository
    {
        public EntrustRepository(ApplicationDbContext context) : base(context)
        {
        }

        public void CreateEntrust(Entrust entrust)
        {
            Create(entrust);
        }

        public void DeleteAllEntrust(Entrust entrust)
        {
            var allEntrusts = FindAll(trackChanges: false).ToList();
            foreach (var e in allEntrusts)
            {
                Delete(e);
            }
        }

        public void DeleteEntrustById(Entrust entrust)
        {
            Delete(entrust);
        }

        public IQueryable<Entrust> GetAllEntrusts(bool trackChanges)
        {
            return FindAll(trackChanges)
                .OrderBy(x => x.EntrustId);
        }

        public Entrust GetEntrustById(int entrustId, bool trackChanges)
        {
            return FindByCondition(x => x.EntrustId.Equals(entrustId), trackChanges)
                .SingleOrDefault();
        }

        public void UpdateEntrust(Entrust entrust)
        {
            Update(entrust);
        }
    }
}
