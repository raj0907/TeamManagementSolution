using AutoMapper;
using TeamManagement.DTOs.BusinessUnit;
using TeamManagement.DTOs.BusinessUnitMemebers;
using TeamManagement.DTOs.Employees;
using TeamManagement.Models;

namespace TeamManagement.Mapper.BusinessUnit
 
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<BusinessUnitRequest, Models.BusinessUnit>();
            CreateMap<BusinessUnitUpdateRequest, Models.BusinessUnit>();
            CreateMap<EmployeeSearchRequest, Employee>().ReverseMap();
            CreateMap<EmployeesResponse, Employee>().ReverseMap();
            CreateMap<BusinessUnitMemebersRequest, BusinessUnitMemebers>();

        }
    }
}
