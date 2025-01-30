using System.ComponentModel.Design.Serialization;
using System.Security.Cryptography.X509Certificates;

namespace FirstConsoleApp;
public class Program
{
    public static void Main()
    {
        StreamWriter streamWriter= new StreamWriter("");

        Console.WriteLine("1. Display Characters");
        Console.WriteLine("2. Add Character");
        Console.WriteLine("3. Level Up Character");
        var input = Console.ReadLine();
        int.TryParse(input, out int opt);

        StreamReader sr = new StreamReader("input.csv", true);
        StreamWriter sw = new StreamWriter("input.csv", true);

        string[] classes = new string[13] {
            "Barbarian", "Bard", "Cleric", "Druid", "Fighter",
            "Monk", "Paladin", "Ranger", "Rogue", "Sorcerer",
            "Warlock", "Wizard", "Artificer"
        };
        //Yes this is the full official DnD class list :)
        
        void writeClasses() {
            for (int i = 0; i < classes.Length; i++) {
                Console.WriteLine(classes[i] + i);
            }
        }

        string chooseClass(int classChoice) {
            switch (classChoice) {
                case 1:
                    return classes[0];
                case 2:
                    return classes[1];
                case 3:
                    return classes[2];
                case 4:
                    return classes[3];
                case 5:
                    return classes[4];
                case 6:
                    return classes[5];
                case 7:
                    return classes[6];
                case 8:
                    return classes[7];
                case 9:
                    return classes[8];
                case 10:
                    return classes[9];
                case 11:
                    return classes[10];
                case 12:
                    return classes[11];
                case 13:
                    return classes[12];
                
            }
        }

        switch (opt) {
            case 1:
                Console.WriteLine(rw);
                break;
            case 2:
                Console.WriteLine("Name: ");
                    String name = Console.ReadLine();
                Console.WriteLine(writeClasses());
                    int classChoice = int.Parse(Console.ReadLine());
                    chooseClass(classChoice);
                int lvl = 1;
                int hp = 10;
                String[,] inventory = new string[1, 3];

                sw.WriteLine(sr + "/n" name " " + classChoice " " + lvl " " + hp " " + inventory);
                break;
            case 3:
                Console.WriteLine("Enter Current HP: ");
                int.TryParse(Console.ReadLine(), out int currentHP);

                Console.WriteLine("Enter how many HP you wish to add to your stats: ");
                int.TryParse(Console.ReadLine(), out int increase);

                currentHP += increase;
                break; 
        }

        
    }
}