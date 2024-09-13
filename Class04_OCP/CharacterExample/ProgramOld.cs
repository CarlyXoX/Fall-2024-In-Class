using Class04_OCP.Models;

namespace Class04_OCP.CharacterExample
{
    public class ProgramOld
    {
        public static void MainOld()
        {
            CharacterOld knight = new CharacterOld("Lancelot");
            CharacterOld wizard = new CharacterOld("Merlin");
            CharacterOld cleric = new CharacterOld("Geoffrey");

            //knight.Fight(wizard, "sword");
            //wizard.Fight(knight, "wand");
            //wizard.Fight(knight, "poison");

            knight.Attack = new Attack() { AttackName = "club" };
            knight.Fight(wizard);

            wizard.Attack = new Punch() { };
            wizard.Fight(knight);

            cleric.Attack = new Laugh() { };
            cleric.Fight(wizard);

            cleric.Inventory.PutItemInInventory();

        }
    }
}

