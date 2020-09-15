using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WeDeliver.Common.Domain.Entities;
using WeDeliver.Microservices.ClienteMicroservice.Domain.AggregatesModel.ClienteModel;
using WeDeliver.Microservices.ClienteMicroservice.Infra.DataAccess.Config;

namespace WeDeliver.Microservices.ClienteMicroservice.Infra.DataAccess.Contexts
{
    public class ClienteContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        //public DbSet<Endereco> Enderecos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=tcp:wedeliver-microservices-db-server-brenno.database.windows.net,1433;Initial Catalog=WeDeliver-Microservices-Db;Persist Security Info=False;User ID=Brenno;Password=Fdt2895!@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ClienteConfig());
        }
    }
}
