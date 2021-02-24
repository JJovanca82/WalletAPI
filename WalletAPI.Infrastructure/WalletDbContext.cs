using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection;
using WalletAPI.Core.Entities;

namespace WalletAPI.Infrastructure
{
    public class WalletDbContext:DbContext
    {
        public WalletDbContext(DbContextOptions<WalletDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Credentials> Credentials { get; set; }

        public DbSet<Balance> Balances { get; set; }

        public DbSet<Transaction> Transactions { get; set; }

        public DbSet<TransactionType> TransactionTypes { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
