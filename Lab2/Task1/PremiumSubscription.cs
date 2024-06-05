using System.Collections.Generic;

class PremiumSubscription : Subscription
{
    public override string Name => "Преміум підписка";
    public override double MonthlyFee => 200.00;
    public override int MinimumPeriod => 24;
    public override List<string> Channels => new List<string> { "Преміум", "Спорт", "Фільми", "Новини" };
    public override List<string> Features => new List<string> { "4K якість", "Без реклами", "Запис програм" };
}