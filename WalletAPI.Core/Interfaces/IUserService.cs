using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WalletAPI.Core.Entities;

namespace WalletAPI.Core.Interfaces
{
    public interface IUserService
    {
        Task<Balance> GetBalanceByGuidAsync(string guid);

        Task<bool> CreateNewBalanceForUserAsync(string Guid);

        Task<string> GetUserIdAsync(string email, string password);

        Task<bool> CreateUser(User newUser);
    }
}
