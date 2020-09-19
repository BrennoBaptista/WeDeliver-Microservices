using Microsoft.Extensions.Hosting;
using System;
using System.Threading.Tasks;
using WeDeliver.Microservices.PostagemMicroservice.Application.PostagemWorker.Properties;

namespace WeDeliver.Microservices.PostagemMicroservice.Application.PostagemWorker
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var builder = new HostBuilder();
            builder.ConfigureWebJobs(b =>
            {
                b.AddAzureStorageCoreServices();
                b.AddServiceBus(sbOptions =>
                {
                    sbOptions.ConnectionString = Resources.ServiceBusConnectionString;
                    sbOptions.MessageHandlerOptions.AutoComplete = true;
                    sbOptions.MessageHandlerOptions.MaxConcurrentCalls = 16;
                });
            });
            var host = builder.Build();
            using (host)
            {
                await host.RunAsync();
            }
        }
    }
}