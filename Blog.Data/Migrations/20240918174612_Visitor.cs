using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog.Data.Migrations
{
    /// <inheritdoc />
    public partial class Visitor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Images_ImageId",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("3cf84d1b-493e-4c62-9511-145b39ab28c0"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("81914f8a-0714-4a68-8a24-3f4c9195d366"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("822914d9-48d9-45be-a778-79b018c30ccf"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("a5f76a44-30ce-46df-b7e7-0ce24ed9f284"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("b026d241-fec7-4e3b-934b-a30efeaf1947"));

            migrationBuilder.AlterColumn<Guid>(
                name: "ImageId",
                table: "AspNetUsers",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.CreateTable(
                name: "Visitor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IpAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserAgent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visitor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ArticleVisitor",
                columns: table => new
                {
                    ArticleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VisitorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleVisitor", x => new { x.ArticleId, x.VisitorId });
                    table.ForeignKey(
                        name: "FK_ArticleVisitor_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticleVisitor_Visitor_VisitorId",
                        column: x => x.VisitorId,
                        principalTable: "Visitor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("0181fbaa-52c9-4884-ae91-50bac03ed1e9"), new Guid("f9cd51ae-20df-4dd7-bc5e-c9e58d6da613"), "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of \"de Finibus Bonorum et Malorum\" (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, \"Lorem ipsum dolor sit amet..\", comes from a line in section 1.10.32.\r\n\r\nThe standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.", "Admin Test", new DateTime(2024, 9, 18, 20, 46, 11, 777, DateTimeKind.Local).AddTicks(4746), null, null, new Guid("b93e0a19-ea35-4121-985a-5d2e33720de4"), false, null, null, "Asp.net core", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), 30 },
                    { new Guid("0e4102e6-8ee4-4419-85c5-f2e1bb9f20cc"), new Guid("45db3e81-c868-459e-8234-f14913d9ea62"), "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of \"de Finibus Bonorum et Malorum\" (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, \"Lorem ipsum dolor sit amet..\", comes from a line in section 1.10.32.\r\n\r\nThe standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.", "Admin Test", new DateTime(2024, 9, 18, 20, 46, 11, 777, DateTimeKind.Local).AddTicks(4774), null, null, new Guid("a4c63d74-3640-4e31-a71c-6b24b1412cee"), false, null, null, "C++ Data struct", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), 45 },
                    { new Guid("1f7c4951-36a9-4c88-ac04-804f29820aca"), new Guid("db9c2a0b-213e-4cb8-8f28-14ebc5677783"), "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of \"de Finibus Bonorum et Malorum\" (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, \"Lorem ipsum dolor sit amet..\", comes from a line in section 1.10.32.\r\n\r\nThe standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.", "Admin Test", new DateTime(2024, 9, 18, 20, 46, 11, 777, DateTimeKind.Local).AddTicks(4779), null, null, new Guid("f222587b-cbb5-49d2-bde4-973a2879bb67"), false, null, null, "FullStack Development", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), 105 },
                    { new Guid("86e369fb-89af-4a27-809e-a083ada23328"), new Guid("2f635d41-ad10-4f31-a708-38d5f035e69b"), "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of \"de Finibus Bonorum et Malorum\" (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, \"Lorem ipsum dolor sit amet..\", comes from a line in section 1.10.32.\r\n\r\nThe standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.", "Admin Test", new DateTime(2024, 9, 18, 20, 46, 11, 777, DateTimeKind.Local).AddTicks(4759), null, null, new Guid("52d13349-e46b-4d2e-9053-92282b5f4911"), false, null, null, "Javascript Öğren", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), 35 },
                    { new Guid("9e3a5a2a-a18d-4736-9fae-8f18889bd638"), new Guid("fbfc4775-6074-4dd0-803f-192d426f70ae"), "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of \"de Finibus Bonorum et Malorum\" (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, \"Lorem ipsum dolor sit amet..\", comes from a line in section 1.10.32.\r\n\r\nThe standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.", "Admin Test", new DateTime(2024, 9, 18, 20, 46, 11, 777, DateTimeKind.Local).AddTicks(4754), null, null, new Guid("717ba245-2468-4334-97d4-2b87e77351a5"), false, null, null, "Derinlemesine C#", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1348ca82-0ea9-4de9-a08e-f21fc9f5906a"),
                column: "ConcurrencyStamp",
                value: "32a5f4ac-0f3d-4c3a-a983-7221b084ac36");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("ac2bfb1d-dfaa-4057-bb71-b5718a312cd9"),
                column: "ConcurrencyStamp",
                value: "5d3a88f9-5529-4c7b-b407-19ea5d27c3a7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d0bc7ad4-d344-4f5e-a18c-a9538730f007"),
                column: "ConcurrencyStamp",
                value: "38c34760-495e-4790-b388-00640e451795");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ddf765f0-a15f-41a7-950f-b3c7c395011b", "AQAAAAIAAYagAAAAELPMPkG+HRkiwmgJXcIn9eePeAyGrzuZmxTYmzxtbvjT61BwmkhNCAj3GaPVUbxGHw==", "59598582-b85c-4398-9233-730d27b199db" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "309b128a-4bb6-4b70-86e5-406897942be2", "AQAAAAIAAYagAAAAEBLJRfeesoRpHFr8zdrvxrEdmwq3VQF1u+tgxbRMDA8wosi6QQEFMnoe0rciZZBVCQ==", "926a36d6-4edb-457a-a8b1-0568270f8845" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2f635d41-ad10-4f31-a708-38d5f035e69b"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 18, 20, 46, 11, 777, DateTimeKind.Local).AddTicks(9397));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("45db3e81-c868-459e-8234-f14913d9ea62"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 18, 20, 46, 11, 777, DateTimeKind.Local).AddTicks(9400));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("db9c2a0b-213e-4cb8-8f28-14ebc5677783"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 18, 20, 46, 11, 777, DateTimeKind.Local).AddTicks(9408));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f9cd51ae-20df-4dd7-bc5e-c9e58d6da613"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 18, 20, 46, 11, 777, DateTimeKind.Local).AddTicks(9391));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fbfc4775-6074-4dd0-803f-192d426f70ae"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 18, 20, 46, 11, 777, DateTimeKind.Local).AddTicks(9395));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("52d13349-e46b-4d2e-9053-92282b5f4911"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 18, 20, 46, 11, 778, DateTimeKind.Local).AddTicks(735));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("717ba245-2468-4334-97d4-2b87e77351a5"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 18, 20, 46, 11, 778, DateTimeKind.Local).AddTicks(732));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("a4c63d74-3640-4e31-a71c-6b24b1412cee"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 18, 20, 46, 11, 778, DateTimeKind.Local).AddTicks(738));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("b93e0a19-ea35-4121-985a-5d2e33720de4"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 18, 20, 46, 11, 778, DateTimeKind.Local).AddTicks(728));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("f222587b-cbb5-49d2-bde4-973a2879bb67"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 18, 20, 46, 11, 778, DateTimeKind.Local).AddTicks(741));

            migrationBuilder.CreateIndex(
                name: "IX_ArticleVisitor_VisitorId",
                table: "ArticleVisitor",
                column: "VisitorId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Images_ImageId",
                table: "AspNetUsers",
                column: "ImageId",
                principalTable: "Images",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Images_ImageId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "ArticleVisitor");

            migrationBuilder.DropTable(
                name: "Visitor");

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("0181fbaa-52c9-4884-ae91-50bac03ed1e9"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("0e4102e6-8ee4-4419-85c5-f2e1bb9f20cc"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("1f7c4951-36a9-4c88-ac04-804f29820aca"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("86e369fb-89af-4a27-809e-a083ada23328"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("9e3a5a2a-a18d-4736-9fae-8f18889bd638"));

            migrationBuilder.AlterColumn<Guid>(
                name: "ImageId",
                table: "AspNetUsers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("3cf84d1b-493e-4c62-9511-145b39ab28c0"), new Guid("2f635d41-ad10-4f31-a708-38d5f035e69b"), "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of \"de Finibus Bonorum et Malorum\" (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, \"Lorem ipsum dolor sit amet..\", comes from a line in section 1.10.32.\r\n\r\nThe standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.", "Admin Test", new DateTime(2024, 9, 17, 7, 52, 20, 460, DateTimeKind.Local).AddTicks(4453), null, null, new Guid("52d13349-e46b-4d2e-9053-92282b5f4911"), false, null, null, "Javascript Öğren", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), 35 },
                    { new Guid("81914f8a-0714-4a68-8a24-3f4c9195d366"), new Guid("45db3e81-c868-459e-8234-f14913d9ea62"), "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of \"de Finibus Bonorum et Malorum\" (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, \"Lorem ipsum dolor sit amet..\", comes from a line in section 1.10.32.\r\n\r\nThe standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.", "Admin Test", new DateTime(2024, 9, 17, 7, 52, 20, 460, DateTimeKind.Local).AddTicks(4458), null, null, new Guid("a4c63d74-3640-4e31-a71c-6b24b1412cee"), false, null, null, "C++ Data struct", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), 45 },
                    { new Guid("822914d9-48d9-45be-a778-79b018c30ccf"), new Guid("db9c2a0b-213e-4cb8-8f28-14ebc5677783"), "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of \"de Finibus Bonorum et Malorum\" (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, \"Lorem ipsum dolor sit amet..\", comes from a line in section 1.10.32.\r\n\r\nThe standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.", "Admin Test", new DateTime(2024, 9, 17, 7, 52, 20, 460, DateTimeKind.Local).AddTicks(4464), null, null, new Guid("f222587b-cbb5-49d2-bde4-973a2879bb67"), false, null, null, "FullStack Development", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), 105 },
                    { new Guid("a5f76a44-30ce-46df-b7e7-0ce24ed9f284"), new Guid("f9cd51ae-20df-4dd7-bc5e-c9e58d6da613"), "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of \"de Finibus Bonorum et Malorum\" (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, \"Lorem ipsum dolor sit amet..\", comes from a line in section 1.10.32.\r\n\r\nThe standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.", "Admin Test", new DateTime(2024, 9, 17, 7, 52, 20, 460, DateTimeKind.Local).AddTicks(4423), null, null, new Guid("b93e0a19-ea35-4121-985a-5d2e33720de4"), false, null, null, "Asp.net core", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), 30 },
                    { new Guid("b026d241-fec7-4e3b-934b-a30efeaf1947"), new Guid("fbfc4775-6074-4dd0-803f-192d426f70ae"), "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of \"de Finibus Bonorum et Malorum\" (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, \"Lorem ipsum dolor sit amet..\", comes from a line in section 1.10.32.\r\n\r\nThe standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.", "Admin Test", new DateTime(2024, 9, 17, 7, 52, 20, 460, DateTimeKind.Local).AddTicks(4436), null, null, new Guid("717ba245-2468-4334-97d4-2b87e77351a5"), false, null, null, "Derinlemesine C#", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1348ca82-0ea9-4de9-a08e-f21fc9f5906a"),
                column: "ConcurrencyStamp",
                value: "83036b79-6191-4949-a3bc-f3e96b692687");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("ac2bfb1d-dfaa-4057-bb71-b5718a312cd9"),
                column: "ConcurrencyStamp",
                value: "fde267d3-073b-4e72-893c-e6ef7fb24190");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d0bc7ad4-d344-4f5e-a18c-a9538730f007"),
                column: "ConcurrencyStamp",
                value: "d31157ad-49dc-4a84-ac6c-2cb22bf50719");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9822245-2646-4795-a57d-385052a76baa", "AQAAAAIAAYagAAAAEPYBmHwP7YufoF8mgi4dMhN+ZQOr/YQOVXCQlFTeYXA4tCHGZ5fyp6nV73JJbKRwWw==", "fbd3e9ac-9c74-4328-9e46-833e51fdc909" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a58d67d3-22bc-48c2-837b-869517a64285", "AQAAAAIAAYagAAAAELOw8eHpL/q+AMvVKALiJWKQvSQsjFEPAnZZQb38FqzpTSO66ht7uTt1FyUjbYR74Q==", "34f902b3-6bdd-472e-a084-208a0b0094eb" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2f635d41-ad10-4f31-a708-38d5f035e69b"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 17, 7, 52, 20, 460, DateTimeKind.Local).AddTicks(6246));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("45db3e81-c868-459e-8234-f14913d9ea62"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 17, 7, 52, 20, 460, DateTimeKind.Local).AddTicks(6250));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("db9c2a0b-213e-4cb8-8f28-14ebc5677783"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 17, 7, 52, 20, 460, DateTimeKind.Local).AddTicks(6253));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f9cd51ae-20df-4dd7-bc5e-c9e58d6da613"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 17, 7, 52, 20, 460, DateTimeKind.Local).AddTicks(6229));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fbfc4775-6074-4dd0-803f-192d426f70ae"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 17, 7, 52, 20, 460, DateTimeKind.Local).AddTicks(6238));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("52d13349-e46b-4d2e-9053-92282b5f4911"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 17, 7, 52, 20, 460, DateTimeKind.Local).AddTicks(7625));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("717ba245-2468-4334-97d4-2b87e77351a5"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 17, 7, 52, 20, 460, DateTimeKind.Local).AddTicks(7622));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("a4c63d74-3640-4e31-a71c-6b24b1412cee"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 17, 7, 52, 20, 460, DateTimeKind.Local).AddTicks(7629));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("b93e0a19-ea35-4121-985a-5d2e33720de4"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 17, 7, 52, 20, 460, DateTimeKind.Local).AddTicks(7616));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("f222587b-cbb5-49d2-bde4-973a2879bb67"),
                column: "CreatedDate",
                value: new DateTime(2024, 9, 17, 7, 52, 20, 460, DateTimeKind.Local).AddTicks(7632));

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Images_ImageId",
                table: "AspNetUsers",
                column: "ImageId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
