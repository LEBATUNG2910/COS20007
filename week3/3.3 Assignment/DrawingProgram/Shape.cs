using SplashKitSDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingProgram
{
    public class Shape
    {
        private bool oselected;
        private float ox, oy;
        private int owidth, oheight;
        private Color ocolor;
        public float X
        {
            get
            {
                return ox;
            }
            set
            {
                ox = value;
            }
        }
        public float Y
        {
            get
            {
                return oy;
            }
            set
            {
                oy = value;
            }
        }
        public int Width
        {
            get
            {
                return owidth;
            }
            set
            {
                owidth = value;
            }
        }
        public int Height
        {
            get
            {
                return oheight;
            }
            set
            {
                oheight = value;
            }
        }
        public bool Selected
        {
            get
            {
                return oselected;
            }
            set
            {
                oselected = value;
            }
        }
        public Color Color
        {
            get
            {
                return ocolor;
            }
            set
            {
                ocolor = value;
            }
        }
        public Shape()
        {
            ox = 0;
            oy = 0;
            owidth = 50;
            oheight = 50;
            ocolor = SplashKit.ColorGreen();
        }
        public Shape(Color color, float x, float y, int width, int height)
        {
            ocolor = color;
            ox = x;
            oy = y;
            owidth = width;
            oheight = height;
        }
        public void Draw()
        {
            if (oselected == true)
            {
                DrawOutline();
            }
            SplashKit.FillRectangle(ocolor, ox, oy, owidth, oheight); //draw shape
        }

        public bool IsAt(Point2D pt) //the result return bool so need to set bool here, pt is param
        {
            if ((((pt.X >= ox) && (pt.X <= (ox + owidth))) && (pt.Y >= oy) && (pt.Y <= (oy + oheight))))
            // mouse x-coor >= shape x-coor && mouse x-coor <= shape x-coor + shape width 
            // mouse y-coor >= shape y-coor && mouse y-coor <= shape y-coor + height
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void DrawOutline()
        {
            SplashKit.FillRectangle(SplashKit.ColorBlack(), ox - 2, oy - 2, owidth + 4, oheight + 4); //draw shape
        }
    }
}
