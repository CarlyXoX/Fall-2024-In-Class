using Class05_ISP.Interfaces;

namespace Class05_ISP.Models
{
    public class Goblin : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Move()
        {
            Console.WriteLine("The goblin moves");
        }
    }
}
