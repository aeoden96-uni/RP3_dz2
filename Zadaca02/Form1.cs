using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadaca02
{
    public partial class Sinus : Form
    {
        public Sinus()
        {
            InitializeComponent();

            

            vremenski_raspon1.promjena += new EventHandler(UserControl_ValueChanged);
        }

        protected void UserControl_ValueChanged(object sender, EventArgs e)
        {
            label4.Text = vremenski_raspon1.raspon.Item1.Day.ToString();
        }

        int count = 5;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void draw_sin(int x,int ind)
        {
            var scalar =   (float)(count+2) / 10.0f;

            label3.Text = scalar.ToString();
            

            float sin_x = (float)x / groupBox1.Size.Width;

            //label4.Text = sin_x.ToString();

            int sin_y = (int)(Math.Sin(sin_x * scalar) * (groupBox1.Size.Height / 2) + groupBox1.Size.Height / 2);

            draw_circ(x, sin_y);
        }

        private void draw_circ(int x,int y)
        {
            var pen = new Pen(Brushes.Black, 1);
            groupBox1.CreateGraphics().DrawEllipse(pen,x-2, y-2,4,4);
        }


        private void draw_tick(int x,int len)
        {
            var pen = new Pen(Brushes.Black, 2);
            groupBox1.CreateGraphics().DrawLine(pen,
                        new Point(x,    groupBox1.Size.Height / 2 - len),
                        new Point(x,    groupBox1.Size.Height / 2 + len));
        }

        private void draw_x()
        {
            int offset = 10;
            var pen = new Pen(Brushes.Black, 2);
            groupBox1.CreateGraphics().DrawLine(pen,
                        new Point(offset,                           groupBox1.Size.Height / 2),
                        new Point(groupBox1.Size.Width - offset,    groupBox1.Size.Height / 2));

            
            int len = groupBox1.Size.Width - 2*offset;
            int k = 1;
            for (int i = offset; i <= len; i += len/count)
            {
                draw_tick(i, 5);
                draw_sin(i,k++ );
            }
            
            //draw_tick(groupBox1.Size.Width - offset, 10);

        }


        private void draw_graph()
        {
            groupBox1.CreateGraphics().Clear(Color.White);

            draw_x();


            
        }





        private void button1_Click(object sender, EventArgs e)
        {
            //pts[count++] = new Point((int)pocetak_1.Value,(int)pocetak_2.Value);

            draw_graph();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void resize_begin(object sender, EventArgs e)
        {
            draw_x();
        }

        private void resize_end(object sender, EventArgs e)
        {
            draw_x();
        }

        private void kraj_1_ValueChanged(object sender, EventArgs e)
        {
            count = (int)kraj_1.Value;
            draw_graph();
        }

        private void datum1_Load(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void vremenski_raspon1_Load(object sender, EventArgs e)
        {

        }
       





    }
}
