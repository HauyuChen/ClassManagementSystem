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
    /// SG_Del_Page.xaml 的交互逻辑
    /// </summary>
    public partial class SG_Del_Page : Page
    {
        public SG_Del_Page()
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

                    cmd.Parameters.Add(new SqlParameter("@DSno", TB_SG_DEL.Text));

                    cmd.CommandText = "delete from Stu_Grade where Sno=@DSno";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("删除学生成绩信息成功！");
                }
            }
        }
    }
}
