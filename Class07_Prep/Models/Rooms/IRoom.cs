namespace Class07_Prep.Models.Rooms
{
    public interface IRoom
    {
        string Name { get; set; }
        string Description { get; set; }

        IRoom North { get; set; }
        IRoom South { get; set; }
        IRoom West { get; set; }
        IRoom East { get; set; }
    }
}