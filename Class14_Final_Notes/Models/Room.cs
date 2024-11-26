public class Room
{
    public int Id { get; set; }

    [Required]
    public string? Name { get; set; }

    [StringLength(100)]
    public string Description { get; set; }

    [ForeignKey("NorthId")]
    public virtual Room? North { get; set; }
    public int? NorthId { get; set; }

    [ForeignKey("SouthId")]
    public virtual Room? South { get; set; }
    public int? SouthId { get; set; }

    [ForeignKey("EastId")]
    public virtual Room? East { get; set; }
    public int? EastId { get; set; }

    [ForeignKey("WestId")]
    public virtual Room? West { get; set; }
    public int? WestId { get; set; }

    public virtual ICollection<Monster> Monsters { get; set; } = new List<Monster>();

    public virtual int? PlayerId { get; set; }
    public virtual ICollection<Player> Players { get; set; } = new List<Player>();
}

