

namespace PlatformaEducationala.Converters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Data;

    namespace PlatformaEducationala.Converters
    {
        class PersonConverter : IMultiValueConverter
        {
            public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
            {
                if (values[0] != null && values[1] != null && values[2] != null && values[3] != null && values[4] != null)
                {
                    return new Person()
                    {                     
                        FirstName = values[0].ToString(),
                        LastName = values[1].ToString(),
                        EmailAddress = values[2].ToString(),
                        Password = values[3].ToString(),
                        ClassName = values[4].ToString()
                    };
                }
                else
                {
                    return null;
                }
            }
            public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
            {
                //Person pers = value as Person;
                //object[] result = new object[4] { pers.FirstName, pers.LastName,  pers.EmailAdress, pers.Password};
                //return result;
                throw new NotImplementedException();
            }
        }
    }

}
