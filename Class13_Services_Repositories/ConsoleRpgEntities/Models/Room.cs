using System.ComponentModel.DataAnnotations.Schema;
using ConsoleRpgEntities.Models.Characters;

namespace ConsoleRpgEntities.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        // foreign key
        public int? OtherRoomId { get; set; }

        // navigation properties
        [ForeignKey("OtherRoomId")]
        public virtual Room? OtherRoom { get; set; }
        [ForeignKey("AnotherRoomId")]
        public virtual Room? AnotherRoom { get; set; }

        public virtual int? PlayerId { get; set; }
        public virtual ICollection<Player> Players { get; set; }

    }
}
