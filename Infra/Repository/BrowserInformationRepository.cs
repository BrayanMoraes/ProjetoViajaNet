using Domain.Context;
using Domain.Entities;
using Infra.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public ICollection<BrowserInformation> GetAll()
        {
            return _context.BrowserInformation.ToList();
        }

        public void SaveInformations(BrowserInformation browserInformation)
        {
            _context.BrowserInformation.Add(browserInformation);
        }
    }
}
