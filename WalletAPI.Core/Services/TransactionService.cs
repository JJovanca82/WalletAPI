using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WalletAPI.Core.Entities;
using WalletAPI.Core.Interfaces;

namespace WalletAPI.Core.Services
{
    public class TransactionService : ITransactionService
    {
        ICommonEFRepository<BaseEntity> repository;
        IUserRepository usrRepository;

        public TransactionService(ICommonEFRepository<BaseEntity> rep, IUserRepository usrRep)
        {
            repository = rep;
            usrRepository = usrRep;
        }

        public async Task<bool> CommitTransactionAsync(string Guid, Transaction transaction)
        {
            bool result = true;
            Balance balance = await usrRepository.GetBalanceForUserAsync(Guid);
            if (transaction.TransactionType.TransactionName == TransactionName.Deposit || transaction.TransactionType.TransactionName == TransactionName.Win)
            {
                // update amount
                balance.CurrentAmount += transaction.Amount;
                // log transaction
                balance.Transactions.Add(transaction);
                await repository.UpdateAsync(balance);
            }else {
                if (result = balance.CurrentAmount - transaction.Amount >= 0)
                {
                    // update amount
                    balance.CurrentAmount -= transaction.Amount;
                    // log transaction
                    balance.Transactions.Add(transaction);
                    await repository.UpdateAsync(balance);
                }                    
            }
            return result;
        }
    }
}
