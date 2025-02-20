using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms___Program__3_Paint
{
    public partial class Form1: Form
    {
        Graphics gr;
        Pen pen;
        bool isPaiting;
        Point startPos;
        Point endPos;
        ColorDialog colorDialog;
        
        public Form1()
        {
            InitializeComponent();
            gr = panel1.CreateGraphics();
            pen = new Pen(Color.Black, 10);
            gr.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            colorDialog = new ColorDialog();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            isPaiting = true;
            startPos = e.Location;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isPaiting = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isPaiting == true)
            {
                endPos = e.Location;
                gr.DrawLine(pen, startPos, endPos);
                startPos = endPos;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                pen.Color = colorDialog.Color;
            }
        }
    }
}
