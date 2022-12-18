using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Data;

namespace PersianCalendar.WinUI3.Helpers;

public class GregorianToPersianConverter : IValueConverter
{
    public GregorianToPersianConverter()
    {
    }

    public object Convert(object value, Type targetType, object parameter, string language)
    {
        if (value == null) return null;
        
        var gregorianDate = (DateTime)value;

        var persianCalendar = new System.Globalization.PersianCalendar();
        var persianDate = $"{persianCalendar.GetYear(gregorianDate)}/{persianCalendar.GetMonth(gregorianDate)}/{persianCalendar.GetDayOfMonth(gregorianDate)}";
        return persianDate;
        //if (parameter is string enumString)
        //{
        //    if (!Enum.IsDefined(typeof(ElementTheme), value))
        //    {
        //        throw new ArgumentException("ExceptionEnumToBooleanConverterValueMustBeAnEnum");
        //    }

        //    var enumValue = Enum.Parse(typeof(ElementTheme), enumString);

        //    return enumValue.Equals(value);
        //}

        throw new ArgumentException("ExceptionEnumToBooleanConverterParameterMustBeAnEnumName");
    }

    public object ConvertBack(object value, Type targetType, object parameter, string language)
    {
        if (parameter is string enumString)
        {
            return Enum.Parse(typeof(ElementTheme), enumString);
        }

        throw new ArgumentException("ExceptionEnumToBooleanConverterParameterMustBeAnEnumName");
    }
}
