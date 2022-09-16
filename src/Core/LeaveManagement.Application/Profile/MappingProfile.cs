using LeaveManagement.Application.DTOs;
using LeaveManagement.Application.DTOs.LeaveRequest;
using LeaveManagement.Domain;

namespace LeaveManagement.Application.Profile
{
    public class MappingProfile : AutoMapper.Profile
    {
        public MappingProfile()
        {
            CreateMap<LeaveRequest, LeaveRequestListDto>();

            CreateMap<LeaveRequest, LeaveRequestDto>()
                .ReverseMap();

            CreateMap<LeaveAllocation, LeaveAllocationDto>()
                .ReverseMap();

            CreateMap<LeaveType, LeaveTypeDto>()
                .ReverseMap();
        }
    }
}
