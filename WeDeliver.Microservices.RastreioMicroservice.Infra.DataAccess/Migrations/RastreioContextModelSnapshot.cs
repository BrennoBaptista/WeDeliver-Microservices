﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WeDeliver.Microservices.RastreioMicroservice.Infra.DataAccess.Contexts;

namespace WeDeliver.Microservices.RastreioMicroservice.Infra.DataAccess.Migrations
{
    [DbContext(typeof(RastreioContext))]
    partial class RastreioContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WeDeliver.Microservices.RastreioMicroservice.Domain.AggregatesModel.RastreioModel.Rastreio", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Id_Pacote")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Id_Postagem")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Localizacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime>("UltimaAtualizacao")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Rastreios");
                });
#pragma warning restore 612, 618
        }
    }
}
