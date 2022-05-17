using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Practicum_1
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Sfera_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page2());
            
        }

        private void Konus_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page3());
        }

        private void Cilindr_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page4());
        }

        private void Minikonus_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page5());
        }
        private void Out_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Windows[0].Close();
        }

    }
}
