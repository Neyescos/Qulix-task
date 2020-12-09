using AutoMapper;
using BLL.DTO;
using BLL.MapProfile;
using ProjectBLL.Interfaces;
using ProjectDAL.Interfaces;
using ProjectDAL.Modules;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjectBLL.Services
{
    public class CompanyService : ICompanyService
    {

        readonly IUnitOfWork unit;

        public CompanyService(IUnitOfWork unit)
        {
            this.unit = unit;
        }
        readonly MapperConfiguration config = new MapperConfiguration(mc =>
        {
            mc.AddProfile(new DTOProfile());
        });
        public async Task Delete(int id)
        {
            await unit.Companies.Delete(id);
            unit.Save();
        }

        public async Task<IEnumerable<CompanyDTO>> GetCompanies()
        {
            var mapper = new Mapper(config);
            var companies = await unit.Companies.GetAll();
            return mapper.Map<IEnumerable<CompanyDTO>>(companies);
        }

        public async Task<CompanyDTO> GetCompany(int? id)
        {
            var mapper = new Mapper(config);
            var company = await unit.Companies.Find(temp => temp.Id == id);
            return mapper.Map<Company, CompanyDTO>(company);
        }

        public async Task MakeCompany(CompanyDTO company)
        {

            var result = await unit.Companies.Find(x => x.Name == company.Name);

            if (result == null)
            {
                var mapper = new Mapper(config);
                unit.Companies.Create(mapper.Map<CompanyDTO, Company>(company));
                unit.Save();

            }
            else
            {
                bool isCancelled = true;
                await Task.FromCanceled(new CancellationToken(isCancelled));
            }
        }

        public async Task UpdateCompany(CompanyDTO company)
        {
            var mapper = new Mapper(config);
            var tempUser = await unit.Companies.Get(company.Id);


            await Task.Run(() =>
            {
                unit.Companies.Update(mapper.Map<CompanyDTO, Company>(company));
                unit.Save();
            });
        }
    }
}
