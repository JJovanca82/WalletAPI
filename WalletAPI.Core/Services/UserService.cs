using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WalletAPI.Core.Entities;
using WalletAPI.Core.Interfaces;


namespace WalletAPI.Core.Services
{
    public class UserService : IUserService
    {
        private ICommonEFRepository<BaseEntity> repository;
        private IUserRepository userRepository;
        
        public UserService(ICommonEFRepository<BaseEntity> rep, IUserRepository usrRep)
        {
            repository = rep;
            userRepository = usrRep;
        }


        public async Task<bool> CreateNewBalanceForUserAsync(string Guid)
        {
            bool result = true;
            try
            {
                Balance balance = new Balance();
                balance.User = await userRepository.GetUserByGuidAsync(Guid);
                var tsk = await repository.AddAsync(balance);
            }catch(Exception e){
                // Log exception details
                result = false;
            }
            return result;

        }

        public async Task<bool> CreateUser(User newUser)
        {
            bool result = true;
            try
            {
                var tsk = await repository.AddAsync(newUser);
            }
            catch (Exception e)
            {
                // Log exception details
                result = false;
            }
            return result;
        }

        public async Task<Balance> GetBalanceByGuidAsync(string guid)
        {
            return await userRepository.GetBalanceForUserAsync(guid);         
        }

        public Task<string> GetUserIdAsync(string email, string password)
        {
            throw new NotImplementedException();
        }
    }
}
