namespace RoomGeneratorConsole;

class Program
{
    static void Main(string[] args)
    {
        int mapSize = 5; // Example size of 5x5
        MapGenerator generator = new MapGenerator(mapSize);

        Room[,] map = generator.Generate();
        bool isNavigable = generator.VerifyMap(map);

        Console.WriteLine("Generated Map:");
        for (int x = 0; x < mapSize; x++)
        {
            for (int y = 0; y < mapSize; y++)
            {
                Console.WriteLine(map[x, y]);
                Console.WriteLine();
            }
        }

        Console.WriteLine("Map is " + (isNavigable ? "navigable!" : "not navigable!"));

        // Generate and display SQL INSERT statements
        generator.GenerateInsertStatements(map);
    }
}