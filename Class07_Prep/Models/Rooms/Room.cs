namespace Class07_Prep.Models.Rooms
{
    public class Room : IRoom
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public IRoom North { get; set; }
        public IRoom South { get; set; }
        public IRoom West { get; set; }
        public IRoom East { get; set; }

        public Room()
        {

        }
        public Room(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }

}
