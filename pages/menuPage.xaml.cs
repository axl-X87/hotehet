using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using hotehet.pages;

namespace hotehet.pages
{
    /// <summary>
    /// Логика взаимодействия для menuPage.xaml
    /// </summary>
    public partial class menuPage : Page
    {
        public menuPage()
        {
            InitializeComponent();
        }

        private void delete_password_Click(object sender, RoutedEventArgs e)
        {
            naviClass.mainF.Navigate(new pages.actionPage());
        }

        private void create_new_password_Click(object sender, RoutedEventArgs e)
        {
            naviClass.mainF.Navigate(new pages.setNewPassword_page());
        }

        private void exitToauth_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
