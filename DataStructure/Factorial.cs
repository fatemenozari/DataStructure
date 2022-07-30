using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public static class Factorial
    {
         public static int Recurfactorial(int num)
        {
            if (num < 0)
                throw new ArgumentOutOfRangeException("Sorry, factorial does not exist for negative numbers");
            else if (num == 0)
                throw new ArgumentOutOfRangeException("The factorial of 0 is 1");
            else if (num == 1)
                throw new ArgumentOutOfRangeException("The factorial of 1 is 1");
            else
                return (num * Recurfactorial(num - 1));
        }
    }
}
