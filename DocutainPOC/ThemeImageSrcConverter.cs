using System;
using System.Globalization;

namespace DocutainPOC
{
    public class ThemeImageSrcConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string ImgSrc = (string)value;

            AppTheme oSAppTheme = Application.Current.RequestedTheme;
            if (oSAppTheme == AppTheme.Light)
            {
                return ImgSrc + "black.png";
            }
            else
            {
                return ImgSrc + "white.png";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return AppTheme.Dark;
        }
    }
}
