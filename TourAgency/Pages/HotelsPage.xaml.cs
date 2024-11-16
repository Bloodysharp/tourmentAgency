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
using TourAgency.CustomNotify;
using TourAgency.Data;

namespace TourAgency.Pages
{
    /// <summary>
    /// Логика взаимодействия для HotelsPage.xaml
    /// </summary>
    public partial class HotelsPage : Page
    {
        public HotelsPage()
        {
            InitializeComponent();
            DGridHotels.ItemsSource = tourDatabaseEntities.GetContext().Hotel.ToList();
        }

        private void ButtonEdit_Click(object sender, RoutedEventArgs e)
        {

        }
        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {

        }
        private SolidColorBrush HextoSolidBrush(string Hex)
        {
            return new SolidColorBrush((Color)ColorConverter.ConvertFromString(Hex));
        }
        private void ButtonDel_Click(object sender, RoutedEventArgs e)
        {
            var hotelsForRemoving = DGridHotels.SelectedItems.Cast<Hotel>().ToList();

            if (MessageBox.Show($"Удалить?", "Внимание!", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    tourDatabaseEntities.GetContext().Hotel.RemoveRange(hotelsForRemoving);
                    tourDatabaseEntities.GetContext().SaveChanges();
                    Notification success = new Notification(
                    "Успех!",
                    "Удаление произошло успешно!",
                    "/Images/success_icon.png",
                    (LinearGradientBrush)this.Resources["GreenGradient"],
                    HextoSolidBrush("#36AE3B")
               );
                    success.Show();
                }
                catch (Exception ex)
                {
                    Notification error = new Notification(
                    "Ошибка!",
                    "Не удалось удалить данные!",
                    "/Images/Error_icon.png",
                    (LinearGradientBrush)this.Resources["RedGradient"],
                    HextoSolidBrush("#F24A50")
                    );
                    error.Show();
                }
            }
        }
    }
}
