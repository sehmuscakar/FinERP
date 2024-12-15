using FinERP.FrontAccounting.NavigationService;
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

namespace FinERP.FrontAccounting
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly NavigationServicee _navigationService;


        public MainWindow()
        {
            InitializeComponent();
          _navigationService = new NavigationServicee(ContentFrame);
          _navigationService.Navigate(typeof(Anasayfa)); // Uygulama açıldığında Anasayfa yüklenir.

         //   NavigationService.Navigate(new Anasayfa());
        }

        private void AnasayfaButton_Click(object sender, RoutedEventArgs e)
        {
            _navigationService.Navigate(typeof(Anasayfa));
           // NavigationService.Navigate(new Anasayfa());
        }

        //private void UrunlerButton_Click(object sender, RoutedEventArgs e)
        //{
        //    _navigationService.Navigate(typeof(Urunler));
        //}

        //private void FaturalarButton_Click(object sender, RoutedEventArgs e)
        //{
        //    _navigationService.Navigate(typeof(Faturalar));
        //}

        private void StoklarButton_Click(object sender, RoutedEventArgs e)
        {
            _navigationService.Navigate(typeof(Stoklar));
        }

        private void MusterilerButton_Click(object sender, RoutedEventArgs e)
        {
            _navigationService.Navigate(typeof(Musteriler));
        }
    }
}

