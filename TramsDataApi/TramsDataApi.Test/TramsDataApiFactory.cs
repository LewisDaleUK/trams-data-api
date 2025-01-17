using System.Linq;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TramsDataApi.DatabaseModels;

namespace TramsDataApi.Test
{
    public class TramsDataApiFactory : WebApplicationFactory<TramsDataApi.Startup>
    {
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureAppConfiguration(config =>
            {
                var integrationConfig = new ConfigurationBuilder()
                    .AddJsonFile("integration_settings.json")
                    .Build();

                config.AddConfiguration(integrationConfig);
            });
        }
    }
}