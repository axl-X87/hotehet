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
    /// Логика взаимодействия для setNewPassword_page.xaml
    /// </summary>
    public partial class setNewPassword_page : Page
    {
        Client cl = new Client();
        public setNewPassword_page()
        {
            InitializeComponent();
        }

        private void setNewPasswordBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //if (cl.zachem != null)
                //{
                    cl = conDB.cont.Client.Where(ll => ll.zachem == oldPassword.Password).FirstOrDefault();
                    if (cl != null)
                    {
                        cl.zachem = null;
                        cl.zachem = newPassword.Password;
                        conDB.cont.SaveChanges();
                        if (cl.zachem == repeatNewPassword.Password)
                        {
                            MessageBox.Show("ваш пароль успешно сменён!");
                            
                            
                        }
                        else
                        {
                            MessageBox.Show("ваш пароль успешно не сменён!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ошибка!");
                    }
                //}
                //else
                //{
                //    MessageBox.Show("Ошибка!");
                //}
            }
            catch
            {
                MessageBox.Show("Ошибка!");
            }
        }
    }
}
