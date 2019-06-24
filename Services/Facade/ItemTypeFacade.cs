using Domain.Context;
using Domain.Entities;
using Infra.UnitOfWork;
using Services.FacadeInterfaces;
using Shared;
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
            try
            {
                return _unitOfWork.ItemTypeRepository.GetAllItemTypes();
            }
            catch (Exception ex)
            {
                new ExceptionsLog().SaveExceptionLogs(ex);
            }

            return null;
        }
    }
}
