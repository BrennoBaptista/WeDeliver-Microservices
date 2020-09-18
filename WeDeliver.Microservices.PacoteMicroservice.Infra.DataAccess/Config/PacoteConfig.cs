using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WeDeliver.Microservices.PacoteMicroservice.Domain.AggregatesModel.PacoteAggregate;

namespace WeDeliver.Microservices.PacoteMicroservice.Infra.DataAccess.Config
{
    public class PacoteConfig : IEntityTypeConfiguration<Pacote>
    {
        public void Configure(EntityTypeBuilder<Pacote> builder)
        {
            builder.ToTable("Pacotes");
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id_Cliente).IsRequired();
            builder.Property(a => a.Peso).IsRequired();
            builder.Property(a => a.Altura).IsRequired();
            builder.Property(a => a.Largura).IsRequired();
            builder.Property(a => a.Profundidade).IsRequired();
        }
    }
}
