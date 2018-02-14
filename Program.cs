using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //izsaucam pirmo izveidoto funkciju
            SayHello();
            //otrā funckcija
            SayHellotoUser();
            VardsunVecums();
        }





            
        //pirmā funckija
        static void SayHello()
        {
            Console.WriteLine("Hello World !! @@@##");
            Console.ReadLine();
        }
        //otrā funckcija - izveidots mainīgais 
        static void SayHellotoUser()
        {
            Console.WriteLine("Ieraksti savu vārdu");
            string userName;
            userName = Console.ReadLine();
            Console.WriteLine("Labdien "+userName+"!");
            Console.ReadLine();
        }

        static void VardsunVecums()
        {
            string vards;
            string vecums;
            Console.WriteLine("Vārds?");
            vards = Console.ReadLine();
            Console.WriteLine("Vecums?");
            vecums = Console.ReadLine();
            Console.WriteLine("Tavs Vārds ir "+vards+" Un tavs Vecums ir "+vecums);
            Console.ReadLine();
        }
    }
}

