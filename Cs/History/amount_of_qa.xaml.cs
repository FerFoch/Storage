using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace History
{
    /// <summary>
    /// Логика взаимодействия для amount_of_qa.xaml
    /// </summary>
    public partial class amount_of_qa : Window
    {
        public amount_of_qa(int entered_response)
        {
            InitializeComponent();
            object sender = entered_response;
        }

        private void TextBox_TextChanged(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
                MessageBox.Show("Введите число!");
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(amount_of_qa1.Text))
            {
                MessageBox.Show("Необходимо ввести число от 1 до 50");
            }
            else if (Convert.ToInt32(amount_of_qa1.Text) > 51 || Convert.ToInt32(amount_of_qa1.Text) < 0)
            {
                MessageBox.Show("Введите число от 1 до 50");
            }
            else
            {
                for (int i = 0; i < Convert.ToInt32(amount_of_qa1.Text); i++)
                {
                    test taskWindow1 = new test(amount_of_qa1.Text);
                    taskWindow1.Show();
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow taskWindow = new MainWindow();
            taskWindow.Show();
            this.Close();
        }
    }
}
