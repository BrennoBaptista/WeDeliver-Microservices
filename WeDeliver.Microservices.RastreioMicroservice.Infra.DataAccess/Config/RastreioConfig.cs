using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WeDeliver.Microservices.RastreioMicroservice.Domain.AggregatesModel.RastreioModel;

namespace WeDeliver.Microservices.RastreioMicroservice.Infra.DataAccess.Config
{
    public class RastreioConfig : IEntityTypeConfiguration<Rastreio>
    {
        public void Configure(EntityTypeBuilder<Rastreio> builder)
        {
            builder.ToTable("Rastreios");
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id_Pacote).IsRequired();
            builder.Property(a => a.Id_Postagem).IsRequired();
            builder.Property(a => a.StatusEnvio).HasColumnType("nvarchar(16)").IsRequired();
            builder.Property(a => a.Localizacao).IsRequired();
            builder.Property(a => a.UltimaAtualizacao).IsRequired();
        }
    }
}
