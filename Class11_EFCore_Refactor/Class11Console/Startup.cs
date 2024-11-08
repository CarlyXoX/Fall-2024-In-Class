using Class11Console.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

public static class Startup
{
    public static void ConfigureServices(IServiceCollection services)
    {
        var serviceProvider = services.BuildServiceProvider();

        var configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();

        services.AddDbContext<GameContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"))
        );

        // Entity Framework Factory for creating instance of DbContext
        //var contextFactory = serviceProvider.GetRequiredService<IDbContextFactory<GameContext>>();
        //var context = contextFactory.CreateDbContext();

        services.AddTransient<GameEngine>();
    }
}
