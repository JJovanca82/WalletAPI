using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WalletAPI.Core.Entities;
using WalletAPI.Core.Interfaces;

namespace WalletAPI.Infrastructure.Repositories
{
    public class UserRepository : CommonEFRepository<User>,IUserRepository
    {
        public UserRepository(WalletDbContext dbContext):base(dbContext)
        {            

        }

        public Task<Balance> GetBalanceForUserAsync(string guid)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserByGuidAsync(string guid)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserByGuidAsync(string email, string password)
        {
            throw new NotImplementedException();
        }
    }
}
