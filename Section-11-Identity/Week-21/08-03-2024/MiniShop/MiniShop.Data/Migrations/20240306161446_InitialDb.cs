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
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Text = table.Column<string>(type: "TEXT", nullable: true),
                    SendToId = table.Column<string>(type: "TEXT", nullable: true),
                    SendToName = table.Column<string>(type: "TEXT", nullable: true),
                    SendFromId = table.Column<string>(type: "TEXT", nullable: true),
                    SendFromName = table.Column<string>(type: "TEXT", nullable: true),
                    IsRead = table.Column<bool>(type: "INTEGER", nullable: false),
                    SendDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
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
                    { "4b4e5541-cd79-441d-a1f5-89f67622396a", null, "Süper Yönetici haklarını taşıyan rol", "SuperAdmin", "SUPERADMIN" },
                    { "703cfb4e-7a5a-4d1a-9e36-7c43de0c0bd8", null, "Müşteri haklarını taşıyan rol", "Customer", "CUSTOMER" },
                    { "da0a5988-b50b-420d-9a3a-54bf50ea9f5a", null, "Yönetici haklarını taşıyan rol", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "50594917-8da8-42e6-9b9c-04f6784adfce", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "b774b615-df9e-45d4-9e1f-8aba6dd56215", new DateTime(1990, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "denizfoca@gmail.com", true, "Deniz", "Erkek", "Foça", false, null, "DENIZFOCA@GMAIL.COM", "DENIZFOCA", "AQAAAAIAAYagAAAAEHjpMMfbkdCj6uhVF9sd5X5lMWKaXiZE/PgAQlOr5DKRAYZNiNfexFF1dCidtGmERQ==", "5558779966", false, "276942d1-3a9f-40aa-b041-28425605251f", false, "denizfoca" },
                    { "53b532f0-ed07-411d-b472-8cc05272cc35", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "9a916648-dd5f-41d8-9c7a-fa30ee96be85", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "aysenumay@gmail.com", true, "Ayşen Umay", "Kadın", "Ergül", false, null, "AYSENUMAY@GMAIL.COM", "AYSENUMAY", "AQAAAAIAAYagAAAAEOWikJNvYMVLkeyfUDNzN1f9UqBHnSTkil+me25jBYMOVDhqiM2B9lhB8IhVpbjmow==", "5387996655", false, "565a3709-66ef-4ce9-8d6d-7ffaa1f92ff4", false, "aysenumay" },
                    { "67666810-1258-434a-9e95-52c97c365c11", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "e6d743f2-f7d2-4b97-8d65-29376424d5df", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "selinmete@gmail.com", true, "Selin", "Kadın", "Mete", false, null, "SELINMETE@GMAIL.COM", "SELINMETE", "AQAAAAIAAYagAAAAEEKGog6ADVemsIYbnCBPmJoB+xLrogZMrs8KKKSgLoMG67A0frKKtUOonVTME59Hgg==", "5387996655", false, "aceab1d8-a9fd-452b-b44c-387ff8675391", false, "selinmete" },
                    { "e9c318db-69bf-4f99-b493-2f435b445d98", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "ae7ba229-9e1a-42ff-be67-e6816525713e", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "kemaldurukan@gmail.com", true, "Kemal", "Erkek", "Durukan", false, null, "KEMALDURUKAN@GMAIL.COM", "KEMALDURUKAN", "AQAAAAIAAYagAAAAEBcF04xAPqHJOZCdoyynfAkl0zO9ixPkK24V8H4g+8Qi6Uk69vzdEHv1nmrVrZRQ9A==", "5387996655", false, "8dfc0909-7864-4259-b85c-424b9a1e2d39", false, "kemaldurukan" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedDate", "Name", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 6, 19, 14, 46, 180, DateTimeKind.Local).AddTicks(8354), "TV kategorisi", true, false, new DateTime(2024, 3, 6, 19, 14, 46, 180, DateTimeKind.Local).AddTicks(8362), "Televizyon", "televizyon" },
                    { 2, new DateTime(2024, 3, 6, 19, 14, 46, 180, DateTimeKind.Local).AddTicks(8366), "Bilgisayar kategorisi", true, false, new DateTime(2024, 3, 6, 19, 14, 46, 180, DateTimeKind.Local).AddTicks(8366), "Bilgisayar", "bilgisayar" },
                    { 3, new DateTime(2024, 3, 6, 19, 14, 46, 180, DateTimeKind.Local).AddTicks(8368), "Elektronik Eşya kategorisi", true, false, new DateTime(2024, 3, 6, 19, 14, 46, 180, DateTimeKind.Local).AddTicks(8369), "Elektronik Eşya", "elektronik-esya" },
                    { 4, new DateTime(2024, 3, 6, 19, 14, 46, 180, DateTimeKind.Local).AddTicks(8370), "Beyaz Eşya kategorisi", true, false, new DateTime(2024, 3, 6, 19, 14, 46, 180, DateTimeKind.Local).AddTicks(8370), "Beyaz Eşya", "beyaz-esya" },
                    { 5, new DateTime(2024, 3, 6, 19, 14, 46, 180, DateTimeKind.Local).AddTicks(8372), "Telefon kategorisi", true, false, new DateTime(2024, 3, 6, 19, 14, 46, 180, DateTimeKind.Local).AddTicks(8372), "Telefon", "telefon" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedDate", "ImageUrl", "IsActive", "IsDeleted", "IsHome", "ModifiedDate", "Name", "Price", "Properties", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 6, 19, 14, 46, 181, DateTimeKind.Local).AddTicks(6844), "1.png", true, false, true, new DateTime(2024, 3, 6, 19, 14, 46, 181, DateTimeKind.Local).AddTicks(6848), "IPhone 14", 59000m, "Harika bir telefon", "iphone-14" },
                    { 2, new DateTime(2024, 3, 6, 19, 14, 46, 181, DateTimeKind.Local).AddTicks(6855), "2.png", true, false, false, new DateTime(2024, 3, 6, 19, 14, 46, 181, DateTimeKind.Local).AddTicks(6856), "IPhone 14 Pro", 69000m, "Bu da harika bir telefon", "iphone-14-pro" },
                    { 3, new DateTime(2024, 3, 6, 19, 14, 46, 181, DateTimeKind.Local).AddTicks(6857), "3.png", true, false, true, new DateTime(2024, 3, 6, 19, 14, 46, 181, DateTimeKind.Local).AddTicks(6858), "Samsung S23", 49000m, "İdare eder", "samsung-s23" },
                    { 4, new DateTime(2024, 3, 6, 19, 14, 46, 181, DateTimeKind.Local).AddTicks(6859), "4.png", true, false, true, new DateTime(2024, 3, 6, 19, 14, 46, 181, DateTimeKind.Local).AddTicks(6859), "Xaomi Note 4", 39000m, "Harika bir telefon", "xaomi-note-4" },
                    { 5, new DateTime(2024, 3, 6, 19, 14, 46, 181, DateTimeKind.Local).AddTicks(6861), "5.png", true, false, true, new DateTime(2024, 3, 6, 19, 14, 46, 181, DateTimeKind.Local).AddTicks(6861), "MacBook Air M2", 52000m, "M2nin gücü", "macbook-air-m2" },
                    { 6, new DateTime(2024, 3, 6, 19, 14, 46, 181, DateTimeKind.Local).AddTicks(6862), "6.png", true, false, false, new DateTime(2024, 3, 6, 19, 14, 46, 181, DateTimeKind.Local).AddTicks(6862), "MacBook Pro M3", 79000m, "16 Gb ram", "macbook-pro-m3" },
                    { 7, new DateTime(2024, 3, 6, 19, 14, 46, 181, DateTimeKind.Local).AddTicks(6864), "7.png", true, false, true, new DateTime(2024, 3, 6, 19, 14, 46, 181, DateTimeKind.Local).AddTicks(6864), "Vestel Çamaşır Makinesi X65", 19000m, "Akıllı makine", "vestel-camasir-makinesi-x65" },
                    { 8, new DateTime(2024, 3, 6, 19, 14, 46, 181, DateTimeKind.Local).AddTicks(6866), "8.png", true, false, false, new DateTime(2024, 3, 6, 19, 14, 46, 181, DateTimeKind.Local).AddTicks(6870), "Arçelik Çamaşır Makinesi A-4", 21000m, "Süper hızlı makine", "arcelik-camasir-makinesi-a-4" },
                    { 9, new DateTime(2024, 3, 6, 19, 14, 46, 181, DateTimeKind.Local).AddTicks(6888), "9.png", true, false, true, new DateTime(2024, 3, 6, 19, 14, 46, 181, DateTimeKind.Local).AddTicks(6889), "Hoop Dijital Radyo X96", 1250m, "Klasik radyo keyfi", "hoop-dijital-radyo-x96" },
                    { 10, new DateTime(2024, 3, 6, 19, 14, 46, 181, DateTimeKind.Local).AddTicks(6890), "10.png", true, false, true, new DateTime(2024, 3, 6, 19, 14, 46, 181, DateTimeKind.Local).AddTicks(6890), "Xaomi Dijital Baskül", 2100m, "Kilonuzu kontrol edin", "xaomi-dijital-baskul" },
                    { 11, new DateTime(2024, 3, 6, 19, 14, 46, 181, DateTimeKind.Local).AddTicks(6892), "11.png", true, false, true, new DateTime(2024, 3, 6, 19, 14, 46, 181, DateTimeKind.Local).AddTicks(6892), "Blaupunkt AC69 Led TV", 9800m, "Android tv", "blaupunkt-ac69-led-tv" }
                });

            migrationBuilder.InsertData(
                table: "ShoppingCarts",
                columns: new[] { "Id", "CreatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 6, 19, 14, 46, 180, DateTimeKind.Local).AddTicks(547), "50594917-8da8-42e6-9b9c-04f6784adfce" },
                    { 2, new DateTime(2024, 3, 6, 19, 14, 46, 180, DateTimeKind.Local).AddTicks(571), "67666810-1258-434a-9e95-52c97c365c11" },
                    { 3, new DateTime(2024, 3, 6, 19, 14, 46, 180, DateTimeKind.Local).AddTicks(573), "e9c318db-69bf-4f99-b493-2f435b445d98" },
                    { 4, new DateTime(2024, 3, 6, 19, 14, 46, 180, DateTimeKind.Local).AddTicks(575), "53b532f0-ed07-411d-b472-8cc05272cc35" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "4b4e5541-cd79-441d-a1f5-89f67622396a", "50594917-8da8-42e6-9b9c-04f6784adfce" },
                    { "703cfb4e-7a5a-4d1a-9e36-7c43de0c0bd8", "53b532f0-ed07-411d-b472-8cc05272cc35" },
                    { "da0a5988-b50b-420d-9a3a-54bf50ea9f5a", "67666810-1258-434a-9e95-52c97c365c11" },
                    { "da0a5988-b50b-420d-9a3a-54bf50ea9f5a", "e9c318db-69bf-4f99-b493-2f435b445d98" }
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
                name: "Messages");

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
