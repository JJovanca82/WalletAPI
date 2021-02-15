using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WalletAPI.Core.Interfaces
{
    public interface ICommonEFRepository<T>
    {
        Task<IReadOnlyList<T>> ListAllAsync();

        Task<T> AddAsync(T entity);

        Task UpdateAsync(T entity);

        Task DeleteAsync(T entity);
    }
}
