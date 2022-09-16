using System;
using System.Collections.Generic;
using System.Text;

namespace LeaveManagement.Domain
{
    public class LeaveRequest
    {
        public int Id { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int DefaultDays { get; set; }

    }
}
