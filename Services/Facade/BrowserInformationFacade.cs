using Domain.Context;
using Domain.Entities;
using Infra.UnitOfWork;
using Services.FacadeInterfaces;
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
        public void SaveInformations(BrowserInformation browserInformation)
        {
            _unitOfWork.BrowserInformationRepository.SaveInformations(browserInformation);
            _unitOfWork.Commit();
        }
    }
}
