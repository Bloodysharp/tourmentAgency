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
using TourAgency.Classes;

namespace TourAgency
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Manager.MainFrame = MainFrame;
        }
        private void Border_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void ButtonHotels_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Pages.HotelsPage());
            
        }
        private void ButtonComments_Click(object sender, RoutedEventArgs e)
        {

        }
        private void ButtonTours_Click(object sender, RoutedEventArgs e)
        {

        }
        private void ButtonCountry_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonShutDown_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
