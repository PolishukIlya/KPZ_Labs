using System;
using System.Collections.Generic;

abstract class Subscription
{
    public abstract string Name { get; }
    public abstract double MonthlyFee { get; }
    public abstract int MinimumPeriod { get; }
    public abstract List<string> Channels { get; }
    public abstract List<string> Features { get; }

    public void DisplayDetails()
    {
        Console.WriteLine($"Тип підписки: {Name}");
        Console.WriteLine($"Щомісячна плата: {MonthlyFee} грн");
        Console.WriteLine($"Мінімальний період: {MinimumPeriod} місяців");
        Console.WriteLine("Список каналів:");
        Channels.ForEach(channel => Console.WriteLine($" - {channel}"));
        Console.WriteLine("Інші можливості:");
        Features.ForEach(feature => Console.WriteLine($" - {feature}"));
    }
}