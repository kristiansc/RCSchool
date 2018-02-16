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
            Spele();   

        }
        static void Spele()
        {
            int minamaisskaitlis = 1;
            int randomskaitlis = 2;
            {
                // paprasīt lietotājam, cik lielu skaitli viņš grib minēt
                Console.WriteLine("lūdzu izvēlieties minimālo skaitli, ko minēt");
                int minNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("lūdzu izvēlieties maksimālo skaitli, ko minēt");
                int maxNumber = int.Parse(Console.ReadLine());
                Random randomNumberMaker = new Random();
                // uzģenerēt gadījuma skaitli līdz šai robežai
                randomskaitlis = randomNumberMaker.Next(minNumber, maxNumber);
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
                        // spelet atkal
                        if (speletatkal == "Y")
                        {
                            Spele();
                        }
                        else if (speletatkal == "N")

                        {   
                            //partrauc ciklu, ja lietotajs nevelas spelet atkal
                            Console.WriteLine("Paldies par spēli!");
                            Console.ReadLine();
                            break;
                        }
                    }   //parbaudi vai lietotaja ievaditais skaitlis ir lielaks vai mazaks par nejaušo skaitli
                    else if (minamaisskaitlis > randomskaitlis)
                    {
                        Console.WriteLine("Ievadītais skaitlis ir lielāks nekā nejauši ģenerētais skaitlis");
                    }
                    else if (minamaisskaitlis < randomskaitlis)
                    {
                        Console.WriteLine("Ievadītais skaitlis ir mazāks nekā nejaušais ģenerētais skaitlis");
                    }
                }
            }
        }
    }
}