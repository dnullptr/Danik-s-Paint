using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace FormAndClass
{
    class MyRectangle
    {
        public Point startPoint;
        public int width;
        public int height;
        public Color colgam;
        public bool Filled;
        public Color subcol;
        public MyRectangle() { }

        public MyRectangle(int startX,int startY,int width,int height,Color col)
        {
            this.startPoint = new Point(startX, startY);
            this.width = width;
            this.height = height;
            this.colgam = col;
        }
        public MyRectangle(int startX, int startY, int width, int height, Color col,bool fill)
        {
            this.startPoint = new Point(startX, startY);
            this.width = width;
            this.height = height;
            this.colgam = col;
            this.Filled = fill;
        }

        public MyRectangle(int startX, int startY, int width, int height, Color col, bool fill,Color subcol)
        {
            this.startPoint = new Point(startX, startY);
            this.width = width;
            this.height = height;
            this.colgam = col;
            this.Filled = fill;
            this.subcol = subcol;
        }
    }
}
