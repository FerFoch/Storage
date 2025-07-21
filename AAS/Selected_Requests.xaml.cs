using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
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
using System.Windows.Media.Media3D;
using System.Windows.Shapes;
using static Applic.Requests;
namespace Applic
{
    /// <summary>
    /// Логика взаимодействия для Selected_Requests.xaml
    /// </summary>
    public partial class Selected_Requests : Window
    {
        public Selected_Requests(string GRequest_Number)
        {
            InitializeComponent();
            Find_Request(GRequest_Number);
        }
        //[Keyless]
        public class Selected_Request_Info
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
        }
        public class Selected_Request_Execution_Time
        {
            [Key]
            public int request_id { get; set; }
            public string? receipt_time { get; set; }
            public string? execute_time { get; set; }
        }

        public class Selected_Connection_Type
        {
            [Key]
            public int request_id { get; set; }
            public string? connection_type { get; set; }
        }
        public class Selected_Employeers
        {
            [Key]
            public int request_id { get; set; }
            public string? specialist_name { get; set; }
        }
        public class Selected_Type_Of_Work
        {
            [Key]
            public int request_id { get; set; }
            public string? type_of_work { get; set; }
        }
        public class ApplicationContext : DbContext
        {
            public DbSet<Selected_Request_Execution_Time> request_execution_time { get; set; } = null!;
            public DbSet<Selected_Request_Info> request_info { get; set; }
            public DbSet<Selected_Connection_Type> connection_type { get; set; } = null!;
            public DbSet<Selected_Employeers> employeers { get; set; } = null!;
            public DbSet<Selected_Type_Of_Work> type_of_work { get; set; } = null!;
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlite("Data Source=AAS.db");
            }
        }

        public async Task Find_Request(string index)
        {
            int Iindex = Convert.ToInt32(index);
            using (ApplicationContext db = new ApplicationContext())
            {
                try
                {
                    var RI = db.request_info.ToList();
                    var RET = db.request_execution_time.ToList();
                    var CT = db.connection_type.ToList();
                    var E = db.employeers.ToList();
                    var TOW = db.type_of_work.ToList();

                    foreach (Selected_Request_Execution_Time Instance_RET in RET)
                    {
                        if (Instance_RET.request_id == Iindex)
                        {
                            Receipt_Time.Text = Instance_RET.receipt_time;
                            Execute_Time.Text = Instance_RET.execute_time;
                            break;
                        }
                    }
                    foreach (Selected_Connection_Type Instance_CT in CT)
                    {
                        if (Instance_CT.request_id == Iindex)
                        {
                            Connection_Type.Text = Instance_CT.connection_type;
                            break;
                        }
                    }
                    foreach (Selected_Employeers Instance_E in E)
                    {
                        if (Instance_E.request_id == Iindex)
                        {
                            Specialist_Name.Text = Instance_E.specialist_name;
                            break;
                        }
                    }
                    foreach (Selected_Type_Of_Work Instance_TOW in TOW)
                    {
                        if (Instance_TOW.request_id == Iindex)
                        {
                            Type_Of_Work.Text = Instance_TOW.type_of_work;
                            break;
                        }
                    }
                    foreach (Selected_Request_Info Instance_RI in RI)
                    {
                        if (Instance_RI.request_id == Iindex)
                        {
                            Request_ID.Text = Instance_RI.request_id.ToString(); Model_ID.Text = Instance_RI.model_id;
                            Executor.Text = Instance_RI.executor; Legal_Name.Text = Instance_RI.legal_name;
                            Destanation.Text = Instance_RI.destanition; Representative.Text = Instance_RI.representative;
                            Represent_Pnumber.Text = Instance_RI.represent_pnumber; Transmit_Model.Text = Instance_RI.transmit_model;
                            Transmti_Model_Snumber.Text = Instance_RI.transmit_model_snumber; Taken_Model.Text = Instance_RI.taken_model;
                            Taken_Model_Snumber.Text = Instance_RI.taken_model_snumber;
                            break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        private void Save_Button_ClickAsync(object sender, RoutedEventArgs e)
        {
            asdAsync();  
        }
        private async Task asdAsync() {
            using (var db = new ApplicationContext())
            {
                try
                { 
                    var DbUpdate_RET = db.request_execution_time.Find(Convert.ToInt32(Request_ID.Text));
                    var DbUpdate_RI = db.request_info.Find(Convert.ToInt32(Request_ID.Text));
                    var DbUpdate_CT = db.connection_type.Find(Convert.ToInt32(Request_ID.Text));
                    var DbUpdate_E = db.employeers.Find(Convert.ToInt32(Request_ID.Text));
                    var DbUpdate_TOW = db.type_of_work.Find(Convert.ToInt32(Request_ID.Text));
                    if (DbUpdate_RI != null)
                    {
                        DbUpdate_RI.legal_name = Legal_Name.Text;DbUpdate_RI.destanition = Destanation.Text;DbUpdate_RI.representative = Representative.Text;
                        DbUpdate_RI.transmit_model = Transmit_Model.Text;DbUpdate_RI.taken_model_snumber = Transmti_Model_Snumber.Text; DbUpdate_RI.taken_model = Taken_Model.Text;
                        DbUpdate_RI.taken_model_snumber = Taken_Model_Snumber.Text;DbUpdate_RI.model_id = Model_ID.Text;DbUpdate_RI.executor = Executor.Text;
                        DbUpdate_RET.receipt_time = Receipt_Time.Text;DbUpdate_RET.execute_time = Execute_Time.Text; DbUpdate_CT.connection_type = Connection_Type.Text;
                        DbUpdate_E.specialist_name = Specialist_Name.Text; DbUpdate_TOW.type_of_work = Type_Of_Work.Text;
                        await db.SaveChangesAsync();
                        MessageBox.Show("Данные сохранены!");
                        string UserRole = "";
                        string UserName = "";
                        Requests Goods = new Requests(UserRole, UserName);
                        Goods.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Запись не найдена!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}");
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                string UserRole = "";
                string UserName = "";
                Requests Goods = new Requests(UserRole, UserName);
                Goods.Show();
                this.Close();
            }
        }
    }
}
