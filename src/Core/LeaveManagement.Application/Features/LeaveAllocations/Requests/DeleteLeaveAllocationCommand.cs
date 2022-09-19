using LeaveManagement.Application.DTOs;
using MediatR;

namespace LeaveManagement.Application.Features.LeaveAllocations.Requests
{
    public class DeleteLeaveAllocationCommand : IRequest
    {
        public int Id { get; set; }
    }
}
