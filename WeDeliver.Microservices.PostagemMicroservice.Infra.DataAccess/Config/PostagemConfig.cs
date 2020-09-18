using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WeDeliver.Microservices.PostagemMicroservice.Domain.AggregatesModel.PostagemAggregate;

namespace WeDeliver.Microservices.PostagemMicroservice.Infra.DataAccess.Config
{
    class PostagemConfig : IEntityTypeConfiguration<Postagem>
    {
        public void Configure(EntityTypeBuilder<Postagem> builder)
        {
            builder.ToTable("Postagens");
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id_Pacote).IsRequired();
            builder.Property(a => a.Recebedor).IsRequired();
            builder.Property(a => a.Destino).IsRequired();
            builder.Property(a => a.DataEnvio).IsRequired();
        }
    }
}
