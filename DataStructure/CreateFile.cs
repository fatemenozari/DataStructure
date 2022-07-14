using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class CreateFile
    {
        public static void Creator(string filePath)
        {
            File.Create(filePath);
        }
    }
}
