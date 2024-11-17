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

namespace TourAgency.Pages.Edit
{
    /// <summary>
    /// Логика взаимодействия для Editing.xaml
    /// </summary>
    public partial class Editing : Page
    {
        private Hotel _currentHotel = new Hotel();
        public Editing(Hotel selectedHotel)
        {
            InitializeComponent();
            if (selectedHotel != null) _currentHotel = selectedHotel;

            DataContext = _currentHotel;
            countryNameComboBox.ItemsSource = tourDatabaseEntities.GetContext().Country.ToList();

            countryNameComboBox.SelectedItem = _currentHotel.Country;

        }
        private SolidColorBrush HextoSolidBrush(string Hex)
        {
            return new SolidColorBrush((Color)ColorConverter.ConvertFromString(Hex));
        }
        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var obj = new Hotel
                {
                    hotelName = hotelNameTextBox.Text,
                    countOfStars = int.Parse(countOfStarsTextBox.Text),
                    countryCode = tourDatabaseEntities.GetContext().Country.Where(d => d.countryName == countryNameComboBox.Text).FirstOrDefault().code

                    // var prodcut = DB.FurnitureManufacturyEntities.GetContext().Supplies.Where(d => d.SupplyName == "1").FirstOrDefault();
                };

                tourDatabaseEntities.GetContext().Hotel.Add(obj);
                tourDatabaseEntities.GetContext().SaveChanges();
                Notification success = new Notification(
                  "Успех!",
                  "Сохранение произошло успешно!",
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
                    "Не удалось сохранить данные!",
                    "/Images/Error_icon.png",
                    (LinearGradientBrush)this.Resources["RedGradient"],
                    HextoSolidBrush("#F24A50")
                    );
                    error.Show();
            }

        }
    }
}
