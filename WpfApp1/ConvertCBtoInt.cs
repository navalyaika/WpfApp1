using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Controls;
using System.Windows.Data;

namespace WpfApp1
{
    public class ConvertCBtoInt : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            ComboBoxItem cbi = value as ComboBoxItem;
            if (cbi != null)
                return cbi.Content;

            return value;
        }
    }
}
