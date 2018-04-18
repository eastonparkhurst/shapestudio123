﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shape_studio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Width = 500;
            this.Height = 500;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen myPen = new Pen(Color.Black);
            Brush myBrush = new SolidBrush(Color.Yellow);
            Brush mylolbrush = new SolidBrush(Color.Black);


            g.DrawRectangle(myPen, 100, 100, 200, 150);
            g.FillRectangle(myBrush, 100, 100, 200, 150);
            g.DrawEllipse(myPen, 100, 300, 100, 100);
            g.DrawEllipse(myPen, 300, 300, 100, 100);
            g.FillEllipse(mylolbrush, 300, 300, 100, 100);
            g.FillEllipse(mylolbrush, 100, 300, 100, 100);







        }
    }
}
