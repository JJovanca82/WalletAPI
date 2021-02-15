using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WalletAPI.Core.Entities;

namespace WalletAPI.Core.Interfaces
{
    public interface IUserRepository
    {
        Task<User> GetUserByGuidAsync(string guid);

        Task<User> GetUserByGuidAsync(string email, string password);

        Task<Balance> GetBalanceForUserAsync(string guid);

    }
}
