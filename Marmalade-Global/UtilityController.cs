using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marmalade_Global
{
    static class UtilityController
    {
        public static List<T> EnumToList<T>()
        {
            List<T> allEnums = Enum.GetValues(typeof(T)).Cast<T>().ToList();
            return allEnums;
        }
    }
}
