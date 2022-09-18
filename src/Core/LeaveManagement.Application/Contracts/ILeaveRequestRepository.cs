using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using LeaveManagement.Domain;

namespace LeaveManagement.Application.Contracts
{
    public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
    {
        Task<LeaveRequest> GetRequestDetails(int id);
    }
}
