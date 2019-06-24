using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.RepositoryInterface
{
    public interface IBrowserInformationRepository
    {
        void SaveInformations(BrowserInformation browserInformation);
        ICollection<BrowserInformation> GetAll();
    }
}
