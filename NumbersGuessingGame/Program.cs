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
            Saktspeli();
        }

        // vai sākt spēli?
        static void Saktspeli()
        {
            Console.WriteLine("Vai vēlies sāk spēli?");
            Console.WriteLine("Y - Sākt");
            Console.WriteLine("N - Izbeigt");
            string saktspeli;
            saktspeli = Console.ReadLine();
            //ja ja tad ejam speles funkciju
            if (saktspeli == "Y")
            {
                Spele();
            }
            else if (saktspeli == "N")
            {   // ja ne tad exit
                Console.WriteLine("Paldies par spēli!");
                Console.ReadLine();
            }
        }

        // spele
        static void Spele()
        {
            {
                // paprasīt lietotājam, cik lielu skaitli viņš grib minēt
                int minamaisskaitlis;
                int randomskaitlis;
                Console.WriteLine("lūdzu izvēlieties minimālo skaitli, ko minēt");
                int minNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("lūdzu izvēlieties maksimālo skaitli, ko minēt");
                int maxNumber = int.Parse(Console.ReadLine());
                Random randomNumberMaker = new Random();
                if (minNumber > maxNumber)
                {
                    Console.WriteLine("Minimālais skaitlis nevar būt lielāks par maksimālo skaitli");
                    Spele();
                }
                // uzģenerēt gadījuma skaitli līdz šai robežai
                randomskaitlis = randomNumberMaker.Next(minNumber, maxNumber);
                // cikls: kamēr lietotājs neuzmin:
                bool hasUserWon;
                hasUserWon = false;
                for (int trycount = 1; trycount <= 4 && !hasUserWon; trycount++)
                {
                    Console.WriteLine("Uzmini uzģenerēto skaitli" + "Mēģinājums #" + trycount);
                    minamaisskaitlis = int.Parse(Console.ReadLine());
                    string speletatkal;
                    if (minamaisskaitlis == randomskaitlis)
                    {
                        Console.WriteLine("Apsveicu tu uzminēji savu nejauši gēnerēto skaitli, tavs skaitlis ir " + randomskaitlis);
                        Console.WriteLine("Y - Ja vēlies spēlēt atkal");
                        Console.WriteLine("N - Ja nevēlies spēlēt atkal");
                        speletatkal = Console.ReadLine();
                        hasUserWon = true;
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
                    if (trycount == 4)
                    {
                        Console.WriteLine("Sorry, tu zaudēji, random skaitlis bija " + randomskaitlis);
                        Console.WriteLine("Y - Ja vēlies spēlēt atkal");
                        Console.WriteLine("N - Ja nevēlies spēlēt atkal");
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
                        }
                    }
                }
            }
        }
    }
}