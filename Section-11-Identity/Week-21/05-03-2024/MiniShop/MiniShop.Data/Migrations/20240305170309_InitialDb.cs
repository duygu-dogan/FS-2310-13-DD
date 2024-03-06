using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MiniShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    Address = table.Column<string>(type: "TEXT", nullable: true),
                    City = table.Column<string>(type: "TEXT", nullable: true),
                    Gender = table.Column<string>(type: "TEXT", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    Url = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "date('now')"),
                    Price = table.Column<decimal>(type: "real", nullable: false),
                    Properties = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    IsHome = table.Column<bool>(type: "INTEGER", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "date('now')"),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    Url = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCarts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCarts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OrderNumber = table.Column<string>(type: "TEXT", nullable: true),
                    OrderDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    Address = table.Column<string>(type: "TEXT", nullable: true),
                    City = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Note = table.Column<string>(type: "TEXT", nullable: true),
                    PaymentType = table.Column<int>(type: "INTEGER", nullable: false),
                    OrderState = table.Column<int>(type: "INTEGER", nullable: false),
                    ConversationId = table.Column<string>(type: "TEXT", nullable: true),
                    PaymentId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => new { x.ProductId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_ProductCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductCategories_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    ShoppingCartId = table.Column<int>(type: "INTEGER", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_ShoppingCarts_ShoppingCartId",
                        column: x => x.ShoppingCartId,
                        principalTable: "ShoppingCarts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OrderId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3d74d22e-1f2c-4d01-9f79-e4c140bebc5c", null, "Süper Yönetici haklarını taşıyan rol", "SuperAdmin", "SUPERADMIN" },
                    { "86acf12b-5277-4065-b18d-0a6856d47266", null, "Müşteri haklarını taşıyan rol", "Customer", "CUSTOMER" },
                    { "b387b261-2186-4a9c-a80c-02a34d0935cb", null, "Yönetici haklarını taşıyan rol", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "184326aa-6ef9-40d0-81ba-cdf49ab1fba6", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "799f5816-8ee3-4f05-a414-4b2107d25110", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "selinmete@gmail.com", true, "Selin", "Kadın", "Mete", false, null, "SELINMETE@GMAIL.COM", "SELINMETE", "AQAAAAIAAYagAAAAEFMtMlVbJ3rCz8JeYAIs6yIij53ubkK1JvWs4WrK2aAGpWOs8NYuhZttwvjaotQTOQ==", "5387996655", false, "bfd01439-21c9-41da-968a-cafd26fccc32", false, "selinmete" },
                    { "19af57ba-d7ad-414f-9ee7-451b09dfaafc", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "8310088c-632f-4678-9259-aa207a96e481", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "aysenumay@gmail.com", true, "Ayşen Umay", "Kadın", "Ergül", false, null, "AYSENUMAY@GMAIL.COM", "AYSENUMAY", "AQAAAAIAAYagAAAAEEcalCgF7OpXJyNrStEU9pkBV+KIXGsoqfnIeC0LsRL5O7I1MRRzu6SNmqFwCK3q+A==", "5387996655", false, "91a9c30e-fb0d-4cef-bd92-c071b1b05208", false, "aysenumay" },
                    { "c3010d1a-906d-49bf-8e26-666d047fd820", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "61823936-841b-4b64-a4b2-5512f6bae79a", new DateTime(1990, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "denizfoca@gmail.com", true, "Deniz", "Erkek", "Foça", false, null, "DENIZFOCA@GMAIL.COM", "DENIZFOCA", "AQAAAAIAAYagAAAAEONAyFhUHfijOb1GzS3jj0RSw9/adAguu9h/SNkGc498AObv0WXmLWhliqr23IiVMg==", "5558779966", false, "044034a3-f006-47a2-977f-ad58ad4383be", false, "denizfoca" },
                    { "e7591510-aba5-4fdf-a459-610cb2280e50", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "89eeb1d9-0cea-4132-babb-16c4a4b5fc0e", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "kemaldurukan@gmail.com", true, "Kemal", "Erkek", "Durukan", false, null, "KEMALDURUKAN@GMAIL.COM", "KEMALDURUKAN", "AQAAAAIAAYagAAAAEKwcBvsJPQ8TIiUutbmgreeF30txWKlPPAcDsDuQ9JCBlYtW0FgNNuttUMmLJ5xmAQ==", "5387996655", false, "432ca6b2-d5eb-4378-b4d4-636e03f277ee", false, "kemaldurukan" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedDate", "Name", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 5, 20, 3, 9, 390, DateTimeKind.Local).AddTicks(4272), "TV kategorisi", true, false, new DateTime(2024, 3, 5, 20, 3, 9, 390, DateTimeKind.Local).AddTicks(4286), "Televizyon", "televizyon" },
                    { 2, new DateTime(2024, 3, 5, 20, 3, 9, 390, DateTimeKind.Local).AddTicks(4291), "Bilgisayar kategorisi", true, false, new DateTime(2024, 3, 5, 20, 3, 9, 390, DateTimeKind.Local).AddTicks(4291), "Bilgisayar", "bilgisayar" },
                    { 3, new DateTime(2024, 3, 5, 20, 3, 9, 390, DateTimeKind.Local).AddTicks(4293), "Elektronik Eşya kategorisi", true, false, new DateTime(2024, 3, 5, 20, 3, 9, 390, DateTimeKind.Local).AddTicks(4294), "Elektronik Eşya", "elektronik-esya" },
                    { 4, new DateTime(2024, 3, 5, 20, 3, 9, 390, DateTimeKind.Local).AddTicks(4295), "Beyaz Eşya kategorisi", true, false, new DateTime(2024, 3, 5, 20, 3, 9, 390, DateTimeKind.Local).AddTicks(4295), "Beyaz Eşya", "beyaz-esya" },
                    { 5, new DateTime(2024, 3, 5, 20, 3, 9, 390, DateTimeKind.Local).AddTicks(4296), "Telefon kategorisi", true, false, new DateTime(2024, 3, 5, 20, 3, 9, 390, DateTimeKind.Local).AddTicks(4297), "Telefon", "telefon" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedDate", "ImageUrl", "IsActive", "IsDeleted", "IsHome", "ModifiedDate", "Name", "Price", "Properties", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 5, 20, 3, 9, 391, DateTimeKind.Local).AddTicks(4357), "1.png", true, false, true, new DateTime(2024, 3, 5, 20, 3, 9, 391, DateTimeKind.Local).AddTicks(4366), "IPhone 14", 59000m, "Harika bir telefon", "iphone-14" },
                    { 2, new DateTime(2024, 3, 5, 20, 3, 9, 391, DateTimeKind.Local).AddTicks(4377), "2.png", true, false, false, new DateTime(2024, 3, 5, 20, 3, 9, 391, DateTimeKind.Local).AddTicks(4377), "IPhone 14 Pro", 69000m, "Bu da harika bir telefon", "iphone-14-pro" },
                    { 3, new DateTime(2024, 3, 5, 20, 3, 9, 391, DateTimeKind.Local).AddTicks(4379), "3.png", true, false, true, new DateTime(2024, 3, 5, 20, 3, 9, 391, DateTimeKind.Local).AddTicks(4380), "Samsung S23", 49000m, "İdare eder", "samsung-s23" },
                    { 4, new DateTime(2024, 3, 5, 20, 3, 9, 391, DateTimeKind.Local).AddTicks(4382), "4.png", true, false, true, new DateTime(2024, 3, 5, 20, 3, 9, 391, DateTimeKind.Local).AddTicks(4382), "Xaomi Note 4", 39000m, "Harika bir telefon", "xaomi-note-4" },
                    { 5, new DateTime(2024, 3, 5, 20, 3, 9, 391, DateTimeKind.Local).AddTicks(4384), "5.png", true, false, true, new DateTime(2024, 3, 5, 20, 3, 9, 391, DateTimeKind.Local).AddTicks(4384), "MacBook Air M2", 52000m, "M2nin gücü", "macbook-air-m2" },
                    { 6, new DateTime(2024, 3, 5, 20, 3, 9, 391, DateTimeKind.Local).AddTicks(4386), "6.png", true, false, false, new DateTime(2024, 3, 5, 20, 3, 9, 391, DateTimeKind.Local).AddTicks(4387), "MacBook Pro M3", 79000m, "16 Gb ram", "macbook-pro-m3" },
                    { 7, new DateTime(2024, 3, 5, 20, 3, 9, 391, DateTimeKind.Local).AddTicks(4389), "7.png", true, false, true, new DateTime(2024, 3, 5, 20, 3, 9, 391, DateTimeKind.Local).AddTicks(4389), "Vestel Çamaşır Makinesi X65", 19000m, "Akıllı makine", "vestel-camasir-makinesi-x65" },
                    { 8, new DateTime(2024, 3, 5, 20, 3, 9, 391, DateTimeKind.Local).AddTicks(4391), "8.png", true, false, false, new DateTime(2024, 3, 5, 20, 3, 9, 391, DateTimeKind.Local).AddTicks(4406), "Arçelik Çamaşır Makinesi A-4", 21000m, "Süper hızlı makine", "arcelik-camasir-makinesi-a-4" },
                    { 9, new DateTime(2024, 3, 5, 20, 3, 9, 391, DateTimeKind.Local).AddTicks(4428), "9.png", true, false, true, new DateTime(2024, 3, 5, 20, 3, 9, 391, DateTimeKind.Local).AddTicks(4429), "Hoop Dijital Radyo X96", 1250m, "Klasik radyo keyfi", "hoop-dijital-radyo-x96" },
                    { 10, new DateTime(2024, 3, 5, 20, 3, 9, 391, DateTimeKind.Local).AddTicks(4430), "10.png", true, false, true, new DateTime(2024, 3, 5, 20, 3, 9, 391, DateTimeKind.Local).AddTicks(4431), "Xaomi Dijital Baskül", 2100m, "Kilonuzu kontrol edin", "xaomi-dijital-baskul" },
                    { 11, new DateTime(2024, 3, 5, 20, 3, 9, 391, DateTimeKind.Local).AddTicks(4434), "11.png", true, false, true, new DateTime(2024, 3, 5, 20, 3, 9, 391, DateTimeKind.Local).AddTicks(4434), "Blaupunkt AC69 Led TV", 9800m, "Android tv", "blaupunkt-ac69-led-tv" }
                });

            migrationBuilder.InsertData(
                table: "ShoppingCarts",
                columns: new[] { "Id", "CreatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 5, 20, 3, 9, 389, DateTimeKind.Local).AddTicks(8023), "c3010d1a-906d-49bf-8e26-666d047fd820" },
                    { 2, new DateTime(2024, 3, 5, 20, 3, 9, 389, DateTimeKind.Local).AddTicks(8061), "184326aa-6ef9-40d0-81ba-cdf49ab1fba6" },
                    { 3, new DateTime(2024, 3, 5, 20, 3, 9, 389, DateTimeKind.Local).AddTicks(8063), "e7591510-aba5-4fdf-a459-610cb2280e50" },
                    { 4, new DateTime(2024, 3, 5, 20, 3, 9, 389, DateTimeKind.Local).AddTicks(8065), "19af57ba-d7ad-414f-9ee7-451b09dfaafc" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "b387b261-2186-4a9c-a80c-02a34d0935cb", "184326aa-6ef9-40d0-81ba-cdf49ab1fba6" },
                    { "86acf12b-5277-4065-b18d-0a6856d47266", "19af57ba-d7ad-414f-9ee7-451b09dfaafc" },
                    { "3d74d22e-1f2c-4d01-9f79-e4c140bebc5c", "c3010d1a-906d-49bf-8e26-666d047fd820" },
                    { "b387b261-2186-4a9c-a80c-02a34d0935cb", "e7591510-aba5-4fdf-a459-610cb2280e50" }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 3, 1 },
                    { 5, 1 },
                    { 3, 2 },
                    { 5, 2 },
                    { 3, 3 },
                    { 5, 3 },
                    { 3, 4 },
                    { 5, 4 },
                    { 2, 5 },
                    { 3, 5 },
                    { 2, 6 },
                    { 3, 6 },
                    { 3, 7 },
                    { 4, 7 },
                    { 3, 8 },
                    { 4, 8 },
                    { 3, 9 },
                    { 3, 10 },
                    { 4, 10 },
                    { 1, 11 },
                    { 3, 11 },
                    { 4, 11 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_CategoryId",
                table: "ProductCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_ProductId",
                table: "ShoppingCartItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_ShoppingCartId",
                table: "ShoppingCartItems",
                column: "ShoppingCartId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ShoppingCarts");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
