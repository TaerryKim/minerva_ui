﻿using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Minerva.UI.Converters
{
    public class BooleanToVisibilityConverter : IValueConverter
    {
        #region [ Public Methods ]
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value.GetType() == typeof(bool) && targetType == typeof(Visibility))
            {
                return System.Convert.ToBoolean(value, culture) ? Visibility.Visible : Visibility.Collapsed;
            }

            throw new InvalidOperationException("Converter can only convert to value of type Visibility.");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
