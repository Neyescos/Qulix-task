using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBLL.Interfaces
{
    interface IEmployeeService
    {
        Task MakeEmployee(EmployeeDTO employee);
        Task UpdateEmployee(EmployeeDTO employee);
        Task<EmployeeDTO> GetEmployee(int? id);
        Task<IEnumerable<EmployeeDTO>> GetEmployees();
        Task Delete(int id);
    }
}
