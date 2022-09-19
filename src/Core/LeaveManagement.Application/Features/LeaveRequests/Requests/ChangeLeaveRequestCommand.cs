using LeaveManagement.Application.DTOs;
using LeaveManagement.Application.DTOs.LeaveRequest;
using MediatR;

namespace LeaveManagement.Application.Features.LeaveRequests.Requests
{
    public class ChangeLeaveRequestCommand : IRequest<Unit>
    {
        public ChangeLeaveRequestApprovalDto LeaveRequest { get; set; }
    }
}
