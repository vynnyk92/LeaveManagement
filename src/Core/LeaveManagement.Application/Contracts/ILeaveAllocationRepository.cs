using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using LeaveManagement.Domain;

namespace LeaveManagement.Application.Contracts
{
    public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {
        Task<LeaveAllocation> GetLeaveAllocationDetails(int id);
        Task<IReadOnlyCollection<LeaveAllocation>> GetLeaveAllocationsWithDetails();
    }
}
