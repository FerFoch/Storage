using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace History
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void testing_Click(object sender, RoutedEventArgs e)
        {
            int f = 0;
            amount_of_qa taskWindow = new amount_of_qa(f);
            taskWindow.Show();
            this.Hide();
        }

        private void adding_Click(object sender, RoutedEventArgs e)
        {
            adding taskWindow = new adding();
            taskWindow.Show();
            this.Hide();
        }
    }
}
