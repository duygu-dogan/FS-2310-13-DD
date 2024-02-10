using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MiniShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class SampleDataIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "02c518d8-560b-4bb8-a242-9dce0b18642e", null, "Süper yönetici haklarını taşıyan rol", "SuperAdmin", "SUPERADMIN" },
                    { "3e52c815-fc2d-4612-bf2f-57c96a2bea61", null, "Müşteri haklarını taşıyan rol", "Customer", "CUSTOMER" },
                    { "5823e9bf-cf6a-4aaa-8d2a-c84e1b2a8f45", null, "Yönetici haklarını taşıyan rol", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "57353a43-d02d-4f60-9790-31c9f17e181f", 0, "Halilpaşa Konağı Caddesi, Kemeraltı Sokak No:4 D:2 Üsküdar", "Istanbul", "8827e8fc-8994-4708-9e69-42962f7e38fb", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "aysenumay@gmail.com", true, "Ayşen Umay", "Kadın", "Ergül", false, null, "AYSENUMAY@GMAIL.COM", "AYSENUMAY", "AQAAAAIAAYagAAAAELwy46mgggAgGKYaA0CAlxyd0vN5kyrFBGaCVas4gxorXVnYAza7Fomxbeo8kt8FUQ==", "5559998273", false, "235c3d7f-b112-4ab9-88bc-5c8cf30bf760", false, "aysenumay" },
                    { "a92b6033-7f75-49a8-a2d9-c01f155eaa11", 0, "Halilpaşa Konağı Caddesi, Kemeraltı Sokak No:4 D:2 Üsküdar", "Istanbul", "9cfe930a-de96-4b03-bbca-f0a10aed5e07", new DateTime(1990, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "kemaldurukana@gmail.com", true, "Kemal", "Erkek", "Durukan", false, null, "KEMALDURUKAN@GMAIL.COM", "KEMALDURUKAN", "AQAAAAIAAYagAAAAEJFKOMrWD0+C48g2OSVDGCNgIw+Qlk1X65aqlZyWm0aN9kWhKZHax80cbC013g4u/w==", "5558779966", false, "5e0c4ed5-2b15-4b6b-b05b-448aa0789ef4", false, "kemaldurukan" },
                    { "b1b98a3f-2d31-4f3e-831e-1f12bf9be825", 0, "Halilpaşa Konağı Caddesi, Kemeraltı Sokak No:4 D:2 Üsküdar", "Istanbul", "2749f85a-fe9a-4856-abab-1e62aaf883d1", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "selinmete@gmail.com", true, "Selin", "Kadın", "Mete", false, null, "SELINMETE@GMAIL.COM", "SELINMETE", "AQAAAAIAAYagAAAAEDDrGF5e916QaqVmc7nMlj/WaHxdm6jaBldX95JzCAY6m+sUp3u7q1Zi7VcjF1A0pQ==", "5559998273", false, "ee72aa1b-84cb-41ac-be07-0ebc41f08612", false, "selinmete" },
                    { "e6095946-beb7-4f13-898e-0838a5dea881", 0, "Halilpaşa Konağı Caddesi, Kemeraltı Sokak No:4 D:2 Üsküdar", "Istanbul", "4bc583aa-629d-4ff6-9aea-d5edf60770d4", new DateTime(1990, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "denizfoca@gmail.com", true, "Deniz", "Erkek", "Foça", false, null, "DENIZFOCA@GMAIL.COM", "DENIZFOCA", "AQAAAAIAAYagAAAAELUN4mJYKxvNP/JbM408v73+3ob3iIZK76DNprvlpX0ZZTxg/iRLLqRWYqJF51lolg==", "5558779966", false, "69e7cc57-6e93-4535-896d-d339d7637349", false, "denizfoca" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 4, 6, 277, DateTimeKind.Local).AddTicks(4815), new DateTime(2024, 2, 8, 20, 4, 6, 277, DateTimeKind.Local).AddTicks(4827) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 4, 6, 277, DateTimeKind.Local).AddTicks(4831), new DateTime(2024, 2, 8, 20, 4, 6, 277, DateTimeKind.Local).AddTicks(4831) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 4, 6, 277, DateTimeKind.Local).AddTicks(4832), new DateTime(2024, 2, 8, 20, 4, 6, 277, DateTimeKind.Local).AddTicks(4833) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 4, 6, 277, DateTimeKind.Local).AddTicks(4834), new DateTime(2024, 2, 8, 20, 4, 6, 277, DateTimeKind.Local).AddTicks(4834) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 4, 6, 277, DateTimeKind.Local).AddTicks(4836), new DateTime(2024, 2, 8, 20, 4, 6, 277, DateTimeKind.Local).AddTicks(4836) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 4, 6, 278, DateTimeKind.Local).AddTicks(2714), new DateTime(2024, 2, 8, 20, 4, 6, 278, DateTimeKind.Local).AddTicks(2723) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 4, 6, 278, DateTimeKind.Local).AddTicks(2731), new DateTime(2024, 2, 8, 20, 4, 6, 278, DateTimeKind.Local).AddTicks(2731) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 4, 6, 278, DateTimeKind.Local).AddTicks(2733), new DateTime(2024, 2, 8, 20, 4, 6, 278, DateTimeKind.Local).AddTicks(2733) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 4, 6, 278, DateTimeKind.Local).AddTicks(2735), new DateTime(2024, 2, 8, 20, 4, 6, 278, DateTimeKind.Local).AddTicks(2735) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 4, 6, 278, DateTimeKind.Local).AddTicks(2737), new DateTime(2024, 2, 8, 20, 4, 6, 278, DateTimeKind.Local).AddTicks(2737) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 4, 6, 278, DateTimeKind.Local).AddTicks(2738), new DateTime(2024, 2, 8, 20, 4, 6, 278, DateTimeKind.Local).AddTicks(2739) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 4, 6, 278, DateTimeKind.Local).AddTicks(2740), new DateTime(2024, 2, 8, 20, 4, 6, 278, DateTimeKind.Local).AddTicks(2740) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 4, 6, 278, DateTimeKind.Local).AddTicks(2742), new DateTime(2024, 2, 8, 20, 4, 6, 278, DateTimeKind.Local).AddTicks(2747) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 4, 6, 278, DateTimeKind.Local).AddTicks(2760), new DateTime(2024, 2, 8, 20, 4, 6, 278, DateTimeKind.Local).AddTicks(2761) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 4, 6, 278, DateTimeKind.Local).AddTicks(2762), new DateTime(2024, 2, 8, 20, 4, 6, 278, DateTimeKind.Local).AddTicks(2763) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 4, 6, 278, DateTimeKind.Local).AddTicks(2764), new DateTime(2024, 2, 8, 20, 4, 6, 278, DateTimeKind.Local).AddTicks(2764) });

            migrationBuilder.InsertData(
                table: "ShoppingCarts",
                columns: new[] { "Id", "CreatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 8, 20, 4, 6, 276, DateTimeKind.Local).AddTicks(8832), "e6095946-beb7-4f13-898e-0838a5dea881" },
                    { 2, new DateTime(2024, 2, 8, 20, 4, 6, 276, DateTimeKind.Local).AddTicks(8906), "b1b98a3f-2d31-4f3e-831e-1f12bf9be825" },
                    { 3, new DateTime(2024, 2, 8, 20, 4, 6, 276, DateTimeKind.Local).AddTicks(8908), "a92b6033-7f75-49a8-a2d9-c01f155eaa11" },
                    { 4, new DateTime(2024, 2, 8, 20, 4, 6, 276, DateTimeKind.Local).AddTicks(8909), "57353a43-d02d-4f60-9790-31c9f17e181f" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "3e52c815-fc2d-4612-bf2f-57c96a2bea61", "57353a43-d02d-4f60-9790-31c9f17e181f" },
                    { "5823e9bf-cf6a-4aaa-8d2a-c84e1b2a8f45", "a92b6033-7f75-49a8-a2d9-c01f155eaa11" },
                    { "5823e9bf-cf6a-4aaa-8d2a-c84e1b2a8f45", "b1b98a3f-2d31-4f3e-831e-1f12bf9be825" },
                    { "02c518d8-560b-4bb8-a242-9dce0b18642e", "e6095946-beb7-4f13-898e-0838a5dea881" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3e52c815-fc2d-4612-bf2f-57c96a2bea61", "57353a43-d02d-4f60-9790-31c9f17e181f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5823e9bf-cf6a-4aaa-8d2a-c84e1b2a8f45", "a92b6033-7f75-49a8-a2d9-c01f155eaa11" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5823e9bf-cf6a-4aaa-8d2a-c84e1b2a8f45", "b1b98a3f-2d31-4f3e-831e-1f12bf9be825" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "02c518d8-560b-4bb8-a242-9dce0b18642e", "e6095946-beb7-4f13-898e-0838a5dea881" });

            migrationBuilder.DeleteData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "02c518d8-560b-4bb8-a242-9dce0b18642e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e52c815-fc2d-4612-bf2f-57c96a2bea61");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5823e9bf-cf6a-4aaa-8d2a-c84e1b2a8f45");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57353a43-d02d-4f60-9790-31c9f17e181f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a92b6033-7f75-49a8-a2d9-c01f155eaa11");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1b98a3f-2d31-4f3e-831e-1f12bf9be825");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6095946-beb7-4f13-898e-0838a5dea881");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 50, 591, DateTimeKind.Local).AddTicks(5044), new DateTime(2024, 2, 7, 21, 47, 50, 591, DateTimeKind.Local).AddTicks(5057) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 50, 591, DateTimeKind.Local).AddTicks(5060), new DateTime(2024, 2, 7, 21, 47, 50, 591, DateTimeKind.Local).AddTicks(5060) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 50, 591, DateTimeKind.Local).AddTicks(5062), new DateTime(2024, 2, 7, 21, 47, 50, 591, DateTimeKind.Local).AddTicks(5062) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 50, 591, DateTimeKind.Local).AddTicks(5063), new DateTime(2024, 2, 7, 21, 47, 50, 591, DateTimeKind.Local).AddTicks(5063) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 50, 591, DateTimeKind.Local).AddTicks(5064), new DateTime(2024, 2, 7, 21, 47, 50, 591, DateTimeKind.Local).AddTicks(5065) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 50, 592, DateTimeKind.Local).AddTicks(227), new DateTime(2024, 2, 7, 21, 47, 50, 592, DateTimeKind.Local).AddTicks(233) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 50, 592, DateTimeKind.Local).AddTicks(240), new DateTime(2024, 2, 7, 21, 47, 50, 592, DateTimeKind.Local).AddTicks(240) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 50, 592, DateTimeKind.Local).AddTicks(242), new DateTime(2024, 2, 7, 21, 47, 50, 592, DateTimeKind.Local).AddTicks(242) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 50, 592, DateTimeKind.Local).AddTicks(243), new DateTime(2024, 2, 7, 21, 47, 50, 592, DateTimeKind.Local).AddTicks(244) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 50, 592, DateTimeKind.Local).AddTicks(266), new DateTime(2024, 2, 7, 21, 47, 50, 592, DateTimeKind.Local).AddTicks(267) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 50, 592, DateTimeKind.Local).AddTicks(269), new DateTime(2024, 2, 7, 21, 47, 50, 592, DateTimeKind.Local).AddTicks(269) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 50, 592, DateTimeKind.Local).AddTicks(270), new DateTime(2024, 2, 7, 21, 47, 50, 592, DateTimeKind.Local).AddTicks(271) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 50, 592, DateTimeKind.Local).AddTicks(272), new DateTime(2024, 2, 7, 21, 47, 50, 592, DateTimeKind.Local).AddTicks(272) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 50, 592, DateTimeKind.Local).AddTicks(273), new DateTime(2024, 2, 7, 21, 47, 50, 592, DateTimeKind.Local).AddTicks(274) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 50, 592, DateTimeKind.Local).AddTicks(275), new DateTime(2024, 2, 7, 21, 47, 50, 592, DateTimeKind.Local).AddTicks(275) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 50, 592, DateTimeKind.Local).AddTicks(276), new DateTime(2024, 2, 7, 21, 47, 50, 592, DateTimeKind.Local).AddTicks(277) });
        }
    }
}
