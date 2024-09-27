using Class06_DIP.Data;
using Class06_DIP.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Class06_DIP
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            var serviceProvider = serviceCollection.BuildServiceProvider();

            //var game = new GameEngine(context);
            var game = serviceProvider.GetService<GameEngine>();

            game?.Run();
            
        }

        public static void ConfigureServices(ServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IContext, DataContext>();
            serviceCollection.AddTransient<GameEngine>();
            //var context = new DataContext();
        }
    }
}


