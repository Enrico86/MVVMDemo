using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace MVVMDemo.ValueConverter
{
    public class MoneyConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var valor = value.ToString();
            if (valor != null)
            {
                var nuevoValor = $"{valor} €";
                return nuevoValor;
            }
            return valor;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value.ToString()!="")
            {
                var nuevoValor = value.ToString().Replace(" €", "");
                return decimal.Parse(nuevoValor);
            }
            else
            {
                return 0;
            }

        }
    }
}
