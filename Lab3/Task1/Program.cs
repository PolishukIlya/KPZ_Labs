using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть шлях до файлу логів:");
        string filePath = Console.ReadLine();

        Logger logger = new Logger();
        FileLogger fileLogger = new FileLogger(filePath);

        while (true)
        {
            Console.WriteLine("Виберіть опцію (1 - Log, 2 - Error, 3 - Warn, 0 - Exit):");
            string option = Console.ReadLine();

            if (option == "0")
                break;

            Console.WriteLine("Введіть повідомлення:");
            string message = Console.ReadLine();

            switch (option)
            {
                case "1":
                    logger.Log(message);
                    fileLogger.Log(message);
                    break;
                case "2":
                    logger.Error(message);
                    fileLogger.Error(message);
                    break;
                case "3":
                    logger.Warn(message);
                    fileLogger.Warn(message);
                    break;
                default:
                    Console.WriteLine("Невідома опція.");
                    break;
            }
        }
    }
}