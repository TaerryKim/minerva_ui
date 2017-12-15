using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace Minerva.UI.Converters
{
    class WindowSizeWithMarginConverter : IValueConverter
    {
        #region [ Public Methods ]
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value.GetType() != typeof(double))
                throw new FormatException("WindowSizeWithMarginConverter : Type of value have to be double");

            var size = (double)value;
            return size += 10;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
