using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using SadafStore.DataLayer.Entities.User;
using SadafStore.DataLayer.Entities.Wallet;

namespace SadafStore.DataLayer.Context
{
    public class SadafStoreContext : DbContext
    {
        public SadafStoreContext(DbContextOptions<SadafStoreContext> options) : base(options)
        {

        }

        #region MyTables

        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<WalletType> WalletTypes { get; set; }
        public DbSet<Wallet> Wallets { get; set; }


        #endregion
    }
}
