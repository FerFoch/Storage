using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace History
{
    /// <summary>
    /// Логика взаимодействия для adding.xaml
    /// </summary>
    public partial class adding : Window
    {
        public adding()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string path = @"C:\Users\Student\Desktop\History\qa db.txt";
            FileInfo fileInfo = new FileInfo("C:\\Users\\Student\\Desktop\\History\\qa db.txt");
            if (!fileInfo.Exists)
            {
                MessageBox.Show("Файл qa db не существует");
            }
            else if(string.IsNullOrEmpty(Quetion.Text))
            {
                MessageBox.Show("Напишите вопрос");
            }
            else if (Convert.ToInt32(Answer.Text) > 2000 || Convert.ToInt32(Answer.Text) < 1)
            {
                MessageBox.Show("Введите число от 1 до 2000");
            }
            else
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    reader.Close();
                    File.AppendAllText(path, Environment.NewLine);
                    File.AppendAllText(path, Quetion.Text);
                    File.AppendAllText(path, ":");
                    File.AppendAllText(path, Answer.Text);
                    MessageBox.Show("Запись успешно добавлена");
                }
            }
        }
        private void Quetion_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void Answer_TextChanged(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
                MessageBox.Show("Введите число !");
            }
        }

        private void back_from_add_qa(object sender, RoutedEventArgs e)
        {
            MainWindow taskWindow = new MainWindow();
            taskWindow.Show();
            this.Close();
        }
    }
}
