using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
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
using System.Windows.Shapes;
using static Applic.Selected_Requests;

namespace Applic
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string UserRole = "";
            string UserName = "";
            Requests requests = new Requests(UserRole, UserName);
            requests.Show();
            this.Close();
        }
        public class User
        {
            public int Id { get; set; }
            public string? Name { get; set; }
            public string? Login { get; set; }
            public string? Password { get; set; }
            public string? Role { get; set; }

        }
        public class ApplicationContext : DbContext
        {
            public DbSet<User> users { get; set; } = null!;
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlite("Data Source=AAS.db");
            }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Password.Password == Password2.Password)
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    var U = db.users.ToList();
                    bool Check = false;
                    foreach (User Instance_U in U)
                    {
                        if (Instance_U.Login == Login.Text)
                        {
                            Check = true;
                            break;
                        }
                    }
                    if (Check == false){
                        User user = new User { Name = Name.Text, Login = Login.Text, Password = Password.Password, Role = Role.Text };
                        db.users.Add(user);
                        db.SaveChanges();
                        MainWindow MainWindow = new MainWindow();
                        MainWindow.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Такой пользователь уже существует");
                    }
                }
            }
            else
            {
                MessageBox.Show("Неправильно введен пароль");
            }
        }
    }
}
