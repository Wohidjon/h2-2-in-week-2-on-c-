public class Login
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public bool IsLoggedIn { get; set; }

    string UserLoginSystem(string username, string password)
    {
        if (username == UserName && password == Password)
        {
            Console.WriteLine("Пользователь успешно зарегистрирован");
            IsLoggedIn = true;
        }
        else
        {
            Console.WriteLine("Ваш пароль или имя пользователя неверны");
            IsLoggedIn = false;
        }
    }
    public void Logout()
    {
        IsLoggedIn = false;
    }
    public string GetFullInfo()
    {
        return $"{FirstName} {LastName} - {IsLoggedIn}";
    }
    
}