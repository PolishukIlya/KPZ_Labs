using System;

class Program
{
    static void Main(string[] args)
    {
        LightElementNode table = new LightElementNode("table", "block", false);
        table.CssClasses.Add("my-table");

        LightElementNode tbody = new LightElementNode("tbody", "block", false);
        table.AddChild(tbody);

        LightElementNode tr1 = new LightElementNode("tr", "block", false);
        tbody.AddChild(tr1);

        LightElementNode td1 = new LightElementNode("td", "block", false);
        td1.AddChild(new LightTextNode("Cell 1"));
        tr1.AddChild(td1);

        LightElementNode td2 = new LightElementNode("td", "block", false);
        td2.AddChild(new LightTextNode("Cell 2"));
        tr1.AddChild(td2);

        Console.WriteLine("Outer HTML:");
        Console.WriteLine(table.OuterHTML);

        Console.WriteLine("Inner HTML:");
        Console.WriteLine(table.InnerHTML);

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}