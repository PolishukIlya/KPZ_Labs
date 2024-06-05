using System.Collections.Generic;

class DomesticSubscription : Subscription
{
    public override string Name => "Домашня підписка";
    public override double MonthlyFee => 100.00;
    public override int MinimumPeriod => 12;
    public override List<string> Channels => new List<string> { "Домашній", "Новини", "Фільми" };
    public override List<string> Features => new List<string> { "HD якість", "Запис програм" };
}