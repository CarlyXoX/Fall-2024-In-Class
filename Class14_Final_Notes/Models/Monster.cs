namespace ConsoleRpg.Models;

public abstract class Monster
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Health { get; set; }
    public int AggressionLevel { get; set; }
    public string MonsterType { get; set; }

    public virtual ICollection<Item> Items { get; set; } = new List<Item>();
    public virtual int RoomId { get; set; } // Foreign key
    public virtual Room Room { get; set; } // Navigation property
}