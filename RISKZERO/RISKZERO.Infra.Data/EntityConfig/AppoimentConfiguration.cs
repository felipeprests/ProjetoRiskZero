using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RISKZERO.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RISKZERO.Infra.Data.EntityConfig
{
    public class AppoimentConfiguration : IEntityTypeConfiguration<Appoiment>
    {
        public void Configure(EntityTypeBuilder<Appoiment> builder)
        {
            builder.HasKey(a => a.ID);
            builder.Property(a => a.PatientID)
                .IsRequired();
            builder.Property(a => a.UserID)
                .IsRequired();
        }
    }
}
