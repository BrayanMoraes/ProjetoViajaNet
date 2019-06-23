using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.FacadeInterfaces
{
    public interface IItemTypeFacade
    {
        ICollection<ItemType> GetAllItemTypes();
    }
}
