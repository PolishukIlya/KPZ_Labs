using System;

public class Vector : Renderer
{
    public void RenderCircle(float radius)
    {
        Console.WriteLine($"Drawing Circle as vectors with radius {radius}");
    }

    public void RenderSquare(float side)
    {
        Console.WriteLine($"Drawing Square as vectors with side {side}");
    }

    public void RenderTriangle(float baseLength, float height)
    {
        Console.WriteLine($"Drawing Triangle as vectors with base {baseLength} and height {height}");
    }
}