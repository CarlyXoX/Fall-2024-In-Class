namespace Class04_OCP.Services
{
    public class CsvFileManager : IFileManager
    {
        public string FileName { get; set; }

        public CsvFileManager()
        {
            FileName = "Files/input.csv";
        }

        public void ReadFile()
        {
            // logic to read csv file
        }

        public void WriteFile()
        {
            // logic to write csv file
        }
    }
}
