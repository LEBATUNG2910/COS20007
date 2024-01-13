using System.Drawing;
using System.Windows.Forms;

public abstract class Shape
{
    public int X { get; set; }
    public int Y { get; set; }
    public Color Color { get; set; }

    public Shape(int x, int y, Color color)
    {
        X = x;
        Y = y;
        Color = color;
    }

    public abstract void Draw(Graphics graphics);
}

public class RectangleShape : Shape
{
    public int Width { get; set; }
    public int Height { get; set; }

    public RectangleShape(int x, int y, int width, int height, Color color)
        : base(x, y, color)
    {
        Width = width;
        Height = height;
    }

    public override void Draw(Graphics graphics)
    {
        using (Brush brush = new SolidBrush(Color))
        {
            graphics.FillRectangle(brush, X, Y, Width, Height);
        }
    }
}

public class CircleShape : Shape
{
    public int Radius { get; set; }

    public CircleShape(int x, int y, int radius, Color color)
        : base(x, y, color)
    {
        Radius = radius;
    }

    public override void Draw(Graphics graphics)
    {
        using (Brush brush = new SolidBrush(Color))
        {
            graphics.FillEllipse(brush, X - Radius, Y - Radius, 2 * Radius, 2 * Radius);
        }
    }
}
