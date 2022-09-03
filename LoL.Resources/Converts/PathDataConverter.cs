using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace LoL.Resources.Converts
{
    public class PathDataConverter : IValueConverter
    {
        public object? Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == DependencyProperty.UnsetValue || value == null || string.IsNullOrEmpty(value.ToString()))
                return DependencyProperty.UnsetValue;
            return Application.Current.TryFindResource(value.ToString());
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}