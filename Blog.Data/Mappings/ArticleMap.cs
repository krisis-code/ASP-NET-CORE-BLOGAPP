using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Mappings
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasData(new Article
            {
                Id = Guid.NewGuid(),
                Title = "Asp.net core",

                Content = "Contrary to popular belief, Lorem Ipsum is not simply random text." +
                           " It has roots in a piece of classical Latin literature from 45 BC, making it " +
                           "over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney " +
                           "College in Virginia, looked up one of the more obscure Latin words, consectetur," +
                           " from a Lorem Ipsum passage, and going through the cites of the word in classical" +
                           " literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32" +
                           " and 1.10.33 of \"de Finibus Bonorum et Malorum\" (The Extremes of Good and Evil) by Cicero," +
                           " written in 45 BC. This book is a treatise on the theory of ethics, very popular during the " +
                           "Renaissance. The first line of Lorem Ipsum, \"Lorem ipsum dolor sit amet..\", comes from a line" +
                           " in section 1.10.32.\r\n\r\nThe standard chunk of Lorem Ipsum used since the 1500s is reproduced" +
                           " below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" " +
                           "by Cicero are also reproduced in their exact original form, accompanied by English versions from " +
                           "the 1914 translation by H. Rackham.",
                
                ViewCount = 30 ,

                Category = new Category 
                {
                    Id = Guid.Parse("F9CD51AE-20DF-4DD7-BC5E-C9E58D6DA613"),
                    Name = "Asp.net core",
                    CreatedBy = "Admin Test",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                },
                CategoryId = Guid.Parse("F9CD51AE-20DF-4DD7-BC5E-C9E58D6DA613"),
                Image = new Image 
                {
                    Id = Guid.NewGuid(),
                    FileName = "images/1",
                    FileType = "png",
                    CreatedBy = "Admin Test",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                },
                ImageId = Guid.Parse("B93E0A19-EA35-4121-985A-5D2E33720DE4"),
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            
            },
            new Article
            {
                Id = Guid.NewGuid(),
                Title = "Derinlemesine C#",

                Content = "Contrary to popular belief, Lorem Ipsum is not simply random text." +
                           " It has roots in a piece of classical Latin literature from 45 BC, making it " +
                           "over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney " +
                           "College in Virginia, looked up one of the more obscure Latin words, consectetur," +
                           " from a Lorem Ipsum passage, and going through the cites of the word in classical" +
                           " literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32" +
                           " and 1.10.33 of \"de Finibus Bonorum et Malorum\" (The Extremes of Good and Evil) by Cicero," +
                           " written in 45 BC. This book is a treatise on the theory of ethics, very popular during the " +
                           "Renaissance. The first line of Lorem Ipsum, \"Lorem ipsum dolor sit amet..\", comes from a line" +
                           " in section 1.10.32.\r\n\r\nThe standard chunk of Lorem Ipsum used since the 1500s is reproduced" +
                           " below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" " +
                           "by Cicero are also reproduced in their exact original form, accompanied by English versions from " +
                           "the 1914 translation by H. Rackham.",
                
                ViewCount = 15,

                Category = new Category
                {
                    Id = Guid.Parse("FBFC4775-6074-4DD0-803F-192D426F70AE"),
                    Name = "Derinlemesine C#",
                    CreatedBy = "Admin Test",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                },
                CategoryId = Guid.Parse("FBFC4775-6074-4DD0-803F-192D426F70AE"),
                Image = new Image
                {
                    Id = Guid.NewGuid(),
                    FileName = "images/23",
                    FileType = "png",
                    CreatedBy = "Admin Test",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                },
                ImageId= Guid.Parse("717BA245-2468-4334-97D4-2B87E77351A5"),
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false


            },
            new Article
            {
                Id = Guid.NewGuid(),
                Title = "Javascript Öğren",

                Content = "Contrary to popular belief, Lorem Ipsum is not simply random text." +
                           " It has roots in a piece of classical Latin literature from 45 BC, making it " +
                           "over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney " +
                           "College in Virginia, looked up one of the more obscure Latin words, consectetur," +
                           " from a Lorem Ipsum passage, and going through the cites of the word in classical" +
                           " literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32" +
                           " and 1.10.33 of \"de Finibus Bonorum et Malorum\" (The Extremes of Good and Evil) by Cicero," +
                           " written in 45 BC. This book is a treatise on the theory of ethics, very popular during the " +
                           "Renaissance. The first line of Lorem Ipsum, \"Lorem ipsum dolor sit amet..\", comes from a line" +
                           " in section 1.10.32.\r\n\r\nThe standard chunk of Lorem Ipsum used since the 1500s is reproduced" +
                           " below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" " +
                           "by Cicero are also reproduced in their exact original form, accompanied by English versions from " +
                           "the 1914 translation by H. Rackham.",
                
                ViewCount = 35,

                Category = new Category
                {
                    Id = Guid.Parse("2F635D41-AD10-4F31-A708-38D5F035E69B"),
                    Name = "Javascript Öğren",
                    CreatedBy = "Admin Test",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                },
                CategoryId = Guid.Parse("2F635D41-AD10-4F31-A708-38D5F035E69B"),
                Image = new Image
                {
                    Id = Guid.NewGuid(),
                    FileName = "images/3",
                    FileType = "png",
                    CreatedBy = "Admin Test",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                },
                ImageId = Guid.Parse("52D13349-E46B-4D2E-9053-92282B5F4911"),
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false

            },
            new Article
            {
                Id = Guid.NewGuid(),
                Title = "C++ Data struct",

                Content = "Contrary to popular belief, Lorem Ipsum is not simply random text." +
                           " It has roots in a piece of classical Latin literature from 45 BC, making it " +
                           "over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney " +
                           "College in Virginia, looked up one of the more obscure Latin words, consectetur," +
                           " from a Lorem Ipsum passage, and going through the cites of the word in classical" +
                           " literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32" +
                           " and 1.10.33 of \"de Finibus Bonorum et Malorum\" (The Extremes of Good and Evil) by Cicero," +
                           " written in 45 BC. This book is a treatise on the theory of ethics, very popular during the " +
                           "Renaissance. The first line of Lorem Ipsum, \"Lorem ipsum dolor sit amet..\", comes from a line" +
                           " in section 1.10.32.\r\n\r\nThe standard chunk of Lorem Ipsum used since the 1500s is reproduced" +
                           " below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" " +
                           "by Cicero are also reproduced in their exact original form, accompanied by English versions from " +
                           "the 1914 translation by H. Rackham.",
               
                ViewCount = 45,

                Category = new Category
                {
                    Id = Guid.Parse("45DB3E81-C868-459E-8234-F14913D9EA62"),
                    Name = "C++ Data struct",
                    CreatedBy = "Admin Test",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                },
                CategoryId = Guid.Parse("45DB3E81-C868-459E-8234-F14913D9EA62"),
                Image = new Image
                {
                    Id = Guid.NewGuid(),
                    FileName = "images/4",
                    FileType = "png",
                    CreatedBy = "Admin Test",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                },
                ImageId = Guid.Parse("A4C63D74-3640-4E31-A71C-6B24B1412CEE"),
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false

            },
            new Article
            {
                Id = Guid.NewGuid(),
                Title = "FullStack Development",

                Content = "Contrary to popular belief, Lorem Ipsum is not simply random text." +
                           " It has roots in a piece of classical Latin literature from 45 BC, making it " +
                           "over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney " +
                           "College in Virginia, looked up one of the more obscure Latin words, consectetur," +
                           " from a Lorem Ipsum passage, and going through the cites of the word in classical" +
                           " literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32" +
                           " and 1.10.33 of \"de Finibus Bonorum et Malorum\" (The Extremes of Good and Evil) by Cicero," +
                           " written in 45 BC. This book is a treatise on the theory of ethics, very popular during the " +
                           "Renaissance. The first line of Lorem Ipsum, \"Lorem ipsum dolor sit amet..\", comes from a line" +
                           " in section 1.10.32.\r\n\r\nThe standard chunk of Lorem Ipsum used since the 1500s is reproduced" +
                           " below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" " +
                           "by Cicero are also reproduced in their exact original form, accompanied by English versions from " +
                           "the 1914 translation by H. Rackham.",
                
                ViewCount = 105,

                Category = new Category
                {
                    Id = Guid.Parse("DB9C2A0B-213E-4CB8-8F28-14EBC5677783"),
                    Name = "FullStack Development",
                    CreatedBy = "Admin Test",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                },
                CategoryId = Guid.Parse("DB9C2A0B-213E-4CB8-8F28-14EBC5677783"),
                Image = new Image
                {
                    Id = Guid.NewGuid(),
                    FileName = "images/5",
                    FileType = "png",
                    CreatedBy = "Admin Test",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                },
                ImageId = Guid.Parse("F222587B-CBB5-49D2-BDE4-973A2879BB67"),
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            });
        }
    }
}
