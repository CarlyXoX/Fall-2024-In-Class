using Class05_ISP.Data;
using Class05_ISP.Interfaces;
using Class05_ISP.Models;

namespace Class05_ISP.Services
{
    public class GameEngine
    {
        private readonly IEntity _character;
        private readonly IEntity _goblin;
        private readonly IEntity _ghost;

        // default constructor
        public GameEngine(IEntity character, IEntity goblin, IEntity ghost)
        {
            Console.WriteLine("Starting GameEngine");
            _character = character;
            _goblin = goblin;
            _ghost = ghost;
        }

        public void DatabasePrep()
        {
            // should the program care how characters was populated?
            DataContext dataContext = new DataContext();
            var characters = dataContext.Characters;
            foreach (var character in characters)
            {
                character.Move();
            }
            dataContext.Create("Snorg");
            dataContext.Read();

            dataContext.Save();
        }

        public void Run()
        {
            _character.Move();
            
            _goblin.Move();

            _ghost.Move();
            ((Ghost)_ghost).Fly();

            // optional approach
            //if (_ghost is IFlyable)
            //{
            //    ((IFlyable)_ghost).Fly();
            //}
        }
    }
}


