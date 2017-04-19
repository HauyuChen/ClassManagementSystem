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

namespace ClassSystem.AdminUser
{
    /// <summary>
    /// Admin_PassAlter_Page.xaml 的交互逻辑
    /// </summary>
    public partial class Admin_PassAlter_Page : Page
    {
        public Admin_PassAlter_Page()
        {
            InitializeComponent();


        }

        private void BTN_AlterSub_Click(object sender, RoutedEventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["dbConnStr"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.Parameters.Add(new SqlParameter("@ia_sno", TB_IA_Sno.Text));
                    cmd.Parameters.Add(new SqlParameter("@ia_opass", TB_IA_OPass.Text));

                    cmd.CommandText = "select * from User_info where Sno=@ia_sno and Password=@ia_opass";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (TB_IA_NPassA.Text != "" && TB_IA_NPassB.Text != "" && TB_IA_NPassA.Text.Length >= 4 && TB_IA_NPassB.Text.Length >= 4)
                            {
                                if (TB_IA_NPassA.Text == TB_IA_NPassB.Text)
                                {
                                    reader.Close();
                                    using (SqlCommand cmd2 = conn.CreateCommand())
                                    {
                                        cmd2.Parameters.Add(new SqlParameter("@ia_npassa", TB_IA_NPassA.Text));
                                        cmd2.Parameters.Add(new SqlParameter("@ia_sno", TB_IA_Sno.Text));
                                        cmd2.CommandText = "update User_info set Password=@ia_npassa where Sno=@ia_sno";
                                        cmd2.ExecuteNonQuery();
                                        MessageBox.Show("修改成功！");

                                    }

                                }
                                else
                                {
                                    MessageBox.Show("两次输入的密码不一致！");
                                }
                            }
                            else
                            {
                                MessageBox.Show("密码不能低于4位且不能为空！");
                            }

                        }
                        else
                        {
                            MessageBox.Show("修改失败！用户名或密码错误！");
                        }
                    }
                }
            }
        }
    }
}
