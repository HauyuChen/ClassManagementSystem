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
using System.Data;
using System.Configuration;

namespace ClassSystem.AdminUser
{
    /// <summary>
    /// ANN_Page.xaml 的交互逻辑
    /// </summary>
    public partial class ANN_Page : Page
    {
        public ANN_Page()
        {
            InitializeComponent();

            string connStr = ConfigurationManager.ConnectionStrings["dbConnStr"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from Announ";

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataSet dataset = new DataSet();
                    adapter.Fill(dataset);  //把查询结果填充到dataset
                    DataTable table = dataset.Tables[0];
                    DataRowCollection rows = table.Rows;

                    DataTable dt = new DataTable();
                    for (int i = 0; i < rows.Count; i++)
                    {
                        DataRow row = rows[i];
                        string info = (string)row["info"];
                        string task = (string)row["task"];
                        string infotime = (string)row["infotime"];
                        string tasktime = (string)row["tasktime"];

                        TB_info.Text = info;
                        TB_task.Text = task;
                        TB_infotime.Text = infotime;
                        TB_tasktime.Text = tasktime;
                    }

                }
            }
        }

        private void BTN_infoAlt_Click(object sender, RoutedEventArgs e)
        {
            ANN_Alter_Info_Window win_info = new ANN_Alter_Info_Window();
            win_info.ShowDialog();
        }

        private void BTN_taskAlt_Click(object sender, RoutedEventArgs e)
        {
            ANN_Alter_Task_Window win_task = new ANN_Alter_Task_Window();
            win_task.ShowDialog();
        }
    }
}
