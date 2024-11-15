using System;
using System.Collections.Generic;

namespace ScaffoldProject.Models
{
    public partial class Item
    {
        public Item()
        {
            EquipmentArmors = new HashSet<Equipment>();
            EquipmentWeapons = new HashSet<Equipment>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Type { get; set; } = null!;
        public int Attack { get; set; }
        public int Defense { get; set; }

        public virtual ICollection<Equipment> EquipmentArmors { get; set; }
        public virtual ICollection<Equipment> EquipmentWeapons { get; set; }
    }
}
