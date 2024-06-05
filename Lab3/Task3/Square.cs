using System;

public class Square : Shape
{
    private float side;

    public Square(Renderer renderer, float side) : base(renderer)
    {
        this.side = side;
    }

    public override void Draw()
    {
        renderer.RenderSquare(side);
    }
}