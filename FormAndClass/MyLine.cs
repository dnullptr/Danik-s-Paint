using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace FormAndClass
{
    class MyLine
    {
        public Point startPoint;
        public Point endPoint;
        public Color colgam;
        public int penSize;
        public MyLine() { }

        public MyLine(Point p1 , Point p2)
        {
            this.startPoint = p1;
            this.endPoint = p2;
        }
        public MyLine(Point p1, Point p2,Color col,int PenSize)
        {
            this.startPoint = p1;
            this.endPoint = p2;
            this.colgam = col;
            this.penSize = PenSize;
        }
        public MyLine(Point p1, Point p2, Color col)
        {
            this.startPoint = p1;
            this.endPoint = p2;
            this.colgam = col;
            
        }
    }
}
