using GurmanBookStores.Models;
using GurmansBookStores.DataAccess.Data;
using GurmansBookStores.DataAccess.Repository.IRepository;
using GurmanssBookStores.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace GurmansBookStores.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(CategoryRepository category)
        {
            throw new NotImplementedException();
        }
    }
}
