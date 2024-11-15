using System;
using System.Collections.Generic;

namespace ScaffoldProject.Models
{
    public partial class Player
    {
        public Player()
        {
            Abilities = new HashSet<Ability>();
        }

        public int Id { get; set; }
        public int Experience { get; set; }
        public string Name { get; set; } = null!;
        public int Health { get; set; }
        public int? EquipmentId { get; set; }

        public virtual Equipment? Equipment { get; set; }

        public virtual ICollection<Ability> Abilities { get; set; }
    }
}
