using System;
using System.Collections.Generic;
using System.Text;

namespace WalletAPI.Core.Entities
{
    public class Balance:BaseEntity
    {
        public int BalanceId { get; set; }

        public decimal CurrentAmount { get; set; }

        public User User { get; set; }

        public int UserId { get; set; }

        public ICollection<Transaction> Transactions { get; set; }
    }
}
