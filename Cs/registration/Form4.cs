using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string note = textBox1.Text;
            string path = @"C:\Users\\User\\Desktop\\reg\\db.txt";
            FileInfo fileInfo = new FileInfo("C:\\Users\\User\\Desktop\\reg\\db.txt");
            if (fileInfo.Exists)
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    reader.Close();
                    File.AppendAllText(path, Environment.NewLine);
                    File.AppendAllText(path, label3.Text);
                    File.AppendAllText(path, ":");
                    File.AppendAllText(path, note);
                    MessageBox.Show("Запись успешно добавлена");
                }
            }
            else
            {
                MessageBox.Show("Файл 'db' не существует");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("В разработке");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 x = new Form2();
            x.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

    
