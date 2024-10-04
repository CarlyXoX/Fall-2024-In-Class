using Class07_Prep.Models.Characters;

namespace Class07_Prep.Data
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