using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormAndClass
{
    public partial class Form1 : Form
    {
        public static int PenSize = 3;

        List<MyLine> list = new List<MyLine>();
        List<MyRectangle> list2 = new List<MyRectangle>();
        List<MyEllipse> list3 = new List<MyEllipse>();
        List<MyCircle> list4 = new List<MyCircle>();

        MyLine l1 = new MyLine();
        MyRectangle r1 = new MyRectangle();
        MyEllipse e1 = new MyEllipse();
        MyCircle c1 = new MyCircle();

        private bool CanDrawLine= false;
        private bool CanDrawRect = false;
        private bool CanDrawElli = false;
        private bool CanDrawCircle = false;

        private int startX, startY;

        static Pen MyPen = new Pen(Color.Red, PenSize);
        
        public Form1()
        {
            InitializeComponent();
        }

        
        public void Form1_Paint(object sender, PaintEventArgs e)
        {
           

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (CanDrawLine==true)
            {
                l1.startPoint = new Point(startX, startY);
                l1.endPoint = new Point(e.X, e.Y);
                Refresh();
            }

            if (CanDrawRect==true)
            { 
            r1.startPoint = new Point(startX, startY);
            Refresh();
            }

            if(CanDrawElli==true)
            { 
            e1.startPoint = new Point(startX, startY);
            Refresh();
            }

            if (CanDrawCircle == true)
            {
              c1.startPoint = new Point(startX, startY);
              Refresh();
            }


        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
                
            
            
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
           

        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void Button1_Click(object sender, EventArgs e) //ColorDialog button
        {
            ColorDialog coldiag = new ColorDialog();
            coldiag.ShowDialog();
            MyPen.Color = coldiag.Color;
            
        }

        private void Button2_Click(object sender, EventArgs e) //undo
        {
       
            
        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PenPlusBtn_Click(object sender, EventArgs e)
        {
            PenSize++;
        }

        private void PenMinusBtn_Click(object sender, EventArgs e)
        {
            PenSize--;
        }

        private void CheckBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            PictureBoxForm f = new PictureBoxForm();
            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
