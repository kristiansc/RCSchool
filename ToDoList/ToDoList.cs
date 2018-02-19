using System;
using System.Collections.Generic;
using System.IO;
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
            Console.WriteLine("Uzdevums pievienots:" + task);
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
                Console.WriteLine((i + 1) + ". " + todoEntries[i]);
            }
        }

        public void DeleteToDo(int indexOfTodo)
        {
            todoEntries.RemoveAt(indexOfTodo);
            if (indexOfTodo >= this.todoEntries.Count)
            {
                Console.WriteLine("šāds ieraksts neeksitē");
                return;
            }
            todoEntries.RemoveAt(indexOfTodo);
        }

        public void DeleteAll()
        {
            todoEntries.Clear();
        }

        public void SaveToFile()
        {
            for (int i = 0; i < todoEntries.Count; i++)
            {
                File.AppendAllText(@"C:\Users\Edgars\Documents\todoapp\todo.txt", todoEntries[i] + "\n");
            }
            
        }
        public void ReadFromFile()
        {
            string[] readtext = File.ReadAllLines(@"C:\Users\Edgars\Documents\todoapp\todo.txt");
            foreach (string listEntry in readtext)
            {
                todoEntries.Add(listEntry);
            }
        }
    }
}