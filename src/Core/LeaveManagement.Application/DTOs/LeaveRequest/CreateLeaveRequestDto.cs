using System;
using LeaveManagement.Application.DTOs.Abstractions;
using LeaveManagement.Domain;

namespace LeaveManagement.Application.DTOs.LeaveRequest
{
    public class CreateLeaveRequestDto : IDtoWithLeaveTypeDto
    {
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int LeaveTypeId { get; set; }

        public DateTime DateRequested { get; set; }

        public string RequestComments { get; set; }
    }
}
