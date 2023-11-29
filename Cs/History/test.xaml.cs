using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
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

namespace History
{
    /// <summary>
    /// Логика взаимодействия для test.xaml
    /// </summary>
    public partial class test : Window
    {
        int answer;

        public test(String amount_of_qa1)
        {
            InitializeComponent();
            if (amount_of_qa1 == "1")
                return;
            for (int i = 0; i < Convert.ToInt32(amount_of_qa1); i++)
            {
                int number = Convert.ToInt32(amount_of_qa1);
                answer = task(number);
            }
        }
        public int task(int number)
        {
            int number_of_qa = 0;
            Random rnd = new Random();
            number_of_qa = rnd.Next(1, 50);
            int[] answers = new int[number];
            string line = File.ReadLines("C:\\Users\\Student\\Desktop\\History\\qa db.txt").ElementAtOrDefault(number_of_qa);
            string[] check = line.Split(':');
            string quetion = check[0];
            int answer = Convert.ToInt32(check[1]);
            label_test.Content = quetion;
            return answer;
        }
        private void test_textbox_TextChanged(object sender, TextChangedEventArgs e)
        {}
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string answers = test_textbox.Text;
            Comparing(answers, answer);
            this.Close();
        }
        public void Comparing(string answers, int answer)
        {
            if (string.IsNullOrEmpty(test_textbox.Text))
            {
                MessageBox.Show("Напишите ответ");
            }
            else
            {
                if (Convert.ToInt32(answers) == answer)
                {
                    MessageBox.Show("Правильно");
                }
                else
                {
                    MessageBox.Show("Неправильно");
                }
            }
        }
    }
}
