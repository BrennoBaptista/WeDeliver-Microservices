using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using WeDeliver.Common.Application.CQRS.Messaging;
using WeDeliver.Common.Domain.Services;
using WeDeliver.Common.Infra.Helper.Serializers;
using WeDeliver.Common.Infra.Messaging.Services;
using WeDeliver.Microservices.PostagemMicroservice.Domain.AggregatesModel.PostagemAggregate;
using WeDeliver.Microservices.PostagemMicroservice.Infra.DataAccess.Contexts;
using WeDeliver.Microservices.PostagemMicroservice.Infra.DataAccess.Repositories;


namespace WeDeliver.Microservices.PostagemMicroservice.Application.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddDbContext<PostagemContext>();
            services.AddScoped<DbContext, PostagemContext>();
            services.AddScoped<IPostagemRepository, PostagemRepository>();
            services.AddScoped<IPostagemService, PostagemService>();
            services.AddScoped<ISerializerService, SerializerService>();
            services.AddScoped<IApiApplicationService, ApiApplicationService>();
            services.AddScoped<IMediatorHandler, AzureServiceBusQueue>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
