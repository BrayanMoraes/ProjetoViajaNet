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
    public class ItemFacade : IItemFacade
    {
        private readonly UnitOfWork _unitOfWork;
        public ItemFacade(ProjectContext context)
        {
            _unitOfWork = new UnitOfWork(context);
        }

        public void ConfirmItem(int itemId)
        {
            try
            {
                var item = _unitOfWork.ItemRepository.GetItem(itemId);
                item.Confirmed = true;

                _unitOfWork.Commit();
            }
            catch (Exception ex)
            {
                new ExceptionsLog().SaveExceptionLogs(ex);
            }
        }

        public int CreateItem(Item item)
        {
            try
            {
                _unitOfWork.ItemRepository.CreateItem(item);
                _unitOfWork.Commit();

                return item.Id;
            }
            catch (Exception ex)
            {
                new ExceptionsLog().SaveExceptionLogs(ex);
            }

            return 0;
        }

        public ICollection<Item> GetAllItems()
        {
            try
            {
                return _unitOfWork.ItemRepository.GetAllItems();
            }
            catch (Exception ex)
            {
                new ExceptionsLog().SaveExceptionLogs(ex);
            }

            return null;
        }
    }
}
