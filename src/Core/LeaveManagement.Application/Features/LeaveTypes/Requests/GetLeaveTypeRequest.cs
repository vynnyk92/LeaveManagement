using System;
using System.Collections.Generic;
using System.Text;
using LeaveManagement.Application.DTOs;
using MediatR;

namespace LeaveManagement.Application.Features.LeaveTypes.Requests
{
    public class GetLeaveTypeRequest : IRequest<LeaveTypeDto>
    {
        public int Id { get; set; }
    }
}
