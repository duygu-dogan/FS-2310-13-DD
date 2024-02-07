using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiniShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddingIdentityAndOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
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
                    OrderState = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
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
                name: "OrderItems",
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
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Products_ProductId",
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

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 44, 16, 549, DateTimeKind.Local).AddTicks(872), new DateTime(2024, 2, 7, 21, 44, 16, 549, DateTimeKind.Local).AddTicks(889) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 44, 16, 549, DateTimeKind.Local).AddTicks(895), new DateTime(2024, 2, 7, 21, 44, 16, 549, DateTimeKind.Local).AddTicks(895) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 44, 16, 549, DateTimeKind.Local).AddTicks(896), new DateTime(2024, 2, 7, 21, 44, 16, 549, DateTimeKind.Local).AddTicks(896) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 44, 16, 549, DateTimeKind.Local).AddTicks(898), new DateTime(2024, 2, 7, 21, 44, 16, 549, DateTimeKind.Local).AddTicks(898) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 44, 16, 549, DateTimeKind.Local).AddTicks(899), new DateTime(2024, 2, 7, 21, 44, 16, 549, DateTimeKind.Local).AddTicks(899) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 44, 16, 549, DateTimeKind.Local).AddTicks(7482), new DateTime(2024, 2, 7, 21, 44, 16, 549, DateTimeKind.Local).AddTicks(7491) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 44, 16, 549, DateTimeKind.Local).AddTicks(7500), new DateTime(2024, 2, 7, 21, 44, 16, 549, DateTimeKind.Local).AddTicks(7500) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 44, 16, 549, DateTimeKind.Local).AddTicks(7501), new DateTime(2024, 2, 7, 21, 44, 16, 549, DateTimeKind.Local).AddTicks(7502) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 44, 16, 549, DateTimeKind.Local).AddTicks(7503), new DateTime(2024, 2, 7, 21, 44, 16, 549, DateTimeKind.Local).AddTicks(7503) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 44, 16, 549, DateTimeKind.Local).AddTicks(7504), new DateTime(2024, 2, 7, 21, 44, 16, 549, DateTimeKind.Local).AddTicks(7505) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 44, 16, 549, DateTimeKind.Local).AddTicks(7506), new DateTime(2024, 2, 7, 21, 44, 16, 549, DateTimeKind.Local).AddTicks(7506) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 44, 16, 549, DateTimeKind.Local).AddTicks(7507), new DateTime(2024, 2, 7, 21, 44, 16, 549, DateTimeKind.Local).AddTicks(7508) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 44, 16, 549, DateTimeKind.Local).AddTicks(7509), new DateTime(2024, 2, 7, 21, 44, 16, 549, DateTimeKind.Local).AddTicks(7509) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 44, 16, 549, DateTimeKind.Local).AddTicks(7510), new DateTime(2024, 2, 7, 21, 44, 16, 549, DateTimeKind.Local).AddTicks(7511) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 44, 16, 549, DateTimeKind.Local).AddTicks(7512), new DateTime(2024, 2, 7, 21, 44, 16, 549, DateTimeKind.Local).AddTicks(7512) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 44, 16, 549, DateTimeKind.Local).AddTicks(7514), new DateTime(2024, 2, 7, 21, 44, 16, 549, DateTimeKind.Local).AddTicks(7515) });

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductId",
                table: "OrderItems",
                column: "ProductId");

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
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "ShoppingCarts");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 14, 52, 371, DateTimeKind.Local).AddTicks(1804), new DateTime(2024, 2, 7, 14, 14, 52, 371, DateTimeKind.Local).AddTicks(1818) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 14, 52, 371, DateTimeKind.Local).AddTicks(1823), new DateTime(2024, 2, 7, 14, 14, 52, 371, DateTimeKind.Local).AddTicks(1824) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 14, 52, 371, DateTimeKind.Local).AddTicks(1825), new DateTime(2024, 2, 7, 14, 14, 52, 371, DateTimeKind.Local).AddTicks(1825) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 14, 52, 371, DateTimeKind.Local).AddTicks(1826), new DateTime(2024, 2, 7, 14, 14, 52, 371, DateTimeKind.Local).AddTicks(1826) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 14, 52, 371, DateTimeKind.Local).AddTicks(1827), new DateTime(2024, 2, 7, 14, 14, 52, 371, DateTimeKind.Local).AddTicks(1827) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 14, 52, 372, DateTimeKind.Local).AddTicks(4484), new DateTime(2024, 2, 7, 14, 14, 52, 372, DateTimeKind.Local).AddTicks(4492) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 14, 52, 372, DateTimeKind.Local).AddTicks(4499), new DateTime(2024, 2, 7, 14, 14, 52, 372, DateTimeKind.Local).AddTicks(4499) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 14, 52, 372, DateTimeKind.Local).AddTicks(4501), new DateTime(2024, 2, 7, 14, 14, 52, 372, DateTimeKind.Local).AddTicks(4501) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 14, 52, 372, DateTimeKind.Local).AddTicks(4502), new DateTime(2024, 2, 7, 14, 14, 52, 372, DateTimeKind.Local).AddTicks(4503) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 14, 52, 372, DateTimeKind.Local).AddTicks(4504), new DateTime(2024, 2, 7, 14, 14, 52, 372, DateTimeKind.Local).AddTicks(4505) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 14, 52, 372, DateTimeKind.Local).AddTicks(4506), new DateTime(2024, 2, 7, 14, 14, 52, 372, DateTimeKind.Local).AddTicks(4506) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 14, 52, 372, DateTimeKind.Local).AddTicks(4507), new DateTime(2024, 2, 7, 14, 14, 52, 372, DateTimeKind.Local).AddTicks(4508) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 14, 52, 372, DateTimeKind.Local).AddTicks(4509), new DateTime(2024, 2, 7, 14, 14, 52, 372, DateTimeKind.Local).AddTicks(4509) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 14, 52, 372, DateTimeKind.Local).AddTicks(4510), new DateTime(2024, 2, 7, 14, 14, 52, 372, DateTimeKind.Local).AddTicks(4511) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 14, 52, 372, DateTimeKind.Local).AddTicks(4512), new DateTime(2024, 2, 7, 14, 14, 52, 372, DateTimeKind.Local).AddTicks(4512) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 14, 52, 372, DateTimeKind.Local).AddTicks(4514), new DateTime(2024, 2, 7, 14, 14, 52, 372, DateTimeKind.Local).AddTicks(4514) });
        }
    }
}
