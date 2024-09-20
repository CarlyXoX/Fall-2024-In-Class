using Class05_ISP.Models;
using Class05_ISP.Services;

namespace Class05_ISP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var character = new Character();
            var goblin = new Goblin();
            var ghost = new Ghost();

            var game = new GameEngine(character, goblin, ghost);
            //game.Run();
            game.DatabasePrep();
        }
    }
}


