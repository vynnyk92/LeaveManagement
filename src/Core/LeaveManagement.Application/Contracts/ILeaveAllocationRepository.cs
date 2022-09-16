using System;
using System.Collections.Generic;
using System.Text;
using LeaveManagement.Domain;

namespace LeaveManagement.Application.Contracts
{
    public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {
    }
}
