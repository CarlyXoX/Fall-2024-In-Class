namespace Class04_OCP.Models
{
    public interface IInventory
    {
        public string GetItemFromInventory();

        public string PutItemInInventory();
    }
}