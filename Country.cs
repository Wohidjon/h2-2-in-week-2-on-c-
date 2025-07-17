public class Country
{
    private string name;
    private string capital;
    private int population;
    private string officialLanguage;

    // Конструктор
    public Country(string n, string c, int p, string lang)
    {
        name = n;
        capital = c;
        population = p;
        officialLanguage = lang;
    }

    // Методы
    public void SetCapital(string c)
    {
        capital = c;
    }

    public string GetCapital()
    {
        return capital;
    }

    public void SetPopulation(int p)
    {
        population = p;
    }

    public int GetPopulation()
    {
        return population;
    }

    public void SetOfficialLanguage(string lang)
    {
        officialLanguage = lang;
    }

    public string GetOfficialLanguage()
    {
        return officialLanguage;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Country Name: {name}");
        Console.WriteLine($"Capital: {capital}");
        Console.WriteLine($"Population: {population:N0}");
        Console.WriteLine($"Official Language: {officialLanguage}");
    }
}