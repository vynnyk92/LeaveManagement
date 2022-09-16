﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LeaveManagement.Application.DTOs.LeaveRequest
{
    public class LeaveRequestListDto : BaseDto
    {
        public LeaveTypeDto LeaveType { get; set; }

        public DateTime DateRequested { get; set; }

        public bool? Approved { get; set; }
    }
}
