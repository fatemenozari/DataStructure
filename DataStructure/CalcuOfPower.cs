using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class CalcuOfPower
    {
        public static double CalcuPower(int num, int power)
        {
            if (power == 0)
                return 1;
            else if (power == 1)
                return num;
            else
                return num * CalcuPower(num, power - 1);
        }
    }
}
