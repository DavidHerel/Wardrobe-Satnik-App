using Satnik.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Satnik.ViewModels
{
    public class ObleceniCustomCardViewModel:ViewModelBase
    {

        public ObleceniCustomCardViewModel(MainViewModel mainViewModelReference, string druh, string barva, string kategorie, BitmapImage icon)
        {
            _mainViewModelReference = mainViewModelReference;
            Druh = druh;
            Barva = barva;
            Kategorie = kategorie;
            Icon = icon;
        }

        private RelayCommand _removeCityCommand;
        private MainViewModel _mainViewModelReference;
        private string _druh;
        private string _barva;
        private string _kategorie;
        private BitmapImage _icon;

        public string Druh { get { return _druh; } set { _druh = value; OnPropertyChanged(); } }

        public string Barva { get { return _barva; } set { _barva = value; OnPropertyChanged(); } }

        public string Kategorie { get { return _kategorie; } set { _kategorie = value; OnPropertyChanged(); } }

        public BitmapImage Icon { get { return _icon; } set { _icon = value; OnPropertyChanged(); } }

        public RelayCommand DeleteCity
        {
            get
            {
                return _removeCityCommand ?? (_removeCityCommand = new RelayCommand(DeleteCityItem));
            }
        }

        private void DeleteCityItem(object obj)
        {
            _mainViewModelReference.ObleceniCards.Remove(this);
            _mainViewModelReference.PocetObleceni = "Ve vaší skříni je " + _mainViewModelReference.ObleceniCards.Count + " kusů oblečení";
        }

    }
}
