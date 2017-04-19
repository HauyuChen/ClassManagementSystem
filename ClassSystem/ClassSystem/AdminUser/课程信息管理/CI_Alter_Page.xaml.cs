using System;
using System.Collections.Generic;
using System.Linq;
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
using System.Data.SqlClient;

namespace ClassSystem.AdminUser.课程信息管理
{
    /// <summary>
    /// CI_Alter_Page.xaml 的交互逻辑
    /// </summary>
    public partial class CI_Alter_Page : Page
    {
        public CI_Alter_Page()
        {
            InitializeComponent();
            Bind();
        }
        public void Bind()
        {
            IList<customer> customList_day = new List<customer>();
            customList_day.Add(new customer() { ID = 1, Name = "一" });
            customList_day.Add(new customer() { ID = 2, Name = "二" });
            customList_day.Add(new customer() { ID = 3, Name = "三" });
            customList_day.Add(new customer() { ID = 4, Name = "四" });
            customList_day.Add(new customer() { ID = 5, Name = "五" });
            customList_day.Add(new customer() { ID = 6, Name = "六" });
            customList_day.Add(new customer() { ID = 7, Name = "七" });

            IList<customer> customList_sec = new List<customer>();
            customList_sec.Add(new customer() { ID = 1, Name = "1-2" });
            customList_sec.Add(new customer() { ID = 2, Name = "3-4" });
            customList_sec.Add(new customer() { ID = 3, Name = "5-6" });
            customList_sec.Add(new customer() { ID = 4, Name = "7-8" });
            customList_sec.Add(new customer() { ID = 5, Name = "9-10" });
            customList_sec.Add(new customer() { ID = 6, Name = "9-11" });

            CB_CI_N_1A.ItemsSource = customList_day;
            CB_CI_N_1A.DisplayMemberPath = "Name";
            CB_CI_N_1A.SelectedValuePath = "Name";
            CB_CI_N_1A.SelectedValue = 1;
            CB_CI_N_1B.ItemsSource = customList_sec;
            CB_CI_N_1B.DisplayMemberPath = "Name";
            CB_CI_N_1B.SelectedValuePath = "Name";
            CB_CI_N_1B.SelectedValue = 1;

            CB_CI_N_2A.ItemsSource = customList_day;
            CB_CI_N_2A.DisplayMemberPath = "Name";
            CB_CI_N_2A.SelectedValuePath = "Name";
            CB_CI_N_2A.SelectedValue = 1;
            CB_CI_N_2B.ItemsSource = customList_sec;
            CB_CI_N_2B.DisplayMemberPath = "Name";
            CB_CI_N_2B.SelectedValuePath = "Name";
            CB_CI_N_2B.SelectedValue = 1;

            CB_CI_N_3A.ItemsSource = customList_day;
            CB_CI_N_3A.DisplayMemberPath = "Name";
            CB_CI_N_3A.SelectedValuePath = "Name";
            CB_CI_N_3A.SelectedValue = 1;
            CB_CI_N_3B.ItemsSource = customList_sec;
            CB_CI_N_3B.DisplayMemberPath = "Name";
            CB_CI_N_3B.SelectedValuePath = "Name";
            CB_CI_N_3B.SelectedValue = 1;
        }
        public class customer
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }

        private void BTN_CI_N_SUB_Click(object sender, RoutedEventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=ClassSystem;User ID=sa;Password=root"))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.Parameters.Add(new SqlParameter("@NCno", TB_CI_N_Cno.Text));
                    cmd.Parameters.Add(new SqlParameter("@NCname", TB_CI_N_Cname.Text));
                    cmd.Parameters.Add(new SqlParameter("@NCteac", TB_CI_N_Cteac.Text));
                    cmd.Parameters.Add(new SqlParameter("@NCcredit", TB_CI_N_Ccredit.Text));
                    cmd.Parameters.Add(new SqlParameter("@NCplace", TB_CI_N_Cplace.Text));
                    cmd.Parameters.Add(new SqlParameter("@NCtime", TB_CI_N_CW1.Text + '至' + TB_CI_N_CW2.Text + "周星期" + CB_CI_N_1A.SelectedValue.ToString() + CB_CI_N_1B.SelectedValue.ToString() + '节'));

                    cmd.CommandText = "update Course_info set Cno=@NCno,Cname=@NCname,Cteacher=@NCteac,Ccredit=@NCcredit,Ctime=@NCtime,Cplace=@NCplace where Cno=@NCno";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("修改课程信息成功！");
                }
            }
        }
    }
}
