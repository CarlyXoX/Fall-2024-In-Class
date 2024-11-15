using System;
using System.Collections.Generic;

namespace ScaffoldProject.Models
{
    public partial class Equipment
    {
        public Equipment()
        {
            Players = new HashSet<Player>();
        }

        public int Id { get; set; }
        public int? WeaponId { get; set; }
        public int? ArmorId { get; set; }

        public virtual Item? Armor { get; set; }
        public virtual Item? Weapon { get; set; }
        public virtual ICollection<Player> Players { get; set; }
    }
}
