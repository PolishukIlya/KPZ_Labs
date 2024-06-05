using System;

public interface Renderer
{
    void RenderCircle(float radius);
    void RenderSquare(float side);
    void RenderTriangle(float baseLength, float height);
}