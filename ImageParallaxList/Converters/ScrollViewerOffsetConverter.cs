using System;
using System.Diagnostics;
using System.Windows.Data;

namespace ImageParallaxList.Converters
{
    public class ScrollViewerOffsetConverter : IValueConverter
    {
        private const double ZeroDouble = 0;

        public static double ConvertValue { get; set; }

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (!Double.IsInfinity(ConvertValue) && !ConvertValue.Equals(ZeroDouble))
            {
                double targetValue = ((double) value)*ConvertValue;

                if (((string) parameter).Equals("inverse", StringComparison.OrdinalIgnoreCase))
                    return 0 - targetValue;

                return targetValue;
            }
            else
            {
                return value;
            }
        }

        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
