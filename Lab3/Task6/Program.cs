using System;
using System.IO;
using System.Net;
using System.Text;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string url = "https://www.gutenberg.org/cache/epub/1513/pg1513.txt";
        string bookText = DownloadBookText(url);

        LightNodeFactory factory = new LightNodeFactory();
        LightElementNode root = factory.GetElementNode("html", "block", false);
        LightElementNode body = factory.GetElementNode("body", "block", false);
        root.AddChild(body);

        string[] lines = bookText.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
        bool firstLine = true;

        foreach (string line in lines)
        {
            if (firstLine)
            {
                LightElementNode h1 = factory.GetElementNode("h1", "block", false);
                h1.AddChild(factory.GetTextNode(line));
                body.AddChild(h1);
                firstLine = false;
            }
            else if (line.Length < 20)
            {
                LightElementNode h2 = factory.GetElementNode("h2", "block", false);
                h2.AddChild(factory.GetTextNode(line));
                body.AddChild(h2);
            }
            else if (line.StartsWith(" "))
            {
                LightElementNode blockquote = factory.GetElementNode("blockquote", "block", false);
                blockquote.AddChild(factory.GetTextNode(line));
                body.AddChild(blockquote);
            }
            else
            {
                LightElementNode p = factory.GetElementNode("p", "block", false);
                p.AddChild(factory.GetTextNode(line));
                body.AddChild(p);
            }
        }

        Console.WriteLine("Outer HTML:");
        Console.WriteLine(root.OuterHTML);

        Console.WriteLine("Memory used by the HTML tree:");
        Console.WriteLine(GC.GetTotalMemory(false));

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    static string DownloadBookText(string url)
    {
        using (WebClient client = new WebClient())
        {
            byte[] data = client.DownloadData(url);
            return Encoding.UTF8.GetString(data);
        }
    }
}