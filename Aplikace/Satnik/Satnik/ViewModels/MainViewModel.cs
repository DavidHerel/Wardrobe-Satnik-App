using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Satnik.Support;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Threading;

namespace Satnik.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public ObservableCollection<ObleceniCustomCardViewModel> ObleceniCards { get; set; } = new ObservableCollection<ObleceniCustomCardViewModel>();
        private string _PocetObleceni;
        private RelayCommand _addObleceniCommand;
        private RelayCommand _dalsiOutfitButton;

        private BitmapImage _sakoVM;

        public BitmapImage sakoVM { get { return _sakoVM; } set { _sakoVM = value; OnPropertyChanged(); } }

        private BitmapImage _trickoVM;

        public BitmapImage trickoVM { get { return _trickoVM; } set { _trickoVM = value; OnPropertyChanged(); } }

        private BitmapImage _kalhotyVM;

        public BitmapImage kalhotyVM { get { return _kalhotyVM; } set { _kalhotyVM = value; OnPropertyChanged(); } }

        private BitmapImage _botyVM;

        public BitmapImage botyVM { get { return _botyVM; } set { _botyVM = value; OnPropertyChanged(); } }


        public MainViewModel()
        {
            //pridani zakladniho druhu obleceni
            addStartingClothes();

            PocetObleceni = "Ve vaší skříni je " + ObleceniCards.Count + " kusů oblečení";

        }

        public string PocetObleceni { get { return _PocetObleceni; } set { _PocetObleceni = value; OnPropertyChanged(); } }

        public RelayCommand NoveObleceniButton
        {
            get
            {
                return _addObleceniCommand ?? (_addObleceniCommand = new RelayCommand(AddObleceniItem));
            }
        }

        private void AddObleceniItem(object obj)
        {
            //add new window
            var noveObleceni = new NoveObleceni();
            if (noveObleceni.ShowDialog() == true)
            {
                //vezmu si data
                BitmapImage bitmapImage = noveObleceni.bitmapImage;
                string druh = noveObleceni.druhObleceni;
                string barva = "zelena";
                string kategorie = "formalni";

                //pridam
                ObleceniCards.Add(new ObleceniCustomCardViewModel(this, druh, barva, kategorie, bitmapImage));

                //updatuju string
                PocetObleceni = "Ve vaší skříni je " + ObleceniCards.Count + " kusů oblečení";
            }
            //ObleceniCards.Add(new ObleceniCards(this, _cityToBeAdded));
        }

        public RelayCommand DalsiOutfitButton
        {
            get
            {
                return _dalsiOutfitButton ?? (_dalsiOutfitButton = new RelayCommand(dalsiOutfitButton));
            }
        }

        private void dalsiOutfitButton(object obj)
        {
            IList<ObleceniCustomCardViewModel> saka = new List<ObleceniCustomCardViewModel>();
            //vygeneruji outfit
            //saka
            foreach(var tricko in ObleceniCards)
            {
                if(tricko.Druh == "Mikina" || tricko.Druh == "Svetr" || tricko.Druh == "Sako" || tricko.Druh == "Kabat" || tricko.Druh == "Bunda")
                {
                    saka.Add(tricko);                    
                }
            }

            //zasafluhuju tricka
            saka.Shuffle();
            //vezmu random
            if (saka.Count > 0)
            {
                sakoVM = saka.First().Icon;
            }

            //trika
            IList<ObleceniCustomCardViewModel> tricka = new List<ObleceniCustomCardViewModel>();
            //vygeneruji outfit
            foreach (var tricko in ObleceniCards)
            {
                if (tricko.Druh == "Tricko" || tricko.Druh == "Kosile")
                {
                    tricka.Add(tricko);
                }
            }

            //zasafluhuju tricka
            tricka.Shuffle();
            //vezmu random
            if (tricka.Count > 0)
            {
                trickoVM = tricka.First().Icon;
            }

            //kalhoty
            IList<ObleceniCustomCardViewModel> kalhoty = new List<ObleceniCustomCardViewModel>();
            //vygeneruji outfit
            foreach (var tricko in ObleceniCards)
            {
                if (tricko.Druh == "Kalhoty" || tricko.Druh == "Sukne")
                {
                    kalhoty.Add(tricko);
                }
            }

            //zasafluhuju tricka
            kalhoty.Shuffle();
            //vezmu random
            if (kalhoty.Count > 0)
            {
                kalhotyVM = kalhoty.First().Icon;
            }

            //kalhoty
            IList<ObleceniCustomCardViewModel> boty = new List<ObleceniCustomCardViewModel>();
            //vygeneruji outfit
            foreach (var tricko in ObleceniCards)
            {
                if (tricko.Druh == "Boty")
                {
                    boty.Add(tricko);
                }
            }

            //zasafluhuju tricka
            boty.Shuffle();
            if (boty.Count > 0)
            {
                //vezmu random
                botyVM = boty.First().Icon;
            }
        }


        private void addStartingClothes()
        {
            //pridani obleceni
            BitmapImage logo = new BitmapImage();
            logo.BeginInit();
            logo.UriSource = new Uri(@"/Satnik;component/Images/boty.png", UriKind.Relative);
            logo.EndInit();
            ObleceniCards.Add(new ObleceniCustomCardViewModel(this, "Boty", "cerna", "formalni", logo));

            logo = new BitmapImage();
            logo.BeginInit();
            logo.UriSource = new Uri(@"/Satnik;component/Images/sandale.png", UriKind.Relative);
            logo.EndInit();
            ObleceniCards.Add(new ObleceniCustomCardViewModel(this, "Boty", "cerna", "formalni", logo));

            logo = new BitmapImage();
            logo.BeginInit();
            logo.UriSource = new Uri(@"/Satnik;component/Images/boty3.png", UriKind.Relative);
            logo.EndInit();
            ObleceniCards.Add(new ObleceniCustomCardViewModel(this, "Boty", "cerna", "formalni", logo));

            logo = new BitmapImage();
            logo.BeginInit();
            logo.UriSource = new Uri(@"/Satnik;component/Images/tricko2.png", UriKind.Relative);
            logo.EndInit();
            ObleceniCards.Add(new ObleceniCustomCardViewModel(this, "Tricko", "zelena", "formalni", logo));

            logo = new BitmapImage();
            logo.BeginInit();
            logo.UriSource = new Uri(@"/Satnik;component/Images/tricko4.jpg", UriKind.Relative);
            logo.EndInit();
            ObleceniCards.Add(new ObleceniCustomCardViewModel(this, "Tricko", "zelena", "formalni", logo));

            logo = new BitmapImage();
            logo.BeginInit();
            logo.UriSource = new Uri(@"/Satnik;component/Images/tricko4.png", UriKind.Relative);
            logo.EndInit();
            ObleceniCards.Add(new ObleceniCustomCardViewModel(this, "Tricko", "zelena", "formalni", logo));

            logo = new BitmapImage();
            logo.BeginInit();
            logo.UriSource = new Uri(@"/Satnik;component/Images/sako.png", UriKind.Relative);
            logo.EndInit();
            ObleceniCards.Add(new ObleceniCustomCardViewModel(this, "Sako", "zelena", "formalni", logo));

            logo = new BitmapImage();
            logo.BeginInit();
            logo.UriSource = new Uri(@"/Satnik;component/Images/mikina.png", UriKind.Relative);
            logo.EndInit();
            ObleceniCards.Add(new ObleceniCustomCardViewModel(this, "Sako", "zelena", "formalni", logo));

            logo = new BitmapImage();
            logo.BeginInit();
            logo.UriSource = new Uri(@"/Satnik;component/Images/bunda.jpg", UriKind.Relative);
            logo.EndInit();
            ObleceniCards.Add(new ObleceniCustomCardViewModel(this, "Sako", "zelena", "formalni", logo));

            logo = new BitmapImage();
            logo.BeginInit();
            logo.UriSource = new Uri(@"/Satnik;component/Images/kalhoty.png", UriKind.Relative);
            logo.EndInit();
            ObleceniCards.Add(new ObleceniCustomCardViewModel(this, "Kalhoty", "zelena", "formalni", logo));

            logo = new BitmapImage();
            logo.BeginInit();
            logo.UriSource = new Uri(@"/Satnik;component/Images/kalhoty2.png", UriKind.Relative);
            logo.EndInit();
            ObleceniCards.Add(new ObleceniCustomCardViewModel(this, "Kalhoty", "zelena", "formalni", logo));

            logo = new BitmapImage();
            logo.BeginInit();
            logo.UriSource = new Uri(@"/Satnik;component/Images/kratasy.jpg", UriKind.Relative);
            logo.EndInit();
            ObleceniCards.Add(new ObleceniCustomCardViewModel(this, "Kalhoty", "zelena", "formalni", logo));

            logo = new BitmapImage();
            logo.BeginInit();
            logo.UriSource = new Uri(@"/Satnik;component/Images/kratasy2.jpg", UriKind.Relative);
            logo.EndInit();
            ObleceniCards.Add(new ObleceniCustomCardViewModel(this, "Kalhoty", "zelena", "formalni", logo));
        }

    }

    public static class ThreadSafeRandom
    {
        [ThreadStatic] private static Random Local;

        public static Random ThisThreadsRandom
        {
            get { return Local ?? (Local = new Random(unchecked(Environment.TickCount * 31 + Thread.CurrentThread.ManagedThreadId))); }
        }
    }

    static class MyExtensions
    {
        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = ThreadSafeRandom.ThisThreadsRandom.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
