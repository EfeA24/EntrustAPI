using Entities.Models;
using Repositories.Contracts;
using Services.Contrats;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public class ItemManager : IItemService
    {
        private readonly IRepositoryManager _manager;

        public ItemManager(IRepositoryManager manager)
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
            _manager.Item.DeleteItemById(item);
            _manager.Save();
        }

        public IEnumerable<Item> GetAllItems(bool trackChanges)
        {
            return _manager.Item.GetAllItems(trackChanges).ToList();
        }

        public Item GetItemById(int itemId, bool trackChanges)
        {
            return _manager.Item.GetItemById(itemId, trackChanges);
        }

        public void UpdateItem(Item item)
        {
            _manager.Item.UpdateItem(item);
            _manager.Save();
        }
    }
}