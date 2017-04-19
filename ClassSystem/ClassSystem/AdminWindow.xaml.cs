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
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Navigation;
using ClassSystem.AdminUser;
using ClassSystem.AdminUser.课程信息管理;
using ClassSystem.AdminUser.学生成绩管理;
using ClassSystem.AdminUser.班费支出管理;

namespace ClassSystem
{
    /// <summary>
    /// AdminWindow.xaml 的交互逻辑
    /// </summary>
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();
            Admin.NavigationUIVisibility = NavigationUIVisibility.Hidden;
            ANN_Page ann = new ANN_Page();
            Admin.Content = ann;
        }

        private void BTN_SI_Search_Click(object sender, RoutedEventArgs e)
        {
            SI_Search_Page sis = new SI_Search_Page();
            Admin.Content = sis;
        }

        private void BTN_CI_Search_Click(object sender, RoutedEventArgs e)
        {
            CI_Search_Page cis = new CI_Search_Page();
            Admin.Content = cis;
        }

        private void BTN_SG_Search_Click(object sender, RoutedEventArgs e)
        {
            SG_Search_Page sgs = new SG_Search_Page();
            Admin.Content = sgs;
        }

        private void BTN_CC_Search_Click(object sender, RoutedEventArgs e)
        {
            CC_Search_Page ccs = new CC_Search_Page();
            Admin.Content = ccs;
        }

        private void BTN_AM_InfoAlter_Click(object sender, RoutedEventArgs e)
        {
            //InfoAlterWindow InfoAlterWin = new InfoAlterWindow();
            //InfoAlterWin.ShowDialog();
        }


        private void BTN_SI_Alter_Click(object sender, RoutedEventArgs e)
        {
            SI_Alter_Page sia = new SI_Alter_Page();
            Admin.Content = sia;
        }

        private void BTN_SI_New_Click(object sender, RoutedEventArgs e)
        {
            SI_New_Page sin = new SI_New_Page();
            Admin.Content = sin;
        }

        private void BTN_SI_Del_Click(object sender, RoutedEventArgs e)
        {
            SI_Del_Page sid = new SI_Del_Page();
            Admin.Content = sid;
        }

        private void BTN_CI_Alter_Click(object sender, RoutedEventArgs e)
        {
            CI_Alter_Page cia = new CI_Alter_Page();
            Admin.Content = cia;
        }

        private void BTN_CI_New_Click(object sender, RoutedEventArgs e)
        {
            CI_New_Page cin = new CI_New_Page();
            Admin.Content = cin;
        }

        private void BTN_CI_Del_Click(object sender, RoutedEventArgs e)
        {
            CI_Del_Page cid = new CI_Del_Page();
            Admin.Content = cid;
        }

        private void BTN_SG_Alter_Click(object sender, RoutedEventArgs e)
        {
            SG_Alter_Page sga = new SG_Alter_Page();
            Admin.Content = sga;
        }

        private void BTN_SG_New_Click(object sender, RoutedEventArgs e)
        {
            SG_New_Page sgn = new SG_New_Page();
            Admin.Content = sgn;
        }

        private void BTN_SG_Del_Click(object sender, RoutedEventArgs e)
        {
            SG_Del_Page sgd = new SG_Del_Page();
            Admin.Content = sgd;
        }

        private void BTN_CC_zhuru_Click(object sender, RoutedEventArgs e)
        {
            CC_Alter_Page cca = new CC_Alter_Page();
            Admin.Content = cca;
        }

        private void BTN_CC_New_Click(object sender, RoutedEventArgs e)
        {
            CC_New_Page ccn = new CC_New_Page();
            Admin.Content = ccn;
        }

        private void BTN_CC_Del_Click(object sender, RoutedEventArgs e)
        {
            CC_Del_Page ccd = new CC_Del_Page();
            Admin.Content = ccd;
        }

        private void BTN_A_PassAlter_Click(object sender, RoutedEventArgs e)
        {
            Admin_PassAlter_Page apa = new Admin_PassAlter_Page();
            Admin.Content = apa;
        }

        private void BTN_A_ANN_Click(object sender, RoutedEventArgs e)
        {
            ANN_Page ann = new ANN_Page();
            Admin.Content = ann;
        }

        private void BTN_EXIT_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mwin = new MainWindow();
            Close();
            mwin.ShowDialog();
        }

    }
}
