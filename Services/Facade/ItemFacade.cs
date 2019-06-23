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
            var item = _unitOfWork.ItemRepository.GetItem(itemId);
            item.Confirmed = true;

            _unitOfWork.Commit();
        }

        public void CreateItem(Item item)
        {
            _unitOfWork.ItemRepository.CreateItem(item);
            _unitOfWork.Commit();
        }

        public ICollection<Item> GetAllItems()
        {
            return _unitOfWork.ItemRepository.GetAllItems();
        }
    }
}
