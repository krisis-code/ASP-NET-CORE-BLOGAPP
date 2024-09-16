using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog.Data.Migrations
{
    /// <inheritdoc />
    public partial class SunucDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("84aa41f4-6f9e-4520-b609-e050576869e9"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("96ece9ec-a23d-4de6-aec4-343e6b034f58"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("98310c1a-6c58-4640-bae6-9b4c28fe222a"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("9b3b7186-ac89-4a9b-b415-96f2765bc081"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("bd3c0eb5-02d7-42e8-aa7a-311a587bf3d1"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("1abe0bd8-4e39-4257-b0a0-49be0d006739"), new Guid("f9cd51ae-20df-4dd7-bc5e-c9e58d6da613"), "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of \"de Finibus Bonorum et Malorum\" (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, \"Lorem ipsum dolor sit amet..\", comes from a line in section 1.10.32.\r\n\r\nThe standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.", "Admin Test", new DateTime(2024, 9, 16, 15, 1, 12, 570, DateTimeKind.Local).AddTicks(4661), null, null, new Guid("b93e0a19-ea35-4121-985a-5d2e33720de4"), false, null, null, "Asp.net core", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), 30 },
                    { new Guid("420b242f-5fc6-4100-9660-37d493185475"), new Guid("db9c2a0b-213e-4cb8-8f28-14ebc5677783"), "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of \"de Finibus Bonorum et Malorum\" (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, \"Lorem ipsum dolor sit amet..\", comes from a line in section 1.10.32.\r\n\r\nThe standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.", "Admin Test", new DateTime(2024, 9, 16, 15, 1, 12, 570, DateTimeKind.Local).AddTicks(4703), null, null, new Guid("f222587b-cbb5-49d2-bde4-973a2879bb67"), false, null, null, "FullStack Development", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), 105 },
                    { new Guid("99cbbb60-753a-4f36-bb21-10f7eb21617a"), new Guid("45db3e81-c868-459e-8234-f14913d9ea62"), "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of \"de Finibus Bonorum et Malorum\" (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, \"Lorem ipsum dolor sit amet..\", comes from a line in section 1.10.32.\r\n\r\nThe standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.", "Admin Test", new DateTime(2024, 9, 16, 15, 1, 12, 570, DateTimeKind.Local).AddTicks(4698), null, null, new Guid("a4c63d74-3640-4e31-a71c-6b24b1412cee"), false, null, null, "C++ Data struct", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), 45 },
                    { new Guid("a723c4d3-dea7-4103-b090-8512989d3abf"), new Guid("2f635d41-ad10-4f31-a708-38d5f035e69b"), "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of \"de Finibus Bonorum et Malorum\" (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, \"Lorem ipsum dolor sit amet..\", comes from a line in section 1.10.32.\r\n\r\nThe standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.", "Admin Test", new DateTime(2024, 9, 16, 15, 1, 12, 570, DateTimeKind.Local).AddTicks(4693), null, null, new Guid("52d13349-e46b-4d2e-9053-92282b5f4911"), false, null, null, "Javascript Öğren", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), 35 },
                    { new Guid("ff664d0d-a7e2-4fae-a6cb-0824387c8e5d"), new Guid("fbfc4775-6074-4dd0-803f-192d426f70ae"), "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of \"de Finibus Bonorum et Malorum\" (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, \"Lorem ipsum dolor sit amet..\", comes from a line in section 1.10.32.\r\n\r\nThe standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.", "Admin Test", new DateTime(2024, 9, 16, 15, 1, 12, 570, DateTimeKind.Local).AddTicks(4687), null, null, new Guid("717ba245-2468-4334-97d4-2b87e77351a5"), false, null, null, "Derinlemesine C#", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1348ca82-0ea9-4de9-a08e-f21fc9f5906a"),
                column: "ConcurrencyStamp",
                value: "f1c01790-9b77-4912-a29e-fa5d6ef06793");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("ac2bfb1d-dfaa-4057-bb71-b5718a312cd9"),
                column: "ConcurrencyStamp",
                value: "e08f6c1b-498d-4b17-893b-8914fb750b07");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d0bc7ad4-d344-4f5e-a18c-a9538730f007"),
                column: "ConcurrencyStamp",
                value: "2569b030-e344-4211-bd9d-e0f9b28a5d58");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c132284-86d7-40a4-8df9-79ae2c458add", "AQAAAAIAAYagAAAAEHnLuzEEsZhmysEMzUGMdiegDmY77e8ZjRm+R+SLKQfKU2+nw5NmSwBh2zf1sUcbNA==", "6f086f4f-9565-48dc-99f8-5bd058b02f8a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b70cc0e-5186-4e06-8ddc-bf856234086c", "AQAAAAIAAYagAAAAEOTlPSKUzat5xEjgumvzQg+U/RJVndvwye4tvQjucj1ooUHZOfZBHBQMk/FodMEC1A==", "8f161223-a20a-4de5-ba37-fdd0f259c906" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2f635d41-ad10-4f31-a708-38d5f035e69b"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 16, 15, 1, 12, 570, DateTimeKind.Local).AddTicks(6632));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("45db3e81-c868-459e-8234-f14913d9ea62"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 16, 15, 1, 12, 570, DateTimeKind.Local).AddTicks(6634));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("db9c2a0b-213e-4cb8-8f28-14ebc5677783"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 16, 15, 1, 12, 570, DateTimeKind.Local).AddTicks(6637));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f9cd51ae-20df-4dd7-bc5e-c9e58d6da613"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 16, 15, 1, 12, 570, DateTimeKind.Local).AddTicks(6621));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fbfc4775-6074-4dd0-803f-192d426f70ae"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 16, 15, 1, 12, 570, DateTimeKind.Local).AddTicks(6629));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("52d13349-e46b-4d2e-9053-92282b5f4911"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 16, 15, 1, 12, 570, DateTimeKind.Local).AddTicks(7719));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("717ba245-2468-4334-97d4-2b87e77351a5"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 16, 15, 1, 12, 570, DateTimeKind.Local).AddTicks(7716));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("a4c63d74-3640-4e31-a71c-6b24b1412cee"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 16, 15, 1, 12, 570, DateTimeKind.Local).AddTicks(7722));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("b93e0a19-ea35-4121-985a-5d2e33720de4"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 16, 15, 1, 12, 570, DateTimeKind.Local).AddTicks(7712));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("f222587b-cbb5-49d2-bde4-973a2879bb67"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 16, 15, 1, 12, 570, DateTimeKind.Local).AddTicks(7729));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("1abe0bd8-4e39-4257-b0a0-49be0d006739"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("420b242f-5fc6-4100-9660-37d493185475"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("99cbbb60-753a-4f36-bb21-10f7eb21617a"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("a723c4d3-dea7-4103-b090-8512989d3abf"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("ff664d0d-a7e2-4fae-a6cb-0824387c8e5d"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("84aa41f4-6f9e-4520-b609-e050576869e9"), new Guid("45db3e81-c868-459e-8234-f14913d9ea62"), "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of \"de Finibus Bonorum et Malorum\" (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, \"Lorem ipsum dolor sit amet..\", comes from a line in section 1.10.32.\r\n\r\nThe standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.", "Admin Test", new DateTime(2024, 9, 16, 14, 59, 7, 706, DateTimeKind.Local).AddTicks(1534), null, null, new Guid("a4c63d74-3640-4e31-a71c-6b24b1412cee"), false, null, null, "C++ Data struct", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), 45 },
                    { new Guid("96ece9ec-a23d-4de6-aec4-343e6b034f58"), new Guid("2f635d41-ad10-4f31-a708-38d5f035e69b"), "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of \"de Finibus Bonorum et Malorum\" (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, \"Lorem ipsum dolor sit amet..\", comes from a line in section 1.10.32.\r\n\r\nThe standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.", "Admin Test", new DateTime(2024, 9, 16, 14, 59, 7, 706, DateTimeKind.Local).AddTicks(1519), null, null, new Guid("52d13349-e46b-4d2e-9053-92282b5f4911"), false, null, null, "Javascript Öğren", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), 35 },
                    { new Guid("98310c1a-6c58-4640-bae6-9b4c28fe222a"), new Guid("f9cd51ae-20df-4dd7-bc5e-c9e58d6da613"), "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of \"de Finibus Bonorum et Malorum\" (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, \"Lorem ipsum dolor sit amet..\", comes from a line in section 1.10.32.\r\n\r\nThe standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.", "Admin Test", new DateTime(2024, 9, 16, 14, 59, 7, 706, DateTimeKind.Local).AddTicks(1508), null, null, new Guid("b93e0a19-ea35-4121-985a-5d2e33720de4"), false, null, null, "Asp.net core", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), 30 },
                    { new Guid("9b3b7186-ac89-4a9b-b415-96f2765bc081"), new Guid("db9c2a0b-213e-4cb8-8f28-14ebc5677783"), "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of \"de Finibus Bonorum et Malorum\" (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, \"Lorem ipsum dolor sit amet..\", comes from a line in section 1.10.32.\r\n\r\nThe standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.", "Admin Test", new DateTime(2024, 9, 16, 14, 59, 7, 706, DateTimeKind.Local).AddTicks(1539), null, null, new Guid("f222587b-cbb5-49d2-bde4-973a2879bb67"), false, null, null, "FullStack Development", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), 105 },
                    { new Guid("bd3c0eb5-02d7-42e8-aa7a-311a587bf3d1"), new Guid("fbfc4775-6074-4dd0-803f-192d426f70ae"), "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of \"de Finibus Bonorum et Malorum\" (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, \"Lorem ipsum dolor sit amet..\", comes from a line in section 1.10.32.\r\n\r\nThe standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.", "Admin Test", new DateTime(2024, 9, 16, 14, 59, 7, 706, DateTimeKind.Local).AddTicks(1514), null, null, new Guid("717ba245-2468-4334-97d4-2b87e77351a5"), false, null, null, "Derinlemesine C#", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1348ca82-0ea9-4de9-a08e-f21fc9f5906a"),
                column: "ConcurrencyStamp",
                value: "b32831a9-2ed9-4132-ad6f-28fc255a2989");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("ac2bfb1d-dfaa-4057-bb71-b5718a312cd9"),
                column: "ConcurrencyStamp",
                value: "d2844f31-c705-45a5-af2d-a4e58c48192b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d0bc7ad4-d344-4f5e-a18c-a9538730f007"),
                column: "ConcurrencyStamp",
                value: "5eb66145-8171-4f29-8b94-9b40f68e852a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5be4161f-692e-4151-b73f-2efbc22d8176", "AQAAAAIAAYagAAAAEOPNiM8pJJDjR/QW2n1Ka/xtHuOJ/WrVa4WyKWnqJBUJYCU/jhKEkXkNERQAZ/1CXA==", "7cc0d6e1-ced1-4a60-9719-44fe98937578" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "edac951c-97fd-4a5e-905a-3b04bd5f2f0c", "AQAAAAIAAYagAAAAEG9DB62ijYaG4jbYErE7i1azZ78Tu5g1G3KIRSeir/mcN6imXKRnIVpTYojOR5nVoQ==", "7d56acba-c003-4351-aa59-c5105803ea90" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2f635d41-ad10-4f31-a708-38d5f035e69b"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 16, 14, 59, 7, 706, DateTimeKind.Local).AddTicks(2886));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("45db3e81-c868-459e-8234-f14913d9ea62"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 16, 14, 59, 7, 706, DateTimeKind.Local).AddTicks(2888));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("db9c2a0b-213e-4cb8-8f28-14ebc5677783"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 16, 14, 59, 7, 706, DateTimeKind.Local).AddTicks(2931));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f9cd51ae-20df-4dd7-bc5e-c9e58d6da613"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 16, 14, 59, 7, 706, DateTimeKind.Local).AddTicks(2880));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fbfc4775-6074-4dd0-803f-192d426f70ae"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 16, 14, 59, 7, 706, DateTimeKind.Local).AddTicks(2883));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("52d13349-e46b-4d2e-9053-92282b5f4911"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 16, 14, 59, 7, 706, DateTimeKind.Local).AddTicks(4023));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("717ba245-2468-4334-97d4-2b87e77351a5"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 16, 14, 59, 7, 706, DateTimeKind.Local).AddTicks(4019));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("a4c63d74-3640-4e31-a71c-6b24b1412cee"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 16, 14, 59, 7, 706, DateTimeKind.Local).AddTicks(4025));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("b93e0a19-ea35-4121-985a-5d2e33720de4"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 16, 14, 59, 7, 706, DateTimeKind.Local).AddTicks(4014));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("f222587b-cbb5-49d2-bde4-973a2879bb67"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 16, 14, 59, 7, 706, DateTimeKind.Local).AddTicks(4028));
        }
    }
}
