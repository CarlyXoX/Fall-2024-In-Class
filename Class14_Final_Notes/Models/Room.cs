namespace ConsoleRpg.Models;

public class Room
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string Description { get; set; }
    public virtual Room? North { get; set; }
    public int? NorthId { get; set; }
    public virtual Room? South { get; set; }
    public int? SouthId { get; set; }
    public virtual Room? East { get; set; }
    public int? EastId { get; set; }
    public virtual Room? West { get; set; }
    public int? WestId { get; set; }
    public virtual ICollection<Monster> Monsters { get; set; } = new List<Monster>();
}