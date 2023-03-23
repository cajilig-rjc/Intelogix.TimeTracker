using AutoMapper;
using Starshot.TimeTracker.Data.Models;
using Starshot.TimeTracker.Dtos;
using Starshot.TimeTracker.Responses;

namespace Starshot.TimeTracker.Core.Mappings.Profiles
{
    internal class EmployeeProfile : Profile
    {
        public EmployeeProfile() {
            CreateMap<CreateEmployeeDto,Employee>()
                 .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            CreateMap<UpdateEmployeeDto, Employee>()
                 .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            CreateMap<TimeSheet, ReadTimeSheetDto>()
                   .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            CreateMap<CreateTimeSheetDto, TimeSheet>()
                  .ForMember(x=>x.UserIdFk,x=>x.MapFrom(x=>x.EmployeeId))
                  .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            CreateMap<Employee,ReadEmployeeDto>()
                    .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            CreateMap<IEnumerable<Employee>,SearchEmployeeResponse >()
                    .ForPath(x=>x.Employees,x=>x.MapFrom(x=>x))
                    .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
        }
    }
}
