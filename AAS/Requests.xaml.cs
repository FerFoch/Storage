using System.Data.SQLite;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Metadata;
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
using static Applic.New_Requests;
using System.Diagnostics;
using static Applic.Requests;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Media.Animation;
using System.IO;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml.Vml;
using Run = DocumentFormat.OpenXml.Wordprocessing.Run;
using Paragraph = DocumentFormat.OpenXml.Wordprocessing.Paragraph;
using Document = DocumentFormat.OpenXml.Wordprocessing.Document;
using DocumentFormat.OpenXml.ExtendedProperties;

namespace Applic
{
    /// <summary>
    /// Логика взаимодействия для Requests.xaml
    /// </summary>
    public partial class Requests : Window
    {
        public Requests(string UserRole, string UserName)
        {
            InitializeComponent();
            this.ResizeMode = ResizeMode.NoResize;
            string BCreateNewUserButton = "false";
            connAsync(UserRole, BCreateNewUserButton, UserName);

        }
        private SQLiteConnection con;
        public static string UserName;
        [Keyless]
        public class Request_Info
        {
            public int request_id { get; set; }
            public string? model_id { get; set; }
            public string? executor { get; set; }
            public string? legal_name { get; set; }
            public string? destanition { get; set; }
            public string? representative { get; set; }
            public string? represent_pnumber { get; set; }
            public string? transmit_model { get; set; }
            public string? transmit_model_snumber { get; set; }
            public string? taken_model { get; set; }
            public string? taken_model_snumber { get; set; }
        }
        [Keyless]
        public class Request_Execution_Time
        {
            public int request_id { get; set; }
            public string? receipt_time { get; set; }
            public string? execute_time { get; set; }
        }
        [Keyless]
        public class Combined_Request_Info
        {
            public int request_id { get; set; }
            public string? model_id { get; set; }
            public string? executor { get; set; }
            public string? legal_name { get; set; }
            public string? destanition { get; set; }
            public string? representative { get; set; }
            public string? represent_pnumber { get; set; }
            public string? transmit_model { get; set; }
            public string? transmit_model_snumber { get; set; }
            public string? taken_model { get; set; }
            public string? taken_model_snumber { get; set; }
            public int request_execute_id { get; set; }
            public string? receipt_time { get; set; }
            public string? execute_time { get; set; }
            public string? connection_type { get; set; }
            public string? specialist_name { get; set; }
            public string? type_of_work { get; set; }

        }
        [Keyless]
        public class Connection_Type
        {
            public int request_id { get; set; }
            public string? connection_type { get; set; }
        }
        [Keyless]
        public class Employeers
        {
            public int request_id { get; set; }
            public string? specialist_name { get; set; }
        }
        [Keyless]
        public class Type_Of_Work
        {
            public int request_id { get; set; }
            public string? type_of_work { get; set; }
        }
        public class User
        {
            public int Id { get; set; }
            public string? Name { get; set; }
            public string? Login { get; set; }
            public string? Password { get; set; }
            public string? Role { get; set; }

        }
        public class Report
        {
        public int request_id { get; set; }
        public string? legal_name { get; set; }
        public string? represent_pnumber { get; set; }
        public string? representative { get; set; }
        }
        public class ApplicationContext : DbContext
        {
            public DbSet<Request_Execution_Time> request_execution_time { get; set; } = null!;
            public DbSet<User> users { get; set; } = null!;
            public DbSet<Request_Info> request_info { get; set; } = null!;
            public DbSet<Combined_Request_Info> combined_request_info { get; set; } = null!;
            public DbSet<Connection_Type> connection_type { get; set; } = null!;
            public DbSet<Employeers> employeers { get; set; } = null!;
            public DbSet<Type_Of_Work> type_of_work { get; set; } = null!;


            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlite("Data Source=AAS.db");
            }
        }
        public async Task connAsync(string UserRole, string BCreateNewUserButton, string User_Name)
        {
            UserName = User_Name;
            if (BCreateNewUserButton == "True")
            {
                Registration registration = new Registration();
                registration.Show();
                this.Close();
            }
            if (UserRole != "admin" && UserRole != "")
            {
                Create_Button.Visibility = Visibility.Collapsed;
                Dg_Requests.MouseDoubleClick -= Item_Click;
                Create_New_User_Button.Visibility = Visibility.Collapsed;
            }
            using (ApplicationContext db = new ApplicationContext())
            {
                var Requests = (from request_info in db.request_info
                                join request_execution_time in db.request_execution_time
                                    on request_info.request_id equals request_execution_time.request_id
                                join connection_type in db.connection_type
                                    on request_info.request_id equals connection_type.request_id
                                join specialist_name in db.employeers
                                    on request_info.request_id equals specialist_name.request_id
                                join type_of_work in db.type_of_work
                                    on request_info.request_id equals type_of_work.request_id
                                select new Combined_Request_Info
                                {
                                    request_id = request_info.request_id,
                                    model_id = request_info.model_id,
                                    executor = request_info.executor,
                                    legal_name = request_info.legal_name,
                                    destanition = request_info.destanition,
                                    representative = request_info.representative,
                                    represent_pnumber = request_info.represent_pnumber,
                                    transmit_model = request_info.transmit_model,
                                    transmit_model_snumber = request_info.transmit_model_snumber,
                                    taken_model = request_info.taken_model,
                                    taken_model_snumber = request_info.taken_model_snumber,
                                    receipt_time = request_execution_time.receipt_time,
                                    execute_time = request_execution_time.execute_time,
                                    connection_type = connection_type.connection_type,
                                    specialist_name = specialist_name.specialist_name,
                                    type_of_work = type_of_work.type_of_work
                                }).ToList();
                Dg_Requests.ItemsSource = Requests;
                await Task.Run(async () =>
                {
                    Dispatcher.Invoke(() =>
                    {
                        Dg_Requests.ItemsSource = Requests;
                    });
                });
            }

        }

