using LeaveManagement.Application.DTOs.Abstractions;

namespace LeaveManagement.Application.DTOs
{
    public class LeaveAllocationDto : BaseDto, IDtoWithLeaveTypeDto
    {
        public int NumberOfDays { get; set; }

        public LeaveTypeDto LeaveType { get; set; }

        public int LeaveTypeId { get; set; }

        public int Period { get; set; }
    }
}
