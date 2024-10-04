namespace Class07_Prep.Models.Rooms
{
    public interface IRoomFactory
    {
        IRoom CreateRoom(string roomType);
    }
}
