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
    /// CC_Alter_Page.xaml 的交互逻辑
    /// </summary>
    public partial class CC_Alter_Page : Page
    {
        public CC_Alter_Page()
        {
            InitializeComponent();
        }

        private void BTN_CC_ALTER_Click(object sender, RoutedEventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["dbConnStr"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.Parameters.Add(new SqlParameter("@Ntime", TB_CC_TIME.Text));
                    cmd.Parameters.Add(new SqlParameter("@Nmoney", '+'+TB_CC_MONEY.Text));
                    cmd.Parameters.Add(new SqlParameter("@Nbz","备注："+TB_CC_BZ.Text));

                    cmd.CommandText = "insert into Cost_Detail(CostTime,CostProj,Costplace,JoinNum,CostSum) values(@Ntime,'班费注入',@Nbz,0,@Nmoney)";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "update Cost_Detail set ID=(SELECT Max(ID) FROM Cost_Detail)+1 where CostTime IN (SELECT Max(CostTime) FROM Cost_Detail);";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "update Cost_Detail set OCost=(select RCost from Cost_Detail where ID IN (SELECT Max(ID)-1 FROM Cost_Detail)) where ID=(SELECT Max(ID) FROM Cost_Detail);";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "update Cost_Detail set RCost=OCost+CostSum where ID=(SELECT Max(ID) FROM Cost_Detail);";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("注入班费成功！");
                }
            }
        }
    }
}
