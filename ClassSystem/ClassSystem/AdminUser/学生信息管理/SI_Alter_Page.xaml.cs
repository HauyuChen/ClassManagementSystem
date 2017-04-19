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

namespace ClassSystem.AdminUser
{
    /// <summary>
    /// SI_Alter_Page.xaml 的交互逻辑
    /// </summary>
    public partial class SI_Alter_Page : Page
    {
        public SI_Alter_Page()
        {
            InitializeComponent();
            Bind();
        }
        public void Bind()
        {
            IList<customer> customList = new List<customer>();
            customList.Add(new customer() { ID = 1, Name = "无" });
            customList.Add(new customer() { ID = 2, Name = "班长" });
            customList.Add(new customer() { ID = 3, Name = "副班长" });
            customList.Add(new customer() { ID = 1, Name = "团支书" });
            customList.Add(new customer() { ID = 2, Name = "生活委员" });
            customList.Add(new customer() { ID = 3, Name = "体育委员" });
            customList.Add(new customer() { ID = 3, Name = "组织委员" });
            CB_N_Srole.ItemsSource = customList;
            CB_N_Srole.DisplayMemberPath = "Name";
            CB_N_Srole.SelectedValuePath = "Name";
            CB_N_Srole.SelectedValue = 1;
        }
        public class customer
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }

        private void BTN_N_Sub_Click(object sender, RoutedEventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=ClassSystem;User ID=sa;Password=root"))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    DateTime? datevalue = DP_Data.SelectedDate;
                    bool? man = RB_N_Man.IsChecked;
                    bool? woman = RB_N_Man.IsChecked;
                    if (man == true)
                    {
                        cmd.Parameters.Add(new SqlParameter("@NSsex", "男"));
                    }
                    else if (woman == true)
                    {
                        cmd.Parameters.Add(new SqlParameter("@NSsex", "女"));
                    }
                    cmd.Parameters.Add(new SqlParameter("@NSrole", CB_N_Srole.SelectedValue.ToString()));
                    cmd.Parameters.Add(new SqlParameter("@NSbirth", datevalue));
                    cmd.Parameters.Add(new SqlParameter("@NSno", TB_N_Sno.Text));
                    cmd.Parameters.Add(new SqlParameter("@NSname", TB_N_Sname.Text));
                    cmd.Parameters.Add(new SqlParameter("@NSmobile", TB_N_Smobile.Text));
                    cmd.Parameters.Add(new SqlParameter("@NSident", TB_N_Sident.Text));
                    cmd.Parameters.Add(new SqlParameter("@NScard", TB_N_Scard.Text));
                    cmd.Parameters.Add(new SqlParameter("@NSdorm", TB_N_Sdorm.Text));
                    cmd.Parameters.Add(new SqlParameter("@NSqq", TB_N_Sqq.Text));

                    cmd.CommandText = "update Stu_info set Sno=@NSno,Sname=@NSname,Srole=@NSrole,Ssex=@NSsex,Sbirth=@NSbirth,Sidentity=@NSident,Scardnum=@NScard,Smobile=@NSmobile,Sdorm=@NSdorm,Sqq=@NSqq where Sno=@NSno";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("修改学生信息成功！");
                }
            }
        }
    }
}
