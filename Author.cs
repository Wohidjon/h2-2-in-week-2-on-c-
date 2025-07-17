public class Author
{
    private string name;
    private int age;
    private string nationality;

    // Конструкторы
    public Author()
    {
        name = "Unknown";
        age = 0;
        nationality = "Unknown";
    }

    public Author(string n, int a)
    {
        name = n;
        age = a;
        nationality = "Unknown";
    }

    public Author(string n, int a, string nat)
    {
        name = n;
        age = a;
        nationality = nat;
    }

    // Методы
    public string GetName()
    {
        return name;
    }

    public int GetAge()
    {
        return age;
    }

    public string GetNationality()
    {
        return nationality;
    }

    public void Introduce()
    {
        Console.WriteLine($"Меня зовут {name}. Мне {age} лет. Я из {nationality}.");
    }

    public void CelebrateBirthday()
    {
        age++;
    }
}