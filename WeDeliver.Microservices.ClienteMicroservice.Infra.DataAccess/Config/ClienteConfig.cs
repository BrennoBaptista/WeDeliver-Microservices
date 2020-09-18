using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WeDeliver.Microservices.ClienteMicroservice.Domain.AggregatesModel.ClienteAggregate;

namespace WeDeliver.Microservices.ClienteMicroservice.Infra.DataAccess.Config
{
    public class ClienteConfig : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Clientes");
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Nome).IsRequired();
            builder.Property(a => a.Telefone).IsRequired();
            builder.Property(a => a.Cpf).IsRequired();
            builder.Property(a => a.Email).IsRequired();
            builder.Property(a => a.Endereco).IsRequired();
        }
    }
}
