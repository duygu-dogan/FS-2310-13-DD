﻿using System;
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
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
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
                    Price = table.Column<decimal>(type: "real", nullable: false),
                    Properties = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    IsHome = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "date('now')"),
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

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedDate", "Name", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 27, 11, 0, 13, 204, DateTimeKind.Local).AddTicks(869), "TV kategorisi", true, false, new DateTime(2024, 1, 27, 11, 0, 13, 204, DateTimeKind.Local).AddTicks(881), "Televizyon", "televizyon" },
                    { 2, new DateTime(2024, 1, 27, 11, 0, 13, 204, DateTimeKind.Local).AddTicks(885), "Bilgisayar kategorisi", true, false, new DateTime(2024, 1, 27, 11, 0, 13, 204, DateTimeKind.Local).AddTicks(886), "Bilgisayar", "bilgisayar" },
                    { 3, new DateTime(2024, 1, 27, 11, 0, 13, 204, DateTimeKind.Local).AddTicks(887), "Elektronik Eşya kategorisi", true, false, new DateTime(2024, 1, 27, 11, 0, 13, 204, DateTimeKind.Local).AddTicks(887), "Elektronik Eşya", "elektronik-esya" },
                    { 4, new DateTime(2024, 1, 27, 11, 0, 13, 204, DateTimeKind.Local).AddTicks(888), "Beyaz Eşya kategorisi", true, false, new DateTime(2024, 1, 27, 11, 0, 13, 204, DateTimeKind.Local).AddTicks(888), "Beyaz Eşya", "beyaz-esya" },
                    { 5, new DateTime(2024, 1, 27, 11, 0, 13, 204, DateTimeKind.Local).AddTicks(889), "Telefon kategorisi", true, false, new DateTime(2024, 1, 27, 11, 0, 13, 204, DateTimeKind.Local).AddTicks(890), "Telefon", "telefon" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedDate", "ImageUrl", "IsActive", "IsDeleted", "IsHome", "ModifiedDate", "Name", "Price", "Properties", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 27, 11, 0, 13, 204, DateTimeKind.Local).AddTicks(6634), "1.png", true, false, true, new DateTime(2024, 1, 27, 11, 0, 13, 204, DateTimeKind.Local).AddTicks(6637), "IPhone 14", 59000m, "Harika bir telefon", "iphone-14" },
                    { 2, new DateTime(2024, 1, 27, 11, 0, 13, 204, DateTimeKind.Local).AddTicks(6642), "2.png", true, false, false, new DateTime(2024, 1, 27, 11, 0, 13, 204, DateTimeKind.Local).AddTicks(6643), "IPhone 14 Pro", 69000m, "Bu da harika bir telefon", "iphone-14-pro" },
                    { 3, new DateTime(2024, 1, 27, 11, 0, 13, 204, DateTimeKind.Local).AddTicks(6644), "3.png", true, false, true, new DateTime(2024, 1, 27, 11, 0, 13, 204, DateTimeKind.Local).AddTicks(6645), "Samsung S23", 49000m, "İdare eder", "samsung-s23" },
                    { 4, new DateTime(2024, 1, 27, 11, 0, 13, 204, DateTimeKind.Local).AddTicks(6646), "4.png", true, false, true, new DateTime(2024, 1, 27, 11, 0, 13, 204, DateTimeKind.Local).AddTicks(6646), "Xaomi Note 4", 39000m, "Harika bir telefon", "xaomi-note-4" },
                    { 5, new DateTime(2024, 1, 27, 11, 0, 13, 204, DateTimeKind.Local).AddTicks(6647), "5.png", true, false, true, new DateTime(2024, 1, 27, 11, 0, 13, 204, DateTimeKind.Local).AddTicks(6648), "MacBook Air M2", 52000m, "M2nin gücü", "macbook-air-m2" },
                    { 6, new DateTime(2024, 1, 27, 11, 0, 13, 204, DateTimeKind.Local).AddTicks(6649), "6.png", true, false, false, new DateTime(2024, 1, 27, 11, 0, 13, 204, DateTimeKind.Local).AddTicks(6649), "MacBook Pro M3", 79000m, "16 Gb ram", "macbook-pro-m3" },
                    { 7, new DateTime(2024, 1, 27, 11, 0, 13, 204, DateTimeKind.Local).AddTicks(6650), "7.png", true, false, true, new DateTime(2024, 1, 27, 11, 0, 13, 204, DateTimeKind.Local).AddTicks(6651), "Vestel Çamaşır Makinesi X65", 19000m, "Akıllı makine", "vestel-camasir-makinesi-x65" },
                    { 8, new DateTime(2024, 1, 27, 11, 0, 13, 204, DateTimeKind.Local).AddTicks(6652), "8.png", true, false, false, new DateTime(2024, 1, 27, 11, 0, 13, 204, DateTimeKind.Local).AddTicks(6652), "Arçelik Çamaşır Makinesi A-4", 21000m, "Süper hızlı makine", "arcelik-camasir-makinesi-a-4" },
                    { 9, new DateTime(2024, 1, 27, 11, 0, 13, 204, DateTimeKind.Local).AddTicks(6654), "9.png", true, false, true, new DateTime(2024, 1, 27, 11, 0, 13, 204, DateTimeKind.Local).AddTicks(6654), "Hoop Dijital Radyo X96", 1250m, "Klasik radyo keyfi", "hoop-dijital-radyo-x96" },
                    { 10, new DateTime(2024, 1, 27, 11, 0, 13, 204, DateTimeKind.Local).AddTicks(6655), "10.png", true, false, true, new DateTime(2024, 1, 27, 11, 0, 13, 204, DateTimeKind.Local).AddTicks(6655), "Xaomi Dijital Baskül", 2100m, "Kilonuzu kontrol edin", "xaomi-dijital-baskul" },
                    { 11, new DateTime(2024, 1, 27, 11, 0, 13, 204, DateTimeKind.Local).AddTicks(6657), "11.png", true, false, true, new DateTime(2024, 1, 27, 11, 0, 13, 204, DateTimeKind.Local).AddTicks(6657), "Blaupunkt AC69 Led TV", 9800m, "Android tv", "blaupunkt-ac69-led-tv" }
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
                name: "IX_ProductCategories_CategoryId",
                table: "ProductCategories",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
