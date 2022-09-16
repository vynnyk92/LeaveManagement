using System;
using System.Collections.Generic;
using System.Text;
using LeaveManagement.Domain;

namespace LeaveManagement.Application.Contracts
{
    public interface ILeaveTypeRepository : IGenericRepository<LeaveType>
    {
    }
}
