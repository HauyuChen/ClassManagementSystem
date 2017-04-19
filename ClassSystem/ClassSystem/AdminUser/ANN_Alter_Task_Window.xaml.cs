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
    /// ANN_Alter_Task_Window.xaml 的交互逻辑
    /// </summary>
    public partial class ANN_Alter_Task_Window : Window
    {
        public ANN_Alter_Task_Window()
        {
            InitializeComponent();
        }

        private void BTN_Win_ALTTask_Click(object sender, RoutedEventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["dbConnStr"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.Parameters.Add(new SqlParameter("@task", TB_Win_ALTTask.Text));
                    cmd.Parameters.Add(new SqlParameter("@tasktime", DateTime.Now));
                    cmd.CommandText = "update Announ set task=@task,tasktime=@tasktime";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("修改成功！");
                    Close();
                }
            }
        }
    }
}
