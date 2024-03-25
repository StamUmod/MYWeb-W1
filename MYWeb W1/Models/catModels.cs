namespace MYWeb_W1.Models;

public class catModels
{
    public int id;
    public string cat;
    public string cats;
    public bool Nurturing;
}

public static class catModelDb
{
    public static Dictionary<string, catModels> _dictionary = new Dictionary<string, catModels>();

    static catModelDb()
    {
        _dictionary.Add("black cat", new catModels()
            {
                id = 1234,
                cat = "black cat",
                Nurturing = false
            }
        );
    }
}

