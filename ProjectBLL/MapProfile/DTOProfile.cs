using AutoMapper;
using BLL.DTO;
using ProjectDAL.Modules;

namespace BLL.MapProfile
{
    public class DTOProfile:Profile
    {
        public DTOProfile()
        {
            CreateMap<EmployeeDTO, Employee>()
                    .ForMember(
                    dest => dest.Company,
                    opts => opts.MapFrom(src => src.Company));
            CreateMap<Employee, EmployeeDTO>()
                .ForMember(
                dest => dest.Company,
                opts => opts.MapFrom(src => src.Company));
            CreateMap<CompanyDTO, Company>()
                .ForMember(
                dest => dest.Employees,
                opts => opts.MapFrom(src => src.Employees));
            CreateMap<Company, CompanyDTO>()
                .ForMember(
                dest => dest.Employees,
                opts => opts.MapFrom(src => src.Employees));


        }
    }
}
