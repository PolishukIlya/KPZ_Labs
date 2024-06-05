using System;

public class Authenticator
{
    private static Authenticator _instance;
    private static readonly object _lock = new object();

    protected Authenticator()
    {
    }

    public static Authenticator Instance
    {
        get
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new Authenticator();
                }
                return _instance;
            }
        }
    }

    public void Authenticate()
    {
        Console.WriteLine("Введіть ім'я користувача:");
        string username = Console.ReadLine();
        Console.WriteLine("Введіть пароль:");
        string password = Console.ReadLine();

        Console.WriteLine($"Користувач {username} автентифікований.");
    }
}