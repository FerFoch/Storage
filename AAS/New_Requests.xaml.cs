using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Windows;
using System.Windows.Input;

namespace Applic
{
    /// <summary>
    /// Логика взаимодействия для New_Goods.xaml
    /// </summary>
    public partial class New_Requests : Window
    {
        private string user_role = "";

        public New_Requests(string user_role)
        {
            InitializeComponent();
            GetLastRequstId();
        }
        public class New_Request_Info
        {
            [Key]
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

            public virtual List<New_Request_Execution_Time> RequestExecutionTimes { get; set; } = new List<New_Request_Execution_Time>();
            public virtual List<New_Connection_Type> ConnectionTypes { get; set; } = new List<New_Connection_Type>();
            public virtual List<New_Type_Of_Work> TypeOfWorks { get; set; } = new List<New_Type_Of_Work>();
            public virtual List<New_Employeers> Employeers { get; set; } = new List<New_Employeers>();
        }

        public class New_Request_Execution_Time
        {
            [Key]
            public int request_id { get; set; } // Внешний ключ
            public string? receipt_time { get; set; }
            public string? execute_time { get; set; }
            public New_Request_Info RequestInfo { get; set; } = null!; //Навигационное свойство
        }

        public class New_Connection_Type
        {
            [Key]
            public int request_id { get; set; } // Внешний ключ
            public string? connection_type { get; set; }
            public New_Request_Info RequestInfo { get; set; } = null!; //Навигационное свойство
        }

        public class New_Employeers
        {
            [Key]
            public int request_id { get; set; } // Внешний ключ
            public string? specialist_name { get; set; }
            public New_Request_Info RequestInfo { get; set; } = null!; //Навигационное свойство
        }

        public class New_Type_Of_Work
        {
            [Key]
            public int request_id { get; set; } // Внешний ключ
            public string? type_of_work { get; set; }

            public New_Request_Info RequestInfo { get; set; } = null!; //Навигационное свойство
        }

        public class ApplicationContext : DbContext
        {
            public DbSet<New_Request_Execution_Time> request_execution_time { get; set; } = null!;
            public DbSet<New_Request_Info> request_info { get; set; } = null!;
            public DbSet<New_Connection_Type> connection_type { get; set; } = null!;
            public DbSet<New_Employeers> employeers { get; set; } = null!;
            public DbSet<New_Type_Of_Work> type_of_work { get; set; } = null!;

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                // Связь между New_Request_Info и New_Request_Execution_Time (один ко многим)
                modelBuilder.Entity<New_Request_Execution_Time>()
                    .HasOne(e => e.RequestInfo)
                    .WithMany(r => r.RequestExecutionTimes)
                    .HasForeignKey(e => e.request_id);

                // Связь между New_Request_Info и New_Connection_Type (один ко многим)
                modelBuilder.Entity<New_Connection_Type>()
                    .HasOne(c => c.RequestInfo)
                    .WithMany(r => r.ConnectionTypes)
                    .HasForeignKey(c => c.request_id);

                // Связь между New_Request_Info и New_Employeers (один ко многим)
                modelBuilder.Entity<New_Employeers>()
                    .HasOne(e => e.RequestInfo)
                    .WithMany(r => r.Employeers)
                    .HasForeignKey(e => e.request_id);

                // Связь между New_Request_Info и New_Type_Of_Work (один ко многим)
                modelBuilder.Entity<New_Type_Of_Work>()
                    .HasOne(t => t.RequestInfo)
                    .WithMany(r => r.TypeOfWorks)
                    .HasForeignKey(t => t.request_id);


                //Дополнительные настройки для корректной обработки связи
                modelBuilder.Entity<New_Request_Info>().HasMany(r => r.RequestExecutionTimes).WithOne(e => e.RequestInfo).IsRequired(false);
                modelBuilder.Entity<New_Request_Info>().HasMany(r => r.ConnectionTypes).WithOne(c => c.RequestInfo).IsRequired(false);
                modelBuilder.Entity<New_Request_Info>().HasMany(r => r.Employeers).WithOne(e => e.RequestInfo).IsRequired(false);
                modelBuilder.Entity<New_Request_Info>().HasMany(r => r.TypeOfWorks).WithOne(t => t.RequestInfo).IsRequired(false);
            }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlite("Data Source=AAS.db");
            }
        }
       private void GetLastRequstId()
            {
            using (var db = new ApplicationContext())
            {
                int LastRequestNumber = 0;
                var RI = db.request_info.ToList();
                foreach (New_Request_Info Instance_RI in RI)
                {
                    if (Convert.ToInt32(Instance_RI.request_id) > LastRequestNumber)
                    {
                        LastRequestNumber = Convert.ToInt32(Instance_RI.request_id);
                    }
                }
                Request_ID.Text = (LastRequestNumber+1).ToString();
            }
            }
        private async Task CreateRequestAsync()
        {
            using (var db = new ApplicationContext())
            {
                try
                {
                    var RequestInfo = new New_Request_Info
                    {
                        request_id = Convert.ToInt32(Request_ID.Text),
                        legal_name = Legal_Name.Text,
                        destanition = Destanation.Text,
                        model_id = Model_ID.Text,
                        representative = Representative.Text,
                        represent_pnumber = Represent_Pnumber.Text,
                        transmit_model = Transmit_Model.Text,
                        taken_model_snumber = Transmti_Model_Snumber.Text,
                        taken_model = Taken_Model.Text,
                        executor = Executor.Text,
                    };
                    var NewRequestExecutionTime = new New_Request_Execution_Time
                    {
                        receipt_time = Receipt_Time.Text, 
                        execute_time = Execute_Time.Text   
                    };
                    var NewConnectionType = new New_Connection_Type
                    {
                        connection_type = Connection_type.Text
                    };
                    var NewEmployeeRequest = new New_Employeers
                    {
                        specialist_name = Specialist_Name.Text
                    };
                    var NewTypeOfWorkRequest = new New_Type_Of_Work
                    {
                        type_of_work = Type_of_Work.Text
                    };

                    RequestInfo.RequestExecutionTimes.Add(new New_Request_Execution_Time { receipt_time = Receipt_Time.Text, execute_time = Execute_Time.Text });
                    RequestInfo.ConnectionTypes.Add(new New_Connection_Type { connection_type = Connection_type.Text });
                    RequestInfo.Employeers.Add(new New_Employeers { specialist_name = Specialist_Name.Text });
                    RequestInfo.TypeOfWorks.Add(new New_Type_Of_Work { type_of_work = Type_of_Work.Text });

                    db.request_info.Add(RequestInfo);
                    await db.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Заполните необходимые поля!");
                }
                MessageBox.Show($"Заявка создана!");                                                  
                Request_ID.Text = ""; Legal_Name.Text = ""; Destanation.Text = ""; Model_ID.Text = ""; Representative.Text = "";
                Represent_Pnumber.Text = ""; Transmit_Model.Text = ""; Transmti_Model_Snumber.Text = "";Taken_Model_Snumber.Text = "";
                Taken_Model.Text = ""; Executor.Text = ""; Receipt_Time.Text = ""; Execute_Time.Text = ""; Connection_type.Text = "";
                Specialist_Name.Text = ""; Type_of_Work.Text = "";
                string user_name = "";
                Requests goo = new Requests(user_role, user_name);
                goo.Show();
                this.Close();
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string UserName = "";
            Requests goo = new Requests(user_role, UserName);
            goo.Show();
            this.Close();
        }
        private void Create_Button_ClickAsync(object sender, RoutedEventArgs e)
        {
            CreateRequestAsync();
        }
    }
}
