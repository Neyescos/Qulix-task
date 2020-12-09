using AutoMapper;
using BLL.DTO;
namespace BLL.MapProfile
{
    class DTOProfile:Profile
    {
        DTOProfile()
        {
            CreateMap<EmployeeDTO, Employee>()
                    .ForMember(
                    dest => dest.Company,
                    opts => opts.MapFrom(src => src.Company));
            

        }
    }
}
