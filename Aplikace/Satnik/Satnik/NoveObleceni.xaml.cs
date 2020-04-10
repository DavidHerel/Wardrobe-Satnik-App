using Microsoft.Win32;
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

namespace Satnik
{
    /// <summary>
    /// Interakční logika pro NoveObleceni.xaml
    /// </summary>
    public partial class NoveObleceni : Window
    {

        public BitmapImage bitmapImage;

        public string druhObleceni;

        public string barvaObleceni;

        public string kategorieObleceni;

        public NoveObleceni()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void StornoButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ObleceniButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png";
            if (op.ShowDialog() == true)
            {
                ObleceniImage.Source = new BitmapImage(new Uri(op.FileName));
                bitmapImage = new BitmapImage(new Uri(op.FileName));
            }
        }

        private void Tricko_Checked(object sender, RoutedEventArgs e)
        {
            druhObleceni = "Tricko";
        }

        private void Kosile_Checked(object sender, RoutedEventArgs e)
        {
            druhObleceni = "Kosile";
        }

        private void Mikina_Checked(object sender, RoutedEventArgs e)
        {
            druhObleceni = "Mikina";
        }

        private void Svetr_Checked(object sender, RoutedEventArgs e)
        {
            druhObleceni = "Svetr";
        }

        private void Sako_Checked(object sender, RoutedEventArgs e)
        {
            druhObleceni = "Sako";
        }

        private void Kabat_Checked(object sender, RoutedEventArgs e)
        {
            druhObleceni = "Kabat";
        }

        private void Bunda_Checked(object sender, RoutedEventArgs e)
        {
            druhObleceni = "Bunda";
        }

        private void Kalhoty_Checked(object sender, RoutedEventArgs e)
        {
            druhObleceni = "Kalhoty";
        }

        private void Kratasy_Checked(object sender, RoutedEventArgs e)
        {
            druhObleceni = "Kratasy";
        }

        private void Sukne_Checked(object sender, RoutedEventArgs e)
        {
            druhObleceni = "Sukne";
        }

        private void Boty_Checked(object sender, RoutedEventArgs e)
        {
            druhObleceni = "Boty";
        }

        private void Doplnky_Checked(object sender, RoutedEventArgs e)
        {
            druhObleceni = "Doplnky";
        }
    }
}
