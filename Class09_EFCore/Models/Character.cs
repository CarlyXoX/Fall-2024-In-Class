namespace Class09_EFCore.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }

        // foreign key reference
        public int RoomId { get; set; }
        // navigation property
        public Room Room { get; set; }

    }
}
