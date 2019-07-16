using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RISKZERO.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RISKZERO.Infra.Data.EntityConfig
{
    public class AgendaConfiguration : IEntityTypeConfiguration<Agenda>
    {
        public void Configure(EntityTypeBuilder<Agenda> builder)
        {
            builder.HasKey(a => a.ID);
        }
    }
}
