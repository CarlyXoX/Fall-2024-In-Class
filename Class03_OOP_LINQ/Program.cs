public class Program
{
    public static void Main()
    {
        // Instantiate the character content manager and get the characters
        CharacterContentManager characterContent = new CharacterContentManager();
        characterContent.PopulateCharacters();
        var characters = characterContent.Characters;

        // output the retrieved characters
        foreach (var character in characters)
        {
            Console.WriteLine($"Name: {character.Name}");
            Console.WriteLine($"HitPoints: {character.HitPoints}");
            Console.WriteLine("-----");
        }

        // find the character
        Console.WriteLine("Found Character");
        var foundCharacter = characters.Where(c => c.Name == "bobby").FirstOrDefault();
        //foreach (var foundCharacter in foundCharacters)
        //{
            Console.WriteLine($"Name: {foundCharacter?.Name}");
            Console.WriteLine($"HitPoints: {foundCharacter?.HitPoints}");
        //}
        // modify the character
        foundCharacter.HitPoints += 10;

        // ****** NOTE: This method has changed from the original discussion in class ******
        // you do not need to pass the character to the UpdateCharacters method as the character is already in 
        // the List<Character> Characters in the CharacterContentManager class and owned by that class
        characterContent.UpdateCharacters();

    }

    // Example of how you could write the Func<Character, bool> method for the Where method
    public static bool FindCharacter(Character character)
    {
        if (character.Name == "Bobby")
        {
            return true;
        }
        return false;
    }
}
