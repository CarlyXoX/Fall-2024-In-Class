namespace Class11Console.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        // navigation property
        public List<Character> Characters { get; set; }
    }
}
