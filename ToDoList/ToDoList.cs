using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class ToDoList
    {   //konstruktors, kurs tiek izsaukt, kad tiek izveidots objekts
        //neko neatgriez un saucas tapat ka klase - vienmer
        public ToDoList()
        {
            todoEntries = new List<string>();
        }
        List<string> todoEntries;
        public void AddNewToDo(string task)
        {
            Console.WriteLine("Uzdevums pievienot:" + task);
            todoEntries.Add(task);
        }

        public void ShowAllTodos()
        {
            // [] indeksators
            //izgustam pirmo elementu no saraksta izmantojot indeksatoru
            // skaititajs = skaititijas +1, taspats kas skaititajs += 1
            // tas pats kas skaititajs++
            // i ir saisinajums no indeks = skaititjas
            for (int i = 0; i < todoEntries.Count; i++)
            {
                Console.WriteLine("Tavs daramo lietu saraksts ir " + todoEntries[i]);
            }
        }
    }
}