        private void Item_Click(object sender, MouseButtonEventArgs e)
        {
            string GRequest_Number = "";
            int SelectedColumn = 2;
            if (Dg_Requests.SelectedCells.Count != 0)
            {
                var SelectedCell = Dg_Requests.SelectedCells[SelectedColumn];
                var CellContent = SelectedCell.Column.GetCellContent(SelectedCell.Item);
                if (CellContent is TextBlock)
                {
                    GRequest_Number = (CellContent as TextBlock).Text;
                }
                Selected_Requests SelectedRequests = new Selected_Requests(GRequest_Number);
                SelectedRequests.Show();
                this.Close();
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MainWindow = new MainWindow();
            MainWindow.Show();
            this.Close();
        }

        private void Create_New_User_Click(object sender, RoutedEventArgs e)
        {
            bool BCreateNewUserButton = true;
            string UserRole = "";
            string UserName = "";
            connAsync(UserRole, BCreateNewUserButton.ToString(), UserName);
        }

        private void New_Letter_Click(object sender, RoutedEventArgs e)
        {
            string UserRole = "";
            New_Requests NewRequests = new New_Requests(UserRole);
            NewRequests.Show();
            this.Close();
        }
        private void Search_Button_Click(object sender, RoutedEventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var RequestNumber = db.request_info.ToList();
                int SearchableRequestNumber = 0;
                bool Check = false;
                try
                {
                    SearchableRequestNumber = Convert.ToInt32(Search_TextBox.Text);
                    foreach (Request_Info Instance_Request_Number in RequestNumber)
                    {
                        if (Instance_Request_Number.request_id == SearchableRequestNumber)
                        {
                            Check = true;
                            break;
                        }
                    }
                    if (Check == true)
                    {
                        Selected_Requests SelectedRequests = new Selected_Requests(SearchableRequestNumber.ToString());
                        SelectedRequests.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Номер заявки не найден!");
                        Search_TextBox.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Неверный ввод!");
                    Search_TextBox.Text = "";
                }
            }
        }
        private void Generate_Report_Button_Click(object sender, RoutedEventArgs e)
        {
            List<Report> Requests = new List<Report>();
            try
            {
               // string user_name = "Васильев А.Ф";
                using (SQLiteConnection connection = new SQLiteConnection($"Data Source=AAS.db;"))
                {
                    connection.Open();
                    string sql = "SELECT request_id, legal_name, represent_pnumber, representative FROM request_info WHERE executor = @executor";
                    using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@executor", UserName);

                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Requests.Add(new Report
                                {
                                    request_id = Convert.ToInt32(reader["request_id"]),
                                    legal_name = reader["legal_name"].ToString(),
                                    represent_pnumber = reader["represent_pnumber"].ToString(),
                                    representative = reader["representative"].ToString(),
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при поиске заявок по исполнителю: {ex.Message}");
            }
            string filePath = "C:\\Users\\User\\Desktop\\report.txt";
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine(UserName);
                    writer.WriteLine();
                    foreach (Report line in Requests)
                    {
                        writer.WriteLine(line.request_id.ToString());
                        writer.WriteLine(line.legal_name.ToString());
                        writer.WriteLine(line.represent_pnumber.ToString());
                        writer.WriteLine(line.representative.ToString());
                        writer.WriteLine();
                    }
                }
                MessageBox.Show($"Текст записан в файл: {filePath}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка записи в файл: {ex.Message}");
            }
        }
    }
}
