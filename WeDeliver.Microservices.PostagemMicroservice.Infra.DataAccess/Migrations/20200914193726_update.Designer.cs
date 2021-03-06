﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WeDeliver.Microservices.PostagemMicroservice.Infra.DataAccess.Contexts;

namespace WeDeliver.Microservices.PostagemMicroservice.Infra.DataAccess.Migrations
{
    [DbContext(typeof(PostagemContext))]
    [Migration("20200914193726_update")]
    partial class update
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WeDeliver.Microservices.PostagemMicroservice.Domain.AggregatesModel.PostagemAggregate.Postagem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataEnvio")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("Id_Pacote")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Recebedor")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Postagens");
                });

            modelBuilder.Entity("WeDeliver.Microservices.PostagemMicroservice.Domain.AggregatesModel.PostagemAggregate.Postagem", b =>
                {
                    b.OwnsOne("WeDeliver.Common.Domain.Entities.Endereco", "Destino", b1 =>
                        {
                            b1.Property<Guid>("PostagemId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Bairro")
                                .HasColumnName("Bairro")
                                .HasColumnType("nvarchar(25)")
                                .HasMaxLength(25);

                            b1.Property<string>("Cep")
                                .HasColumnName("Cep")
                                .HasColumnType("nvarchar(7)")
                                .HasMaxLength(7);

                            b1.Property<string>("Cidade")
                                .HasColumnName("Cidade")
                                .HasColumnType("nvarchar(25)")
                                .HasMaxLength(25);

                            b1.Property<string>("Complemento")
                                .HasColumnName("Complemento")
                                .HasColumnType("nvarchar(25)")
                                .HasMaxLength(25);

                            b1.Property<string>("Estado")
                                .HasColumnName("Estado")
                                .HasColumnType("nvarchar(25)")
                                .HasMaxLength(25);

                            b1.Property<string>("Logradouro")
                                .HasColumnName("Logradouro")
                                .HasColumnType("nvarchar(50)")
                                .HasMaxLength(50);

                            b1.Property<string>("Lote")
                                .HasColumnName("Lote")
                                .HasColumnType("nvarchar(4)")
                                .HasMaxLength(4);

                            b1.HasKey("PostagemId");

                            b1.ToTable("Postagens");

                            b1.WithOwner()
                                .HasForeignKey("PostagemId");
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
