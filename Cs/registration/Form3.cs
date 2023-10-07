using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            button3.BackgroundImage = Image.FromFile("C:\\Users\\User\\Desktop\\reg\\oe.png");
        }

        private void button3_MouseUp(object sender, MouseEventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
            button3.BackgroundImage = Image.FromFile("C:\\Users\\User\\Desktop\\reg\\oe.png");
        }

        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            textBox3.UseSystemPasswordChar = false;
            button4.BackgroundImage = Image.FromFile("C:\\Users\\User\\Desktop\\reg\\oe.png");
        }

        private void button4_MouseUp(object sender, MouseEventArgs e)
        {
            textBox3.UseSystemPasswordChar = true;
            button4.BackgroundImage = Image.FromFile("C:\\Users\\User\\Desktop\\reg\\oe.png");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            logpass x = new logpass();
            x.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string log, pass1, pass2;
            log = textBox1.Text;
            pass1 = textBox2.Text;
            pass2 = textBox3.Text;
            string path = @"C:\Users\\User\\Desktop\\reg\\logpass.txt";
            bool b = false;
            string line;
            if (pass1 == pass2 && !string.IsNullOrWhiteSpace(pass1) && pass1.Length > 6 && pass1.Any(char.IsLetter) && pass1.Any(char.IsDigit) && pass1.Any(char.IsUpper) && pass1.Any(char.IsLower) && pass1.Any(c => !char.IsLetterOrDigit(c)))
            {
                FileInfo fileInfo = new FileInfo("C:\\Users\\User\\Desktop\\reg\\logpass.txt");
                if (fileInfo.Exists)
                {
                    using (StreamReader reader = new StreamReader(path))
                    {
                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] check = line.Split(':');
                            if (check[0] == log)
                            {
                                b = false;
                                break;
                            }
                            else
                            {
                                b = true; 
                            }
                        }
                        reader.Close();
                        if (b == true)
                        {
                            File.AppendAllText(path, Environment.NewLine);
                            File.AppendAllText(path, log);
                            File.AppendAllText(path, ":");
                            File.AppendAllText(path, pass1);
                            MessageBox.Show("Новый пользователь зарегестрирован");
                            Form2 x = new Form2();
                            x.Show();
                            this.Hide();
                            x.label1.Text = log;
                            x.label2.Text = pass1;
                        }
                        else
                        {
                            MessageBox.Show("Такой логин уже существует");
                        }
                        }
                    }
                else
                {
                    MessageBox.Show("Файл 'logpass' не существует");
                }
            }
            else
            {
                MessageBox.Show("Неверно введен пароль");
            }
        }
        }            
    }
