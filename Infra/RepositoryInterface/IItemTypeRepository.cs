using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.RepositoryInterface
{
    public interface IItemTypeRepository
    {
        ICollection<ItemType> GetAllItemTypes();
    }
}
