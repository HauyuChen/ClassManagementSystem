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
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Configuration;

namespace ClassSystem.AdminUser
{
    /// <summary>
    /// ANN_Alter_Info_Window.xaml 的交互逻辑
    /// </summary>
    public partial class ANN_Alter_Info_Window : Window
    {
        public ANN_Alter_Info_Window()
        {
            InitializeComponent();
        }

        private void BTN_Win_ALTInfo_Click(object sender, RoutedEventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["dbConnStr"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.Parameters.Add(new SqlParameter("@info", TB_Win_ALTInfo.Text));
                    cmd.Parameters.Add(new SqlParameter("@infotime",DateTime.Now));
                    cmd.CommandText = "update Announ set info=@info,infotime=@infotime";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("修改成功！");
                    Close();
                }
            }
        }
    }
}
