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
using ClassSystem.CommonUser;

namespace ClassSystem
{
    /// <summary>
    /// MWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MWindow : Window
    {
        public MWindow()
        {
            InitializeComponent();
            pc.NavigationUIVisibility = NavigationUIVisibility.Hidden;
            CM_ANN_Page cmann = new CM_ANN_Page();
            pc.Content = cmann;
        }

        private void BTN_CM_StuInfo_Click(object sender, RoutedEventArgs e)
        {
            CStuInfoPage psi = new CStuInfoPage();
            pc.Content = psi;
        }

        private void BTN_CM_CourseInfo_Click(object sender, RoutedEventArgs e)
        {
            CCourseInfoPage pci = new CCourseInfoPage();
            pc.Content = pci;
        }

        private void BTN_CM_StuGrade_Click(object sender, RoutedEventArgs e)
        {
            CStuGradePage psg = new CStuGradePage();
            pc.Content = psg;
        }

        private void BTN_CM_ClsCost_Click(object sender, RoutedEventArgs e)
        {
            CCostDetailPage pcc = new CCostDetailPage();
            pc.Content = pcc;
        }

        private void BTN_CM_InfoAlter_Click(object sender, RoutedEventArgs e)
        {
            CInfoAlterPage p1 = new CInfoAlterPage();
            pc.Content = p1;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            CM_ANN_Page cmann = new CM_ANN_Page();
            pc.Content = cmann;
        }

        private void BTN_EXIT_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mwin = new MainWindow();
            Close();
            mwin.ShowDialog();
        }
    }
}
