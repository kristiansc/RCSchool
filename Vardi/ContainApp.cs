using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Vardi
{
    class ContainApp
    {
        static void Main(string[] args)
        {
            string file = @"C:\Users\Edgars\Documents\todoapp\words.txt";

            {
                Console.WriteLine("Ievadi burtus, no kuriem minēt");
                string usersLetter = Console.ReadLine();
                string[] readtext = File.ReadAllLines(file);
                foreach (string wordfromdictionary in readtext)
                {
                    bool hasInvalidLetter = false;
                    foreach (char currentsymbol in usersLetter)
                        if (wordfromdictionary.Contains(currentsymbol) == false)
                        {
                            hasInvalidLetter = true;
                        }
                    foreach (char wordfrominput in wordfromdictionary)
                    {
                        if (usersLetter.Contains(wordfrominput))
                        {
                            hasInvalidLetter = true;
                        }
                    }
                    if (hasInvalidLetter == false)
                    {
                        Console.WriteLine(wordfromdictionary);
                    }
                }
            }
        }
    }
}
