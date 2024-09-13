namespace Class04_OCP.Models
{
    // Attack implements IAttack
    // Attack is IAttack
    public class Attack : IAttack
    {
        public string AttackName { get; set; }

        public void Perform(CharacterOld attacker, CharacterOld target)
        {
            Console.WriteLine($"{attacker.Name} attacks {target.Name} with {AttackName}");
        }
    }

    public class Punch : IAttack
    {
        public void Perform(CharacterOld attacker, CharacterOld target)
        {
            Console.WriteLine($"{attacker.Name} punches {target.Name}");
        }
    }

    public class Laugh : IAttack
    {
        public void Perform(CharacterOld attacker, CharacterOld target)
        {
            Console.WriteLine($"{attacker.Name} laughs at {target.Name}");
        }
    }

    // blueprint or contract that the contents MUST exist in the implementation
    public interface IAttack
    {
        void Perform(CharacterOld attacker, CharacterOld target);
    }
}