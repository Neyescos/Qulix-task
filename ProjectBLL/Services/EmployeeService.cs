using AutoMapper;
using BLL.DTO;
using ProjectBLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ProjectDAL.Interfaces;
using BLL.MapProfile;
using ProjectDAL.Modules;
using System.Threading;

namespace ProjectBLL.Services
{
    public class EmployeeService : IEmployeeService
    {
        readonly IUnitOfWork unit;

        public EmployeeService(IUnitOfWork unit)
        {
            this.unit = unit;
        }
        readonly MapperConfiguration config = new MapperConfiguration(mc =>
        {
            mc.AddProfile(new DTOProfile());
        });
        public async Task Delete(int id)
        {
                await unit.Employees.Delete(id);
                unit.Save();
        }

        public async Task<EmployeeDTO> GetEmployee(int? id)
        {
            var mapper = new Mapper(config);
            var employee = await unit.Employees.Find(temp => temp.Id == id);
            return mapper.Map<Employee, EmployeeDTO>(employee);
        }

        public async Task<IEnumerable<EmployeeDTO>> GetEmployees()
        {
            var mapper = new Mapper(config);
            var employees = await unit.Employees.GetAll();
            return mapper.Map<IEnumerable<EmployeeDTO>>(employees);
        }

        public async Task MakeEmployee(EmployeeDTO employee)
        {

            var result = await unit.Employees.Find(x => x.Name == employee.Name);

            if (result == null)
            {
                var mapper = new Mapper(config);
                unit.Employees.Create(mapper.Map<EmployeeDTO, Employee>(employee));
                unit.Save();

            }
            else
            {
                bool isCancelled = true;
                await Task.FromCanceled(new CancellationToken(isCancelled));
            }
        }
        public async Task UpdateEmployee(EmployeeDTO employee)
        {
            var mapper = new Mapper(config);
            var tempUser = await unit.Employees.Get(employee.Id);


            await Task.Run(() =>
            {
                unit.Employees.Update(mapper.Map<EmployeeDTO, Employee>(employee));
                unit.Save();
            });
        }
    }
}
