namespace Class04_OCP.Models
{
    public class CharacterOld
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IAttack Attack { get; set; }

        public IInventory Inventory { get; set; }
        

        // default constructor (ctor)
        public CharacterOld()
        {
            Name = "Bob";
        }

        public void Fight(CharacterOld target)
        {
            Attack.Perform(this, target);
        }

        // *** Not using Open-Closed Principle (OCP)
        //public void Fight(Character target, string attack)
        //{
        //    if (attack == "sword" || attack == "wand")
        //    {
        //        Console.WriteLine($"{this.Name} attacks {target.Name} with {attack}");
        //        // TODO character target will take damage
        //    }

        //    if (attack == "poison")
        //    {
        //        Console.WriteLine($"{this.Name} affects {target.Name} with {attack}");
        //    }
        //}

        public CharacterOld(string name)
        {
            Name = name;
        }


    }
}
