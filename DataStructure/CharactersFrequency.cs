using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class CharactersFrequency
    {
        public static string Calc(string str)
        {
            Console.WriteLine("The frequency of the characters are : ");
            var character =
                        str
                        .GroupBy(n => n)
                         .Select(s => new
                         { Character = s.Key, frequency = s.Count() });
                          
            return String.Join("\n", character);

        }
    }
}
