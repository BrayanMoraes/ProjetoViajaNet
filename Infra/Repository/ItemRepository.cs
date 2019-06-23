using Domain.Context;
using Domain.Entities;
using Infra.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infra.Repository
{
    public class ItemRepository : IItemRepository
    {
        private readonly ProjectContext _context;

        public ItemRepository(ProjectContext context)
        {
            _context = context;
        }
        public Item GetItem(int itemId)
        {
            return _context.Items.Find(itemId);
        }

        public void CreateItem(Item item)
        {
            _context.Items.Add(item);
        }

        public ICollection<Item> GetAllItems()
        {
            return _context.Items.ToList();
        }
    }
}
