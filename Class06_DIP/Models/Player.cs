namespace Class06_DIP.Models
{
    public class Player : CharacterBase
    {
        public int Gold { get; set; }

        public Player()
        {
            Console.WriteLine("Initializing Character");
            Name = "Bob";
        }

        public override void SpecialAction()
        {
            throw new NotImplementedException();
        }

        //public override string ToString()
        //{
        //    return $"{Id}: {Name}";
        //}
    }
}
