public class CharacterContentManager
{
    public List<Character> Characters { get; set; }

    public void PopulateCharacters() {
        Characters = new List<Character>()
        {
            new Character() { Name = "Jimmy", HitPoints = 50 },
            new Character() { Name = "Deborah", HitPoints = 70 },
        };

        var character = new Character();
        character.Name = "Bobby";
        character.HitPoints = 100;
        Characters.Add(character);

        Characters.Add(new Character()
        {
            Name = "Timmy",
            HitPoints = 20
        });
    }
    public void UpdateCharacters() { 
        // ****** NOTE: This method has changed from the original discussion in class ******
        // if the character has been modified in Program.cs then that will be reflected in the List<Character> Characters in this class
        // this means it is not necessary to pass the character to this method
        // this method will just need to save the updates to the file


    }
}
