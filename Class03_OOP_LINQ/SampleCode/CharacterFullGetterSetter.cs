


public class CharacterFullGetterSetter
{
    private string name;
    private string description;
    private int hitPoints;
    private int level;

    // getter - provides public access to private variables
    public string GetName()
    {
        return name;
    }

    // setter - public access to set private variable
    public void SetName(string name)
    {
        this.name = name;
    }
}