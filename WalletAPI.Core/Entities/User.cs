using System;
using System.Collections.Generic;
using System.Text;

namespace WalletAPI.Core.Entities
{
    public class User:BaseEntity
    {
        public int UserId { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public string Guid { get; set; }

        public Balance Balance { get; set; }

        public int BalanceId { get; set; }

        ICollection<Transaction> Transactions { get; set; }
    }
}
