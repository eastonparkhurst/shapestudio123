using System;
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
        Image image_field;
        int x;
        int y;
        public Form1()
        {
            InitializeComponent();
            this.Width = 500;
            this.Height = 500;

            string filename = System.IO.Path.Combine(new string[] { "..", "..", "spoke.jfif" });
            image_field = Image.FromFile(filename);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void Form1_Paint(object sender, PaintEventArgs e)
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
            g.DrawImage(image_field, x, y);




        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            // move the picture of a wheel

            // Step 1: Change some data (field?) that remembers where the wheel is


            y = y + 15;
            x = x + 15;
            // Step 2: Re-draw everything
            Refresh();

        }
    }
}
