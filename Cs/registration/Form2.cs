using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            logpass x = new logpass();   
            x.Show(); 
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 x = new Form4();
            string b = label1.Text; 
            x.Show();
            x.label3.Text = b;
            this.Hide();
        }
    }
}
