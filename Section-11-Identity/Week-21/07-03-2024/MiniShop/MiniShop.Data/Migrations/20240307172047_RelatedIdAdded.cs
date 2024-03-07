using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MiniShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class RelatedIdAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4b4e5541-cd79-441d-a1f5-89f67622396a", "50594917-8da8-42e6-9b9c-04f6784adfce" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "703cfb4e-7a5a-4d1a-9e36-7c43de0c0bd8", "53b532f0-ed07-411d-b472-8cc05272cc35" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "da0a5988-b50b-420d-9a3a-54bf50ea9f5a", "67666810-1258-434a-9e95-52c97c365c11" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "da0a5988-b50b-420d-9a3a-54bf50ea9f5a", "e9c318db-69bf-4f99-b493-2f435b445d98" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4b4e5541-cd79-441d-a1f5-89f67622396a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "703cfb4e-7a5a-4d1a-9e36-7c43de0c0bd8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "da0a5988-b50b-420d-9a3a-54bf50ea9f5a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "50594917-8da8-42e6-9b9c-04f6784adfce");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "53b532f0-ed07-411d-b472-8cc05272cc35");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67666810-1258-434a-9e95-52c97c365c11");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9c318db-69bf-4f99-b493-2f435b445d98");

            migrationBuilder.AddColumn<int>(
                name: "RelatedId",
                table: "Messages",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0e776f97-8b33-41e6-8428-0365e98c62d6", null, "Yönetici haklarını taşıyan rol", "Admin", "ADMIN" },
                    { "2548b558-eb13-4d28-ad44-b533453dc35f", null, "Süper Yönetici haklarını taşıyan rol", "SuperAdmin", "SUPERADMIN" },
                    { "3a1ba279-7cff-43ed-9421-4e9d24018067", null, "Müşteri haklarını taşıyan rol", "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "097794a7-9bca-41c5-917f-7c627154460b", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "0354b09b-257f-4bce-9d4b-09584a89d3d4", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "selinmete@gmail.com", true, "Selin", "Kadın", "Mete", false, null, "SELINMETE@GMAIL.COM", "SELINMETE", "AQAAAAIAAYagAAAAELJneX9O6NBwvWxES28eyJD0H/ZRKTwLb5q4rFkF/S1F2u8tXiKODZSDNPn7uXQwyQ==", "5387996655", false, "79b09e37-d193-4868-805c-bfd2672e38b7", false, "selinmete" },
                    { "46cd8534-97d4-49a6-86ed-8a005220debd", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "b3811eef-c610-4407-823a-7273ef7d9f08", new DateTime(1990, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "denizfoca@gmail.com", true, "Deniz", "Erkek", "Foça", false, null, "DENIZFOCA@GMAIL.COM", "DENIZFOCA", "AQAAAAIAAYagAAAAEJkCO7zm/SjTAO/NY5BEf6gCH11XFV9ftaOy5FzgS9bm68mn4GMO8NGVkCqdlgXmCg==", "5558779966", false, "636f14d6-0b8b-4ba9-a496-e2744dc2b959", false, "denizfoca" },
                    { "f9d8f372-a310-47dc-b2ef-e1a0f4cab057", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "9c9af47c-4f30-4809-a91e-60dbb42f1749", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "kemaldurukan@gmail.com", true, "Kemal", "Erkek", "Durukan", false, null, "KEMALDURUKAN@GMAIL.COM", "KEMALDURUKAN", "AQAAAAIAAYagAAAAEJWl11T+ESp/+p6hOR/3joeNvsK2ess2dph41xNr/P8s2jFe9F5ytzkHraE5Qnx2lQ==", "5387996655", false, "92e4c09f-2009-47a4-af4a-4edf660bb7a2", false, "kemaldurukan" },
                    { "fa689eab-db3a-493c-923a-a152f3d5bfea", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "826ae467-137e-48f6-8e0c-fc37f02770e8", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "aysenumay@gmail.com", true, "Ayşen Umay", "Kadın", "Ergül", false, null, "AYSENUMAY@GMAIL.COM", "AYSENUMAY", "AQAAAAIAAYagAAAAEClftsieNv1rRJ7eulzQBbyVg3s3nz6cmoaA+gPox6xFDPd4aj/3QhkBYdKVXRnm3Q==", "5387996655", false, "3692c97a-eaac-4f5b-bb2f-94a6012898d9", false, "aysenumay" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 20, 47, 46, DateTimeKind.Local).AddTicks(9924), new DateTime(2024, 3, 7, 20, 20, 47, 46, DateTimeKind.Local).AddTicks(9934) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 20, 47, 46, DateTimeKind.Local).AddTicks(9941), new DateTime(2024, 3, 7, 20, 20, 47, 46, DateTimeKind.Local).AddTicks(9941) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 20, 47, 46, DateTimeKind.Local).AddTicks(9943), new DateTime(2024, 3, 7, 20, 20, 47, 46, DateTimeKind.Local).AddTicks(9943) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 20, 47, 46, DateTimeKind.Local).AddTicks(9944), new DateTime(2024, 3, 7, 20, 20, 47, 46, DateTimeKind.Local).AddTicks(9945) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 20, 47, 46, DateTimeKind.Local).AddTicks(9946), new DateTime(2024, 3, 7, 20, 20, 47, 46, DateTimeKind.Local).AddTicks(9946) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 20, 47, 47, DateTimeKind.Local).AddTicks(7908), new DateTime(2024, 3, 7, 20, 20, 47, 47, DateTimeKind.Local).AddTicks(7915) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 20, 47, 47, DateTimeKind.Local).AddTicks(7925), new DateTime(2024, 3, 7, 20, 20, 47, 47, DateTimeKind.Local).AddTicks(7925) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 20, 47, 47, DateTimeKind.Local).AddTicks(7935), new DateTime(2024, 3, 7, 20, 20, 47, 47, DateTimeKind.Local).AddTicks(7936) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 20, 47, 47, DateTimeKind.Local).AddTicks(7937), new DateTime(2024, 3, 7, 20, 20, 47, 47, DateTimeKind.Local).AddTicks(7938) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 20, 47, 47, DateTimeKind.Local).AddTicks(7939), new DateTime(2024, 3, 7, 20, 20, 47, 47, DateTimeKind.Local).AddTicks(7940) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 20, 47, 47, DateTimeKind.Local).AddTicks(7942), new DateTime(2024, 3, 7, 20, 20, 47, 47, DateTimeKind.Local).AddTicks(7942) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 20, 47, 47, DateTimeKind.Local).AddTicks(7944), new DateTime(2024, 3, 7, 20, 20, 47, 47, DateTimeKind.Local).AddTicks(7944) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 20, 47, 47, DateTimeKind.Local).AddTicks(7946), new DateTime(2024, 3, 7, 20, 20, 47, 47, DateTimeKind.Local).AddTicks(7951) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 20, 47, 47, DateTimeKind.Local).AddTicks(7967), new DateTime(2024, 3, 7, 20, 20, 47, 47, DateTimeKind.Local).AddTicks(7968) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 20, 47, 47, DateTimeKind.Local).AddTicks(7970), new DateTime(2024, 3, 7, 20, 20, 47, 47, DateTimeKind.Local).AddTicks(7970) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 20, 47, 47, DateTimeKind.Local).AddTicks(7972), new DateTime(2024, 3, 7, 20, 20, 47, 47, DateTimeKind.Local).AddTicks(7972) });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 20, 47, 46, DateTimeKind.Local).AddTicks(3055), "46cd8534-97d4-49a6-86ed-8a005220debd" });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 20, 47, 46, DateTimeKind.Local).AddTicks(3082), "097794a7-9bca-41c5-917f-7c627154460b" });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 20, 47, 46, DateTimeKind.Local).AddTicks(3084), "f9d8f372-a310-47dc-b2ef-e1a0f4cab057" });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 20, 47, 46, DateTimeKind.Local).AddTicks(3085), "fa689eab-db3a-493c-923a-a152f3d5bfea" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "0e776f97-8b33-41e6-8428-0365e98c62d6", "097794a7-9bca-41c5-917f-7c627154460b" },
                    { "2548b558-eb13-4d28-ad44-b533453dc35f", "46cd8534-97d4-49a6-86ed-8a005220debd" },
                    { "0e776f97-8b33-41e6-8428-0365e98c62d6", "f9d8f372-a310-47dc-b2ef-e1a0f4cab057" },
                    { "3a1ba279-7cff-43ed-9421-4e9d24018067", "fa689eab-db3a-493c-923a-a152f3d5bfea" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0e776f97-8b33-41e6-8428-0365e98c62d6", "097794a7-9bca-41c5-917f-7c627154460b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2548b558-eb13-4d28-ad44-b533453dc35f", "46cd8534-97d4-49a6-86ed-8a005220debd" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0e776f97-8b33-41e6-8428-0365e98c62d6", "f9d8f372-a310-47dc-b2ef-e1a0f4cab057" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3a1ba279-7cff-43ed-9421-4e9d24018067", "fa689eab-db3a-493c-923a-a152f3d5bfea" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0e776f97-8b33-41e6-8428-0365e98c62d6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2548b558-eb13-4d28-ad44-b533453dc35f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a1ba279-7cff-43ed-9421-4e9d24018067");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "097794a7-9bca-41c5-917f-7c627154460b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "46cd8534-97d4-49a6-86ed-8a005220debd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f9d8f372-a310-47dc-b2ef-e1a0f4cab057");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa689eab-db3a-493c-923a-a152f3d5bfea");

            migrationBuilder.DropColumn(
                name: "RelatedId",
                table: "Messages");

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

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 14, 46, 180, DateTimeKind.Local).AddTicks(8354), new DateTime(2024, 3, 6, 19, 14, 46, 180, DateTimeKind.Local).AddTicks(8362) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 14, 46, 180, DateTimeKind.Local).AddTicks(8366), new DateTime(2024, 3, 6, 19, 14, 46, 180, DateTimeKind.Local).AddTicks(8366) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 14, 46, 180, DateTimeKind.Local).AddTicks(8368), new DateTime(2024, 3, 6, 19, 14, 46, 180, DateTimeKind.Local).AddTicks(8369) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 14, 46, 180, DateTimeKind.Local).AddTicks(8370), new DateTime(2024, 3, 6, 19, 14, 46, 180, DateTimeKind.Local).AddTicks(8370) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 14, 46, 180, DateTimeKind.Local).AddTicks(8372), new DateTime(2024, 3, 6, 19, 14, 46, 180, DateTimeKind.Local).AddTicks(8372) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 14, 46, 181, DateTimeKind.Local).AddTicks(6844), new DateTime(2024, 3, 6, 19, 14, 46, 181, DateTimeKind.Local).AddTicks(6848) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 14, 46, 181, DateTimeKind.Local).AddTicks(6855), new DateTime(2024, 3, 6, 19, 14, 46, 181, DateTimeKind.Local).AddTicks(6856) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 14, 46, 181, DateTimeKind.Local).AddTicks(6857), new DateTime(2024, 3, 6, 19, 14, 46, 181, DateTimeKind.Local).AddTicks(6858) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 14, 46, 181, DateTimeKind.Local).AddTicks(6859), new DateTime(2024, 3, 6, 19, 14, 46, 181, DateTimeKind.Local).AddTicks(6859) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 14, 46, 181, DateTimeKind.Local).AddTicks(6861), new DateTime(2024, 3, 6, 19, 14, 46, 181, DateTimeKind.Local).AddTicks(6861) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 14, 46, 181, DateTimeKind.Local).AddTicks(6862), new DateTime(2024, 3, 6, 19, 14, 46, 181, DateTimeKind.Local).AddTicks(6862) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 14, 46, 181, DateTimeKind.Local).AddTicks(6864), new DateTime(2024, 3, 6, 19, 14, 46, 181, DateTimeKind.Local).AddTicks(6864) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 14, 46, 181, DateTimeKind.Local).AddTicks(6866), new DateTime(2024, 3, 6, 19, 14, 46, 181, DateTimeKind.Local).AddTicks(6870) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 14, 46, 181, DateTimeKind.Local).AddTicks(6888), new DateTime(2024, 3, 6, 19, 14, 46, 181, DateTimeKind.Local).AddTicks(6889) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 14, 46, 181, DateTimeKind.Local).AddTicks(6890), new DateTime(2024, 3, 6, 19, 14, 46, 181, DateTimeKind.Local).AddTicks(6890) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 14, 46, 181, DateTimeKind.Local).AddTicks(6892), new DateTime(2024, 3, 6, 19, 14, 46, 181, DateTimeKind.Local).AddTicks(6892) });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 14, 46, 180, DateTimeKind.Local).AddTicks(547), "50594917-8da8-42e6-9b9c-04f6784adfce" });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 14, 46, 180, DateTimeKind.Local).AddTicks(571), "67666810-1258-434a-9e95-52c97c365c11" });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 14, 46, 180, DateTimeKind.Local).AddTicks(573), "e9c318db-69bf-4f99-b493-2f435b445d98" });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 14, 46, 180, DateTimeKind.Local).AddTicks(575), "53b532f0-ed07-411d-b472-8cc05272cc35" });

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
        }
    }
}
