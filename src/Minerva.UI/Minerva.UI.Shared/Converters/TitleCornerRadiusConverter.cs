using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Minerva.UI.Converters
{
    public class TitleCornerRadiusConverter : IValueConverter
    {
        #region [ Public Methods ]
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value.GetType() == typeof(CornerRadius) && targetType == typeof(CornerRadius))
            {
                var inputRadius = (CornerRadius)value;
                return new CornerRadius(inputRadius.TopLeft, inputRadius.TopRight, 0, 0);
            }

            throw new InvalidOperationException("Converter can only convert to value of type CornerRadius.");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
