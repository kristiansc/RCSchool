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
        string file = @"C:\Users\Edgars\Documents\todoapp\todo.txt";
        public ToDoList()
        {
            todoEntries = new List<TodoListEntry>();
        }
        List<TodoListEntry> todoEntries;

        public void AddNewToDo(string task)
        {
            Console.WriteLine("Uzdevums pievienots:" + task);
            TodoListEntry usersTodo = new TodoListEntry();
            usersTodo.Name = task;
            todoEntries.Add(usersTodo);
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
                Console.Write((i + 1) + ". " + todoEntries[i].Name + " ");
                if (todoEntries[i].IsComplete)
                {
                    Console.Write("DONE!");
                }
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
            File.Delete(file);
            for (int i = 0; i < todoEntries.Count; i++)
            {
                string nameoftodo = todoEntries[i].Name;
                File.AppendAllText(file, nameoftodo + "\r\n");
                bool iscompleted = todoEntries[i].IsComplete;
                File.AppendAllText(file, iscompleted + "\r\n");
            }
            
        }
        public void ReadFromFile()
        {
            if (!File.Exists(file))
            {
                return;
            }
            string[] readtext = File.ReadAllLines(file);
            for (var index = 0; index < readtext.Length; index += 2)
            {
                string listEntry = readtext[index];
                TodoListEntry filetodo = new TodoListEntry();
                filetodo.Name = listEntry;
                todoEntries.Add(filetodo);
                filetodo.IsComplete = bool.Parse(readtext[index]);
                this.todoEntries.Add(filetodo);
            }
        }

        public void MarkTodoAsDone(int indexdone)
        {
           todoEntries[indexdone].IsComplete = true;
        }
    }
}