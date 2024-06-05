using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Choose rendering method (raster/vector): ");
        string renderingMethod = Console.ReadLine();

        Renderer renderer;
        if (renderingMethod.ToLower() == "raster")
        {
            renderer = new Raster();
        }
        else
        {
            renderer = new Vector();
        }

        Console.WriteLine("Choose shape (circle/square/triangle): ");
        string shapeType = Console.ReadLine();

        Shape shape = null;
        switch (shapeType.ToLower())
        {
            case "circle":
                Console.WriteLine("Enter radius: ");
                float radius = float.Parse(Console.ReadLine());
                shape = new Circle(renderer, radius);
                break;
            case "square":
                Console.WriteLine("Enter side length: ");
                float side = float.Parse(Console.ReadLine());
                shape = new Square(renderer, side);
                break;
            case "triangle":
                Console.WriteLine("Enter base length: ");
                float baseLength = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter height: ");
                float height = float.Parse(Console.ReadLine());
                shape = new Triangle(renderer, baseLength, height);
                break;
            default:
                Console.WriteLine("Invalid shape type.");
                break;
        }

        shape?.Draw();

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}