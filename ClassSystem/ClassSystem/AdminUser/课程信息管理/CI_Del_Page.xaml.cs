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
    /// CI_Del_Page.xaml 的交互逻辑
    /// </summary>
    public partial class CI_Del_Page : Page
    {
        public CI_Del_Page()
        {
            InitializeComponent();
        }

        private void BTN_CI_D_Click(object sender, RoutedEventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=ClassSystem;User ID=sa;Password=root"))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {

                    cmd.Parameters.Add(new SqlParameter("@DCno", TB_D_Cno.Text));

                    cmd.CommandText = "delete from Course_info where Cno=@DCno";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("删除课程信息成功！");
                }
            }
        }
    }
}
