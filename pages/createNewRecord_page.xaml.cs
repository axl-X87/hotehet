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
    /// Логика взаимодействия для createNewRecord_page.xaml
    /// </summary>
    public partial class createNewRecord_page : Page
    {
        int selectedNumberFromLV = 0;
        public createNewRecord_page()
        {
            InitializeComponent();
            LV.ItemsSource = conDB.cont.Number.Where(pp => pp.isFree == true).ToList();
        }

        private void create_new_record_Click(object sender, RoutedEventArgs e)
        {
            var placeTheClient = conDB.cont.Number.Where(pp => pp.id == selectedNumberFromLV).FirstOrDefault();
            if (placeTheClient != null)
            {
                placeTheClient.isFree = false;
                placeTheClient.dateRelace = DateTime.Now;
                conDB.cont.SaveChanges();
                MessageBox.Show($"Вы забронировали номер {placeTheClient.id}");
            }
            else
            {
                MessageBox.Show("Ошибка!");
            }
            
        }

        private void LV_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
             selectedNumberFromLV = ((Number)LV.SelectedItem).id;

        }
    }
}
