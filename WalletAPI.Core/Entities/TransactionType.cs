using System;
using System.Collections.Generic;
using System.Text;

namespace WalletAPI.Core.Entities
{
    public enum TransactionName { Deposit,Stake, Win };

    public class TransactionType:BaseEntity
    {
        public int TransactionTypeId {get; set;}

        public TransactionName TransactionName { get; set; }

        ICollection<Transaction> Transactions { get; set; }
    }
}
