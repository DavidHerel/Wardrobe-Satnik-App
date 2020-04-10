using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Globalization;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace Satnik
{
    class ObleceniCustomControl : ToggleButton
    {

        static ObleceniCustomControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ObleceniCustomControl), new FrameworkPropertyMetadata(typeof(ObleceniCustomControl)));
        }


        public ICommand RemoveCommand
        {
            get
            {
                return (ICommand)GetValue(RemoveCommandProperty);
            }
            set
            {
                SetValue(RemoveCommandProperty, value);
            }
        }

        public static readonly DependencyProperty RemoveCommandProperty =
    DependencyProperty.Register("RemoveCommand", typeof(ICommand), typeof(ObleceniCustomControl), new PropertyMetadata(default(ICommand)));

        public string DruhObleceni
        {
            get
            {
                return (string)GetValue(DruhObleceniProperty);
            }
            set
            {
                SetValue(DruhObleceniProperty, value);
            }
        }

        public static readonly DependencyProperty DruhObleceniProperty =
      DependencyProperty.Register("DruhObleceni", typeof(string), typeof(ObleceniCustomControl));

        public string Barva
        {
            get
            {
                return (string)GetValue(BarvaProperty);
            }
            set
            {
                SetValue(BarvaProperty, value);
            }
        }

        public static readonly DependencyProperty BarvaProperty =
      DependencyProperty.Register("Barva", typeof(string), typeof(ObleceniCustomControl));

        public string Kategorie
        {
            get
            {
                return (string)GetValue(KategorieProperty);
            }
            set
            {
                SetValue(KategorieProperty, value);
            }
        }

        public static readonly DependencyProperty KategorieProperty =
      DependencyProperty.Register("Kategorie", typeof(string), typeof(ObleceniCustomControl));

        public BitmapImage Icon
        {
            get
            {
                return (BitmapImage)GetValue(IconProperty);
            }
            set
            {
                SetValue(IconProperty, value);
            }
        }

        public static readonly DependencyProperty IconProperty =
    DependencyProperty.Register("Icon", typeof(BitmapImage), typeof(ObleceniCustomControl));


    }

    public class BoolToVisibiltyConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool parameterBool = bool.Parse(parameter.ToString());

            if ((bool)value ^ parameterBool)
            {
                return Visibility.Visible;
            }
            return Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}
