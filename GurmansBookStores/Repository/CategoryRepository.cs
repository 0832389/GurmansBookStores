using GurmanBookStores.DataAccess.Repository.IRepository;
using GurmanBookStores.Models;
using GurmansBookStores.DataAccess.Data;
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
    }
}
