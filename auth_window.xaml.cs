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
using hotehet.DB;

namespace hotehet
{
    /// <summary>
    /// Логика взаимодействия для auth_window.xaml
    /// </summary>
    public partial class auth_window : Window
    {
        public auth_window()
        {
            InitializeComponent();
        }

        private void zaregistrirovatsya_btn_Click(object sender, RoutedEventArgs e)
        {
            var ruser = conDB.cont.Client.Where(id => id.email == email_tb.Text && id.zachem == pass_pb.Password);
            if (ruser != null)
            {
                action_window ac = new action_window();
                ac.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Не верно, поробуйте снова!");
            }
        }
    }
}
