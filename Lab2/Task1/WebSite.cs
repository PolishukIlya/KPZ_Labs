using System;

class WebSite : SubscriptionPurchase
{
    public Subscription CreateSubscription()
    {
        Console.WriteLine("Оберіть тип підписки (1-Домашня, 2-Освітня, 3-Преміум):");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                return new DomesticSubscription();
            case 2:
                return new EducationalSubscription();
            case 3:
                return new PremiumSubscription();
            default:
                throw new Exception("Невірний вибір підписки.");
        }
    }
}