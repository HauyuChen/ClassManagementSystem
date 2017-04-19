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

namespace ClassSystem
{
    /// <summary>
    /// CStuInfoPage.xaml 的交互逻辑
    /// </summary>
    public partial class CStuInfoPage : Page
    {
        public class StuInfo
        {
            public String Sno { get; set; }
            public String Sname { get; set; }
            public String Srole { get; set; }
            public String Ssex { get; set; }
            public String Sbirth { get; set; }
            public String Sidentity { get; set; }
            public String Scardnum { get; set; }
            public String Smobile { get; set; }
            public String Sdorm { get; set; }
            public String Sqq { get; set; }
        }
        public CStuInfoPage()
        {
            InitializeComponent();
            using (SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=ClassSystem;User ID=sa;Password=root"))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from Stu_info";

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataSet dataset = new DataSet();
                    adapter.Fill(dataset);  //把查询结果填充到dataset
                    DataTable table = dataset.Tables[0];
                    DataRowCollection rows = table.Rows;
                    List<StuInfo> t = new List<StuInfo>();

                    for (int i = 0; i < rows.Count; i++)
                    {
                        DataRow row = rows[i];
                        string Sno = (string)row["Sno"];
                        string Sname = (string)row["Sname"];
                        string Srole = (string)row["Srole"];
                        string Ssex = (string)row["Ssex"];
                        string Sbirth = (string)row["Sbirth"];
                        string Sidentity = (string)row["Sidentity"];
                        string Scardnum = (string)row["Scardnum"];
                        string Smobile = (string)row["Smobile"];
                        string Sdorm = (string)row["Sdorm"];
                        string Sqq = (string)row["Sqq"];
                        StuInfo info = new StuInfo
                        {
                            Sno = Sno,
                            Sname = Sname,
                            Srole = Srole,
                            Ssex = Ssex,
                            Sbirth = Sbirth,
                            Sidentity = Sidentity,
                            Scardnum = Scardnum,
                            Smobile = Smobile,
                            Sdorm = Sdorm,
                            Sqq = Sqq
                        };
                        t.Add(info);

                    }
                    this.datagrid1.ItemsSource = t;
                }
            }
        }

        private void BTN_SI_Search_Click(object sender, RoutedEventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=ClassSystem;User ID=sa;Password=root"))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.Parameters.Add(new SqlParameter("@S_SI", TB_SI_Sno.Text));
                    cmd.CommandText = "select * from Stu_info where Sno=@S_SI or Sname=@S_SI";

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataSet dataset = new DataSet();
                    adapter.Fill(dataset);  //把查询结果填充到dataset
                    DataTable table = dataset.Tables[0];
                    DataRowCollection rows = table.Rows;
                    List<StuInfo> t = new List<StuInfo>();

                    for (int i = 0; i < rows.Count; i++)
                    {
                        DataRow row = rows[i];
                        string Sno = (string)row["Sno"];
                        string Sname = (string)row["Sname"];
                        string Srole = (string)row["Srole"];
                        string Ssex = (string)row["Ssex"];
                        string Sbirth = (string)row["Sbirth"];
                        string Sidentity = (string)row["Sidentity"];
                        string Scardnum = (string)row["Scardnum"];
                        string Smobile = (string)row["Smobile"];
                        string Sdorm = (string)row["Sdorm"];
                        string Sqq = (string)row["Sqq"];
                        StuInfo info = new StuInfo
                        {
                            Sno = Sno,
                            Sname = Sname,
                            Srole = Srole,
                            Ssex = Ssex,
                            Sbirth = Sbirth,
                            Sidentity = Sidentity,
                            Scardnum = Scardnum,
                            Smobile = Smobile,
                            Sdorm = Sdorm,
                            Sqq = Sqq
                        };
                        t.Add(info);

                    }
                    this.datagrid1.ItemsSource = t;
                }
            }
        }
    }
}
