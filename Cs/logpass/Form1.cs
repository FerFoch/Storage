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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_Password(object sender, EventArgs e)
        {
            string pswd = Console.ReadLine();
            //bMessageBox.Show("Записано");
        }

        private void textBox1_Login(object sender, EventArgs e)
        {
            string Lg = Console.ReadLine();
           // MessageBox.Show("Записано");
        }

        private void button1_Enter(object sender, EventArgs e)
        {
            string log = "root";
            string pas = "123456";
            if (textBox1.Text == log && textBox2.Text == pas)
            {
                Form2 x = new Form2();
                x.Show();
                x.label1.Text = log;
                x.label2.Text = pas;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }
        private void button2_Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;
            button4.BackgroundImage = Image.FromFile("C:\\Users\\WorkStation\\Desktop\\WindowsFormsApp6\\ce.png");
        }

        private void button4_MouseUp(object sender, MouseEventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
            button4.BackgroundImage = Image.FromFile("C:\\Users\\WorkStation\\Desktop\\WindowsFormsApp6\\oe.png");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 x = new Form3();
            x.Show();
            this.Hide();
        }
    }
}
