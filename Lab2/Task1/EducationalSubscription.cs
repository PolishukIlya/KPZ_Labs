using System.Collections.Generic;

class EducationalSubscription : Subscription
{
    public override string Name => "Освітня підписка";
    public override double MonthlyFee => 50.00;
    public override int MinimumPeriod => 6;
    public override List<string> Channels => new List<string> { "Освіта", "Наука", "Документальні" };
    public override List<string> Features => new List<string> { "HD якість", "Доступ до архіву" };
}