using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulators
{
    class Kalkulators
    {
        static void Main(string[] args)
        {
            //CalculateCircleArea();
            CountTwoNumbers();
        }



        //--------------------------------------------------
        //CTRL+K+D sakārto ekrānu
        static void CalculateCircleArea()
        {
            //izveodjam mainigo, kur glabat radiusu
            double radius;
            // izveidojam mainigo, kur glabat rezultatu
            double rezultats;
            //pieskirsim radiusa mainigajam vertibu
            radius = GetNumberFromUser("Lūdzu ievadiet rādiusu");
            // veicam aprekinus
            rezultats = radius * radius * 3.14;
            Console.WriteLine("Rezultāts " + rezultats);
            Console.ReadLine();
        }
        static double GetNumberFromUser(string msg)
        {
            //izvadam funkcijai iedoto pazinojumu
            Console.WriteLine(msg);
            //nolasam lietotaja ievadi no ekrana
            string textinput = Console.ReadLine();
            //izveidojam mainigo, kur glabat apaklo skaitli
            double parsedNumber;
            // parveidojam tekstu par skaitli un ierakstam mainigaja
            bool parseWasSucess = double.TryParse(textinput, out parsedNumber);
            if (parseWasSucess == false)
            {
                Console.WriteLine("Slikti ievadīts skaitlis " + textinput);
                Console.WriteLine("Ievadi skaitli atkārtoti");
                parsedNumber = GetNumberFromUser(msg);
            }
            else
            {
                Console.WriteLine("Viss ok");
            }
            return parsedNumber;
        }
        static void CountTwoNumbers()
        {
            double pirmaisskaitlis;
            double otraisskaitlis;
            double rezultats;
            pirmaisskaitlis = GetNumberFromUser("Lūdzu ievadi pirmo skaitli");
            otraisskaitlis = GetNumberFromUser("Lūdzu ievadi otro skaitli");
            rezultats = pirmaisskaitlis + otraisskaitlis;
            Console.WriteLine("Rezultāts ir " + rezultats);
            Console.ReadLine();
        }
    }
}
