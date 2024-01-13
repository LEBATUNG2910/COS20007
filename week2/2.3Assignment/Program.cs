using System;
using System.Drawing;
using System.Windows.Forms;

public class RectangleDrawingForm : Form
{
    private int rectX = 50;
    private int rectY = 50;
    private int rectWidth = 200;
    private int rectHeight = 100;

    public RectangleDrawingForm()
    {
        this.Paint += new PaintEventHandler(DrawRectangles);
    }

    private void DrawRectangles(object sender, PaintEventArgs e)
    {
        Graphics g = e.Graphics;
        Pen pen = new Pen(Color.Black);
        Rectangle rect1 = new Rectangle(rectX, rectY, rectWidth, rectHeight);
        g.DrawRectangle(pen, rect1);
    }

    public static void Main()
    {
        Application.Run(new RectangleDrawingForm());
    }
}
