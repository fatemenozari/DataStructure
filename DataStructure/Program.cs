using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial.Recurfactorial(8));

            StringReverse.Reverser("I do something");

            Console.WriteLine(CalcuOfPower.CalcuPower(2,3));

            var arr = new int[] { 2, 3, 4 };
            Console.WriteLine(CalcuOfSquare.CalcuSquare(arr));

            Console.WriteLine(CharactersFrequency.Calc("I do something"));

            CreateFile.Creator(@"E:\file.text");



            Console.ReadLine();



        }
    }
}
