using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class CalcuOfSquare
    {
        public static string CalcuSquare(int[] num)
        {
            var number = num.Select(a => a * a).ToArray();
            return String.Join("\n", number);
        }
    }
}
