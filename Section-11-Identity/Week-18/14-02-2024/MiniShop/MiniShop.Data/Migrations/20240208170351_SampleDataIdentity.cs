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
                    { "058f7729-b253-4d5c-b9e0-98441f1d5b78", null, "Müşteri haklarını taşıyan rol", "Customer", "CUSTOMER" },
                    { "8ed6b7d9-aad2-411a-96f7-70c695edd164", null, "Süper Yönetici haklarını taşıyan rol", "SuperAdmin", "SUPERADMIN" },
                    { "d587f52f-cb0a-4e60-931d-a69ba616c554", null, "Yönetici haklarını taşıyan rol", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2be38022-3c68-4fde-85f6-2e68d7c5550b", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "ec399b05-daad-4b49-8925-c6ea6b6a8dbe", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "kemaldurukan@gmail.com", true, "Kemal", "Erkek", "Durukan", false, null, "KEMALDURUKAN@GMAIL.COM", "KEMALDURUKAN", "AQAAAAIAAYagAAAAEH8dQkFv2u5RXwy/jkHAwe4pb0U/wsk2oh1/QKx/sdiAGqwFgJbVoKa16ootYSFuqw==", "5387996655", false, "f19e1c14-a22a-4b35-b72e-c66254c595c4", false, "kemaldurukan" },
                    { "440c526c-159f-4b44-95a8-68905caba1a7", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "c0786f1f-2c9b-4931-8e5c-5dfe6482f45e", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "aysenumay@gmail.com", true, "Ayşen Umay", "Kadın", "Ergül", false, null, "AYSENUMAY@GMAIL.COM", "AYSENUMAY", "AQAAAAIAAYagAAAAEGLBssj6wmK2x6x0HrRiz7B+S2NcFQNW+dU/22awe1NTm+HexYfQDHooK6UUiKOTDA==", "5387996655", false, "f556e757-5e39-4aa0-a293-5b688d9bbded", false, "aysenumay" },
                    { "4f80583b-1d38-438a-a7df-3016098ebdfd", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "c21847ad-9cba-4b7e-9c64-f3e49ee998d2", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "selinmete@gmail.com", true, "Selin", "Kadın", "Mete", false, null, "SELINMETE@GMAIL.COM", "SELINMETE", "AQAAAAIAAYagAAAAEHcl81EPulrLjDtz7qs9TkViOSDLt/hswROuLpcBdYHJ8iC2l5WqPEe+n6EK1Obeyw==", "5387996655", false, "caac6c3d-e95f-40bb-968b-36eca2ca1a5b", false, "selinmete" },
                    { "f70cd3d3-a497-42a7-92bf-5b2816f8fd66", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "25a300e3-cb56-492f-abd7-26dedf7a7db1", new DateTime(1990, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "denizfoca@gmail.com", true, "Deniz", "Erkek", "Foça", false, null, "DENIZFOCA@GMAIL.COM", "DENIZFOCA", "AQAAAAIAAYagAAAAEEzlQyzKme2Ce4O5WSd0f2SMwZPr8BJ/33tgreG1dkvvtDL5g5CqduJR8Z/u44HIUw==", "5558779966", false, "82fdae6f-c211-4f82-bf96-376c52a3436e", false, "denizfoca" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 3, 51, 571, DateTimeKind.Local).AddTicks(3449), new DateTime(2024, 2, 8, 20, 3, 51, 571, DateTimeKind.Local).AddTicks(3457) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 3, 51, 571, DateTimeKind.Local).AddTicks(3460), new DateTime(2024, 2, 8, 20, 3, 51, 571, DateTimeKind.Local).AddTicks(3460) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 3, 51, 571, DateTimeKind.Local).AddTicks(3462), new DateTime(2024, 2, 8, 20, 3, 51, 571, DateTimeKind.Local).AddTicks(3462) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 3, 51, 571, DateTimeKind.Local).AddTicks(3463), new DateTime(2024, 2, 8, 20, 3, 51, 571, DateTimeKind.Local).AddTicks(3463) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 3, 51, 571, DateTimeKind.Local).AddTicks(3464), new DateTime(2024, 2, 8, 20, 3, 51, 571, DateTimeKind.Local).AddTicks(3464) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 3, 51, 571, DateTimeKind.Local).AddTicks(9695), new DateTime(2024, 2, 8, 20, 3, 51, 571, DateTimeKind.Local).AddTicks(9700) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 3, 51, 571, DateTimeKind.Local).AddTicks(9708), new DateTime(2024, 2, 8, 20, 3, 51, 571, DateTimeKind.Local).AddTicks(9708) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 3, 51, 571, DateTimeKind.Local).AddTicks(9710), new DateTime(2024, 2, 8, 20, 3, 51, 571, DateTimeKind.Local).AddTicks(9710) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 3, 51, 571, DateTimeKind.Local).AddTicks(9711), new DateTime(2024, 2, 8, 20, 3, 51, 571, DateTimeKind.Local).AddTicks(9711) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 3, 51, 571, DateTimeKind.Local).AddTicks(9713), new DateTime(2024, 2, 8, 20, 3, 51, 571, DateTimeKind.Local).AddTicks(9713) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 3, 51, 571, DateTimeKind.Local).AddTicks(9714), new DateTime(2024, 2, 8, 20, 3, 51, 571, DateTimeKind.Local).AddTicks(9714) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 3, 51, 571, DateTimeKind.Local).AddTicks(9716), new DateTime(2024, 2, 8, 20, 3, 51, 571, DateTimeKind.Local).AddTicks(9716) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 3, 51, 571, DateTimeKind.Local).AddTicks(9717), new DateTime(2024, 2, 8, 20, 3, 51, 571, DateTimeKind.Local).AddTicks(9720) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 3, 51, 571, DateTimeKind.Local).AddTicks(9733), new DateTime(2024, 2, 8, 20, 3, 51, 571, DateTimeKind.Local).AddTicks(9733) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 3, 51, 571, DateTimeKind.Local).AddTicks(9734), new DateTime(2024, 2, 8, 20, 3, 51, 571, DateTimeKind.Local).AddTicks(9734) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 3, 51, 571, DateTimeKind.Local).AddTicks(9736), new DateTime(2024, 2, 8, 20, 3, 51, 571, DateTimeKind.Local).AddTicks(9736) });

            migrationBuilder.InsertData(
                table: "ShoppingCarts",
                columns: new[] { "Id", "CreatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 8, 20, 3, 51, 570, DateTimeKind.Local).AddTicks(9797), "f70cd3d3-a497-42a7-92bf-5b2816f8fd66" },
                    { 2, new DateTime(2024, 2, 8, 20, 3, 51, 570, DateTimeKind.Local).AddTicks(9823), "4f80583b-1d38-438a-a7df-3016098ebdfd" },
                    { 3, new DateTime(2024, 2, 8, 20, 3, 51, 570, DateTimeKind.Local).AddTicks(9824), "2be38022-3c68-4fde-85f6-2e68d7c5550b" },
                    { 4, new DateTime(2024, 2, 8, 20, 3, 51, 570, DateTimeKind.Local).AddTicks(9825), "440c526c-159f-4b44-95a8-68905caba1a7" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "d587f52f-cb0a-4e60-931d-a69ba616c554", "2be38022-3c68-4fde-85f6-2e68d7c5550b" },
                    { "058f7729-b253-4d5c-b9e0-98441f1d5b78", "440c526c-159f-4b44-95a8-68905caba1a7" },
                    { "d587f52f-cb0a-4e60-931d-a69ba616c554", "4f80583b-1d38-438a-a7df-3016098ebdfd" },
                    { "8ed6b7d9-aad2-411a-96f7-70c695edd164", "f70cd3d3-a497-42a7-92bf-5b2816f8fd66" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d587f52f-cb0a-4e60-931d-a69ba616c554", "2be38022-3c68-4fde-85f6-2e68d7c5550b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "058f7729-b253-4d5c-b9e0-98441f1d5b78", "440c526c-159f-4b44-95a8-68905caba1a7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d587f52f-cb0a-4e60-931d-a69ba616c554", "4f80583b-1d38-438a-a7df-3016098ebdfd" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8ed6b7d9-aad2-411a-96f7-70c695edd164", "f70cd3d3-a497-42a7-92bf-5b2816f8fd66" });

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
                keyValue: "058f7729-b253-4d5c-b9e0-98441f1d5b78");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ed6b7d9-aad2-411a-96f7-70c695edd164");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d587f52f-cb0a-4e60-931d-a69ba616c554");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2be38022-3c68-4fde-85f6-2e68d7c5550b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "440c526c-159f-4b44-95a8-68905caba1a7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4f80583b-1d38-438a-a7df-3016098ebdfd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f70cd3d3-a497-42a7-92bf-5b2816f8fd66");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 41, 307, DateTimeKind.Local).AddTicks(8382), new DateTime(2024, 2, 7, 21, 47, 41, 307, DateTimeKind.Local).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 41, 307, DateTimeKind.Local).AddTicks(8397), new DateTime(2024, 2, 7, 21, 47, 41, 307, DateTimeKind.Local).AddTicks(8398) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 41, 307, DateTimeKind.Local).AddTicks(8399), new DateTime(2024, 2, 7, 21, 47, 41, 307, DateTimeKind.Local).AddTicks(8399) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 41, 307, DateTimeKind.Local).AddTicks(8400), new DateTime(2024, 2, 7, 21, 47, 41, 307, DateTimeKind.Local).AddTicks(8400) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 41, 307, DateTimeKind.Local).AddTicks(8401), new DateTime(2024, 2, 7, 21, 47, 41, 307, DateTimeKind.Local).AddTicks(8401) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 41, 308, DateTimeKind.Local).AddTicks(2984), new DateTime(2024, 2, 7, 21, 47, 41, 308, DateTimeKind.Local).AddTicks(2989) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 41, 308, DateTimeKind.Local).AddTicks(2995), new DateTime(2024, 2, 7, 21, 47, 41, 308, DateTimeKind.Local).AddTicks(2996) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 41, 308, DateTimeKind.Local).AddTicks(2997), new DateTime(2024, 2, 7, 21, 47, 41, 308, DateTimeKind.Local).AddTicks(2998) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 41, 308, DateTimeKind.Local).AddTicks(2999), new DateTime(2024, 2, 7, 21, 47, 41, 308, DateTimeKind.Local).AddTicks(2999) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 41, 308, DateTimeKind.Local).AddTicks(3000), new DateTime(2024, 2, 7, 21, 47, 41, 308, DateTimeKind.Local).AddTicks(3000) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 41, 308, DateTimeKind.Local).AddTicks(3002), new DateTime(2024, 2, 7, 21, 47, 41, 308, DateTimeKind.Local).AddTicks(3002) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 41, 308, DateTimeKind.Local).AddTicks(3003), new DateTime(2024, 2, 7, 21, 47, 41, 308, DateTimeKind.Local).AddTicks(3003) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 41, 308, DateTimeKind.Local).AddTicks(3004), new DateTime(2024, 2, 7, 21, 47, 41, 308, DateTimeKind.Local).AddTicks(3005) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 41, 308, DateTimeKind.Local).AddTicks(3006), new DateTime(2024, 2, 7, 21, 47, 41, 308, DateTimeKind.Local).AddTicks(3006) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 41, 308, DateTimeKind.Local).AddTicks(3007), new DateTime(2024, 2, 7, 21, 47, 41, 308, DateTimeKind.Local).AddTicks(3007) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 41, 308, DateTimeKind.Local).AddTicks(3009), new DateTime(2024, 2, 7, 21, 47, 41, 308, DateTimeKind.Local).AddTicks(3009) });
        }
    }
}
