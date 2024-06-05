using System;

public class Circle : Shape
{
    private float radius;

    public Circle(Renderer renderer, float radius) : base(renderer)
    {
        this.radius = radius;
    }

    public override void Draw()
    {
        renderer.RenderCircle(radius);
    }
}