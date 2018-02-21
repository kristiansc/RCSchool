using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class DoList
    {
        static void Main(string[] args)
        {
            ToDoList list = new ToDoList();
            while (true)
            {
                Console.WriteLine("Lūdzu izvēlieties darbību");
                Console.WriteLine("a - Pievienot");
                Console.WriteLine("p - Parādīt");
                Console.WriteLine("d - Dzēst");
                Console.WriteLine("v - Dzēst visu");
                Console.WriteLine("s - Saglabāt");
                Console.WriteLine("i - Ieladet no Faila");
                string userinput = Console.ReadLine();
                switch (userinput)
                {
                    case "a":
                        Console.WriteLine("Lūdzu ievadi darāmo lietu ");
                        string todoTask = Console.ReadLine();
                        list.AddNewToDo(todoTask);
                        break;
                        
                    case "p":
                        list.ShowAllTodos();
                        break;
                    case "d":
                        Console.WriteLine("Lūdzu ievadi dzēšamās lietas nr.");
                        list.ShowAllTodos();
                        int indexOfTodo = int.Parse(Console.ReadLine());
                        list.DeleteToDo(indexOfTodo -1);
                        break;
                    case "at":
                        Console.WriteLine("Lūdzu ievadi izpildītās lietas nr.");
                        list.ShowAllTodos();
                        int indexdone = int.Parse(Console.ReadLine());
                        list.MarkTodoAsDone(indexdone - 1);
                        break;
                    case "v":
                        list.DeleteAll();
                        break;
                    case "s":
                        list.SaveToFile();
                        break;
                    case "i":
                        list.ReadFromFile();
                        break;
                }
                
                //pievienot jaunu daramo lietu
                //dzest visas daramas lietas
                //izvadit visas daramas lietas uz ekrana

            }
        }
    }
}
