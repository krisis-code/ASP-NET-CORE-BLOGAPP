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
                    Id = Guid.NewGuid(),
                    Name = "Asp.net core",
                    CreatedBy = "Admin Test",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                },
                Image = new Image 
                {
                    Id = Guid.NewGuid(),
                    FileName = "images/1",
                    FileType = "png",
                    CreatedBy = "Admin Test",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                },
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
                    Id = Guid.NewGuid(),
                    Name = "Derinlemesine C#",
                    CreatedBy = "Admin Test",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                },
                Image = new Image
                {
                    Id = Guid.NewGuid(),
                    FileName = "images/23",
                    FileType = "png",
                    CreatedBy = "Admin Test",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                },
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
                    Id = Guid.NewGuid(),
                    Name = "Javascript Öğren",
                    CreatedBy = "Admin Test",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                },
                Image = new Image
                {
                    Id = Guid.NewGuid(),
                    FileName = "images/3",
                    FileType = "png",
                    CreatedBy = "Admin Test",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                },
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
                    Id = Guid.NewGuid(),
                    Name = "C++ Data struct",
                    CreatedBy = "Admin Test",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                },
                Image = new Image
                {
                    Id = Guid.NewGuid(),
                    FileName = "images/4",
                    FileType = "png",
                    CreatedBy = "Admin Test",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                },
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
                    Id = Guid.NewGuid(),
                    Name = "FullStack Development",
                    CreatedBy = "Admin Test",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                },
                Image = new Image
                {
                    Id = Guid.NewGuid(),
                    FileName = "images/5",
                    FileType = "png",
                    CreatedBy = "Admin Test",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                },
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            });
        }
    }
}
