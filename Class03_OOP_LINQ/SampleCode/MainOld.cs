namespace Week3InClass.SampleCode
{
    public class Program
    {
        public static void MainOld()
        {
            string[] characterNames = { "Jim", "Bob", "John" };
            int[] characterHitPoints = { 10, 20, 30 };
            List<string> characters = new List<string>() { "Jim", "Bob", "John" };

            var name = characters[0];

            CharacterFullGetterSetter myCharacter1 = new CharacterFullGetterSetter(); // Jim
            CharacterFullGetterSetter myCharacter2 = new CharacterFullGetterSetter(); // Bob
            CharacterFullGetterSetter myCharacter3 = new CharacterFullGetterSetter(); // John
            var name1 = myCharacter1.GetName();
            myCharacter1.SetName("Jimbo");

            CharacterFullProp myCharacter4 = new CharacterFullProp();
            var name2 = myCharacter4.Name;
            myCharacter4.Name = "Alec";

            Character character = new Character();
            var name3 = character.Name;
            character.Name = "Donald";
        }
    }
}
