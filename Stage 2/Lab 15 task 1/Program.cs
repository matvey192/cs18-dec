using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_15_task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> str = new List<string>();
            str.Add("q");
            int i = str.Count;// Длина коллекции.
            Console.WriteLine(i);
            str.Add("w");
            Console.WriteLine(str.Count);
            str = new List<string>()
            {
                "q","w","e","r","q","w"
            };

            foreach (String s in str)
            {
                Console.WriteLine(s);
                /*str.Remove("t"); Нельзя удалять во время цикла 
                  str.Add("t"); Нельзя добавлять элементы во время цикла */
            }

            Console.WriteLine(str[0]);

            string[] arr = new string[] { "q", "w", "e" };
            str = arr.ToList();
            Console.WriteLine(str.Count);
        }
    }
}
