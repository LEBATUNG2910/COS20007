using SplashKitSDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingProgram
{
    public class Drawing
    {
        public readonly List<Shape> oshapes;
        private Color obackground;
        public Color Background
        {
            get
            {
                return obackground;
            }
            set
            {
                obackground = value;
            }
        }
        public Drawing(Color background)
        {
            oshapes = new List<Shape>();
            obackground = background;
        }
        public Drawing() : this(Color.White) { }
        public List<Shape> SelectedShapes 
        { 
            get 
            {
                List<Shape> result = new();
                foreach (Shape s in oshapes)
                {
                    if (s.Selected == true)
                     {
                        result.Add(s);
                    }
                }
                return result;
            } 
        }
        public int ShapeCount
        {
            get
            {
                return oshapes.Count; 
            }
        }
        public void AddShape(Shape shape)
        {
            oshapes.Add(shape);
        }

        public void Draw()
        {
            SplashKit.ClearScreen(obackground);
            foreach (Shape shape in oshapes)
            {
                shape.Draw();
            }
        }
        public void SelectShapesAt(Point2D pt)
        {
            foreach (Shape s in oshapes)
            {
                if (s.IsAt(pt))
                {
                    s.Selected = true;
                }
                else
                {
                    s.Selected = false;
                }
            }
        }

        public void RemoveShape(Shape shape)
        {
            oshapes.Remove(shape);
        }

    }
}
