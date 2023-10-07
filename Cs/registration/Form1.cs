using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class logpass : Form
    {
        public logpass()
        {
            InitializeComponent();
        }
        private void textBox2_Password(object sender, EventArgs e)
        {

        }

        private void textBox1_Login(object sender, EventArgs e)
        {

        }

        private void button1_Enter(object sender, EventArgs e)
        {
            bool i = false;
            FileInfo fileInfo1 = new FileInfo("C:\\Users\\User\\Desktop\\reg\\logpass.txt");
            string path = @"C:\\Users\User\\Desktop\\reg\\logpass.txt";
            string[] readEveryLine = new string[5];
            readEveryLine = File.ReadAllLines(path);
            using (StreamReader reader = new StreamReader(path))
            {
                string line,check;
                while ((line =  reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    check = textBox1.Text + ":"+ textBox2.Text;
                   //textBox3.Text = check;
                   //textBox4.Text = line;
                    if (line == check)
                    {
                        i = true;
                        break;
                    }
                    else
                    {
                        i = false;
                    }
                }
            }
            if (i == true)
            {
                Form2 x = new Form2();
                x.Show();
                x.label1.Text = textBox1.Text;
                x.label2.Text = textBox2.Text;
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
            button4.BackgroundImage = Image.FromFile("C:\\Users\\User\\Desktop\\WindowsFormsApp6\\ce.png");
        }

        private void button4_MouseUp(object sender, MouseEventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
            button4.BackgroundImage = Image.FromFile("C:\\Users\\User\\Desktop\\WindowsFormsApp6\\oe.png");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 x = new Form3();
            x.Show();
            this.Hide();
        }

        private void button1_Enter_1(object sender, EventArgs e)
        {

        }
    }
}
