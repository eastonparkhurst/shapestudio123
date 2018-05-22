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
        int xq;
        int yq;
        int z;
        int a;
        int b;
        int c;
        int d;
        int aq;
        int f;
        int gq;
        int h;
        int i;
        int j;
        int k;
        int l;
        int m;
        int n;
        int o;
        int p;
        int q;
        int r;
        int s;
        int t;
        int uq;
        int vq;
        int w;





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
            Pen myPen = new Pen(Color.Red);
            Brush myBrush = new SolidBrush(Color.Green);
            Brush mylolbrush = new SolidBrush(Color.Blue);

            //the fields below designate where the shapes are located. Some of the shapes are stationary and do NOT move, hence the fixed points.
            g.DrawRectangle(myPen, a, b, c, d);
            g.FillRectangle(myBrush, aq, f, gq, h);
            g.DrawEllipse(myPen, i, j, k, l);
            g.DrawEllipse(myPen, m, n, 5, 5);
            g.FillEllipse(mylolbrush, q, r, s, t);
            g.FillEllipse(mylolbrush, uq, vq, w, z);
            g.DrawImage(image_field, xq, yq);
            g.DrawImage(image_field, x, y);



        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            // move the picture of a wheel

            // Step 1: Change some data (field?) that remembers where the wheel is


            y = y + 15;
            x = x + 15;
            a = a + 25;
            b = b + 25;
            c = c + 50;
            d = d + 45;
            aq = aq + 25;
            f = f + 25;
            gq = gq + 50;
            h = h + 45;
            i = i + 25;
            j = j + 50;
            k = k + 25;
            l = l + 25;
            m = m + 75;
            n = n + 75;
            o = o + 25;
            p = p + 25;
            q = q + 75;
            r = r + 75;
            s = s + 25;
            t = t + 25;
            uq = uq + 25;
            vq = vq + 25;
            w = w + 25;
            z = z + 10;
            xq = xq + 7;
            yq = yq + 51;

            //Step 2: Re - draw everything
            Refresh();

        }
        //the code below reacts to you clicking and moving the mouse.
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }

            xq = xq + 1 / 5;
            x = x + 1;

            y = y + 0
                ;
            Refresh();




            // The left button is being pressed, so go ahead and move stuff
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            bool isMouseDown;
            int mousestartx;
            int mousestarty;
            int imagestartx;
                int imagestarty;
                
        }
    }//   g.DrawRectangle(myPen, 100, 100, 200, 150);
     //g.FillRectangle(myBrush, 100, 100, 200, 150);
     //  g.DrawEllipse(myPen, 100, 300, 100, 100);
     //g.DrawEllipse(myPen, 300, 300, 100, 100);
     //g.FillEllipse(mylolbrush, 300, 300, 100, 100);
     //g.FillEllipse(mylolbrush, 100, 300, 100, 100);


}
