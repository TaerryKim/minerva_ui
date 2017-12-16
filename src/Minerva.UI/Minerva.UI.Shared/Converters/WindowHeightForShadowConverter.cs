using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace Minerva.UI.Converters
{
    public class WindowHeightForShadowConverter : IMultiValueConverter
    {
        #region [ Public Methods ]
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        { 
            if (values.Length == 2
                && values[0].GetType() == typeof(double) 
                && values[1].GetType() == typeof(Thickness)
                && targetType == typeof(double))
            {
                var width = (double)values[0];
                var margin = (Thickness)values[1];

                return width + margin.Top + margin.Bottom;
            }

            throw new InvalidOperationException("Converter can only convert to double from height and thickness");
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
        #endregion
    }
}
