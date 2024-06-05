using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Оберіть метод придбання підписки (1-Вебсайт, 2-Мобільний додаток, 3-Зв'язок з менеджером):");
        int method = int.Parse(Console.ReadLine());

        SubscriptionPurchase purchaseMethod;

        switch (method)
        {
            case 1:
                purchaseMethod = new WebSite();
                break;
            case 2:
                purchaseMethod = new MobileApp();
                break;
            case 3:
                purchaseMethod = new ManagerCall();
                break;
            default:
                throw new Exception("Невірний вибір методу придбання.");
        }

        Subscription subscription = purchaseMethod.CreateSubscription();
        subscription.DisplayDetails();

        Console.WriteLine("Натисніть будь-яку клавішу для завершення.");
        Console.ReadKey();
    }
}