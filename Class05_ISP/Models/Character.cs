using Class05_ISP.Interfaces;

namespace Class05_ISP.Models
{
    public class Character : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Character()
        {
            Console.WriteLine("Initializing Character");
            Name = "Bob";
        }

        public void Move()
        {
            Console.WriteLine("The character moves");
        }

        public override string ToString()
        {
            return $"{Id}: {Name}";
        }
    }
}
