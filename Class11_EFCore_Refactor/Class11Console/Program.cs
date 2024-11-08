using Class11Console.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Class11Console;

public static class Program
{
    public static void Main()
    {
        var serviceCollection = new ServiceCollection();
        Startup.ConfigureServices(serviceCollection);

        var serviceProvider = serviceCollection.BuildServiceProvider();

        var gameEngine = serviceProvider.GetService<GameEngine>();
        gameEngine?.Run();

    }
}