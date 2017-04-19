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

namespace ClassSystem.AdminUser.学生成绩管理
{
    /// <summary>
    /// SG_New_Page.xaml 的交互逻辑
    /// </summary>
    public partial class SG_New_Page : Page
    {
        public SG_New_Page()
        {
            InitializeComponent();
        }

        private void BTN_SG_NEW_Click(object sender, RoutedEventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=ClassSystem;User ID=sa;Password=root"))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.Parameters.Add(new SqlParameter("@NSno", TB_SG_NEW_SNO.Text));
                    cmd.Parameters.Add(new SqlParameter("@NSname", TB_SG_NEW_SNAME.Text));
                    cmd.Parameters.Add(new SqlParameter("@NCno", TB_SG_NEW_CNO.Text));
                    cmd.Parameters.Add(new SqlParameter("@NCname", TB_SG_NEW_CNAME.Text));
                    cmd.Parameters.Add(new SqlParameter("@NCcredit", TB_SG_NEW_CCREDIT.Text));
                    cmd.Parameters.Add(new SqlParameter("@NGrade", TB_SG_NEW_GRADE.Text));

                    cmd.CommandText = "insert into Stu_Grade values(@NSno,@NSname,@NCno,@NCname,@NCcredit,@NGrade)";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("新增学生成绩信息成功！");
                }
            }
        }
    }
}
