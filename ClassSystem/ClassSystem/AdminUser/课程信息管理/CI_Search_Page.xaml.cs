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

namespace ClassSystem.AdminUser.课程信息管理
{
    /// <summary>
    /// CI_Search_Page.xaml 的交互逻辑
    /// </summary>
    public partial class CI_Search_Page : Page
    {
        public class CourseInfo
        {
            public String Cno { get; set; }
            public String Cname { get; set; }
            public String Cteacher { get; set; }
            public Int16 Ccredit { get; set; }
            public String Ctime { get; set; }
            public String Cplace { get; set; }
        }
        public CI_Search_Page()
        {
            InitializeComponent();

            using (SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=ClassSystem;User ID=sa;Password=root"))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from Course_info";

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataSet dataset = new DataSet();
                    adapter.Fill(dataset);  //把查询结果填充到dataset
                    DataTable table = dataset.Tables[0];
                    DataRowCollection rows = table.Rows;
                    List<CourseInfo> t = new List<CourseInfo>();
                    DataTable dt = new DataTable();
                    for (int i = 0; i < rows.Count; i++)
                    {
                        DataRow row = rows[i];
                        string Cno = (string)row["Cno"];
                        string Cname = (string)row["Cname"];
                        string Cteacher = (string)row["Cteacher"];
                        Int16 Ccredit = (Int16)row["Ccredit"];
                        string Ctime = (string)row["Ctime"];
                        string Cplace = (string)row["Cplace"];

                        CourseInfo info = new CourseInfo
                        {
                            Cno = Cno,
                            Cname = Cname,
                            Cteacher = Cteacher,
                            Ccredit = Ccredit,
                            Ctime = Ctime,
                            Cplace = Cplace,
                        };
                        t.Add(info);

                    }
                    this.datagrid1.ItemsSource = t;
                }
            }
        }

        private void BTN_CI_Search_Click(object sender, RoutedEventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=ClassSystem;User ID=sa;Password=root"))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.Parameters.Add(new SqlParameter("@S_CI", TB_CI.Text));
                    //string CI = TB_CI.Text;
                    cmd.CommandText = "select * from Course_info where Cno=@S_CI or Cname=@S_CI";

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataSet dataset = new DataSet();
                    adapter.Fill(dataset);  //把查询结果填充到dataset
                    DataTable table = dataset.Tables[0];
                    DataRowCollection rows = table.Rows;
                    List<CourseInfo> t = new List<CourseInfo>();

                    for (int i = 0; i < rows.Count; i++)
                    {
                        DataRow row = rows[i];
                        string Cno = (string)row["Cno"];
                        string Cname = (string)row["Cname"];
                        string Cteacher = (string)row["Cteacher"];
                        Int16 Ccredit = (Int16)row["Ccredit"];
                        string Ctime = (string)row["Ctime"];
                        string Cplace = (string)row["Cplace"];

                        CourseInfo info = new CourseInfo
                        {
                            Cno = Cno,
                            Cname = Cname,
                            Cteacher = Cteacher,
                            Ccredit = Ccredit,
                            Ctime = Ctime,
                            Cplace = Cplace
                        };
                        t.Add(info);

                    }
                    this.datagrid1.ItemsSource = t;
                }
            }
        }
    }
}
