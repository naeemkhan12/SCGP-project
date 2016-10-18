using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            textBox1.Focus();
            //p1.BackColor = Color.DimGray;
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            p1.BackColor = Color.DimGray;
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            p1.BackColor = Color.WhiteSmoke;
        }

        private void textBox2_MouseEnter(object sender, EventArgs e)
        {
            p2.BackColor = Color.DimGray;
        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            p2.BackColor = Color.WhiteSmoke;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }


        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;
            button1.BackColor = Color.White;
        }

        private void button1_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.White;
            button1.BackColor = Color.Lime;
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {

            pictureBox4.BackColor = Color.Red;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.White;
        }
       
      
    }
}
