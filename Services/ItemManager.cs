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
    public class ItemManager : IItemService
    {
        private readonly IRepositoryManager? _manager;

        public ItemManager(IRepositoryManager? manager)
        {
            _manager = manager;
        }

        public Item CreateItem(Item item)
        {
            _manager.Item.CreateItem(item);
            _manager.Save();

            return item;
        }

        public void DeleteItemById(Item item)
        {
            return _manager.Item.DeleteItemById(item);
        }

        public IEnumerable<Item> GetAllItems(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Item GetItemById(int itemId, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public void UpdateItem(Item item)
        {
            throw new NotImplementedException();
        }
    }
}
