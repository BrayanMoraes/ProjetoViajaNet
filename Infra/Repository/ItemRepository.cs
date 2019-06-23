using Domain.Context;
using Domain.Entities;
using Infra.RepositoryInterface;
using System;
using System.Collections.Generic;
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
        public void ConfirmItem(int itemId)
        {
            throw new NotImplementedException();
        }

        public void CreateItem(Item item)
        {
            throw new NotImplementedException();
        }

        public ICollection<Item> GetAllItems()
        {
            throw new NotImplementedException();
        }
    }
}
