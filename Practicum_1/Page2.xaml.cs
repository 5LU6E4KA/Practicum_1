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
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
            Radiuss.Focus();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page1());
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Rasschet_sfera(object sender, RoutedEventArgs e)
        {
            try
            {
                string R = Radiuss.Text;
                string A = Okrugl.Text;
                double Rnov = 0;
                int Onov = 0;
                try
                {
                    Rnov = double.Parse(R);
                    Onov = int.Parse(A);
                    double plosad = 4.0 * Math.PI * Math.Pow(Rnov, 2);
                    double volume = (4.0 / 3) * Math.PI * Math.Pow(Rnov, 3);
                    Square_sfera.Text = Math.Round(plosad, Onov).ToString();
                    Volume_sfera.Text = Math.Round(volume, Onov).ToString();
                    if (Rnov < 0 || Onov < 0)
                    {
                        throw new Exception();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex} Exception.");
                    MessageBox.Show("Введите заново значения!", "Exceptions", MessageBoxButton.OKCancel, MessageBoxImage.Error);
                    throw new Exception();
                }
            }
            catch
            {
                Radiuss.Focus();
            }
        }
    }
}
