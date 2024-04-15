using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess;

internal class MigrationServiceManager
{
    public ServiceProvider ServiceProvider { get; set; }

    public MigrationServiceManager()
    {
        IConfigurationRoot configuration = new ConfigurationBuilder().Build();

        var serviceCollection = new ServiceCollection();
        ConfigureServices(serviceCollection, configuration);
        var serviceProvider = serviceCollection.BuildServiceProvider();
        ServiceProvider = serviceProvider;
    }

    private void ConfigureServices(IServiceCollection services, IConfigurationRoot configuration)
    {
        //var connectionString = configuration.GetRequiredSection("connectionstring");

        services.AddDbContext<PromoveDbContext>(options =>
        {
            options.UseSqlServer("Server=./;Database=MultiContextPromoveMain;Trusted_Connection=False;MultipleActiveResultSets=true;TrustServerCertificate=True");
        });

        

        // Add any other services needed in migrations
        services.AddTransient<PromoveDbContext>();
    }


}


