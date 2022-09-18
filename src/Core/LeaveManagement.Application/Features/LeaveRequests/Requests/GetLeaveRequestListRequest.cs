using System.Collections.Generic;
using LeaveManagement.Application.DTOs.LeaveRequest;
using MediatR;

namespace LeaveManagement.Application.Features.LeaveRequests.Requests
{
    public class GetLeaveRequestListRequest : IRequest<IReadOnlyCollection<LeaveRequestListDto>>
    {
    }
}
