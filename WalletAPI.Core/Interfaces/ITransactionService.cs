using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WalletAPI.Core.Entities;

namespace WalletAPI.Core.Interfaces
{
    public interface ITransactionService
    {
        Task<bool> CommitTransactionAsync(string Guid, Transaction transaction);
    }
}
