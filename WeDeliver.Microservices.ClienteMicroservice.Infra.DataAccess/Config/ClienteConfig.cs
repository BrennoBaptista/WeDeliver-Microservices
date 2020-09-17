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
            
        }
    }
}
