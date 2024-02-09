using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog.Data.Migrations
{
    /// <inheritdoc />
    public partial class seedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("2f635d41-ad10-4f31-a708-38d5f035e69b"), "Admin Test", new DateTime(2024, 2, 7, 0, 48, 1, 111, DateTimeKind.Local).AddTicks(3256), null, null, false, null, null, "Javascript Öğren" },
                    { new Guid("45db3e81-c868-459e-8234-f14913d9ea62"), "Admin Test", new DateTime(2024, 2, 7, 0, 48, 1, 111, DateTimeKind.Local).AddTicks(3259), null, null, false, null, null, "C++ Data struct" },
                    { new Guid("db9c2a0b-213e-4cb8-8f28-14ebc5677783"), "Admin Test", new DateTime(2024, 2, 7, 0, 48, 1, 111, DateTimeKind.Local).AddTicks(3267), null, null, false, null, null, "FullStack Development" },
                    { new Guid("f9cd51ae-20df-4dd7-bc5e-c9e58d6da613"), "Admin Test", new DateTime(2024, 2, 7, 0, 48, 1, 111, DateTimeKind.Local).AddTicks(3249), null, null, false, null, null, "Asp.net core" },
                    { new Guid("fbfc4775-6074-4dd0-803f-192d426f70ae"), "Admin Test", new DateTime(2024, 2, 7, 0, 48, 1, 111, DateTimeKind.Local).AddTicks(3253), null, null, false, null, null, "Derinlemesine C#" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "FileName", "FileType", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("52d13349-e46b-4d2e-9053-92282b5f4911"), "Admin Test", new DateTime(2024, 2, 7, 0, 48, 1, 111, DateTimeKind.Local).AddTicks(4499), null, null, "images/3", "png", false, null, null },
                    { new Guid("717ba245-2468-4334-97d4-2b87e77351a5"), "Admin Test", new DateTime(2024, 2, 7, 0, 48, 1, 111, DateTimeKind.Local).AddTicks(4497), null, null, "images/23", "png", false, null, null },
                    { new Guid("a4c63d74-3640-4e31-a71c-6b24b1412cee"), "Admin Test", new DateTime(2024, 2, 7, 0, 48, 1, 111, DateTimeKind.Local).AddTicks(4502), null, null, "images/4", "png", false, null, null },
                    { new Guid("b93e0a19-ea35-4121-985a-5d2e33720de4"), "Admin Test", new DateTime(2024, 2, 7, 0, 48, 1, 111, DateTimeKind.Local).AddTicks(4492), null, null, "images/1", "png", false, null, null },
                    { new Guid("f222587b-cbb5-49d2-bde4-973a2879bb67"), "Admin Test", new DateTime(2024, 2, 7, 0, 48, 1, 111, DateTimeKind.Local).AddTicks(4505), null, null, "images/5", "png", false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("3cb1482a-1379-4c46-a68f-5e34ef5cd4c4"), new Guid("fbfc4775-6074-4dd0-803f-192d426f70ae"), "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of \"de Finibus Bonorum et Malorum\" (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, \"Lorem ipsum dolor sit amet..\", comes from a line in section 1.10.32.\r\n\r\nThe standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.", "Admin Test", new DateTime(2024, 2, 7, 0, 48, 1, 111, DateTimeKind.Local).AddTicks(1839), null, null, new Guid("717ba245-2468-4334-97d4-2b87e77351a5"), false, null, null, "Derinlemesine C#", 15 },
                    { new Guid("7c0dfdf0-341e-41b1-908e-9051e3a8478e"), new Guid("2f635d41-ad10-4f31-a708-38d5f035e69b"), "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of \"de Finibus Bonorum et Malorum\" (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, \"Lorem ipsum dolor sit amet..\", comes from a line in section 1.10.32.\r\n\r\nThe standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.", "Admin Test", new DateTime(2024, 2, 7, 0, 48, 1, 111, DateTimeKind.Local).AddTicks(1844), null, null, new Guid("52d13349-e46b-4d2e-9053-92282b5f4911"), false, null, null, "Javascript Öğren", 35 },
                    { new Guid("98b560b7-e9aa-47a9-84e1-0e4da8f55164"), new Guid("45db3e81-c868-459e-8234-f14913d9ea62"), "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of \"de Finibus Bonorum et Malorum\" (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, \"Lorem ipsum dolor sit amet..\", comes from a line in section 1.10.32.\r\n\r\nThe standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.", "Admin Test", new DateTime(2024, 2, 7, 0, 48, 1, 111, DateTimeKind.Local).AddTicks(1861), null, null, new Guid("a4c63d74-3640-4e31-a71c-6b24b1412cee"), false, null, null, "C++ Data struct", 45 },
                    { new Guid("9bf53df2-a888-4ef8-9ce0-503200e49f5e"), new Guid("db9c2a0b-213e-4cb8-8f28-14ebc5677783"), "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of \"de Finibus Bonorum et Malorum\" (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, \"Lorem ipsum dolor sit amet..\", comes from a line in section 1.10.32.\r\n\r\nThe standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.", "Admin Test", new DateTime(2024, 2, 7, 0, 48, 1, 111, DateTimeKind.Local).AddTicks(1865), null, null, new Guid("f222587b-cbb5-49d2-bde4-973a2879bb67"), false, null, null, "FullStack Development", 105 },
                    { new Guid("cc7860ac-75ed-4f8d-92db-949993ef4688"), new Guid("f9cd51ae-20df-4dd7-bc5e-c9e58d6da613"), "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of \"de Finibus Bonorum et Malorum\" (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, \"Lorem ipsum dolor sit amet..\", comes from a line in section 1.10.32.\r\n\r\nThe standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.", "Admin Test", new DateTime(2024, 2, 7, 0, 48, 1, 111, DateTimeKind.Local).AddTicks(1833), null, null, new Guid("b93e0a19-ea35-4121-985a-5d2e33720de4"), false, null, null, "Asp.net core", 30 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("3cb1482a-1379-4c46-a68f-5e34ef5cd4c4"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("7c0dfdf0-341e-41b1-908e-9051e3a8478e"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("98b560b7-e9aa-47a9-84e1-0e4da8f55164"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("9bf53df2-a888-4ef8-9ce0-503200e49f5e"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("cc7860ac-75ed-4f8d-92db-949993ef4688"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2f635d41-ad10-4f31-a708-38d5f035e69b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("45db3e81-c868-459e-8234-f14913d9ea62"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("db9c2a0b-213e-4cb8-8f28-14ebc5677783"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f9cd51ae-20df-4dd7-bc5e-c9e58d6da613"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fbfc4775-6074-4dd0-803f-192d426f70ae"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("52d13349-e46b-4d2e-9053-92282b5f4911"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("717ba245-2468-4334-97d4-2b87e77351a5"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("a4c63d74-3640-4e31-a71c-6b24b1412cee"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("b93e0a19-ea35-4121-985a-5d2e33720de4"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("f222587b-cbb5-49d2-bde4-973a2879bb67"));

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
