using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contrats
{
    public interface IItemService
    {
        IEnumerable<Item> GetAllItems(bool trackChanges);
        Item GetItemById(int itemId, bool trackChanges);
        Item CreateItem(Item item);
        void UpdateItem(Item item);
        void DeleteItemById(Item item);
    }
}
