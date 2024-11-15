using System;
using System.Collections.Generic;

namespace ScaffoldProject.Models
{
    public partial class Ability
    {
        public Ability()
        {
            Players = new HashSet<Player>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string AbilityType { get; set; } = null!;
        public int? Damage { get; set; }
        public int? Distance { get; set; }

        public virtual ICollection<Player> Players { get; set; }
    }
}
