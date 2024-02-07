﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MiniShop.Data.Concrete.Contexts;

#nullable disable

namespace MiniShop.Data.Migrations
{
    [DbContext(typeof(MiniShopDbContext))]
    [Migration("20240207184416_AddingIdentityAndOrder")]
    partial class AddingIdentityAndOrder
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.15");

            modelBuilder.Entity("MiniShop.Entity.Concrete.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Categories", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 2, 7, 21, 44, 16, 549, DateTimeKind.Local).AddTicks(872),
                            Description = "TV kategorisi",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 2, 7, 21, 44, 16, 549, DateTimeKind.Local).AddTicks(889),
                            Name = "Televizyon",
                            Url = "televizyon"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 2, 7, 21, 44, 16, 549, DateTimeKind.Local).AddTicks(895),
                            Description = "Bilgisayar kategorisi",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 2, 7, 21, 44, 16, 549, DateTimeKind.Local).AddTicks(895),
                            Name = "Bilgisayar",
                            Url = "bilgisayar"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 2, 7, 21, 44, 16, 549, DateTimeKind.Local).AddTicks(896),
                            Description = "Elektronik Eşya kategorisi",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 2, 7, 21, 44, 16, 549, DateTimeKind.Local).AddTicks(896),
                            Name = "Elektronik Eşya",
                            Url = "elektronik-esya"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 2, 7, 21, 44, 16, 549, DateTimeKind.Local).AddTicks(898),
                            Description = "Beyaz Eşya kategorisi",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 2, 7, 21, 44, 16, 549, DateTimeKind.Local).AddTicks(898),
                            Name = "Beyaz Eşya",
                            Url = "beyaz-esya"
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2024, 2, 7, 21, 44, 16, 549, DateTimeKind.Local).AddTicks(899),
                            Description = "Telefon kategorisi",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 2, 7, 21, 44, 16, 549, DateTimeKind.Local).AddTicks(899),
                            Name = "Telefon",
                            Url = "telefon"
                        });
                });

            modelBuilder.Entity("MiniShop.Entity.Concrete.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Note")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("OrderState")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PaymentType")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("MiniShop.Entity.Concrete.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("OrderId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("MiniShop.Entity.Concrete.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("date('now')");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsHome")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ModifiedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("date('now')");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("real");

                    b.Property<string>("Properties")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Products", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 2, 7, 21, 44, 16, 549, DateTimeKind.Local).AddTicks(7482),
                            ImageUrl = "1.png",
                            IsActive = true,
                            IsDeleted = false,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 2, 7, 21, 44, 16, 549, DateTimeKind.Local).AddTicks(7491),
                            Name = "IPhone 14",
                            Price = 59000m,
                            Properties = "Harika bir telefon",
                            Url = "iphone-14"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 2, 7, 21, 44, 16, 549, DateTimeKind.Local).AddTicks(7500),
                            ImageUrl = "2.png",
                            IsActive = true,
                            IsDeleted = false,
                            IsHome = false,
                            ModifiedDate = new DateTime(2024, 2, 7, 21, 44, 16, 549, DateTimeKind.Local).AddTicks(7500),
                            Name = "IPhone 14 Pro",
                            Price = 69000m,
                            Properties = "Bu da harika bir telefon",
                            Url = "iphone-14-pro"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 2, 7, 21, 44, 16, 549, DateTimeKind.Local).AddTicks(7501),
                            ImageUrl = "3.png",
                            IsActive = true,
                            IsDeleted = false,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 2, 7, 21, 44, 16, 549, DateTimeKind.Local).AddTicks(7502),
                            Name = "Samsung S23",
                            Price = 49000m,
                            Properties = "İdare eder",
                            Url = "samsung-s23"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 2, 7, 21, 44, 16, 549, DateTimeKind.Local).AddTicks(7503),
                            ImageUrl = "4.png",
                            IsActive = true,
                            IsDeleted = false,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 2, 7, 21, 44, 16, 549, DateTimeKind.Local).AddTicks(7503),
                            Name = "Xaomi Note 4",
                            Price = 39000m,
                            Properties = "Harika bir telefon",
                            Url = "xaomi-note-4"
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2024, 2, 7, 21, 44, 16, 549, DateTimeKind.Local).AddTicks(7504),
                            ImageUrl = "5.png",
                            IsActive = true,
                            IsDeleted = false,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 2, 7, 21, 44, 16, 549, DateTimeKind.Local).AddTicks(7505),
                            Name = "MacBook Air M2",
                            Price = 52000m,
                            Properties = "M2nin gücü",
                            Url = "macbook-air-m2"
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(2024, 2, 7, 21, 44, 16, 549, DateTimeKind.Local).AddTicks(7506),
                            ImageUrl = "6.png",
                            IsActive = true,
                            IsDeleted = false,
                            IsHome = false,
                            ModifiedDate = new DateTime(2024, 2, 7, 21, 44, 16, 549, DateTimeKind.Local).AddTicks(7506),
                            Name = "MacBook Pro M3",
                            Price = 79000m,
                            Properties = "16 Gb ram",
                            Url = "macbook-pro-m3"
                        },
                        new
                        {
                            Id = 7,
                            CreatedDate = new DateTime(2024, 2, 7, 21, 44, 16, 549, DateTimeKind.Local).AddTicks(7507),
                            ImageUrl = "7.png",
                            IsActive = true,
                            IsDeleted = false,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 2, 7, 21, 44, 16, 549, DateTimeKind.Local).AddTicks(7508),
                            Name = "Vestel Çamaşır Makinesi X65",
                            Price = 19000m,
                            Properties = "Akıllı makine",
                            Url = "vestel-camasir-makinesi-x65"
                        },
                        new
                        {
                            Id = 8,
                            CreatedDate = new DateTime(2024, 2, 7, 21, 44, 16, 549, DateTimeKind.Local).AddTicks(7509),
                            ImageUrl = "8.png",
                            IsActive = true,
                            IsDeleted = false,
                            IsHome = false,
                            ModifiedDate = new DateTime(2024, 2, 7, 21, 44, 16, 549, DateTimeKind.Local).AddTicks(7509),
                            Name = "Arçelik Çamaşır Makinesi A-4",
                            Price = 21000m,
                            Properties = "Süper hızlı makine",
                            Url = "arcelik-camasir-makinesi-a-4"
                        },
                        new
                        {
                            Id = 9,
                            CreatedDate = new DateTime(2024, 2, 7, 21, 44, 16, 549, DateTimeKind.Local).AddTicks(7510),
                            ImageUrl = "9.png",
                            IsActive = true,
                            IsDeleted = false,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 2, 7, 21, 44, 16, 549, DateTimeKind.Local).AddTicks(7511),
                            Name = "Hoop Dijital Radyo X96",
                            Price = 1250m,
                            Properties = "Klasik radyo keyfi",
                            Url = "hoop-dijital-radyo-x96"
                        },
                        new
                        {
                            Id = 10,
                            CreatedDate = new DateTime(2024, 2, 7, 21, 44, 16, 549, DateTimeKind.Local).AddTicks(7512),
                            ImageUrl = "10.png",
                            IsActive = true,
                            IsDeleted = false,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 2, 7, 21, 44, 16, 549, DateTimeKind.Local).AddTicks(7512),
                            Name = "Xaomi Dijital Baskül",
                            Price = 2100m,
                            Properties = "Kilonuzu kontrol edin",
                            Url = "xaomi-dijital-baskul"
                        },
                        new
                        {
                            Id = 11,
                            CreatedDate = new DateTime(2024, 2, 7, 21, 44, 16, 549, DateTimeKind.Local).AddTicks(7514),
                            ImageUrl = "11.png",
                            IsActive = true,
                            IsDeleted = false,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 2, 7, 21, 44, 16, 549, DateTimeKind.Local).AddTicks(7515),
                            Name = "Blaupunkt AC69 Led TV",
                            Price = 9800m,
                            Properties = "Android tv",
                            Url = "blaupunkt-ac69-led-tv"
                        });
                });

            modelBuilder.Entity("MiniShop.Entity.Concrete.ProductCategory", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProductId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("ProductCategories", (string)null);

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 3
                        },
                        new
                        {
                            ProductId = 1,
                            CategoryId = 5
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 3
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 5
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 3
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 5
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 3
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 5
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryId = 2
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryId = 3
                        },
                        new
                        {
                            ProductId = 6,
                            CategoryId = 2
                        },
                        new
                        {
                            ProductId = 6,
                            CategoryId = 3
                        },
                        new
                        {
                            ProductId = 7,
                            CategoryId = 3
                        },
                        new
                        {
                            ProductId = 7,
                            CategoryId = 4
                        },
                        new
                        {
                            ProductId = 8,
                            CategoryId = 3
                        },
                        new
                        {
                            ProductId = 8,
                            CategoryId = 4
                        },
                        new
                        {
                            ProductId = 9,
                            CategoryId = 3
                        },
                        new
                        {
                            ProductId = 10,
                            CategoryId = 3
                        },
                        new
                        {
                            ProductId = 10,
                            CategoryId = 4
                        },
                        new
                        {
                            ProductId = 11,
                            CategoryId = 1
                        },
                        new
                        {
                            ProductId = 11,
                            CategoryId = 3
                        },
                        new
                        {
                            ProductId = 11,
                            CategoryId = 4
                        });
                });

            modelBuilder.Entity("MiniShop.Entity.Concrete.ShoppingCart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ShoppingCarts");
                });

            modelBuilder.Entity("MiniShop.Entity.Concrete.ShoppingCartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ShoppingCartId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("ShoppingCartId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("MiniShop.Entity.Concrete.OrderItem", b =>
                {
                    b.HasOne("MiniShop.Entity.Concrete.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MiniShop.Entity.Concrete.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("MiniShop.Entity.Concrete.ProductCategory", b =>
                {
                    b.HasOne("MiniShop.Entity.Concrete.Category", "Category")
                        .WithMany("ProductCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MiniShop.Entity.Concrete.Product", "Product")
                        .WithMany("ProductCategories")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("MiniShop.Entity.Concrete.ShoppingCartItem", b =>
                {
                    b.HasOne("MiniShop.Entity.Concrete.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MiniShop.Entity.Concrete.ShoppingCart", "ShoppingCart")
                        .WithMany("ShoppingCartItems")
                        .HasForeignKey("ShoppingCartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("ShoppingCart");
                });

            modelBuilder.Entity("MiniShop.Entity.Concrete.Category", b =>
                {
                    b.Navigation("ProductCategories");
                });

            modelBuilder.Entity("MiniShop.Entity.Concrete.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("MiniShop.Entity.Concrete.Product", b =>
                {
                    b.Navigation("ProductCategories");
                });

            modelBuilder.Entity("MiniShop.Entity.Concrete.ShoppingCart", b =>
                {
                    b.Navigation("ShoppingCartItems");
                });
#pragma warning restore 612, 618
        }
    }
}