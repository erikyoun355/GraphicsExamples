using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace GraphicsExamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            // graphics objects
            Graphics formGraphics = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Red, 10);
            SolidBrush drawBrush = new SolidBrush(Color.Yellow);
            SolidBrush textBrush = new SolidBrush(Color.Black);

            Font drawFont = new Font("road rage", 16);

            formGraphics.Clear(Color.Black);
            formGraphics.DrawLine(drawPen, 0, 0, 100, 100);
            formGraphics.DrawRectangle(drawPen, 30, 30, 100, 200);
            formGraphics.FillRectangle(drawBrush, 30, 30, 100, 200);

            Thread.Sleep(1000);
            formGraphics.Clear(Color.White);

            formGraphics.DrawEllipse(drawPen, 25, 50, 100, 100);

            drawPen = new Pen(Color.Blue);
            formGraphics.DrawArc(drawPen, 150, 20, 50, 50, 30, 300);
            formGraphics.DrawPie(drawPen, 150, 100, 50, 50, 30, 60);

            formGraphics.DrawString("Hello", drawFont, textBrush, 200, 40);
        }
    }
}
