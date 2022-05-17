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
    /// Логика взаимодействия для Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        public Page4()
        {
            InitializeComponent(); Radius.Focus();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page1());
        }
        private void Rasschet(object sender, RoutedEventArgs e)
        {
            try
            {
                string R = Radius.Text, H = Height.Text, O = Okrugl.Text;
                double Rnew = 0, Hnew = 0;
                int Onew = 0;
                try
                {
                    Rnew = double.Parse(R);
                    Hnew = double.Parse(H);
                    Onew = int.Parse(O);

                    double osnova = Math.PI * Math.Pow(Rnew, 2);
                    double boca = 2.0 * Math.PI * Rnew * Hnew;
                    double obch = 2 * osnova + boca;
                    double obem = Hnew * osnova;

                    Sosn.Text = Math.Round(osnova, Onew).ToString();
                    Sboc.Text = Math.Round(boca, Onew).ToString();
                    Sobch.Text = Math.Round(obch, Onew).ToString();
                    Obem.Text = Math.Round(obem, Onew).ToString();
                    if (Rnew < 0 || Hnew < 0 || Onew < 0)
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
                Radius.Focus();
            }
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
