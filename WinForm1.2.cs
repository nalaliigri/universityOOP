using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntCheckWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.textBox1.AutoSize = false;
            this.textBox1.Size = new Size(167, 33);
        }

        double N;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            N = Convert.ToDouble(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int check = Convert.ToInt32(N);
            if (N == check)
            {
                MessageBox.Show("Ви ввели число " + N);
            }
        }
        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void close_MouseEnter(object sender, EventArgs e)
        {
            close.ForeColor = Color.Red;
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            close.ForeColor = Color.Black;
        }

        Point LastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }
       
    }
}
