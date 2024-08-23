namespace FirstConsoleApp;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("1. Display Characters");
        Console.WriteLine("2. Add Character");
        Console.WriteLine("3. Level Up Character");
        var input = Console.ReadLine();

        string[] lines = File.ReadAllLines("input.csv");

        for (int i = 0; i < lines.Length; i++)
        {
            var line = lines[i];
            Console.WriteLine(line);
        }
    }
}