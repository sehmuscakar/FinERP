﻿using System;
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

namespace FinERP.FrontAccounting
{
    /// <summary>
    /// Interaction logic for Anasayfa.xaml
    /// </summary>
    public partial class Anasayfa : Page
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void UrunlerButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Urunler());
        }

        private void FaturalarButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Faturalar());
        }
    }
}
