using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Applic
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
        public class User
        {
            public int Id { get; set; }
            public string? Login { get; set; }
            public string? Password { get; set; }
            public string? Role { get; set; }
            public string? Name { get; set; }

        }
        public class ApplicationContext : DbContext
        {
            public DbSet<User> users { get; set; } = null!;
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlite("Data Source=AAS.db");
            }
        }
        private void Entering_Button_Click(object sender, RoutedEventArgs e)
        {
            bool Check = true;
            using (ApplicationContext db = new ApplicationContext())
            {
                var users = db.users.ToList();
                foreach (User instance in users)
                {
                    if (instance.Login == login_tb.Text && instance.Password == password_pb.Password)
                    {
                        string UserRole = instance.Role;
                        string UserName = instance.Name;
                        Requests goods = new Requests(UserRole, UserName);
                        Check = false;
                        goods.Show();
                        this.Close();
                    }
                }
                if (Check == true)
                {
                    MessageBox.Show("Неправильно введен логин или пароль");
                    login_tb.Text = "";
                    password_pb.Password = "";
                }
            }
        }
        private void Exit_Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
