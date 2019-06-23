using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.FacadeInterfaces
{
    public interface IItemFacade
    {
        void CreateItem(Item item);
        void ConfirmItem(int itemId);
        ICollection<Item> GetAllItems();
    }
}
