using System;
using System.Collections.Generic;
using System.Linq;
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
        public DbSet<Group> Groups { get; set; }
        public DbSet<ProductGallery> ProductGalleries { get; set; }
        public DbSet<ProductSelectedGroup> ProductSelectedGroups { get; set; }
        public DbSet<ProductComment> ProductComments { get; set; }


        #endregion

        #region Orders

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<DisCount> DisCounts { get; set; }
        public DbSet<UserDiscountCode> UserDiscountCodes { get; set; }


        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Off Cascade

            var cascadeFks = modelBuilder.Model.GetEntityTypes()
                .SelectMany(t => t.GetForeignKeys())
                .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

            foreach (var fk in cascadeFks)
            {
                fk.DeleteBehavior = DeleteBehavior.Restrict;
                base.OnModelCreating(modelBuilder);
            }

            #endregion

            #region Filter For IsDeleted

            //Filter For DeletedUser in UserTable
            modelBuilder.Entity<User>()
                .HasQueryFilter(u => !u.IsDelete);
            //Filter For DeletedRole in RoleTable
            modelBuilder.Entity<Role>()
                .HasQueryFilter(u => !u.IsDelete);
            //Filter For DeletedGroup in ProductGroup
            modelBuilder.Entity<Group>()
                .HasQueryFilter(u => !u.IsDelete);
            //Filter For DeletedGroup in ProductGroup
            modelBuilder.Entity<Product>()
                .HasQueryFilter(u => !u.IsDelete);

            #endregion

            #region Seed Data

            #region Roles

            modelBuilder.Entity<Role>().HasData(new Role()
            {
                RoleId = 1,
                RoleName = "مدیر سیستم",
                IsDelete = false
            }, new Role()
            {
                RoleId = 2,
                RoleName = "کاربر",
                IsDelete = false
            });

            #endregion

            #region Users

            modelBuilder.Entity<User>().HasData(new User()
            {
                UserId = 1,
                UserName = "Habib",
                Email = "habib.pa98@gmail.com",
                Password = "C5-FE-25-89-6E-49-DD-FE-99-6D-B7-50-8C-F0-05-34",
                IsActive = true,
                IsDelete = false,
                ActiveCode = Guid.NewGuid().ToString(),
                RegisterDate = DateTime.Now,
                AvatarName = "حبیب پورخانلر احمدی",
                AvatarPhone = "09333635633",
                AvatarAddress = "بابل - جاده قدیم آمل - روستای بالااحمدچاپی",
                AvatarImg = "null.jpg"
            },new User()
            {
                UserId = 2,
                UserName = "Farhad",
                Email = "farhad.manager@gmail.com",
                Password = "C5-FE-25-89-6E-49-DD-FE-99-6D-B7-50-8C-F0-05-34",
                IsActive = true,
                IsDelete = false,
                ActiveCode = Guid.NewGuid().ToString(),
                RegisterDate = DateTime.Now,
                AvatarName = null,
                AvatarPhone = null,
                AvatarAddress = null,
                AvatarImg = "null.jpg"
            });

            #endregion

            #region UserRols

            modelBuilder.Entity<UserRole>().HasData(new UserRole()
            {
                UR_Id = 1,
                UserId = 1,
                RoleId = 1
            }, new UserRole()
            {
                UR_Id = 2,
                UserId = 2,
                RoleId = 2
            });

            #endregion

            #region ProductGrops

            modelBuilder.Entity<Group>().HasData(new Group()
            {
                GroupId = 1,
                GroupTitle = "هنری معماری",
                IsDelete = false,
                ParentId = null
            }, new Group()
            {
                GroupId = 2,
                GroupTitle = "اداری",
                IsDelete = false,
                ParentId = null
            }, new Group()
            {
                GroupId = 3,
                GroupTitle = "نوشت افزار",
                IsDelete = false,
                ParentId = null
            }, new Group()
            {
                GroupId = 4,
                GroupTitle = "کمک آموزشی",
                IsDelete = false,
                ParentId = null
            }, new Group()
            {
                GroupId = 5,
                GroupTitle = "اسباب بازی",
                IsDelete = false,
                ParentId = null
            }, new Group()
            {
                GroupId = 6,
                GroupTitle = "رمان و کتاب",
                IsDelete = false,
                ParentId = null
            });

            #endregion

            #endregion



            base.OnModelCreating(modelBuilder);
        }
    }
}
