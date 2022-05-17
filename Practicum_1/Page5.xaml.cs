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
    /// Логика взаимодействия для Page5.xaml
    /// </summary>
    public partial class Page5 : Page
    {
        public Page5()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page1());
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void Rasschet(object sender, RoutedEventArgs e)
        {
            try
            {
                string R1 = RadiusN.Text, R2 = RadiusV.Text, H = Height.Text, O = Okrugl.Text;
                double Rnov_1 = 0, Rnov_2 = 0, Hnew = 0;
                int Onew = 0;
                try
                {
                    Rnov_1 = double.Parse(R1);
                    Rnov_2 = double.Parse(R2);
                    Hnew = double.Parse(H);
                    Onew = int.Parse(O);

                    double leng = Math.Sqrt(Math.Pow(Rnov_1 - Rnov_2, 2) + Math.Pow(Hnew, 2));
                    double plosad_boc = Math.PI * (Rnov_1 + Rnov_2) * leng;
                    double plosad_osnovania_vverh = Math.PI * Math.Pow(Rnov_2, 2);
                    double plosad_osnovania_nij = Math.PI * Math.Pow(Rnov_1, 2);
                    double plosad_poln = Math.PI * ((Rnov_1 + Rnov_2) * leng + (Math.Pow(Rnov_1, 2) + Math.Pow(Rnov_2, 2)));
                    double volume = (1.0 / 3) * Math.PI * Hnew * ((Math.Pow(Rnov_1, 2) + Rnov_1 * Rnov_2 + Math.Pow(Rnov_2, 2)));



                    Stwo.Text = Math.Round(plosad_osnovania_vverh, Onew).ToString();
                    Sone.Text = Math.Round(plosad_osnovania_nij, Onew).ToString();
                    Sboc.Text = Math.Round(plosad_boc, Onew).ToString();
                    Spoln.Text = Math.Round(plosad_poln, Onew).ToString();
                    Obem.Text = Math.Round(volume, Onew).ToString();

                    if (Rnov_1 < 0 || Rnov_2 < 0 || Hnew < 0 || Onew < 0)
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
                RadiusN.Focus();
            }
        }
    }
}

