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

namespace ClassSystem
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BTN_LOGIN_Click(object sender, RoutedEventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["dbConnStr"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select Position from User_info where Sno=@username and Password=@password";
                    cmd.Parameters.Add(new SqlParameter("@username", TB_username.Text));
                    cmd.Parameters.Add(new SqlParameter("@password", TB_password.Text));
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string posi = (string)reader.GetString(0);
                            string cmp = posi.Substring(0,1);
                            bool? RB1 = RB_1.IsChecked;
                            bool? RB2 = RB_2.IsChecked;
                            if (RB1 == true)
                            {
                                if (string.Compare(cmp, "无") == 0)
                                {
                                    MessageBox.Show("登录失败！你不是管理员！");
                                }
                                else
                                {
                                    AdminWindow adminwin = new AdminWindow();
                                    Close();
                                    adminwin.ShowDialog();
                                }
                            }
                            else if (RB2 == true)
                            {
                                MWindow mwin = new MWindow();
                                Close();
                                mwin.ShowDialog();
                            }
                        }
                        else
                        {
                            MessageBox.Show("登录失败！用户名或密码错误！");
                        }
                    }
                }
            }
        }

    }
}
