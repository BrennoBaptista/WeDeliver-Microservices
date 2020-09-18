using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WeDeliver.Microservices.PacoteMicroservice.Domain.AggregatesModel.PacoteAggregate;
using WeDeliver.Microservices.PacoteMicroservice.Infra.DataAccess.Config;

namespace WeDeliver.Microservices.PacoteMicroservice.Infra.DataAccess.Contexts
{
    public class PacoteContext : DbContext
    {
        public DbSet<Pacote> Pacotes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=tcp:wedeliver-microservices-db-server-brenno.database.windows.net,1433;Initial Catalog=WeDeliver-Microservices-Db;Persist Security Info=False;User ID=Brenno;Password=Fdt2895!@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new PacoteConfig());
        }
    }
}
