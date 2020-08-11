using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace FormAndClass
{
    class MyTriangle
    {
        public Point[] vertexArr;
        public Color colgam;
        public int penSize;
        public bool Filled;
        public Color subcol;
        public MyTriangle()
        {
            this.vertexArr = new Point[3];
        }

        public MyTriangle(Point left, Point head, Point right, Color colgam, int penSize, bool fill)
        {
            this.vertexArr = new Point[3] { left, head, right };
            this.colgam = colgam;
            this.penSize = penSize;
            this.Filled = fill;
        }
        public MyTriangle(Point left, Point head, Point right, Color colgam, int penSize, bool fill,Color subcol)
        {
            this.vertexArr = new Point[3] { left, head, right };
            this.colgam = colgam;
            this.penSize = penSize;
            this.Filled = fill;
            this.subcol = subcol;
        }
        

    }
}
