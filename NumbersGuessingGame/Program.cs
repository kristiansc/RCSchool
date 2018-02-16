using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            spele();   

        }
        static void spele()
        {
            int minamaisskaitlis = 1;
            int randomskaitlis = 2;
            {
                // paprasīt lietotājam, cik lielu skaitli viņš grib minēt
                Console.WriteLine("lūdzu izvēlieties maksimālo skaitli, ko minēt");
                int maxNumber = int.Parse(Console.ReadLine());

                Random randomNumberMaker = new Random();
                // uzģenerēt gadījuma skaitli līdz šai robežai
                randomskaitlis = randomNumberMaker.Next(1, maxNumber);
                // cikls: kamēr lietotājs neuzmin:
                while (minamaisskaitlis != randomskaitlis)
                {
                    Console.WriteLine("Uzmini uzģenerēto skaitli");
                    minamaisskaitlis = int.Parse(Console.ReadLine());

                    if (minamaisskaitlis == randomskaitlis)
                    {
                        Console.WriteLine("Apsveicu tu uzminēji savu nejauši gēnerēto skaitli, tavs skaitlis ir " + randomskaitlis);
                        Console.WriteLine("Y - Ja vēlies spēlēt atkal");
                        Console.WriteLine("N - Ja nevēlies spēlēt atkal");
                        string speletatkal;
                        speletatkal = Console.ReadLine();
                        if (speletatkal == "Y")
                        {
                            spele();
                        }
                        else if (speletatkal == "N")
                        {
                            Console.WriteLine("Paldies par spēli");
                            Console.ReadLine();
                            break;
                        }
                    }
                    else if (minamaisskaitlis > randomskaitlis)
                    {
                        Console.WriteLine("Tavs skaitlis ir lielāks nekā nejaušais skaitlis");
                    }
                    else if (minamaisskaitlis < randomskaitlis)
                    {
                        Console.WriteLine("Tavs skaitlis ir mazāks nekā nejaušais skaitlis");
                    }
                }
            }
        }
    }
}