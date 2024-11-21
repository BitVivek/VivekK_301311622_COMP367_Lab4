using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VivekK_301311622_COMP367_Lab4
{
    public static class StringExtensions
    {
        public static bool StartsWithUppercase(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return false;
            return char.IsUpper(str[0]);
        }

    }
}
