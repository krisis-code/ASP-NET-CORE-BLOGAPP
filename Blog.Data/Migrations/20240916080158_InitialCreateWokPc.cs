using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreateWokPc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("18759c66-ed37-4445-9fa4-7163fe74ace5"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("6a1f9744-d8b2-4996-90ac-c361d27452da"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("b8fc2583-9300-41a5-88a3-802288d80d16"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("f65d76f2-c658-43eb-acb0-fa5d74a4d8c6"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("fded1529-c63d-424a-b536-fe6e14510fc0"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("0fef1f0b-ba16-4004-b0a9-7fd60e7468c8"), new Guid("db9c2a0b-213e-4cb8-8f28-14ebc5677783"), "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of \"de Finibus Bonorum et Malorum\" (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, \"Lorem ipsum dolor sit amet..\", comes from a line in section 1.10.32.\r\n\r\nThe standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.", "Admin Test", new DateTime(2024, 9, 16, 11, 1, 57, 914, DateTimeKind.Local).AddTicks(3325), null, null, new Guid("f222587b-cbb5-49d2-bde4-973a2879bb67"), false, null, null, "FullStack Development", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), 105 },
                    { new Guid("80de6c2f-5638-4268-96aa-aa56a29c98fd"), new Guid("f9cd51ae-20df-4dd7-bc5e-c9e58d6da613"), "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of \"de Finibus Bonorum et Malorum\" (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, \"Lorem ipsum dolor sit amet..\", comes from a line in section 1.10.32.\r\n\r\nThe standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.", "Admin Test", new DateTime(2024, 9, 16, 11, 1, 57, 914, DateTimeKind.Local).AddTicks(3284), null, null, new Guid("b93e0a19-ea35-4121-985a-5d2e33720de4"), false, null, null, "Asp.net core", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), 30 },
                    { new Guid("9bb15c80-f301-4eed-aa88-62fa1b2f981e"), new Guid("45db3e81-c868-459e-8234-f14913d9ea62"), "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of \"de Finibus Bonorum et Malorum\" (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, \"Lorem ipsum dolor sit amet..\", comes from a line in section 1.10.32.\r\n\r\nThe standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.", "Admin Test", new DateTime(2024, 9, 16, 11, 1, 57, 914, DateTimeKind.Local).AddTicks(3320), null, null, new Guid("a4c63d74-3640-4e31-a71c-6b24b1412cee"), false, null, null, "C++ Data struct", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), 45 },
                    { new Guid("b16198f2-4900-4100-b93f-7a19dd304984"), new Guid("fbfc4775-6074-4dd0-803f-192d426f70ae"), "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of \"de Finibus Bonorum et Malorum\" (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, \"Lorem ipsum dolor sit amet..\", comes from a line in section 1.10.32.\r\n\r\nThe standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.", "Admin Test", new DateTime(2024, 9, 16, 11, 1, 57, 914, DateTimeKind.Local).AddTicks(3310), null, null, new Guid("717ba245-2468-4334-97d4-2b87e77351a5"), false, null, null, "Derinlemesine C#", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), 15 },
                    { new Guid("b5c240ca-c058-4195-88b0-4dc02aec7463"), new Guid("2f635d41-ad10-4f31-a708-38d5f035e69b"), "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of \"de Finibus Bonorum et Malorum\" (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, \"Lorem ipsum dolor sit amet..\", comes from a line in section 1.10.32.\r\n\r\nThe standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.", "Admin Test", new DateTime(2024, 9, 16, 11, 1, 57, 914, DateTimeKind.Local).AddTicks(3315), null, null, new Guid("52d13349-e46b-4d2e-9053-92282b5f4911"), false, null, null, "Javascript Öğren", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), 35 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1348ca82-0ea9-4de9-a08e-f21fc9f5906a"),
                column: "ConcurrencyStamp",
                value: "f0aa5034-82c5-4221-b3a2-e17db3ea060c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("ac2bfb1d-dfaa-4057-bb71-b5718a312cd9"),
                column: "ConcurrencyStamp",
                value: "c2ca8884-1de5-48d3-95e5-56c90b5f29da");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d0bc7ad4-d344-4f5e-a18c-a9538730f007"),
                column: "ConcurrencyStamp",
                value: "d1da50ba-7497-47be-b7b7-c28aedea2b15");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c1d84eb-aded-4a82-80eb-37fc01e170e9", "AQAAAAIAAYagAAAAELwR26nE0S5NQSg5vY2aHxn475Ger4I53SFfrxS30ECXKUug+iTXjvOP33K3N98yGw==", "0230d485-e9eb-4252-963e-237b9f3ed066" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "be46d1ad-39a2-429d-b5da-9d690c1cc707", "AQAAAAIAAYagAAAAEG4kokJPZo39xrlLaPwidjVbSol/KcMvZQRzldTkl+RtUhucpSdMe+SHLwLUrXzQhg==", "7cf234a4-d1ca-425d-aaca-d9943b33b46c" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2f635d41-ad10-4f31-a708-38d5f035e69b"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 16, 11, 1, 57, 914, DateTimeKind.Local).AddTicks(4935));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("45db3e81-c868-459e-8234-f14913d9ea62"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 16, 11, 1, 57, 914, DateTimeKind.Local).AddTicks(4938));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("db9c2a0b-213e-4cb8-8f28-14ebc5677783"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 16, 11, 1, 57, 914, DateTimeKind.Local).AddTicks(4941));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f9cd51ae-20df-4dd7-bc5e-c9e58d6da613"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 16, 11, 1, 57, 914, DateTimeKind.Local).AddTicks(4928));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fbfc4775-6074-4dd0-803f-192d426f70ae"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 16, 11, 1, 57, 914, DateTimeKind.Local).AddTicks(4933));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("52d13349-e46b-4d2e-9053-92282b5f4911"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 16, 11, 1, 57, 914, DateTimeKind.Local).AddTicks(6262));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("717ba245-2468-4334-97d4-2b87e77351a5"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 16, 11, 1, 57, 914, DateTimeKind.Local).AddTicks(6228));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("a4c63d74-3640-4e31-a71c-6b24b1412cee"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 16, 11, 1, 57, 914, DateTimeKind.Local).AddTicks(6270));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("b93e0a19-ea35-4121-985a-5d2e33720de4"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 16, 11, 1, 57, 914, DateTimeKind.Local).AddTicks(6223));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("f222587b-cbb5-49d2-bde4-973a2879bb67"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 16, 11, 1, 57, 914, DateTimeKind.Local).AddTicks(6273));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("0fef1f0b-ba16-4004-b0a9-7fd60e7468c8"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("80de6c2f-5638-4268-96aa-aa56a29c98fd"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("9bb15c80-f301-4eed-aa88-62fa1b2f981e"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("b16198f2-4900-4100-b93f-7a19dd304984"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("b5c240ca-c058-4195-88b0-4dc02aec7463"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("18759c66-ed37-4445-9fa4-7163fe74ace5"), new Guid("fbfc4775-6074-4dd0-803f-192d426f70ae"), "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of \"de Finibus Bonorum et Malorum\" (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, \"Lorem ipsum dolor sit amet..\", comes from a line in section 1.10.32.\r\n\r\nThe standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.", "Admin Test", new DateTime(2024, 4, 9, 23, 14, 34, 33, DateTimeKind.Local).AddTicks(4011), null, null, new Guid("717ba245-2468-4334-97d4-2b87e77351a5"), false, null, null, "Derinlemesine C#", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), 15 },
                    { new Guid("6a1f9744-d8b2-4996-90ac-c361d27452da"), new Guid("45db3e81-c868-459e-8234-f14913d9ea62"), "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of \"de Finibus Bonorum et Malorum\" (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, \"Lorem ipsum dolor sit amet..\", comes from a line in section 1.10.32.\r\n\r\nThe standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.", "Admin Test", new DateTime(2024, 4, 9, 23, 14, 34, 33, DateTimeKind.Local).AddTicks(4071), null, null, new Guid("a4c63d74-3640-4e31-a71c-6b24b1412cee"), false, null, null, "C++ Data struct", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), 45 },
                    { new Guid("b8fc2583-9300-41a5-88a3-802288d80d16"), new Guid("f9cd51ae-20df-4dd7-bc5e-c9e58d6da613"), "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of \"de Finibus Bonorum et Malorum\" (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, \"Lorem ipsum dolor sit amet..\", comes from a line in section 1.10.32.\r\n\r\nThe standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.", "Admin Test", new DateTime(2024, 4, 9, 23, 14, 34, 33, DateTimeKind.Local).AddTicks(4004), null, null, new Guid("b93e0a19-ea35-4121-985a-5d2e33720de4"), false, null, null, "Asp.net core", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), 30 },
                    { new Guid("f65d76f2-c658-43eb-acb0-fa5d74a4d8c6"), new Guid("2f635d41-ad10-4f31-a708-38d5f035e69b"), "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of \"de Finibus Bonorum et Malorum\" (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, \"Lorem ipsum dolor sit amet..\", comes from a line in section 1.10.32.\r\n\r\nThe standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.", "Admin Test", new DateTime(2024, 4, 9, 23, 14, 34, 33, DateTimeKind.Local).AddTicks(4058), null, null, new Guid("52d13349-e46b-4d2e-9053-92282b5f4911"), false, null, null, "Javascript Öğren", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), 35 },
                    { new Guid("fded1529-c63d-424a-b536-fe6e14510fc0"), new Guid("db9c2a0b-213e-4cb8-8f28-14ebc5677783"), "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of \"de Finibus Bonorum et Malorum\" (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, \"Lorem ipsum dolor sit amet..\", comes from a line in section 1.10.32.\r\n\r\nThe standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.", "Admin Test", new DateTime(2024, 4, 9, 23, 14, 34, 33, DateTimeKind.Local).AddTicks(4076), null, null, new Guid("f222587b-cbb5-49d2-bde4-973a2879bb67"), false, null, null, "FullStack Development", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), 105 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1348ca82-0ea9-4de9-a08e-f21fc9f5906a"),
                column: "ConcurrencyStamp",
                value: "a5d6bef7-bb32-4f5d-a28a-507483607208");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("ac2bfb1d-dfaa-4057-bb71-b5718a312cd9"),
                column: "ConcurrencyStamp",
                value: "38caae4d-e715-44a1-aa66-ba5954da7a02");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d0bc7ad4-d344-4f5e-a18c-a9538730f007"),
                column: "ConcurrencyStamp",
                value: "b5a5fe83-d2f5-4d9a-96bb-e9b62a5056f5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5255af55-2a0a-4307-8e43-12e9bd48e859", "AQAAAAIAAYagAAAAEH31fu7huNCaeyrNtWFdfeCbZ4HxlxAVv6ljIpyhq1VKQza2W/abkaT2EbgSWoGsbg==", "58fd4c42-77d5-4795-a901-e612092f93cb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f41b8aa2-50ef-4e27-a9e8-4af7b5b8892f", "AQAAAAIAAYagAAAAED/JjbhLu3ZBqgLkgp4NpDkjeWIWrV9Out8VRWf5SMvOQ1bDpTRvHdWU2FcHJSwS/Q==", "f8068990-ce76-4cff-bbaf-4d961d0e1946" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2f635d41-ad10-4f31-a708-38d5f035e69b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 9, 23, 14, 34, 33, DateTimeKind.Local).AddTicks(5487));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("45db3e81-c868-459e-8234-f14913d9ea62"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 9, 23, 14, 34, 33, DateTimeKind.Local).AddTicks(5489));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("db9c2a0b-213e-4cb8-8f28-14ebc5677783"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 9, 23, 14, 34, 33, DateTimeKind.Local).AddTicks(5493));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f9cd51ae-20df-4dd7-bc5e-c9e58d6da613"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 9, 23, 14, 34, 33, DateTimeKind.Local).AddTicks(5479));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fbfc4775-6074-4dd0-803f-192d426f70ae"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 9, 23, 14, 34, 33, DateTimeKind.Local).AddTicks(5484));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("52d13349-e46b-4d2e-9053-92282b5f4911"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 9, 23, 14, 34, 33, DateTimeKind.Local).AddTicks(6719));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("717ba245-2468-4334-97d4-2b87e77351a5"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 9, 23, 14, 34, 33, DateTimeKind.Local).AddTicks(6716));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("a4c63d74-3640-4e31-a71c-6b24b1412cee"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 9, 23, 14, 34, 33, DateTimeKind.Local).AddTicks(6721));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("b93e0a19-ea35-4121-985a-5d2e33720de4"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 9, 23, 14, 34, 33, DateTimeKind.Local).AddTicks(6712));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("f222587b-cbb5-49d2-bde4-973a2879bb67"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 9, 23, 14, 34, 33, DateTimeKind.Local).AddTicks(6724));
        }
    }
}
