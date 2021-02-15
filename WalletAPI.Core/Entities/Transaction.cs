using System;
using System.Collections.Generic;
using System.Text;

namespace WalletAPI.Core.Entities
{
    public class Transaction:BaseEntity
    {
        public int TransactionId { get; set; }

        public Balance Balance { get; set; }

        public int BalanceId { get; set; }

        public User User { get; set; }

        public int UserId { get; set; }

        public decimal Amount { get; set; }

        public DateTime TransactionTime { get; set; }

        public int TransactionTypeId { get; set; }

        public TransactionType TransactionType { get; set; }
    }
}
