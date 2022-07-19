using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class CalcuOfPower
    {
        public static double CalcuPower(int num, int power)=> power==0 ? 1 : num* CalcuPower(num, power - 1);
     
    }
}
