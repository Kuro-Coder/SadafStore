﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SadafStore.DataLayer.Context;

namespace SadafStore.DataLayer.Migrations
{
    [DbContext(typeof(SadafStoreContext))]
    partial class SadafStoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SadafStore.DataLayer.Entities.Order.DisCount", b =>
                {
                    b.Property<int>("DiscountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DisCountCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("DisCountPercent")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UsableCount")
                        .HasColumnType("int");

                    b.HasKey("DiscountId");

                    b.ToTable("DisCounts");
                });

            modelBuilder.Entity("SadafStore.DataLayer.Entities.Order.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsFinaly")
                        .HasColumnType("bit");

                    b.Property<int>("OrderSum")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("SadafStore.DataLayer.Entities.Order.OrderDetail", b =>
                {
                    b.Property<int>("DetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("DetailId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("SadafStore.DataLayer.Entities.Permissions.Permission", b =>
                {
                    b.Property<int>("PermissionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.Property<string>("PermissionTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("PermissionId");

                    b.HasIndex("ParentId");

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("SadafStore.DataLayer.Entities.Permissions.RolePermission", b =>
                {
                    b.Property<int>("RP_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PermissionId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("RP_Id");

                    b.HasIndex("PermissionId");

                    b.HasIndex("RoleId");

                    b.ToTable("RolePermissions");
                });

            modelBuilder.Entity("SadafStore.DataLayer.Entities.Product.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Features")
                        .HasColumnType("nvarchar(800)")
                        .HasMaxLength(800);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<int>("OldPrice")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("ProductImage")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("ProductNumber")
                        .HasColumnType("int");

                    b.Property<string>("ProductTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(2000)")
                        .HasMaxLength(2000);

                    b.Property<string>("Tags")
                        .HasColumnType("nvarchar(400)")
                        .HasMaxLength(400);

                    b.HasKey("ProductId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("SadafStore.DataLayer.Entities.Product.ProductComment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(700)")
                        .HasMaxLength(700);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsAdminRead")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("CommentId");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("ProductComments");
                });

            modelBuilder.Entity("SadafStore.DataLayer.Entities.Product.ProductGallery", b =>
                {
                    b.Property<int>("GalleryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("GalleryId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductGalleries");
                });

            modelBuilder.Entity("SadafStore.DataLayer.Entities.Product.ProductGroup", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GroupTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.HasKey("GroupId");

                    b.HasIndex("ParentId");

                    b.ToTable("ProductGroups");

                    b.HasData(
                        new
                        {
                            GroupId = 1,
                            GroupTitle = "هنری معماری",
                            IsDelete = false
                        },
                        new
                        {
                            GroupId = 2,
                            GroupTitle = "اداری",
                            IsDelete = false
                        },
                        new
                        {
                            GroupId = 3,
                            GroupTitle = "نوشت افزار",
                            IsDelete = false
                        },
                        new
                        {
                            GroupId = 4,
                            GroupTitle = "کمک آموزشی",
                            IsDelete = false
                        },
                        new
                        {
                            GroupId = 5,
                            GroupTitle = "اسباب بازی",
                            IsDelete = false
                        },
                        new
                        {
                            GroupId = 6,
                            GroupTitle = "رمان و کتاب",
                            IsDelete = false
                        });
                });

            modelBuilder.Entity("SadafStore.DataLayer.Entities.Product.ProductSelectedGroup", b =>
                {
                    b.Property<int>("PSG_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductGroupGroupId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("PSG_Id");

                    b.HasIndex("ProductGroupGroupId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductSelectedGroups");
                });

            modelBuilder.Entity("SadafStore.DataLayer.Entities.User.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("RoleId");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            RoleId = 1,
                            IsDelete = false,
                            RoleName = "مدیرکل سیستم"
                        },
                        new
                        {
                            RoleId = 2,
                            IsDelete = false,
                            RoleName = "مدیر سیستم"
                        },
                        new
                        {
                            RoleId = 3,
                            IsDelete = false,
                            RoleName = "کاربر"
                        },
                        new
                        {
                            RoleId = 4,
                            IsDelete = true,
                            RoleName = "کاربر طلایی"
                        },
                        new
                        {
                            RoleId = 5,
                            IsDelete = true,
                            RoleName = "کاربر سیلور"
                        });
                });

            modelBuilder.Entity("SadafStore.DataLayer.Entities.User.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ActiveCode")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("AvatarAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AvatarImg")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("AvatarName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AvatarPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime>("RegisterDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            ActiveCode = "001f99de-d36b-4591-8672-15a1264d0b58",
                            AvatarAddress = "بابل - جاده قدیم آمل - روستای بالااحمدچاپی",
                            AvatarImg = "null.jpg",
                            AvatarName = "حبیب پورخانلر احمدی",
                            AvatarPhone = "09333635633",
                            Email = "habib.pa98@gmail.com",
                            IsActive = true,
                            IsDelete = false,
                            Password = "C5-FE-25-89-6E-49-DD-FE-99-6D-B7-50-8C-F0-05-34",
                            RegisterDate = new DateTime(2020, 9, 21, 16, 1, 54, 960, DateTimeKind.Local).AddTicks(992),
                            UserName = "Habib"
                        });
                });

            modelBuilder.Entity("SadafStore.DataLayer.Entities.User.UserDiscountCode", b =>
                {
                    b.Property<int>("UD_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DiscountId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("UD_Id");

                    b.HasIndex("DiscountId");

                    b.HasIndex("UserId");

                    b.ToTable("UserDiscountCodes");
                });

            modelBuilder.Entity("SadafStore.DataLayer.Entities.User.UserRole", b =>
                {
                    b.Property<int>("UR_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("UR_Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRoles");

                    b.HasData(
                        new
                        {
                            UR_Id = 1,
                            RoleId = 1,
                            UserId = 1
                        });
                });

            modelBuilder.Entity("SadafStore.DataLayer.Entities.Wallet.Wallet", b =>
                {
                    b.Property<int>("WalletId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<bool>("IsPay")
                        .HasColumnType("bit");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int?>("WalletTypeTypeId")
                        .HasColumnType("int");

                    b.HasKey("WalletId");

                    b.HasIndex("UserId");

                    b.HasIndex("WalletTypeTypeId");

                    b.ToTable("Wallets");
                });

            modelBuilder.Entity("SadafStore.DataLayer.Entities.Wallet.WalletType", b =>
                {
                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.Property<string>("TypeTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.HasKey("TypeId");

                    b.ToTable("WalletTypes");
                });

            modelBuilder.Entity("SadafStore.DataLayer.Entities.Order.Order", b =>
                {
                    b.HasOne("SadafStore.DataLayer.Entities.User.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("SadafStore.DataLayer.Entities.Order.OrderDetail", b =>
                {
                    b.HasOne("SadafStore.DataLayer.Entities.Order.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SadafStore.DataLayer.Entities.Product.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("SadafStore.DataLayer.Entities.Permissions.Permission", b =>
                {
                    b.HasOne("SadafStore.DataLayer.Entities.Permissions.Permission", null)
                        .WithMany("Permissions")
                        .HasForeignKey("ParentId");
                });

            modelBuilder.Entity("SadafStore.DataLayer.Entities.Permissions.RolePermission", b =>
                {
                    b.HasOne("SadafStore.DataLayer.Entities.Permissions.Permission", "Permission")
                        .WithMany("RolePermissions")
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SadafStore.DataLayer.Entities.User.Role", "Role")
                        .WithMany("RolePermissions")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("SadafStore.DataLayer.Entities.Product.ProductComment", b =>
                {
                    b.HasOne("SadafStore.DataLayer.Entities.Product.Product", "Product")
                        .WithMany("ProductComments")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SadafStore.DataLayer.Entities.User.User", "User")
                        .WithMany("ProductComments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("SadafStore.DataLayer.Entities.Product.ProductGallery", b =>
                {
                    b.HasOne("SadafStore.DataLayer.Entities.Product.Product", "Product")
                        .WithMany("ProductGalleries")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("SadafStore.DataLayer.Entities.Product.ProductGroup", b =>
                {
                    b.HasOne("SadafStore.DataLayer.Entities.Product.ProductGroup", null)
                        .WithMany("ProductGroups")
                        .HasForeignKey("ParentId");
                });

            modelBuilder.Entity("SadafStore.DataLayer.Entities.Product.ProductSelectedGroup", b =>
                {
                    b.HasOne("SadafStore.DataLayer.Entities.Product.ProductGroup", "ProductGroup")
                        .WithMany("ProductSelectedGroups")
                        .HasForeignKey("ProductGroupGroupId");

                    b.HasOne("SadafStore.DataLayer.Entities.Product.Product", "Product")
                        .WithMany("ProductSelectedGroups")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("SadafStore.DataLayer.Entities.User.UserDiscountCode", b =>
                {
                    b.HasOne("SadafStore.DataLayer.Entities.Order.DisCount", "DisCount")
                        .WithMany("UserDiscountCodes")
                        .HasForeignKey("DiscountId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SadafStore.DataLayer.Entities.User.User", "User")
                        .WithMany("UserDiscountCodes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("SadafStore.DataLayer.Entities.User.UserRole", b =>
                {
                    b.HasOne("SadafStore.DataLayer.Entities.User.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SadafStore.DataLayer.Entities.User.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("SadafStore.DataLayer.Entities.Wallet.Wallet", b =>
                {
                    b.HasOne("SadafStore.DataLayer.Entities.User.User", "User")
                        .WithMany("Wallets")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SadafStore.DataLayer.Entities.Wallet.WalletType", "WalletType")
                        .WithMany("Wallets")
                        .HasForeignKey("WalletTypeTypeId");
                });
#pragma warning restore 612, 618
        }
    }
}
