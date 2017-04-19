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
    /// SG_Alter_Page.xaml 的交互逻辑
    /// </summary>
    public partial class SG_Alter_Page : Page
    {
        public SG_Alter_Page()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=ClassSystem;User ID=sa;Password=root"))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.Parameters.Add(new SqlParameter("@NSno", TB_SG_ALTER_SNO.Text));
                    cmd.Parameters.Add(new SqlParameter("@NSname", TB_SG_ALTER_SNAME.Text));
                    cmd.Parameters.Add(new SqlParameter("@NCno", TB_SG_ALTER_CNO.Text));
                    cmd.Parameters.Add(new SqlParameter("@NCname", TB_SG_ALTER_CNAME.Text));
                    cmd.Parameters.Add(new SqlParameter("@NCcredit", TB_SG_ALTER_CCREDIT.Text));
                    cmd.Parameters.Add(new SqlParameter("@NGrade", TB_SG_ALTER_GRADE.Text));

                    cmd.CommandText = "update Stu_Grade set Sno=@NSno,Sname=@NSname,Cno=@NCno,Cname=@NCname,Ccredit=@NCcredit,Grade=@Grade where Sno=@NSno";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("修改学生成绩信息成功！");
                }
            }
        }
    }
}
