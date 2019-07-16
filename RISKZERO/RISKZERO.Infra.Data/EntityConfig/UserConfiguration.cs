using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RISKZERO.Domain.Entities;
using System;

namespace RISKZERO.Infra.Data.EntityConfig
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.ID);
            builder.Property(u => u.FullName)
                .HasMaxLength(200)
                .IsRequired();
            builder.Property(u => u.CRP)
                .HasMaxLength(15)
                .IsRequired();
        }
    }
}
