using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            ToDoList list = new ToDoList();
            while (true)
            {
                Console.WriteLine("Lūdzu ievadi darāmo lietu ");
                string todoTask = Console.ReadLine();
                list.AddNewToDo(todoTask);
                //pievienot jaunu daramo lietu
                //dzest visas daramas lietas
                //izvadit visas daramas lietas uz ekrana
                list.ShowAllTodos();
            }
        }
    }
}
