using System;
using System.Collections.Generic;
using System.Text;
using LeaveManagement.Domain.Common;

namespace LeaveManagement.Domain
{
    public class LeaveType : BaseDomainEntity
    {
        public string Name { get; set; }

        public int DefaultDays { get; set; }
    }
}
