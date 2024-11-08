namespace Class11Console.Models
{
    public abstract class Character : ICharacter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }

        // foreign key reference
        public int RoomId { get; set; }
        // navigation property
        public Room Room { get; set; }

        public virtual void Attack(ICharacter target)
        {
            Console.WriteLine($"{Name} attacks {target.Name}!");
        }

    }
}
