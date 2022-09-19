using LeaveManagement.Application.DTOs;
using LeaveManagement.Application.DTOs.LeaveRequest;
using MediatR;

namespace LeaveManagement.Application.Features.LeaveRequests.Requests
{
    public class UpdateLeaveRequestCommand : IRequest<Unit>
    {
        public UpdateLeaveRequestDto? LeaveRequest { get; set; }
    }
}
