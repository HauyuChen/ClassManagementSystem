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

namespace ClassSystem.AdminUser
{
    /// <summary>
    /// SI_Del_Page.xaml 的交互逻辑
    /// </summary>
    public partial class SI_Del_Page : Page
    {
        public SI_Del_Page()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=ClassSystem;User ID=sa;Password=root"))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    
                    cmd.Parameters.Add(new SqlParameter("@DSno", TB_D_Sno.Text));

                    cmd.CommandText = "delete from Stu_info where Sno=@DSno";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("删除学生信息成功！");
                }
            }
        }
    }
}
