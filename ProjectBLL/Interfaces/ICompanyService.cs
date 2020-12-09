using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBLL.Interfaces
{
    interface ICompanyService
    {
        Task MakeCompany(CompanyDTO company);
        Task UpdateCompany(CompanyDTO company);
        Task<CompanyDTO> GetCompany(int? id);
        Task<IEnumerable<CompanyDTO>> GetCompanies();
        Task Delete(int id);
    }
}
