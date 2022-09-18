using System;
using System.Collections.Generic;
using System.Text;
using LeaveManagement.Application.DTOs;
using LeaveManagement.Application.DTOs.LeaveRequest;
using MediatR;

namespace LeaveManagement.Application.Features.LeaveTypes.Requests
{
    public class GetLeaveRequestListRequest : IRequest<IReadOnlyCollection<LeaveRequestListDto>>
    {
    }
}
