using System;
using System.Collections.Generic;
using System.Text;
using GurmansBookStores.DataAccess.Repository.IRepository;

namespace GurmansBookStores.DataAccess.Repository.IRepository
{
    interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }
        ISP_Call SP_Call { get; }
    }
}
