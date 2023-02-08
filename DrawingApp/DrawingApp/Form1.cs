using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingApp
{
    public partial class Form1 : Form
    {
        private Bitmap bmp = new Bitmap(1024, 768);
        private Pen pen = new Pen(Color.Black, 5);
        private bool drawing = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            drawing = !drawing;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                Graphics graphics = Graphics.FromImage(bmp);
                graphics.DrawEllipse(pen, e.X, e.Y, 3, 1);
                pictureBox1.Image = bmp;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Red;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Blue;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Green;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Purple;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Lime;
        }
    }
}