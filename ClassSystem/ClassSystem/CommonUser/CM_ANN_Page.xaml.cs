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

namespace ClassSystem.CommonUser
{
    /// <summary>
    /// CM_ANN_Page.xaml 的交互逻辑
    /// </summary>
    public partial class CM_ANN_Page : Page
    {
        public CM_ANN_Page()
        {
            InitializeComponent();

            using (SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=ClassSystem;User ID=sa;Password=root"))
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
    }
}
