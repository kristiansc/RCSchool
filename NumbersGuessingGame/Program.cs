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
            while (true)
            {
                //izveidojam mainīgo, kur glabāt random skaitli
                //paprasīt lietotājam, cik lielu skaitli viņš grib minēt
                //uzģenerēt gadījuma skaitli līdz šai robežai
                int maxNumber = int.Parse(Console.ReadLine());
                Random diceNumberGenerator;
                diceNumberGenerator = new Random();
                // paprasam nejaušu skaitli, skaitļu ģeneratoram
                int diceValue = diceNumberGenerator.Next(0, maxNumber);
                string tavsskatilis;
                int parsednumber;
                Console.WriteLine("Lūdzu ievadi savu skaitli");
                tavsskatilis = Console.ReadLine();
                int.Parse(tavsskatilis, out parsednumber);
                if (diceValue == parsednumber)
                {
                    break;
                }
            }
            
            
        }
    }
}
