using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.RepositoryInterface
{
    public interface IItemRepository
    {
        void CreateItem(Item item);
        Item GetItem(int itemId);
        ICollection<Item> GetAllItems();
    }
}
