using System;
using System.Globalization;
using System.Windows.Data;

namespace LoL.Resources.Converts
{
    public class ArcAngleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return 360 * (double)value + 180;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (double)value / 360 - 180;
        }
    }
}