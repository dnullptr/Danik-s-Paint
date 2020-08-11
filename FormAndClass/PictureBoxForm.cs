using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace FormAndClass
{
    public partial class PictureBoxForm : Form
    {
        public static int PenSize = 3;
        public ColorDialog dlg = new ColorDialog();
        List<MyLine> list = new List<MyLine>();
        List<MyRectangle> list2 = new List<MyRectangle>();
        List<MyEllipse> list3 = new List<MyEllipse>();
        List<MyCircle> list4 = new List<MyCircle>();
        List<MyTriangle> list5 = new List<MyTriangle>();
        List<MyHexagon> list6 = new List<MyHexagon>();

        MyLine l1 = new MyLine();
        MyRectangle r1 = new MyRectangle();
        MyEllipse e1 = new MyEllipse();
        MyCircle c1 = new MyCircle();
        MyTriangle t1 = new MyTriangle();
        MyHexagon h1 = new MyHexagon();


        private bool CanDrawLine = false;
        private bool CanDrawRect = false;
        private bool CanDrawElli = false;
        private bool CanDrawCircle = false;
        private bool CanDrawTriangle = false;
        private bool CanDrawHexagon = false;


        static Pen MyPen = new Pen(Color.Red, PenSize);
        static bool isFilled = false; //determines whether the form isFilled or nah.

        int[] StartX = new int[6];
        int[] StartY = new int[6];
        bool LineButton,RectButton,ElliButton,CircleButton,TriangleButton,HexagonButton; //states for buttons in the picboxform.
        Color gradient = Color.White; //by default because it's nice :P , this will be called 'subcol' in object's constructor.
        Stack<string> moves = new Stack<string>();

        public PictureBoxForm()
        {
            InitializeComponent();
            
        }

        private void LineBtn_Click(object sender, EventArgs e)
        {
            LineButton = true;
            RectButton = false;
            ElliButton = false;
            CircleButton = false;
            TriangleButton = false;
            HexagonButton =false;
        }

        private void RectBtn_Click(object sender, EventArgs e)
        {
            LineButton = false;
            RectButton = true;
            ElliButton = false;
            CircleButton = false;
            TriangleButton = false;
            HexagonButton = false;
        }

        private void ElliBtn_Click(object sender, EventArgs e)
        {
            LineButton = false;
            RectButton = false;
            ElliButton = true;
            CircleButton = false;
            TriangleButton = false;
            HexagonButton = false;
        }
        private void CircleBtn_Click(object sender, EventArgs e)
        {
            LineButton = false;
            RectButton = false;
            ElliButton = false;
            CircleButton = true;
            TriangleButton = false;
            HexagonButton = false;
        }

        private void TrngleBtn_Click(object sender, EventArgs e)
        {
            LineButton = false;
            RectButton = false;
            ElliButton = false;
            CircleButton = false;
            TriangleButton = true;
            HexagonButton = false;
        }

        private void HxgnBtn_Click(object sender, EventArgs e)
        {
            LineButton = false;
            RectButton = false;
            ElliButton = false;
            CircleButton = false;
            TriangleButton = false;
            HexagonButton = true;
        }
        private void ColDiag_Click(object sender, EventArgs e) //coldiag
        {
            
            if (LineButton)
            {
                dlg.ShowDialog();
                l1.colgam = dlg.Color;
                MyPen.Color = dlg.Color;
            }
            if (RectButton)
            {
                dlg.ShowDialog();
                r1.colgam = dlg.Color;
                MyPen.Color = dlg.Color;
            }
            if (ElliButton)
            {
                dlg.ShowDialog();
                e1.colgam = dlg.Color;
                MyPen.Color = dlg.Color;
            }
            if (CircleButton)
            {
                dlg.ShowDialog();
                c1.colgam = dlg.Color;
                MyPen.Color = dlg.Color;
            }

            if (TriangleButton)//todo
            {
                dlg.ShowDialog();
                t1.colgam = dlg.Color;
                MyPen.Color = dlg.Color;
            }

            if (HexagonButton)//todo
            {
                dlg.ShowDialog();
                //h1.color = dlg.Color;
                MyPen.Color = dlg.Color;
            }

        }

        

        private void Label1_Click(object sender, EventArgs e)
        {
            PenSize = 5;
        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

       
        private void DoFillBtn_Click(object sender, EventArgs e)
        {
            if (!isFilled)
                isFilled = true;
            else isFilled = !isFilled;
            
        }

        private void DontFillBtn_Click(object sender, EventArgs e)
        {
            //obsolete , moved to a single "switch" button of DoFill
        }

        private void PenPlusBtn_Click(object sender, EventArgs e)
        {
            PenSize++;
            Refresh();
        }
        private void PenMinusBtn_Click(object sender, EventArgs e)
        {
            PenSize--;
            Refresh();
        }
        private void PictureBoxForm_Load(object sender, EventArgs e)
        {
            
        }
        public void ClearCurrentPoly() 
        {
            /*l1.startPoint.X = 0; l1.startPoint.Y = 0;
            l1.endPoint.X = 0; l1.endPoint.Y = 0;
            r1.startPoint.X = 0; r1.startPoint.Y = 0; r1.width = 0;r1.height = 0;
            e1.startPoint.X = 0; e1.startPoint.Y = 0; e1.width = 0; e1.height = 0;
            c1.startPoint.X = 0;c1.startPoint.Y = 0; c1.Radius = 0;*/
           
            
        }
        private void ClrAllBtn_Click(object sender, EventArgs e)
        {
            list.Clear();
            list2.Clear();
            list3.Clear();
            list4.Clear();
            list5.Clear();
            list6.Clear();
            ClearCurrentPoly();
            moves.Clear();
            Refresh();

        }

        private void UndoBtn_Click(object sender, EventArgs e) //uses stack to see what was the last move
        {
            
            string WhatToUndo="Nothing";
            if(moves.Count>0)
                WhatToUndo = moves.Pop();
            
            if (WhatToUndo.Equals("Line"))
            {
                if (list.Count() > 0)
                    list.RemoveAt(list.Count() - 1);
                else ClearCurrentPoly();
                Refresh();
            }
            if (WhatToUndo.Equals("Rect"))
            {
                if (list2.Count() > 0)
                    list2.RemoveAt(list2.Count() - 1);
                else ClearCurrentPoly();
                Refresh();
            }
            if (WhatToUndo.Equals("Elli"))
            {
                if (list3.Count() > 0)
                    list3.RemoveAt(list3.Count() - 1);
                else ClearCurrentPoly();
                Refresh();
            }
            if (WhatToUndo.Equals("Circle"))
            {
                if (list4.Count() > 0)
                    list4.RemoveAt(list4.Count() - 1);
                else ClearCurrentPoly();
                Refresh();
            }

            if (WhatToUndo.Equals("Triangle"))
            {
                if (list5.Count() > 0)
                    list5.RemoveAt(list5.Count() - 1);
                else ClearCurrentPoly();
                Refresh();
            }

            if (WhatToUndo.Equals("Hexagon"))
            {
                if (list6.Count() > 0)
                    list6.RemoveAt(list6.Count() - 1);
                else ClearCurrentPoly();
                Refresh();
            }
            Refresh();
        }

        private void FillSubColorBtn_Click(object sender, EventArgs e) // this will choose the gradient color to mixture the fill.
        {
            ColorDialog subcol = new ColorDialog();
            subcol.ShowDialog();
            gradient = subcol.Color;
            Refresh();
        }

        private void pictureBox1_Click(object sender, EventArgs e) //obsolete
        {
            
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {try
            {
                curColorLbl.Text = MyPen.Color.ToString();
                curColorLbl.ForeColor = MyPen.Color;

                penSize2Lbl.Text = PenSize.ToString();
                fillBtn.BackColor = isFilled ? Color.FromArgb(102, 178, 255) : Color.Transparent;
                fillSubColorBtn.BackColor = gradient;
                if (isFilled)
                { //section of filled & unfilled display
                    isFilledLbl.Text = "Filled";
                    isFilledLbl.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                }
                else
                {
                    isFilledLbl.Text = "Not Filled";
                    isFilledLbl.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
                }

                mouseCurPosLbl.Text = MousePosition.X.ToString() + " " + MousePosition.Y.ToString();

                ////////////////////////////////
                if (LineButton)
                {
                    drawLineBtn.BackColor = MyPen.Color; //Change button bg section
                    e.Graphics.DrawLine(MyPen, l1.startPoint, l1.endPoint);
                }
                else drawLineBtn.BackColor = Color.LightGray; //else color goes back

                foreach (MyLine temp in list) //run on the lines exist in the list
                {
                    e.Graphics.DrawLine(new Pen(temp.colgam, temp.penSize), temp.startPoint, temp.endPoint);
                }
                /////////////////////////////
                if (RectButton) //paint all rects from list
                {
                    drawRectBtn.BackColor = MyPen.Color; //Change button bg section
                    if (isFilled) //if fill selected
                    {
                        e.Graphics.DrawRectangle(MyPen, r1.startPoint.X, r1.startPoint.Y, r1.width, r1.height);
                        e.Graphics.FillRectangle(new LinearGradientBrush(r1.startPoint, new Point(r1.startPoint.X + r1.width,
                            r1.startPoint.Y + r1.height), MyPen.Color, gradient), r1.startPoint.X, r1.startPoint.Y, r1.width, r1.height);
                    }
                    else
                    {
                        e.Graphics.DrawRectangle(MyPen, r1.startPoint.X, r1.startPoint.Y, r1.width, r1.height);
                    }


                }
                else drawRectBtn.BackColor = Color.LightGray; //else color goes back

                foreach (MyRectangle temp in list2)
                {
                    e.Graphics.DrawRectangle(new Pen(temp.colgam, PenSize), temp.startPoint.X, temp.startPoint.Y, temp.width, temp.height);
                    if (temp.Filled)
                        e.Graphics.FillRectangle(new LinearGradientBrush(temp.startPoint, new Point(temp.startPoint.X + temp.width, temp.startPoint.Y + temp.height), temp.colgam, temp.subcol), temp.startPoint.X, temp.startPoint.Y, temp.width, temp.height);
                }

                //////////////////////////////
                if (ElliButton)
                {
                    drawEllipseBtn.BackColor = MyPen.Color; //Change button bg section

                    e.Graphics.DrawEllipse(MyPen, e1.startPoint.X, e1.startPoint.Y, e1.width, e1.height);
                    if (isFilled)
                        e.Graphics.FillEllipse(new LinearGradientBrush(e1.startPoint, new Point(e1.startPoint.X + e1.width, e1.startPoint.Y + e1.height), e1.colgam, gradient), e1.startPoint.X, e1.startPoint.Y, e1.width, e1.height);

                }
                else drawEllipseBtn.BackColor = Color.LightGray; //else color goes back

                foreach (MyEllipse temp in list3)
                {
                    e.Graphics.DrawEllipse(new Pen(temp.colgam, temp.penSize), temp.startPoint.X, temp.startPoint.Y, temp.width, temp.height);
                    if (temp.Filled)
                        e.Graphics.FillEllipse(new LinearGradientBrush(temp.startPoint, new Point(temp.startPoint.X + temp.width, temp.startPoint.Y + temp.height), temp.colgam, temp.subcol), temp.startPoint.X, temp.startPoint.Y, temp.width, temp.height);
                }
                //////////////////////////



                if (CircleButton)
                {
                    drawCircleBtn.BackColor = MyPen.Color; //Change button bg section
                    e.Graphics.DrawEllipse(MyPen, c1.startPoint.X, c1.startPoint.Y, c1.Radius, c1.Radius);
                    if (isFilled)
                        e.Graphics.FillEllipse(new LinearGradientBrush(c1.startPoint, new Point(c1.startPoint.X + c1.Radius, c1.startPoint.Y + c1.Radius), c1.colgam, gradient), e1.startPoint.X, e1.startPoint.Y, e1.width, e1.height);

                }
                else drawCircleBtn.BackColor = Color.LightGray; //else color goes back

                foreach (MyCircle temp in list4)
                {
                    e.Graphics.DrawEllipse(new Pen(temp.colgam, temp.penSize), temp.startPoint.X, temp.startPoint.Y, temp.Radius, temp.Radius);
                    if (temp.Filled)
                        e.Graphics.FillEllipse(new LinearGradientBrush(temp.startPoint, new Point(temp.startPoint.X + temp.Radius, temp.startPoint.Y + temp.Radius), temp.colgam, temp.subcol), temp.startPoint.X, temp.startPoint.Y, temp.Radius, temp.Radius);
                }

                ///////////////////////////

                if (TriangleButton && CanDrawTriangle)
                {
                    drawTriangleBtn.BackColor = MyPen.Color;
                    e.Graphics.DrawPolygon(new Pen(MyPen.Color, PenSize), t1.vertexArr);
                    if (isFilled)
                        e.Graphics.FillPolygon(new LinearGradientBrush(t1.vertexArr[0].X == 0 && t1.vertexArr[0].Y == 0 ? new Point(1, 1) : t1.vertexArr[0], t1.vertexArr[2].X == 0 && t1.vertexArr[2].Y == 0 ? new Point(1, 1) : t1.vertexArr[2], t1.colgam, gradient), t1.vertexArr);

                }
                else drawTriangleBtn.BackColor = Color.LightGray; //else color goes back

                foreach (MyTriangle temp in list5)
                {
                    if (temp.Filled)
                    {

                        e.Graphics.DrawPolygon(new Pen(temp.colgam, temp.penSize), temp.vertexArr);
                        e.Graphics.FillPolygon(new LinearGradientBrush(temp.vertexArr[0], temp.vertexArr[2], temp.colgam, temp.subcol), temp.vertexArr);
                    }
                    else
                        e.Graphics.DrawPolygon(new Pen(temp.colgam, temp.penSize), temp.vertexArr);

                }


                ////////////////////////



                if (HexagonButton && CanDrawHexagon)
                {
                    drawHexagonBtn.BackColor = MyPen.Color; //Change button bg section

                    e.Graphics.DrawPolygon(new Pen(MyPen.Color, h1.penSize), h1.vertexArr); //of current
                    if (isFilled)
                        e.Graphics.FillPolygon(new LinearGradientBrush(h1.vertexArr[0], h1.vertexArr[3], h1.colgam, gradient), h1.vertexArr);

                }
                else drawHexagonBtn.BackColor = Color.LightGray; //else color goes back

                foreach (MyHexagon temp in list6)
                {
                    if (temp.Filled)
                    {

                        e.Graphics.DrawPolygon(new Pen(temp.colgam, temp.penSize), temp.vertexArr);
                        e.Graphics.FillPolygon(new LinearGradientBrush(temp.vertexArr[0], temp.vertexArr[3], temp.colgam, temp.subcol), temp.vertexArr);
                    }
                    else
                        e.Graphics.DrawPolygon(new Pen(temp.colgam, temp.penSize), temp.vertexArr);
                }

            }
            catch(OutOfMemoryException exit)
            {
                isFilledLbl.Text = "Not Enough VRAM to Fill Form , please use a 3D accelerator with 256MB+";
                ClearCurrentPoly(); //since i use a heavy brush - I'll clear some of the VRAM buffer as the VDI allows only 32MB of VRAM
               
            }
          
          
        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {

            if (LineButton)
            {
                CanDrawLine = true;
                StartX[0] = e.X;
                StartY[0] = e.Y;
            }
            if (RectButton)
            {
                CanDrawRect = true;
                StartX[1] = e.X;
                StartY[1] = e.Y;
            }
            if (ElliButton)
            {
                CanDrawElli = true;
                StartX[2] = e.X;
                StartY[2] = e.Y;
            }

            if (CircleButton)
            {
                CanDrawCircle = true;
                StartX[3] = e.X;
                StartY[3] = e.Y;
            }

            if (TriangleButton)
            {
                CanDrawTriangle = true;
                StartX[4] = e.X;
                StartY[4] = e.Y;
            }

            if (HexagonButton)
            {
                CanDrawHexagon = true;
                StartX[5] = e.X;
                StartY[5] = e.Y;
            }
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (CanDrawLine == true)
            {
                l1.startPoint = new Point(StartX[0], StartY[0]);
                l1.endPoint = new Point(e.X, e.Y);
                Refresh();
            }
            if (CanDrawRect == true)
            {
                int x = Math.Min(StartX[1], e.X);
                int y = Math.Min(StartY[1], e.Y);
                int width = Math.Max(StartX[1], e.X) - Math.Min(StartX[1], e.X);
                int height = Math.Max(StartY[1], e.Y) - Math.Min(StartY[1], e.Y);

                r1.startPoint = new Point(x, y);
                r1.width = width;
                r1.height = height;
                Refresh();
            }
            if (CanDrawElli)
            {
                int x = Math.Min(StartX[2], e.X);
                int y = Math.Min(StartY[2], e.Y);
                int width = Math.Max(StartX[2], e.X) - Math.Min(StartX[2], e.X);
                int height = Math.Max(StartY[2], e.Y) - Math.Min(StartY[2], e.Y);
                e1.startPoint = new Point(x, y);
                e1.width = width;
                e1.height = height;
                Refresh();
            }

            if (CanDrawCircle)
            {
                int x = Math.Min(StartX[3], e.X);
                int y = Math.Min(StartY[3], e.Y);
                int width = Math.Max(StartX[3], e.X) - Math.Min(StartX[3], e.X);
                int height = Math.Max(StartY[3], e.Y) - Math.Min(StartY[3], e.Y);
                c1.startPoint = new Point(x, y);
                c1.Radius = (width+height)/2; 
                Refresh();
            }

            if(CanDrawTriangle)
            {
                int x = Math.Min(StartX[4], e.X);
                int y = Math.Min(StartY[4], e.Y);
                int width = Math.Max(StartX[4], e.X) - Math.Min(StartX[4], e.X);
                int height = Math.Max(StartY[4], e.Y) - Math.Min(StartY[4], e.Y);
                int Gova = (width - height);

                t1.vertexArr[0] = new Point(x + Gova, y - Gova); //240 450
                t1.vertexArr[1] = new Point(x,y); //200 520
                t1.vertexArr[2] = new Point(x + 2*Gova, y ); //270 520
                t1.Filled= isFilled ? true : false;
                t1.penSize = PenSize;
                Refresh();


            }

            if (CanDrawHexagon)
            {
                int x = Math.Min(StartX[5], e.X);
                int y = Math.Min(StartY[5], e.Y);
                int width = Math.Max(StartX[5], e.X) - Math.Min(StartX[5], e.X);
                int height = Math.Max(StartY[5], e.Y) - Math.Min(StartY[5], e.Y);
                int Gova = Math.Abs(width-height);
               
                h1.vertexArr[0] = new Point(x, y);
                h1.vertexArr[1] = new Point(x, y + Gova);
                h1.vertexArr[2] = new Point(x + Gova, y + 2 * Gova);
                h1.vertexArr[3] = new Point(x + 2 * Gova, y + Gova);
                h1.vertexArr[4] = new Point(x + 2 * Gova, y);
                h1.vertexArr[5] = new Point(x + Gova, y - Gova); 
                h1.Filled = isFilled ? true : false;
                h1.penSize = PenSize;
                Refresh();
            }

        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {

            CanDrawLine = false;
            CanDrawRect = false;
            CanDrawElli = false;
            CanDrawCircle = false;
            CanDrawTriangle = false;
            CanDrawHexagon = false;

            l1.endPoint = e.Location;

            if (LineButton)
            { 
                list.Add(new MyLine(l1.startPoint, l1.endPoint, MyPen.Color, PenSize));
                moves.Push("Line");
                ClearCurrentPoly();
            }
            if (RectButton)
            { 
                if (isFilled)
                    list2.Add(new MyRectangle(r1.startPoint.X, r1.startPoint.Y, r1.width, r1.height, MyPen.Color, true,gradient));
                else
                    list2.Add(new MyRectangle(r1.startPoint.X, r1.startPoint.Y, r1.width, r1.height, MyPen.Color, false));
                moves.Push("Rect");
                ClearCurrentPoly();
            }

            if (ElliButton)
            {
                if (isFilled)
                    list3.Add(new MyEllipse(e1.startPoint, MyPen.Color, PenSize, e1.width, e1.height, true, gradient));
                else
                    list3.Add(new MyEllipse(e1.startPoint, MyPen.Color, PenSize, e1.width, e1.height, false));
                moves.Push("Elli");
                ClearCurrentPoly();
            }

            if (CircleButton)
            {
                if (isFilled)
                    list4.Add(new MyCircle(c1.startPoint, c1.Radius, MyPen.Color, PenSize, true, gradient));
                else
                    list4.Add(new MyCircle(c1.startPoint, c1.Radius, MyPen.Color, PenSize, false));
                moves.Push("Circle");
                ClearCurrentPoly();
            }


            if (TriangleButton)
            {
                list5.Add(new MyTriangle(t1.vertexArr[0], t1.vertexArr[1], t1.vertexArr[2], MyPen.Color, PenSize, isFilled, gradient));
                moves.Push("Triangle");
                ClearCurrentPoly();
            }


            if (HexagonButton)
            {
                list6.Add(new MyHexagon(h1.vertexArr[0], h1.vertexArr[1], h1.vertexArr[2], h1.vertexArr[3], h1.vertexArr[4], h1.vertexArr[5], MyPen.Color, PenSize, isFilled, gradient));
                moves.Push("Hexagon");
                ClearCurrentPoly();
            }

            
            Refresh();
        }

       
    }
}
