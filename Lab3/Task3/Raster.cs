using System;

public class Raster : Renderer
{
    public void RenderCircle(float radius)
    {
        Console.WriteLine($"Drawing Circle as pixels with radius {radius}");
    }

    public void RenderSquare(float side)
    {
        Console.WriteLine($"Drawing Square as pixels with side {side}");
    }

    public void RenderTriangle(float baseLength, float height)
    {
        Console.WriteLine($"Drawing Triangle as pixels with base {baseLength} and height {height}");
    }
}