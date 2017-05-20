using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4
{
    public partial class Form1 : Form
    {
        Point prevPoint = new Point(0, 0);
        Pen pen = new Pen(Color.Black);
        List<int> x_cord = new List<int>();

        List<int> y_cord = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }
       

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            prevPoint = e.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            int minX = Math.Min(prevPoint.X, e.Location.X - 10);
            int minY = Math.Min(prevPoint.Y, e.Location.Y - 10);
            x_cord.Add(minX);
            y_cord.Add(minY);
            pictureBox1.Refresh();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            for (int i = 0; i < y_cord.Count; i++)
            {
                y_cord[i] += 3;
            }
                Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

            for (int i = 0; i < y_cord.Count; i++)
            {
                e.Graphics.FillEllipse(pen.Brush, x_cord[i], y_cord[i], 10, 10);
            }
        }
    }
}
