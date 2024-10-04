using Class07_Prep.Data;
using Class07_Prep.Models.Rooms;
using Class07_Prep.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Class07_Prep
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
            serviceCollection.AddSingleton<IRoomFactory, RoomFactory>();
            serviceCollection.AddSingleton<IRoom, Room>();
        }
    }
}


