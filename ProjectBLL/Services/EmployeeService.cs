using AutoMapper;
using BLL.DTO;
using ProjectBLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBLL.Services
{
    class EmployeeService : IEmployeeService
    {
        readonly IUnitOfWork unit;

        public EmployeeService(IUnitOfWork unit)
        {
            this.unit = unit;
        }
        readonly MapperConfiguration config = new MapperConfiguration(mc =>
        {
            mc.AddProfile(new MyProfile());
        });
        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<EmployeeDTO> GetEmployee(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EmployeeDTO>> GetEmployees()
        {
            throw new NotImplementedException();
        }

        public Task MakeEmployee(EmployeeDTO employee)
        {
            throw new NotImplementedException();
        }

        public Task UpdateEmployee(EmployeeDTO employee)
        {
            throw new NotImplementedException();
        }
    }
}
