using GurmanBookStores.Models;
using GurmansBookStores.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace GurmansBookStores.DataAccess.Repository.IRepository
{
    interface ICategoryRepository : IRepository<Category>
    {
        void Update(CategoryRepository category);
    }
}
