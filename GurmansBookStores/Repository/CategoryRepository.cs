using GurmanBookStores.Models;
using GurmansBookStores.DataAccess.Data;
using GurmansBookStores.DataAccess.Repository.IRepository;
using GurmanssBookStores.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public object Name { get; private set; }
        public int Id { get; private set; }

        public void Update(CategoryRepository category)
        {
            //use .NET LINQ to retrieve the first or default category object.
            // then pass the id as a generic entity which ,matches the category ID

            var objFormDb =
                _db.Categories.FirstOrDefault(s => s.Id == category.Id);
            if (objFormDb != null) //save changes if not null
            {
                objFormDb.Name = (string)category.Name;
                _db.SaveChanges();
            }

        }

        public void Update(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
