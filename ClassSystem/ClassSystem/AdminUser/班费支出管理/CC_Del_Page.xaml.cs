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
using System.Configuration;

namespace ClassSystem.AdminUser.班费支出管理
{
    /// <summary>
    /// CC_Del_Page.xaml 的交互逻辑
    /// </summary>
    public partial class CC_Del_Page : Page
    {
        public CC_Del_Page()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["dbConnStr"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {

                    cmd.Parameters.Add(new SqlParameter("@DCostTime", TB_CC_DEL.Text));

                    cmd.CommandText = "delete from Cost_Detail where CostTime=@DCostTime";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("删除班费支出记录成功！");
                }
            }
        }
    }
}
