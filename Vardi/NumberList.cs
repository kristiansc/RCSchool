using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Vardi
{
    class NumberList
    {
        string file = @"C:\Users\kristians.cimurs\Desktop\words.txt";

        public void ReadFromFile()
        {
            if (!File.Exists(file))
            {
                return;
            }
            string[] readtext = File.ReadAllLines(file);
            for (var index = 0; index < readtext.Length; index += 1)
            {
                string listEntry = readtext[index];
                Console.WriteLine(readtext[index]);
            }
        }
    }
   
}
