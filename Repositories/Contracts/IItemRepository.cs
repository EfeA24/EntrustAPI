using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface IItemRepository
    {
        IQueryable<Item> GetAllItems(bool trackChanges);
        Item GetItemById(int itemId, bool trackChanges);
        void CreateItem(Item item);
        void UpdateItem(Item item);
        void DeleteItemById(Item item);
    }
}
