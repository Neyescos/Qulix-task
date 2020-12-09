using AutoMapper;
using BLL.DTO;
using Qulix_task.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Qulix_task.MapProfile
{
    public class MapViewProfile:Profile
    {
        public MapViewProfile()
        {
            CreateMap<EmployeeModel, EmployeeDTO>()
                .ForMember(
                dist => dist.Company,
                opts => opts.MapFrom(src => src.Company));
            CreateMap<EmployeeDTO, EmployeeModel>()
                .ForMember(
                dist => dist.Company,
                opts => opts.MapFrom(src => src.Company));
            CreateMap<CompanyModel, CompanyDTO>()
                .ForMember(
                dist => dist.Employees,
                opts => opts.MapFrom(src => src.Employees));
            CreateMap<CompanyDTO, CompanyModel>()
                .ForMember(
                dist => dist.Employees,
                opts => opts.MapFrom(src => src.Employees));
        }
    }
}
