using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace FormAndClass
{
    class MyEllipse : MyRectangle
    {
        public Color colgam;
        public int penSize;
        public bool Filled;
        public MyEllipse() { }

        public MyEllipse(Point p1, Color col)
        {
            this.startPoint = p1;
            this.colgam = col;

        }
        public MyEllipse(Point p1, Color col,int PenSize,int width,int height)
        {
            this.startPoint = p1;
            this.colgam = col;
            this.penSize = PenSize;
            this.width = width;
            this.height = height;

        }
        public MyEllipse(Point p1, Color col, int PenSize, int width, int height,bool fill)
        {
            this.startPoint = p1;
            this.colgam = col;
            this.penSize = PenSize;
            this.width = width;
            this.height = height;
            this.Filled = fill;

        }
        public MyEllipse(Point p1, Color col, int PenSize, int width, int height, bool fill,Color subcol)
        {
            this.startPoint = p1;
            this.colgam = col;
            this.penSize = PenSize;
            this.width = width;
            this.height = height;
            this.Filled = fill;
            this.subcol = subcol;

        }
    }
}
