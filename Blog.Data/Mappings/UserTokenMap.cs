﻿using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Mappings
{
    public class UserTokenMap : IEntityTypeConfiguration<AppUserToken>
    {
        
        public void Configure(EntityTypeBuilder<AppUserToken> builder)
        {
            // Composite primary key consisting of the UserId, LoginProvider and Name
            builder.HasKey(t => new { t.UserId, t.LoginProvider, t.Name });

            // Limit the size of the composite key columns due to common DB restrictions
            builder.Property(t => t.LoginProvider).HasMaxLength(256);
            builder.Property(t => t.Name).HasMaxLength(256);

            // Maps to the AspNetUserTokens table
            builder.ToTable("AspNetUserTokens");
        }
    }
}
