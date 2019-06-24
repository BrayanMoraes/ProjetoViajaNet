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
    public class BrowserInformationFacade : IBrowserInformationFacade
    {
        private readonly UnitOfWork _unitOfWork;
        public BrowserInformationFacade(ProjectContext context)
        {
            _unitOfWork = new UnitOfWork(context);
        }

        public ICollection<BrowserInformation> GetAll()
        {
            try
            {
                return _unitOfWork.BrowserInformationRepository.GetAll();
            }
            catch(Exception ex)
            {
               new ExceptionsLog().SaveExceptionLogs(ex);
            }

            return null;
        }

        public void SaveInformations(BrowserInformation browserInformation)
        {
            try
            {
                _unitOfWork.BrowserInformationRepository.SaveInformations(browserInformation);
                _unitOfWork.Commit();
            }
            catch (Exception ex)
            {
                new ExceptionsLog().SaveExceptionLogs(ex);
            }
        }
    }
}
