using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Artemis
{
    public partial class Window : Form
    {
        private Point lastpoint;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // width of ellipse
           int nHeightEllipse // height of ellipse
       );
        public Window()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            settingsControl1.Hide();
            ultrasoundsensor1.Show();
            settingsControl1.Size = new Size(803, 556);
            settingsControl1.Location = ultrasoundsensor1.Location;

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            button1.ForeColor = Color.FromArgb(211, 204, 245);
            button2.ForeColor = Color.FromArgb(99, 95, 135);
            ultrasoundsensor1.Show();
            settingsControl1.Hide();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            button1.ForeColor = Color.FromArgb(99, 95, 135);
            button2.ForeColor = Color.FromArgb(211, 204, 245);
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            button1.ForeColor = Color.FromArgb(99, 95, 135);
            button2.ForeColor = Color.FromArgb(99, 95, 135);
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            button1.ForeColor = Color.FromArgb(99, 95, 135);
            button2.ForeColor = Color.FromArgb(99, 95, 135);
        }
        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }
        private void Window_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }
        private void button2_Click_2(object sender, EventArgs e)
        {
            button1.ForeColor = Color.FromArgb(99, 95, 135);
            button2.ForeColor = Color.FromArgb(211, 204, 245);
        }
        private void button3_Click_2(object sender, EventArgs e)
        {
            button1.ForeColor = Color.FromArgb(99, 95, 135);
            button2.ForeColor = Color.FromArgb(99, 95, 135);
            ultrasoundsensor1.Hide();
            settingsControl1.Hide();
        }
        private void button4_Click_2(object sender, EventArgs e)
        {
            button1.ForeColor = Color.FromArgb(99, 95, 135);
            button2.ForeColor = Color.FromArgb(99, 95, 135);
        }
        private void button2_Click_3(object sender, EventArgs e)
        {
            button1.ForeColor = Color.FromArgb(99, 95, 135);
            button2.ForeColor = Color.FromArgb(211, 204, 245);
            ultrasoundsensor1.Hide();
            settingsControl1.Show();
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }
    }
}
