using System;

public class Triangle : Shape
{
    private float baseLength;
    private float height;

    public Triangle(Renderer renderer, float baseLength, float height) : base(renderer)
    {
        this.baseLength = baseLength;
        this.height = height;
    }

    public override void Draw()
    {
        renderer.RenderTriangle(baseLength, height);
    }
}