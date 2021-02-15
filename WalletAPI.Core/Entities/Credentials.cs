using System;
using System.Collections.Generic;
using System.Text;

namespace WalletAPI.Core.Entities
{
    public class Credentials
    {
        public int CredentialsId { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public User User { get; set; }

    }
}
