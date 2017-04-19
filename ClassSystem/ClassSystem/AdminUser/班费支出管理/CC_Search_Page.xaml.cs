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
using System.Collections.ObjectModel;

namespace ClassSystem.AdminUser.班费支出管理
{
    /// <summary>
    /// CC_Search_Page.xaml 的交互逻辑
    /// </summary>

    public class CostDetail
    {
        public String CostTime { get; set; }
        public String CostProj { get; set; }
        public String CostPlace { get; set; }
        public Int16 JoinNum { get; set; }
        public Int32 OCost { get; set; }
        public Int32 CostSum { get; set; }
        public Int32 RCost { get; set; }
    }

    public partial class CC_Search_Page : Page
    {
        
        public CC_Search_Page()
        {
            InitializeComponent();

            string connStr = ConfigurationManager.ConnectionStrings["dbConnStr"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from Cost_Detail";

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataSet dataset = new DataSet();
                    adapter.Fill(dataset);  //把查询结果填充到dataset
                    DataTable table = dataset.Tables[0];
                    DataRowCollection rows = table.Rows;
                    ObservableCollection<CostDetail> t = new ObservableCollection<CostDetail>();
                    
                    for (int i = 0; i < rows.Count; i++)
                    {
                        DataRow row = rows[i];
                        string CostTime = (string)row["CostTime"];
                        string CostProj = (string)row["CostProj"];
                        string CostPlace = (string)row["CostPlace"];
                        Int16 JoinNum = (Int16)row["JoinNum"];
                        Int32 OCost = (Int32)row["OCost"];
                        Int32 CostSum = (Int32)row["CostSum"];
                        Int32 RCost = (Int32)row["RCost"];
                        Int32 ID = (Int32)row["ID"];

                        CostDetail info = new CostDetail
                        {
                            CostTime = CostTime,
                            CostProj = CostProj,
                            CostPlace = CostPlace,
                            JoinNum = JoinNum,
                            OCost = OCost,
                            CostSum = CostSum,
                            RCost = RCost
                        };
                        t.Add(info);
                        
                        TB_RCOST.Text = Convert.ToString(RCost);
                        TB_ATY.Text = Convert.ToString(ID);
                    }

                    
                    this.datagrid1.ItemsSource = t;

                }
            }
        }

        private void BTN_CC_Search_Click(object sender, RoutedEventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=ClassSystem;User ID=sa;Password=root"))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.Parameters.Add(new SqlParameter("@S_CC", TB_SI_Sno.Text));
                    cmd.CommandText = "select * from Cost_Detail where CostTime=@S_CC";

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataSet dataset = new DataSet();
                    adapter.Fill(dataset);  //把查询结果填充到dataset
                    DataTable table = dataset.Tables[0];
                    DataRowCollection rows = table.Rows;
                    List<CostDetail> t = new List<CostDetail>();

                    for (int i = 0; i < rows.Count; i++)
                    {
                        DataRow row = rows[i];
                        string CostTime = (string)row["CostTime"];
                        string CostProj = (string)row["CostProj"];
                        string CostPlace = (string)row["CostPlace"];
                        Int16 JoinNum = (Int16)row["JoinNum"];
                        Int32 OCost = (Int32)row["OCost"];
                        Int32 CostSum = (Int32)row["CostSum"];
                        Int32 RCost = (Int32)row["RCost"];

                        CostDetail info = new CostDetail
                        {
                            CostTime = CostTime,
                            CostProj = CostProj,
                            CostPlace = CostPlace,
                            JoinNum = JoinNum,
                            OCost = OCost,
                            CostSum = CostSum,
                            RCost = RCost
                        };
                        t.Add(info);

                    }
                    this.datagrid1.ItemsSource = t;
                }
            }
        }
    }
}
