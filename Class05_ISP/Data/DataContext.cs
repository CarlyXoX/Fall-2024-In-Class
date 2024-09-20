using Class05_ISP.Interfaces;
using Class05_ISP.Models;
using Newtonsoft.Json;

namespace Class05_ISP.Data
{
    public class DataContext : IContext
    {
        public List<Character> Characters { get; set; }

        public DataContext()
        {
            var json = File.ReadAllText("Files/input.json");
            Characters = JsonConvert.DeserializeObject<List<Character>>(json);
        }

        public void Save()
        {
            var json = JsonConvert.SerializeObject(Characters);
            File.WriteAllText("Files/input.json", json);
        }

        public void Create(string name)
        {
            var newId = Characters.Max(x => x.Id) + 1;
            var newName = name;
            Characters.Add(new Character() { Id = newId, Name = newName });
        }

        public void Read()
        {
            //Characters.ForEach(c => WriteOut(c));
            Characters.ForEach(Console.WriteLine);
        }

        private void WriteOut(Character c)
        {
            Console.WriteLine(c.Name);
        }
        public void Update()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }
    }






    //public class FileContext : IContext { }
    //public class ApiContext : IContext { }
    //public class NasContext : IContext { }
    //public class DatabaseContext : IContext { }
}
