using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WeatherApp.ViewModel.ValueConverter
{
    public class BoolToPrecipitationConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool isPercipitation = (bool)value;

            if (isPercipitation)
            {
                return "Currently snowing or raining";
            }
            return "Currently is not snowing or raining";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string isPercipitation = (string)value;

            if(isPercipitation == "Currently snowing or raining")
            {
                return true;
            }
            return false;
        }
    }
}
