using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;
            button3.BackgroundImage = Image.FromFile("C:\\Users\\WorkStation\\Desktop\\WindowsFormsApp6\\ce.png");
        }

        private void button3_MouseUp(object sender, MouseEventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
            button3.BackgroundImage = Image.FromFile("C:\\Users\\WorkStation\\Desktop\\WindowsFormsApp6\\oe.png");
        }

        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            textBox3.UseSystemPasswordChar = false;
            button4.BackgroundImage = Image.FromFile("C:\\Users\\WorkStation\\Desktop\\WindowsFormsApp6\\ce.png");
        }

        private void button4_MouseUp(object sender, MouseEventArgs e)
        {
            textBox3.UseSystemPasswordChar = true;
            button4.BackgroundImage = Image.FromFile("C:\\Users\\WorkStation\\Desktop\\WindowsFormsApp6\\oe.png");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 x = new Form1();
            x.Show();
            this.Hide();
        }
    }
}
