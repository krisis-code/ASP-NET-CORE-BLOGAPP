﻿// <auto-generated />
using System;
using Blog.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Blog.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Blog.Entity.Entities.Article", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ImageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ViewCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ImageId");

                    b.ToTable("Articles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("cc7860ac-75ed-4f8d-92db-949993ef4688"),
                            CategoryId = new Guid("f9cd51ae-20df-4dd7-bc5e-c9e58d6da613"),
                            Content = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of \"de Finibus Bonorum et Malorum\" (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, \"Lorem ipsum dolor sit amet..\", comes from a line in section 1.10.32.\r\n\r\nThe standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2024, 2, 7, 0, 48, 1, 111, DateTimeKind.Local).AddTicks(1833),
                            ImageId = new Guid("b93e0a19-ea35-4121-985a-5d2e33720de4"),
                            IsDeleted = false,
                            Title = "Asp.net core",
                            ViewCount = 30
                        },
                        new
                        {
                            Id = new Guid("3cb1482a-1379-4c46-a68f-5e34ef5cd4c4"),
                            CategoryId = new Guid("fbfc4775-6074-4dd0-803f-192d426f70ae"),
                            Content = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of \"de Finibus Bonorum et Malorum\" (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, \"Lorem ipsum dolor sit amet..\", comes from a line in section 1.10.32.\r\n\r\nThe standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2024, 2, 7, 0, 48, 1, 111, DateTimeKind.Local).AddTicks(1839),
                            ImageId = new Guid("717ba245-2468-4334-97d4-2b87e77351a5"),
                            IsDeleted = false,
                            Title = "Derinlemesine C#",
                            ViewCount = 15
                        },
                        new
                        {
                            Id = new Guid("7c0dfdf0-341e-41b1-908e-9051e3a8478e"),
                            CategoryId = new Guid("2f635d41-ad10-4f31-a708-38d5f035e69b"),
                            Content = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of \"de Finibus Bonorum et Malorum\" (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, \"Lorem ipsum dolor sit amet..\", comes from a line in section 1.10.32.\r\n\r\nThe standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2024, 2, 7, 0, 48, 1, 111, DateTimeKind.Local).AddTicks(1844),
                            ImageId = new Guid("52d13349-e46b-4d2e-9053-92282b5f4911"),
                            IsDeleted = false,
                            Title = "Javascript Öğren",
                            ViewCount = 35
                        },
                        new
                        {
                            Id = new Guid("98b560b7-e9aa-47a9-84e1-0e4da8f55164"),
                            CategoryId = new Guid("45db3e81-c868-459e-8234-f14913d9ea62"),
                            Content = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of \"de Finibus Bonorum et Malorum\" (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, \"Lorem ipsum dolor sit amet..\", comes from a line in section 1.10.32.\r\n\r\nThe standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2024, 2, 7, 0, 48, 1, 111, DateTimeKind.Local).AddTicks(1861),
                            ImageId = new Guid("a4c63d74-3640-4e31-a71c-6b24b1412cee"),
                            IsDeleted = false,
                            Title = "C++ Data struct",
                            ViewCount = 45
                        },
                        new
                        {
                            Id = new Guid("9bf53df2-a888-4ef8-9ce0-503200e49f5e"),
                            CategoryId = new Guid("db9c2a0b-213e-4cb8-8f28-14ebc5677783"),
                            Content = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of \"de Finibus Bonorum et Malorum\" (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, \"Lorem ipsum dolor sit amet..\", comes from a line in section 1.10.32.\r\n\r\nThe standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2024, 2, 7, 0, 48, 1, 111, DateTimeKind.Local).AddTicks(1865),
                            ImageId = new Guid("f222587b-cbb5-49d2-bde4-973a2879bb67"),
                            IsDeleted = false,
                            Title = "FullStack Development",
                            ViewCount = 105
                        });
                });

            modelBuilder.Entity("Blog.Entity.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f9cd51ae-20df-4dd7-bc5e-c9e58d6da613"),
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2024, 2, 7, 0, 48, 1, 111, DateTimeKind.Local).AddTicks(3249),
                            IsDeleted = false,
                            Name = "Asp.net core"
                        },
                        new
                        {
                            Id = new Guid("fbfc4775-6074-4dd0-803f-192d426f70ae"),
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2024, 2, 7, 0, 48, 1, 111, DateTimeKind.Local).AddTicks(3253),
                            IsDeleted = false,
                            Name = "Derinlemesine C#"
                        },
                        new
                        {
                            Id = new Guid("2f635d41-ad10-4f31-a708-38d5f035e69b"),
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2024, 2, 7, 0, 48, 1, 111, DateTimeKind.Local).AddTicks(3256),
                            IsDeleted = false,
                            Name = "Javascript Öğren"
                        },
                        new
                        {
                            Id = new Guid("45db3e81-c868-459e-8234-f14913d9ea62"),
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2024, 2, 7, 0, 48, 1, 111, DateTimeKind.Local).AddTicks(3259),
                            IsDeleted = false,
                            Name = "C++ Data struct"
                        },
                        new
                        {
                            Id = new Guid("db9c2a0b-213e-4cb8-8f28-14ebc5677783"),
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2024, 2, 7, 0, 48, 1, 111, DateTimeKind.Local).AddTicks(3267),
                            IsDeleted = false,
                            Name = "FullStack Development"
                        });
                });

            modelBuilder.Entity("Blog.Entity.Entities.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Images");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b93e0a19-ea35-4121-985a-5d2e33720de4"),
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2024, 2, 7, 0, 48, 1, 111, DateTimeKind.Local).AddTicks(4492),
                            FileName = "images/1",
                            FileType = "png",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = new Guid("717ba245-2468-4334-97d4-2b87e77351a5"),
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2024, 2, 7, 0, 48, 1, 111, DateTimeKind.Local).AddTicks(4497),
                            FileName = "images/23",
                            FileType = "png",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = new Guid("52d13349-e46b-4d2e-9053-92282b5f4911"),
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2024, 2, 7, 0, 48, 1, 111, DateTimeKind.Local).AddTicks(4499),
                            FileName = "images/3",
                            FileType = "png",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = new Guid("a4c63d74-3640-4e31-a71c-6b24b1412cee"),
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2024, 2, 7, 0, 48, 1, 111, DateTimeKind.Local).AddTicks(4502),
                            FileName = "images/4",
                            FileType = "png",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = new Guid("f222587b-cbb5-49d2-bde4-973a2879bb67"),
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2024, 2, 7, 0, 48, 1, 111, DateTimeKind.Local).AddTicks(4505),
                            FileName = "images/5",
                            FileType = "png",
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("Blog.Entity.Entities.Article", b =>
                {
                    b.HasOne("Blog.Entity.Entities.Category", "Category")
                        .WithMany("Articles")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Blog.Entity.Entities.Image", "Image")
                        .WithMany("Articles")
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Image");
                });

            modelBuilder.Entity("Blog.Entity.Entities.Category", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("Blog.Entity.Entities.Image", b =>
                {
                    b.Navigation("Articles");
                });
#pragma warning restore 612, 618
        }
    }
}
