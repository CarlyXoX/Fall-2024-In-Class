using Class05_ISP.Interfaces;

namespace Class05_ISP.Models
{
    public class Ghost : IEntity, IFlyable
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Fly()
        {
            Console.WriteLine("The ghost flies silently");
        }

        public void Move()
        {
            Console.WriteLine("The ghost moves");
        }
    }
}
