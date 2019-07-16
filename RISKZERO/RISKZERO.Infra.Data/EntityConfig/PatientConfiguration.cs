using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RISKZERO.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RISKZERO.Infra.Data.EntityConfig
{
    public class PatientConfiguration : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.HasKey(p => p.ID);
            builder.Property(p => p.CPF)
                .HasMaxLength(11)
                .IsRequired();
            builder.Property(p => p.Email)
                .IsRequired();
        }
    }
}
