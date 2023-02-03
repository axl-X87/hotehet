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

namespace hotehet
{
   
    
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Client client = new Client();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BezReg_Click(object sender, RoutedEventArgs e)
        {
            action_window aw = new action_window();
            aw.Show();
            this.Close();
        }

        private void SRegBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                client.name = name_tb.Text;
                client.surname = surname_tb.Text;
                client.ph_number = Convert.ToInt32(number_tb.Text);
                client.email = email_tb.Text;
                client.zachem = password_tb.Text;
                if (repassword_tb.Text != password_tb.Text)
                {
                    MessageBox.Show("Не верно, поробуйте снова!");
                }
                else
                {
                    conDB.cont.Client.Add(client);
                    conDB.cont.SaveChanges();
                    auth_window auth = new auth_window();
                    auth.Show();
                    this.Close();

                }
            }
            catch
            {
                MessageBox.Show("Не верно, попробуйте снова!");
            }
            
        }

        private void authBtn_Click(object sender, RoutedEventArgs e)
        {
            auth_window ath = new auth_window();
            ath.Show();
            this.Close();
        }
    }
}
