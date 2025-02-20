using Entities.Models;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EfCore
{
    public class ItemRepository : RepositoryBase<Item>, IItemRepository
    {
        public ItemRepository(ApplicationDbContext context) : base(context)
        {
        }

        public void CreateItem(Item item)
        {
            Create(item);
        }

        public void DeleteItemById(Item item)
        {
            Delete(item);
        }

        public IQueryable<Item> GetAllItems(bool trackChanges)
        {
            return FindAll(trackChanges)
                .OrderBy(x => x.ItemName);
        }

        public Item GetItemById(int itemId, bool trackChanges)
        {
            return FindByCondition(x => x.ItemId.Equals(itemId), trackChanges)
                .SingleOrDefault();
        }

        public void UpdateItem(Item item)
        {
            Update(item);
        }
    }
}
