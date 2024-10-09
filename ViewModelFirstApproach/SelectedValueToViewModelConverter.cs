using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace ViewModelFirstApproach
{
    public class SelectedValueToViewModelConverter:IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value is string)
            {
                if (value.Equals("Module1"))
                {
                    return new ViewModel_Module1() { TextProp = "Module 1 Loaded..." };
                }
                else if (value.Equals("Module2"))
                {
                    return new ViewModel_Module2() { TextProp = "Module 2 Loaded..." };
                }
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
