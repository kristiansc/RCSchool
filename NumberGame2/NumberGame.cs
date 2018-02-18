using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGame2
{
    class NumberGame
    {
        static void Main(string[] args)
        {

            {
                int minamaisskaitlis;
                // paprasīt lietotājam, cik lielu skaitli viņš grib minēt
                Console.WriteLine("lūdzu izvēlieties maksimālo skaitli, ko minēt");
                int maxNumber = int.Parse(Console.ReadLine());
                Random randomNumberMaker = new Random();
                // uzģenerēt gadījuma skaitli līdz šai robežai
                int randomskaitlis = randomNumberMaker.Next(1, maxNumber);
                bool hasUserWon;
                hasUserWon = false;
                // cikls: kamēr lietotājs neuzmin:
                for (int trycount = 1; trycount <= 4 && !hasUserWon; trycount = trycount +1)
                {
                    Console.WriteLine("Uzmini uzģenerēto skaitli " + "Mēģinājums# " + trycount);
                    minamaisskaitlis = int.Parse(Console.ReadLine());
                    // || ir tas pats kas vai
                    if (minamaisskaitlis == randomskaitlis)
                    {
                        Console.WriteLine("Apsveicu tu uzminēji savu nejauši gēnerēto skaitli, tavs skaitlis ir " + randomskaitlis);
                        Console.WriteLine("Paldies par spēli!");
                        hasUserWon = true;
                    }
                    else if (minamaisskaitlis > randomskaitlis)
                    {
                        Console.WriteLine("Ievadītais skaitlis ir lielāks nekā nejauši ģenerētais skaitlis");
                    }
                    else if (minamaisskaitlis < randomskaitlis)
                    {
                        Console.WriteLine("Ievadītais skaitlis ir mazāks nekā nejaušais ģenerētais skaitlis");
                    }
                    if (trycount == 4)
                    {
                        Console.WriteLine("Sorry, tu zaudēji, random skaitlis bija " + randomskaitlis);
                    }
                }

                Console.ReadLine();
            }
        }
    }
}
