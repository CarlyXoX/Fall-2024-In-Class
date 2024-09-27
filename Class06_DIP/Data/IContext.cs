using Class06_DIP.Models;

namespace Class06_DIP.Data
{
    public interface IContext
    {
        // READ
        List<CharacterBase> Characters { get; set; }
        // CREATE
        void AddCharacter(CharacterBase character);
        // UPDATE
        void UpdateCharacter(CharacterBase character);
        // DELETE
        void DeleteCharacter(string characterName);
    }
}