using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class StringReverse
    {
        public static string Reverser(string str)
        {
            if ((str == null) || (str.Length <= 1))
                return str;
            else
                return str[str.Length - 1] + Reverser(str.Substring(0, str.Length - 1));
        }
    }
}
