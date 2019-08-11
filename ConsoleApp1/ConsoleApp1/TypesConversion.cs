using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public static class TypesConversion
    {
        public static T Caster<T>(this string value)
        {
            object temp = null;
            if (bool.TryParse(value, out bool numBool))
            {
                temp = numBool;
            }
            else if (int.TryParse(value, out int numINt))
            {
                temp = numINt;
            }
            else if (double.TryParse(value, out double numDouble))
            {
                temp = numDouble;
            }
            return temp == null ? default(T) : (T)temp;
        }
    }
}
