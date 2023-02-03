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
using hotehet.DB;

namespace hotehet.pages
{
    /// <summary>
    /// Логика взаимодействия для actionPage.xaml
    /// </summary>
    public partial class actionPage : Page
    {
        public actionPage()
        {
            InitializeComponent();
        }

        private void reset_password_Click(object sender, RoutedEventArgs e)
        {
            var usr = conDB.cont.Client.Where(io => io.email == email_tb.Text).FirstOrDefault();
            if (usr != null)
            {
                usr.zachem = null;
                conDB.cont.SaveChanges();
                MessageBox.Show("пароль успешно удален");
                naviClass.mainF.Navigate(new pages.setNewPassword_page());
            }
            else
            {
                MessageBox.Show("пароль успешно НЕ удален");
            }
            

        }
    }
}
