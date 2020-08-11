using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace FormAndClass
{
    class MyHexagon
    {
        public Point[] vertexArr;
        public Color colgam;
        public int penSize;
        public bool Filled;
        public Color subcol;

        public MyHexagon()
        {
            this.vertexArr = new Point[6];
        }
        public MyHexagon(Point v0, Point v1, Point v2,Point v3,Point v4,Point v5, Color col, int penSize,bool fill)
        {
            this.vertexArr = new Point[] { v0,v1,v2,v3,v4,v5 };
            this.colgam = col;
            this.Filled = fill;
            this.penSize = penSize;
        }
        public MyHexagon(Point v0, Point v1, Point v2, Point v3, Point v4, Point v5, Color col, int penSize, bool fill,Color subcol)
        {
            this.vertexArr = new Point[] { v0, v1, v2, v3, v4, v5 };
            this.colgam = col;
            this.Filled = fill;
            this.penSize = penSize;
            this.subcol = subcol;
        }
    }
}

