using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace draw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            System.Drawing.Graphics myGraphic;
            myGraphic = this.CreateGraphics();

            Pen myPen1 = new Pen(System.Drawing.Color.LightGreen, 5);
            Pen myPen2 = new Pen(System.Drawing.Color.Red, 5);
            Pen myPen3 = new Pen(System.Drawing.Color.BlueViolet, 5);
            Pen myPen4 = new Pen(System.Drawing.Color.Black, 5);
            Pen myPen5 = new Pen(System.Drawing.Color.DarkRed, 5);

            //วาดดาวโดยใช้DrawLine
            //myGraphic.DrawLine(myPen1, 300, 80, 500, 80);
            //myGraphic.DrawLine(myPen2, 300, 200, 500, 80);
            //myGraphic.DrawLine(myPen3, 300, 80, 500, 200);
            //myGraphic.DrawLine(myPen4, 300, 200, 400, 50);
            //myGraphic.DrawLine(myPen5, 400, 50, 500, 200);

            myGraphic.DrawRectangle(myPen1, 150, 100, 300, 200);
            myGraphic.DrawRectangle(myPen2, 175, 125, 250, 150);
            myGraphic.DrawRectangle(myPen3, 225, 150, 50, 50);
            myGraphic.DrawRectangle(myPen3, 325, 150, 50, 50);
            myGraphic.DrawRectangle(myPen4, 333, 183, 10, 10);
            myGraphic.DrawRectangle(myPen4, 255, 158, 10, 10);
            myGraphic.DrawRectangle(myPen5, 250, 230, 100, 30);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK) 
            {
                btnColor.BackColor = colorDialog1.Color;
            }
        }
    }
}
