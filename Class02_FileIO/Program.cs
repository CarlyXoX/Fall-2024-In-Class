class Program
{
    public static void Main()
    {
        WriteFile();
    }

    public static void WriteFile()
    {
        //StreamReader sr;
        StreamWriter sw = new StreamWriter("input.csv", true);
        sw.WriteLine("Test string");
        sw.Flush();
        sw.Close();
    }

    public static void FileParsing()
    {
        var lines = File.ReadAllLines("input.csv");

        for (int i = 1; i < lines.Length; i++)
        {
            // NAME
            int commaIndex = lines[i].IndexOf(',');
            string name = lines[i].Substring(0, commaIndex);

            if (lines[i].StartsWith('"'))
            {
                // get first quote
                var firstQuotePos = lines[i].IndexOf('"');
                // assign line everything except first quote
                lines[i] = lines[i].Substring(firstQuotePos + 1);
                // get closing quote
                var lastQuotePos = lines[i].IndexOf('"');
                // assign name
                name = lines[i].Substring(firstQuotePos, lastQuotePos - firstQuotePos);
                commaIndex = lines[i].IndexOf('"') + 1;
            }
            Console.WriteLine($"Name: {name}");
            lines[i] = lines[i].Substring(commaIndex + 1);
            Console.WriteLine($"Line: {lines[i]}");

            // CLASS (alternate parsing method)
            //commaIndex = lines[i].IndexOf(',');
            //var heroClass = lines[i].Substring(0, commaIndex);
            //Console.WriteLine($"Hero Class: {heroClass}");

            string[] fields = lines[i].Split(',');
            foreach (var field in fields)
            {
                Console.WriteLine($"Field: {field}");
            }

            // CLASS
            var heroClass = fields[0];
            // LEVEL
            // HP
            // EQUIPMENT
            //string[] equipment = fields[??].Split('|');
        }
    }
}