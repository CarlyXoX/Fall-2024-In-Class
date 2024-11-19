namespace RoomGeneratorConsole;

class Room
{
    public Room North { get; set; }
    public Room South { get; set; }
    public Room East { get; set; }
    public Room West { get; set; }

    public string Name { get; set; }
    public string Description { get; set; }
    public int Id { get; set; } // Unique ID for debugging

    public Room(int id, string name, string description)
    {
        Id = id;
        Name = name;
        Description = description;
    }

    public override string ToString()
    {
        return $"Room {Id}: {Name}\nDescription: {Description}";
    }
}