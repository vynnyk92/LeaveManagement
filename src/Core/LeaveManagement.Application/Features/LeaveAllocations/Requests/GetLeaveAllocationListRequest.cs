using System.Collections.Generic;
using LeaveManagement.Application.DTOs;
using MediatR;

namespace LeaveManagement.Application.Features.LeaveAllocations.Requests
{
    public class GetLeaveAllocationListRequest : IRequest<IReadOnlyCollection<LeaveAllocationDto>>
    {
    }
}
