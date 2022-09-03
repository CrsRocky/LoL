using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace LoL.Resources.Converts
{
    public class PathDataSourceConverter : IValueConverter
    {
        private readonly ResourceDictionary iconDictionary;
        public ResourceDictionary IconDictionary => iconDictionary;

        public PathDataSourceConverter(string uri)
        {
            iconDictionary = new ResourceDictionary
            {
                Source = new Uri($"{uri}", UriKind.RelativeOrAbsolute)
            };
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == DependencyProperty.UnsetValue || value == null || string.IsNullOrEmpty(value.ToString()))
                return DependencyProperty.UnsetValue;
            return IconDictionary[value.ToString()];
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}