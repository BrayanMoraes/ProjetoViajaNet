using Domain.Context;
using Domain.Entities;
using Infra.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Repository
{
    public class BrowserInformationRepository : IBrowserInformationRepository
    {
        private readonly ProjectContext _context;
        public BrowserInformationRepository(ProjectContext context)
        {
            this._context = context;
        }
        public void SaveInformations(BrowserInformation browserInformation)
        {
            _context.BrowserInformation.Add(browserInformation);
        }
    }
}
