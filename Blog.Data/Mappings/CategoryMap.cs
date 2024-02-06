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
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category
            {
                Id = Guid.Parse("F9CD51AE-20DF-4DD7-BC5E-C9E58D6DA613"),
                Name = "Asp.net core",
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            },
            new Category
            {
                Id = Guid.Parse("FBFC4775-6074-4DD0-803F-192D426F70AE"),
                Name = "Derinlemesine C#",
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            },
            new Category
            {
                Id = Guid.Parse("2F635D41-AD10-4F31-A708-38D5F035E69B"),
                Name = "Javascript Öğren",
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            },
            new Category 
            {
                Id = Guid.Parse("45DB3E81-C868-459E-8234-F14913D9EA62"),
                Name = "C++ Data struct",
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            },
            new Category
            {
                Id = Guid.Parse("DB9C2A0B-213E-4CB8-8F28-14EBC5677783"),
                Name = "FullStack Development",
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            });
        }
    }
}
