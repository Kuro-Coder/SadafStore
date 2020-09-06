using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using SadafStore.DataLayer.Entities.Order;
using SadafStore.DataLayer.Entities.Permissions;
using SadafStore.DataLayer.Entities.Product;
using SadafStore.DataLayer.Entities.User;
using SadafStore.DataLayer.Entities.Wallet;

namespace SadafStore.DataLayer.Context
{
    public class SadafStoreContext : DbContext
    {
        public SadafStoreContext(DbContextOptions<SadafStoreContext> options) : base(options)
        {

        }

        #region User

        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

        #endregion

        #region Wallet

        public DbSet<WalletType> WalletTypes { get; set; }
        public DbSet<Wallet> Wallets { get; set; }

        #endregion

        #region Permissions

        public DbSet<Permission> Permissions { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }

        #endregion

        #region Product

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductGroup> ProductGroups { get; set; }
        public DbSet<ProductGallery> ProductGalleries { get; set; }
        public DbSet<ProductSelectedGroup> ProductSelectedGroups { get; set; }


        #endregion

        #region Orders

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }


        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Filter For DeletedUser in UserTable
            modelBuilder.Entity<User>()
                .HasQueryFilter(u => !u.IsDelete);
            //Filter For DeletedRole in RoleTable
            modelBuilder.Entity<Role>()
                .HasQueryFilter(u => !u.IsDelete);
            //Filter For DeletedGroup in ProductGroup
            modelBuilder.Entity<ProductGroup>()
                .HasQueryFilter(u => !u.IsDelete);
            //Filter For DeletedGroup in ProductGroup
            modelBuilder.Entity<Product>()
                .HasQueryFilter(u => !u.IsDelete);


            base.OnModelCreating(modelBuilder);
        }
    }
}
