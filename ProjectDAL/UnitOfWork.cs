
using ProjectDAL.EF;
using ProjectDAL.Interfaces;
using ProjectDAL.Modules;
using ProjectDAL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Context db;
        private IRepository<Employee> userRepository;
        private IRepository<Company> productRepository;
        public UnitOfWork(Context db)
        {
            this.db = db;
        }

        public IRepository<Employee> Employees
        {
            get
            {
                if (userRepository == null)
                {
                    userRepository = new Repository<Employee>(db);
                }
                return userRepository;
            }
        }
        public IRepository<Company> Companies
        {
            get
            {
                if (productRepository == null)
                {
                    productRepository = new Repository<Company>(db);
                }
                return productRepository;
            }
        }
        
        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposed)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
