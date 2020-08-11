using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace FormAndClass
{
    class MyCircle
    {
        public Point startPoint;
        public int Radius;
        public Color colgam;
        public int penSize;
        public bool Filled;
        public Color subcol;
        public MyCircle() { }
        public MyCircle(Point start,int rad,Color col)
        {
            this.startPoint = start;
            this.Radius = rad;
            this.colgam = col;
        }
        public MyCircle(Point start, int rad, Color col,int PenSize)
        {
            this.startPoint = start;
            this.Radius = rad;
            this.colgam = col;
            this.penSize = PenSize;
        }

        public MyCircle(Point start, int rad, Color col, int PenSize,bool fill)
        {
            this.startPoint = start;
            this.Radius = rad;
            this.colgam = col;
            this.penSize = PenSize;
            this.Filled = fill;
        }
        public MyCircle(Point start, int rad, Color col, int PenSize, bool fill,Color subcol)
        {
            this.startPoint = start;
            this.Radius = rad;
            this.colgam = col;
            this.penSize = PenSize;
            this.Filled = fill;
            this.subcol = subcol;
        }
    }
}
