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
    /// CC_New_Page.xaml 的交互逻辑
    /// </summary>
    public partial class CC_New_Page : Page
    {
        public CC_New_Page()
        {
            InitializeComponent();
        }

        private void BTN_CC_NEW_Click(object sender, RoutedEventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["dbConnStr"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.Parameters.Add(new SqlParameter("@Ncosttime", TB_CC_NEW_COSTTIME.Text));
                    cmd.Parameters.Add(new SqlParameter("@Njoinnum", TB_CC_NEW_JOINNUM.Text));
                    cmd.Parameters.Add(new SqlParameter("@Ncostproj", TB_CC_NEW_COSTPROJ.Text));
                    cmd.Parameters.Add(new SqlParameter("@Ncostplace", TB_CC_NEW_COSTPLACE.Text));
                    cmd.Parameters.Add(new SqlParameter("@Ncostmoney", TB_CC_NEW_COSTMONEY.Text));


                    cmd.CommandText = "insert into Cost_Detail(CostTime,CostProj,CostPlace,JoinNum,CostSum) values(@Ncosttime,@Ncostproj,@Ncostplace,@Njoinnum,@Ncostmoney);";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "update Cost_Detail set ID=(SELECT Max(ID) FROM Cost_Detail)+1 where CostTime IN (SELECT Max(CostTime) FROM Cost_Detail);";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "update Cost_Detail set OCost=(select RCost from Cost_Detail where ID IN (SELECT Max(ID)-1 FROM Cost_Detail)) where ID=(SELECT Max(ID) FROM Cost_Detail);";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "update Cost_Detail set RCost=OCost-CostSum where ID=(SELECT Max(ID) FROM Cost_Detail);";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("新增班费支出记录成功！");
                }
            }
        }
    }
}
