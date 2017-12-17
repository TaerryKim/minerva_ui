using System;
using System.Windows;
using System.Windows.Data;

namespace Minerva.UI.Converters
{
    public class IconSizeConverter : IValueConverter
    {
        #region [ Private Mehtods ]
        private double GetDoubleValue(object parameter, double defaultValue)
        {
            double doubleValue;
            if (parameter != null)
            {
                try
                {
                    doubleValue = System.Convert.ToDouble(parameter);
                }
                catch
                {
                    doubleValue = defaultValue;
                }
            }
            else
            {
                doubleValue = defaultValue;
            }
                
            return doubleValue;
        }
        #endregion

        #region [ Public Methods ]
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var doubleValue = GetDoubleValue(value, 0.0) / 5;

            if (doubleValue > 1) doubleValue--;

            return new Thickness(doubleValue, doubleValue + 1, doubleValue, doubleValue + 1);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
