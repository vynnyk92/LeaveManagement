using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagement.Application.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T?> Get(int id);

        Task<IReadOnlyCollection<T>> GetAll();

        Task<T> Add(T entity);

        Task<T> Update(T entity);

        Task<T> Delete(T entity);
    }
}
