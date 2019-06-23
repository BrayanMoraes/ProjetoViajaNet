using Domain.Context;
using Infra.Repository;
using Infra.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ProjectContext _context;

        public UnitOfWork(ProjectContext context)
        {
            _context = context;
        }

        private ItemRepository _itemRepository;
        private ItemTypeRepository _itemTypeRepository;
        private BrowserInformationRepository _browserInformationRepository;

        public IItemRepository ItemRepository
        {
            get
            {
                if (this._itemRepository == null)
                {
                    this._itemRepository = new ItemRepository(_context);
                }

                return this._itemRepository;
            }
        }

        public IItemTypeRepository ItemTypeRepository
        {
            get
            {
                if (this._itemTypeRepository == null)
                {
                    this._itemTypeRepository = new ItemTypeRepository(_context);
                }

                return this._itemTypeRepository;
            }
        }

        public IBrowserInformationRepository BrowserInformationRepository
        {
            get
            {
                if (this._browserInformationRepository == null)
                {
                    this._browserInformationRepository = new BrowserInformationRepository(_context);
                }

                return this._browserInformationRepository;
            }
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
