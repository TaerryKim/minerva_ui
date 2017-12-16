using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Minerva.UI.Converters
{
    public class test : IValueConverter
    {
        #region [ Public Methods ]
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (double)value + 10;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
