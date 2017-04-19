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
    /// CStuGradePage.xaml 的交互逻辑
    /// </summary>
    public partial class CStuGradePage : Page
    {
        public class StuGrade
        {
            public String Sno { get; set; }
            public String Sname { get; set; }
            public String Cname { get; set; }
            public Int32 Grade { get; set; }
        }
        public CStuGradePage()
        {
            InitializeComponent();
            using (SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=ClassSystem;User ID=sa;Password=root"))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select Sno,Sname,Cname,Grade from Stu_Grade";

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataSet dataset = new DataSet();
                    adapter.Fill(dataset);  //把查询结果填充到dataset
                    DataTable table = dataset.Tables[0];
                    DataRowCollection rows = table.Rows;
                    List<StuGrade> t = new List<StuGrade>();

                    for (int i = 0; i < rows.Count; i++)
                    {
                        DataRow row = rows[i];
                        string Sno = (string)row["Sno"];
                        string Sname = (string)row["Sname"];
                        string Cname = (string)row["Cname"];
                        Int32 Grade = (Int32)row["Grade"];


                        StuGrade info = new StuGrade
                        {
                            Sno = Sno,
                            Sname = Sname,
                            Cname = Cname,
                            Grade = Grade
                        };
                        t.Add(info);

                    }
                    this.datagrid1.ItemsSource = t;
                }
            }
        }

        private void BTN_SG_Search_Click(object sender, RoutedEventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=ClassSystem;User ID=sa;Password=root"))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.Parameters.Add(new SqlParameter("@S_SG", TB_SG.Text));
                    cmd.CommandText = "select Sno,Sname,Cname,Grade from Stu_Grade where Sno=@S_SG or Sname=@S_SG";

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataSet dataset = new DataSet();
                    adapter.Fill(dataset);  //把查询结果填充到dataset
                    DataTable table = dataset.Tables[0];
                    DataRowCollection rows = table.Rows;
                    List<StuGrade> t = new List<StuGrade>();

                    for (int i = 0; i < rows.Count; i++)
                    {
                        DataRow row = rows[i];
                        string Sno = (string)row["Sno"];
                        string Sname = (string)row["Sname"];
                        string Cname = (string)row["Cname"];
                        Int32 Grade = (Int32)row["Grade"];


                        StuGrade info = new StuGrade
                        {
                            Sno = Sno,
                            Sname = Sname,
                            Cname = Cname,
                            Grade = Grade
                        };
                        t.Add(info);

                    }
                    this.datagrid1.ItemsSource = t;
                }
            }
        }
    }
}
