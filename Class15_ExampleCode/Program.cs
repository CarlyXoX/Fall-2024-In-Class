using Class15_ExampleCode.Models;

class Program
{
    static void Main()
    {
        // values for paging to determine how much and what to display
        var page = 0;
        var pageSize = 10;

        var itemManager = new ItemManager();
        // calculate maximum possible number of pages for later "clamping"
        var maxPages = (int)Math.Ceiling((double)itemManager.Items.Count / pageSize) - 1; // subtract 1 for 0 indexed

        var isExit = false;
        do
        {
            // Display Items
            Console.WriteLine("--------------------");
            Console.WriteLine("------ Items -------");
            Console.WriteLine($"------ Page {page,3} ----");
            itemManager.GetItems(page, pageSize).ForEach(item => Console.WriteLine($"{item.Id}: {item.Name}"));

            // Prompt User
            Console.Write("Press 'Page Up', 'Page Down', or 'Q' to quit: ");
            var keyInfo = Console.ReadKey(intercept: true); // Read a single keypress, don't display it
            Console.WriteLine(); // Move to the next line for better readability

            switch (keyInfo.Key)
            {
                case ConsoleKey.Q:
                    isExit = true;
                    Console.WriteLine("Exiting...");
                    break;

                case ConsoleKey.PageUp:
                    page--;
                    page = Math.Clamp(page, 0, maxPages); // keep page value in range 0 -> maxPages
                    break;

                case ConsoleKey.PageDown:
                    page++;
                    page = Math.Clamp(page, 0, maxPages); // keep page value in range 0 -> maxPages
                    break;

                default:
                    Console.WriteLine($"Unrecognized choice: {keyInfo.KeyChar}");
                    break;
            }

        } while (!isExit);
    }
}
