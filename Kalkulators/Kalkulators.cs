using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulators
{
    class Kalkulators
    {   //static = funkcija 
        static void Main(string[] args)
        {
            string usersInput = "0";
            //while = cikls
            while (usersInput != "x")
            {
                Console.WriteLine("please choose action");
                Console.WriteLine("a - calculate circle are");
                Console.WriteLine("c - count two numbers together");
                Console.WriteLine("d - Number divoide check");
                //ReadLine nolasa lietotāja ievadi
                usersInput = Console.ReadLine();
                if (usersInput == "a")
                {
                    CalculateCircleArea();
                }

                else if (usersInput == "c")
                {
                    CountTwoNumbers();
                }
                else if (usersInput == "d")
                {
                    DoesTheNmuberDivide();
                }
                else if (usersInput == "x")
                {
                    //pabeidz ciklu
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry, did not understand");
                }
                Console.ReadLine();
            }



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
            if (!parseWasSucess)
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
        static void DoesTheNmuberDivide()
        {
            double dalamais = GetNumberFromUser("Lūdzu ievadiet dalāmo");
            double dalitajs = GetNumberFromUser("Lūdzu ievadiet dalītāju");
            // % - skatlis ar atlikumu
            double modulis = dalamais % dalitajs;
            // vienads == 
            if (modulis == 0)
            {
                Console.WriteLine("Šie skaitļi dalās");
            }
            else
            {
                Console.WriteLine("Šie skaitļi nedalās");
            }
        }

    }
}
