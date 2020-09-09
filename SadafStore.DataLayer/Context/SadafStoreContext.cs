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
            modelBuilder.Entity<ProductGroup>()
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
                RoleName = "مدیرکل سیستم",
                IsDelete = false
            }, new Role()
            {
                RoleId = 2,
                RoleName = "مدیر سیستم",
                IsDelete = false
            }, new Role()
            {
                RoleId = 3,
                RoleName = "کاربر",
                IsDelete = false
            }, new Role()
            {
                RoleId = 4,
                RoleName = "کاربر طلایی",
                IsDelete = true
            }, new Role()
            {
                RoleId = 5,
                RoleName = "کاربر سیلور",
                IsDelete = true
            });

            #endregion

            #region Users

            modelBuilder.Entity<User>().HasData(new User()
            {
                UserId = 1,
                UserName = "Habib",
                Email = "habib.pa98@gmail.com",
                Password = "55555",
                IsActive = true,
                IsDelete = false,
                ActiveCode = Guid.NewGuid().ToString(),
                RegisterDate = DateTime.Now,
                AvatarName = "حبیب پورخانلر احمدی",
                AvatarPhone = "09333635633",
                AvatarAddress = "بابل - جاده قدیم آمل - روستای بالااحمدچاپی"
            }, new User()
            {
                UserId = 2,
                UserName = "Farhad",
                Email = "fahad.90@gmail.com",
                Password = "55555",
                IsActive = true,
                IsDelete = false,
                ActiveCode = Guid.NewGuid().ToString(),
                RegisterDate = DateTime.Now,
                AvatarName = "فرهاد چرچیل",
                AvatarPhone = "",
                AvatarAddress = ""
            }, new User()
            {
                UserId = 3,
                UserName = "Shabnam",
                Email = "shabnam.iz90@gmail.com",
                Password = "55555",
                IsActive = true,
                IsDelete = false,
                ActiveCode = Guid.NewGuid().ToString(),
                RegisterDate = DateTime.Now,
                AvatarName = "شبنم ایزدی",
                AvatarPhone = "09333635633",
                AvatarAddress = "آمل - کوچمون"
            }, new User()
            {
                UserId = 4,
                UserName = "testUser",
                Email = "test.tt98@gmail.com",
                Password = "55555",
                IsActive = false,
                IsDelete = true,
                ActiveCode = Guid.NewGuid().ToString(),
                RegisterDate = DateTime.Now,
                AvatarName = "کاربر تستیم",
                AvatarPhone = "09333635633",
                AvatarAddress = "بابل - جاده قدیم آمل - روستای بالااحمدچاپی"
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
                UserId = 1,
                RoleId = 2
            }, new UserRole()
            {
                UR_Id = 3,
                UserId = 2,
                RoleId = 3
            }, new UserRole()
            {
                UR_Id = 4,
                UserId = 3,
                RoleId = 3
            }, new UserRole()
            {
                UR_Id = 5,
                UserId = 4,
                RoleId = 3
            });

            #endregion

            #region ProductGrops

            modelBuilder.Entity<ProductGroup>().HasData(new ProductGroup()
            {
                GroupId = 1,
                GroupTitle = "هنری معماری",
                IsDelete = false,
                ParentId = null
            }, new ProductGroup()
            {
                GroupId = 2,
                GroupTitle = "اداری",
                IsDelete = false,
                ParentId = null
            }, new ProductGroup()
            {
                GroupId = 3,
                GroupTitle = "نوشت افزار",
                IsDelete = false,
                ParentId = null
            }, new ProductGroup()
            {
                GroupId = 4,
                GroupTitle = "کمک آموزشی",
                IsDelete = false,
                ParentId = null
            }, new ProductGroup()
            {
                GroupId = 5,
                GroupTitle = "اسباب بازی",
                IsDelete = false,
                ParentId = null
            }, new ProductGroup()
            {
                GroupId = 6,
                GroupTitle = "رمان",
                IsDelete = false,
                ParentId = null
            }, new ProductGroup()
            {
                GroupId = 7,
                GroupTitle = "خط کش T",
                IsDelete = false,
                ParentId = 1
            }, new ProductGroup()
            {
                GroupId = 8,
                GroupTitle = "میز طراحی",
                IsDelete = false,
                ParentId = 1
            }, new ProductGroup()
            {
                GroupId = 9,
                GroupTitle = "رومیزی",
                IsDelete = false,
                ParentId = 8
            }, new ProductGroup()
            {
                GroupId = 10,
                GroupTitle = "جا مدادی",
                IsDelete = false,
                ParentId = 2
            }, new ProductGroup()
            {
                GroupId = 11,
                GroupTitle = "خودکار",
                IsDelete = false,
                ParentId = 3
            }, new ProductGroup()
            {
                GroupId = 12,
                GroupTitle = "خودکار بیک",
                IsDelete = false,
                ParentId = 11
            }, new ProductGroup()
            {
                GroupId = 13,
                GroupTitle = "مداد",
                IsDelete = false,
                ParentId = 3
            }, new ProductGroup()
            {
                GroupId = 14,
                GroupTitle = "گام به گام",
                IsDelete = false,
                ParentId = 4
            }, new ProductGroup()
            {
                GroupId = 15,
                GroupTitle = "CD",
                IsDelete = false,
                ParentId = 4
            }, new ProductGroup()
            {
                GroupId = 16,
                GroupTitle = "داستان",
                IsDelete = false,
                ParentId = 6
            });

            #endregion

            #endregion



            base.OnModelCreating(modelBuilder);
        }
    }
}
