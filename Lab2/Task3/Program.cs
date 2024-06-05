using System;
using System.Threading;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Виберіть режим (1 - однопоточний, 2 - багатопоточний):");
        string choice = Console.ReadLine();

        if (choice == "1")
        {
            SingleThreadDemo();
        }
        else if (choice == "2")
        {
            MultiThreadDemo();
        }
        else
        {
            Console.WriteLine("Неправильний вибір.");
        }

        Console.WriteLine("Натисніть будь-яку клавішу для виходу...");
        Console.ReadKey();
    }

    private static void SingleThreadDemo()
    {
        Console.WriteLine("Однопоточний режим:");
        Authenticator auth = Authenticator.Instance;
        auth.Authenticate();
    }

    private static void MultiThreadDemo()
    {
        Console.WriteLine("Багатопоточний режим:");
        Thread thread1 = new Thread(() =>
        {
            Authenticator auth = Authenticator.Instance;
            auth.Authenticate();
        });

        Thread thread2 = new Thread(() =>
        {
            Authenticator auth = Authenticator.Instance;
            auth.Authenticate();
        });

        thread1.Start();
        thread2.Start();

        thread1.Join();
        thread2.Join();
    }
}
