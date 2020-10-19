﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnboardingSIGDB1.Data;

namespace OnboardingSIGDB1.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20201016192745_ajustebase")]
    partial class ajustebase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OnboardingSIGDB1.Models.Classes.Cargo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("Cargos");
                });

            modelBuilder.Entity("OnboardingSIGDB1.Models.Classes.Empresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cnpj")
                        .HasMaxLength(14);

                    b.Property<DateTime?>("DataFundacao");

                    b.Property<string>("Nome")
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.ToTable("Empresas");
                });

            modelBuilder.Entity("OnboardingSIGDB1.Models.Classes.Funcionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cpf")
                        .HasMaxLength(11);

                    b.Property<DateTime?>("DataContratacao");

                    b.Property<int?>("EmpresaId");

                    b.Property<string>("Nome")
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.ToTable("Funcionarios");
                });

            modelBuilder.Entity("OnboardingSIGDB1.Models.Classes.FuncionarioCargo", b =>
                {
                    b.Property<int>("CargoId");

                    b.Property<int>("FuncionarioId");

                    b.Property<DateTime>("DataVinculo");

                    b.HasKey("CargoId", "FuncionarioId");

                    b.HasIndex("FuncionarioId");

                    b.ToTable("FuncionarioCargos");
                });

            modelBuilder.Entity("OnboardingSIGDB1.Models.Classes.Funcionario", b =>
                {
                    b.HasOne("OnboardingSIGDB1.Models.Classes.Empresa", "Empresa")
                        .WithMany("Funcionarios")
                        .HasForeignKey("EmpresaId");
                });

            modelBuilder.Entity("OnboardingSIGDB1.Models.Classes.FuncionarioCargo", b =>
                {
                    b.HasOne("OnboardingSIGDB1.Models.Classes.Cargo", "Cargo")
                        .WithMany("FuncionarioCargos")
                        .HasForeignKey("CargoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OnboardingSIGDB1.Models.Classes.Funcionario", "Funcionario")
                        .WithMany("FuncionarioCargos")
                        .HasForeignKey("FuncionarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
