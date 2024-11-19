namespace RoomGeneratorConsole;

class MapGenerator
{
    private Random _random = new Random();
    private int _size;
    private Room[,] _grid;

    private List<string> _roomNames = new List<string>
    {
        "Ancient Library", "Dark Cavern", "Mystic Grove", "Enchanted Hall", "Forgotten Crypt",
        "Sunlit Clearing", "Ruined Temple", "Abandoned Mine", "Crystal Chamber", "Echoing Hallway"
    };

    private List<string> _roomDescriptions = new List<string>
    {
        "The air is thick with mystery and dust.", "Shadows dance on the walls.",
        "A faint, magical glow illuminates the room.", "The smell of damp earth fills your nose.",
        "Broken artifacts lie scattered on the floor.", "A cool breeze whispers through the space.",
        "The walls are covered with ancient carvings.", "You hear the faint sound of dripping water.",
        "Glittering crystals catch the light.", "The sound of your footsteps echoes eerily."
    };

    public MapGenerator(int size)
    {
        _size = size;
        _grid = new Room[size, size];
    }

    public Room[,] Generate()
    {
        // Create rooms with random names and descriptions
        for (int x = 0; x < _size; x++)
        {
            for (int y = 0; y < _size; y++)
            {
                string name = GetRandomItem(_roomNames);
                string description = GetRandomItem(_roomDescriptions);
                _grid[x, y] = new Room(x * _size + y, name, description);
            }
        }

        // Randomly connect rooms
        for (int x = 0; x < _size; x++)
        {
            for (int y = 0; y < _size; y++)
            {
                ConnectRooms(x, y);
            }
        }

        return _grid;
    }

    private void ConnectRooms(int x, int y)
    {
        Room current = _grid[x, y];

        // Try connecting north
        if (x > 0 && _random.Next(2) == 1)
        {
            current.North = _grid[x - 1, y];
            _grid[x - 1, y].South = current;
        }

        // Try connecting south
        if (x < _size - 1 && _random.Next(2) == 1)
        {
            current.South = _grid[x + 1, y];
            _grid[x + 1, y].North = current;
        }

        // Try connecting east
        if (y < _size - 1 && _random.Next(2) == 1)
        {
            current.East = _grid[x, y + 1];
            _grid[x, y + 1].West = current;
        }

        // Try connecting west
        if (y > 0 && _random.Next(2) == 1)
        {
            current.West = _grid[x, y - 1];
            _grid[x, y - 1].East = current;
        }
    }

    public bool VerifyMap(Room[,] map)
    {
        HashSet<Room> visited = new HashSet<Room>();
        Queue<Room> queue = new Queue<Room>();

        // Start from the first room
        Room start = map[0, 0];
        queue.Enqueue(start);
        visited.Add(start);

        while (queue.Count > 0)
        {
            Room current = queue.Dequeue();

            foreach (Room neighbor in GetNeighbors(current))
            {
                if (neighbor != null && !visited.Contains(neighbor))
                {
                    visited.Add(neighbor);
                    queue.Enqueue(neighbor);
                }
            }
        }

        // Verify all rooms are visited
        foreach (Room room in map)
        {
            if (!visited.Contains(room))
            {
                return false; // Map is not fully navigable
            }
        }

        return true;
    }

    private IEnumerable<Room> GetNeighbors(Room room)
    {
        if (room.North != null) yield return room.North;
        if (room.South != null) yield return room.South;
        if (room.East != null) yield return room.East;
        if (room.West != null) yield return room.West;
    }

    private string GetRandomItem(List<string> list)
    {
        return list[_random.Next(list.Count)];
    }

    public void GenerateInsertStatements(Room[,] map)
    {
        Console.WriteLine("Generated SQL INSERT Statements:");
        for (int x = 0; x < _size; x++)
        {
            for (int y = 0; y < _size; y++)
            {
                Room room = map[x, y];
                string northId = room.North?.Id.ToString() ?? "NULL";
                string southId = room.South?.Id.ToString() ?? "NULL";
                string eastId = room.East?.Id.ToString() ?? "NULL";
                string westId = room.West?.Id.ToString() ?? "NULL";

                string insertStatement = $@"
INSERT INTO Rooms (Id, Name, Description, NorthRoomId, SouthRoomId, EastRoomId, WestRoomId)
VALUES ({room.Id}, '{EscapeSql(room.Name)}', '{EscapeSql(room.Description)}', {northId}, {southId}, {eastId}, {westId});
";
                Console.WriteLine(insertStatement);
            }
        }
    }

    private string EscapeSql(string input)
    {
        // Replace single quotes with two single quotes for SQL compatibility
        return input.Replace("'", "''");
    }
}