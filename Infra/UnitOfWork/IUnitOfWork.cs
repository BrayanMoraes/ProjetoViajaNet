using Infra.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IItemRepository ItemRepository { get; }
        IItemTypeRepository ItemTypeRepository { get; }
        IBrowserInformationRepository BrowserInformationRepository { get; }
        void Commit();
    }
}
