namespace Class05_ISP.Interfaces
{
    public interface IContext
    {
        // CRUD
        public void Read();
        public void Update();
        public void Delete();
        void Create(string name);
    }
}