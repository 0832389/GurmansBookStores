﻿using System;
using System.Collections.Generic;
using System.Text;
using GurmansBookStores.DataAccess.Data;
using GurmansBookStores.DataAccess.Repository;
using GurmansBookStores.DataAccess.Repository.IRepository;

namespace GurmansBookStores.Repository
{
    public class UnitOfWork
    {
        private readonly ApplicationDbContext _db;

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
            SP_Call = new SP_Call(db);
        }

        public ICategoryRepository Category { get; private set; }
        public ISP_Call SP_Call { get; private set; }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }

    }
}
