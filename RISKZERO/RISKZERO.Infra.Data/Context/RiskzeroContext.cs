using Microsoft.EntityFrameworkCore;
using RISKZERO.Domain.Entities;
using RISKZERO.Infra.Data.EntityConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RISKZERO.Infra.Data.Context
{
    public class RiskzeroContext : DbContext
    {
        public RiskzeroContext(DbContextOptions<RiskzeroContext> options) : base(options)
        {
        }

        public RiskzeroContext()
        {
        }

        public DbSet<Agenda> Agendas { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appoiment> Appoiments { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Statistic> Statistics { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AgendaConfiguration());
            modelBuilder.ApplyConfiguration(new QuestionConfiguration());
            modelBuilder.ApplyConfiguration(new AnswerConfiguration());
            modelBuilder.ApplyConfiguration(new PatientConfiguration());
            modelBuilder.ApplyConfiguration(new StatisticConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new AppoimentConfiguration());
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DateHour") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DateHour").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DateHour").IsModified = false;
                }
            }
            return base.SaveChanges();
        }
    }
}
