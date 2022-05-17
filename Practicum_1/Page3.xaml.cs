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
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
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

                    double leng = Math.Sqrt(Math.Pow(Rnew, 2) + Math.Pow(Hnew, 2));
                    double osnova = Math.Round(Math.PI * Math.Pow(Rnew, 2), Onew);
                    double boca = Math.Round(Math.PI * Rnew * leng, Onew);
                    double obch = osnova + boca;
                    double obem = (1.0 / 3) * Math.PI * Math.Pow(Rnew, 2) * Hnew;

                    Sosn.Text = osnova.ToString();
                    Sboc.Text = boca.ToString();
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
