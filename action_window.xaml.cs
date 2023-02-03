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
using System.Windows.Shapes;
using hotehet.pages;

namespace hotehet
{
    /// <summary>
    /// Логика взаимодействия для action_window.xaml
    /// </summary>
    public partial class action_window : Window
    {
        public action_window()
        {
            InitializeComponent();

            naviClass.menuF = menu_frame;
            menu_frame.Navigate(new pages.menuPage());

            naviClass.mainF = main_frame;
           
        }

        private void exitToauth_Click(object sender, RoutedEventArgs e)
        {
            auth_window a = new auth_window();
            a.Show();
            this.Close();
        }
    }
}
