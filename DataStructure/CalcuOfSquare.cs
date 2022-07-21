using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class CalcuOfSquare
    {
        public int[] Numbers { get; set; }

        public static string CalcuSquare(int[] num)
        {
            var number = num.Select(a => a * a).ToArray();
            return String.Join("\n", number);
        }

        public static string CalcuSquare2(int[] num)
        {
            for (int i = 0; i < num.Length; i++)
            {
               num[i] *= num[i];
            }
            return String.Join("\n", num);

        }
    }
}
