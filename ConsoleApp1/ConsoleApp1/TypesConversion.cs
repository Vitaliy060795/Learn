using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public static class TypesConversion
    {
        public static T? ConvertValue<T>(this string value) where T : struct
        {
            try
            {
            return (T)Convert.ChangeType(value, typeof(T));
            }
            catch
            {
                return null;
            }
        }
    }
}
