
using ProjectDAL.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDAL.Interfaces
{
    interface IUnitOfWork:IDisposable
    {
        IRepository<Employee> Employees { get; }
        IRepository<Company> Companies { get; }
        void Save();
    }
}
