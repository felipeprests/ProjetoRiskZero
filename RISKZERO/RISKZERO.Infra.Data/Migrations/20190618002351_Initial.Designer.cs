﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RISKZERO.Infra.Data.Context;

namespace RISKZERO.Infra.Data.Migrations
{
    [DbContext(typeof(RiskzeroContext))]
    [Migration("20190618002351_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RISKZERO.Domain.Entities.Agenda", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateHour");

                    b.Property<bool>("Notification");

                    b.Property<string>("Reminder");

                    b.Property<bool>("Status");

                    b.HasKey("ID");

                    b.ToTable("Agendas");
                });

            modelBuilder.Entity("RISKZERO.Domain.Entities.Answer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdQuestion");

                    b.Property<string>("Observation");

                    b.Property<bool>("Result");

                    b.Property<bool>("Status");

                    b.Property<string>("TypeAnswer");

                    b.HasKey("ID");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("RISKZERO.Domain.Entities.Appoiment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateHour");

                    b.Property<string>("Observation");

                    b.Property<bool>("Status");

                    b.HasKey("ID");

                    b.ToTable("Appoiments");
                });

            modelBuilder.Entity("RISKZERO.Domain.Entities.Patient", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<DateTime>("BirthDate");

                    b.Property<long>("CPF");

                    b.Property<string>("City");

                    b.Property<string>("District");

                    b.Property<string>("Email");

                    b.Property<string>("FullName");

                    b.Property<string>("Phone");

                    b.Property<string>("PhoneType");

                    b.Property<string>("State");

                    b.Property<bool>("Status");

                    b.HasKey("ID");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("RISKZERO.Domain.Entities.Question", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<bool>("Status");

                    b.Property<int>("TypeQuestion");

                    b.HasKey("ID");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("RISKZERO.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CRP");

                    b.Property<string>("Email");

                    b.Property<string>("FullName");

                    b.Property<string>("Level");

                    b.Property<string>("Login");

                    b.Property<string>("Occupation");

                    b.Property<string>("Password");

                    b.Property<bool>("RememberMe");

                    b.Property<bool>("Status");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}