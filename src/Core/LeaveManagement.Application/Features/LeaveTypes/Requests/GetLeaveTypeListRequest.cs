using System;
using System.Collections.Generic;
using System.Text;
using LeaveManagement.Application.DTOs;
using MediatR;

namespace LeaveManagement.Application.Features.LeaveTypes.Requests
{
    public class GetLeaveTypeListRequest : IRequest<IReadOnlyCollection<LeaveTypeDto>>
    {
    }
}
