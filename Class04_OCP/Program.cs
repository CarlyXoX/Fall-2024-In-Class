using Class04_OCP.Services;

namespace Class04_OCP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1. Read File");
            Console.WriteLine("2. Write File");
            var choice = Console.ReadLine();

            // instantiate the manager
            IFileManager fileManager = new JsonFileManager();

            // execute - this should not change if we honor our interface contract
            if (choice == "1")
            {
                fileManager.ReadFile();
            }
            else if (choice == "2")
            {
                fileManager.WriteFile();
            }
        }
    }
}
