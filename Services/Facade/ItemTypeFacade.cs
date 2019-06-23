using Domain.Context;
using Domain.Entities;
using Infra.UnitOfWork;
using Services.FacadeInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Facade
{
    public class ItemTypeFacade : IItemTypeFacade
    {
        private readonly UnitOfWork _unitOfWork;
        public ItemTypeFacade(ProjectContext context)
        {
            _unitOfWork = new UnitOfWork(context);
        }

        public ICollection<ItemType> GetAllItemTypes()
        {
            return _unitOfWork.ItemTypeRepository.GetAllItemTypes();
        }
    }
}
