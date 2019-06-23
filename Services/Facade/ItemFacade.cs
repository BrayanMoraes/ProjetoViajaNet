using Domain.Context;
using Domain.Entities;
using Infra.UnitOfWork;
using Services.FacadeInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Facade
{
    public class ItemFacade : IItemFacade
    {
        private readonly UnitOfWork _unitOfWork;
        public ItemFacade(ProjectContext context)
        {
            _unitOfWork = new UnitOfWork(context);
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
