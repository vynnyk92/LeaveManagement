using System;
using System.Collections.Generic;
using System.Text;
using LeaveManagement.Application.DTOs;
using MediatR;

namespace LeaveManagement.Application.Features.LeaveTypes.Requests
{
    public class DeleteLeaveTypeRequest : IRequest
    {
        public int Id { get; set; }
    }
}
