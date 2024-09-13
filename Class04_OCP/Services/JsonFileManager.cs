using Class04_OCP.Models;
using Newtonsoft.Json;

namespace Class04_OCP.Services
{
    public class JsonFileManager : IFileManager
    {
        public string FileName { get; set; }

        public JsonFileManager()
        {
            FileName = "Files/input.json";
        }

        public void ReadFile()
        {
            // logic to read json file
            var json = File.ReadAllText(FileName);
            var characters = JsonConvert.DeserializeObject<List<Character>>(json);

            foreach (var character in characters)
            {
                Console.WriteLine($"Character: {character.Name}");
            }

        }

        public void WriteFile()
        {
            // logic to write json file
            var characters = new List<Character>()
            {
                new Character()
                {
                    Name = "Bob",
                    ClassName = "Peasant",
                    Hp = 1,
                    Level = 0,
                    Equipment = new string[] { "stick", "spoon" }
                },
                new Character()
                {
                    Name = "Rover",
                    ClassName = "Dog",
                    Hp = 3,
                    Level = 1,
                    Equipment = new string[] { "bowl", "bone" }
                }
            };

            string json = JsonConvert.SerializeObject(characters);
            File.WriteAllText(FileName, json);

        }
    }
}
