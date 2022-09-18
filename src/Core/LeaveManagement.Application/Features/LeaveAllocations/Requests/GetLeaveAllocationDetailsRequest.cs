using LeaveManagement.Application.DTOs;
using MediatR;

namespace LeaveManagement.Application.Features.LeaveAllocations.Requests
{
    public class GetLeaveAllocationDetailsRequest : IRequest<LeaveAllocationDto>
    {
        public int Id { get; set; }
    }
}
