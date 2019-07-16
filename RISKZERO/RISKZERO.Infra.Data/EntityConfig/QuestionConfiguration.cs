using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RISKZERO.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RISKZERO.Infra.Data.EntityConfig
{
    public class QuestionConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.HasKey(q => q.ID);
        }
    }
}
