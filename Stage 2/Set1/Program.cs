using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Set1
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> set = new HashSet<int>();
            set.Add(9);
            set.Add(8);
            set.Add(7);
            set.Remove(8);
            Console.WriteLine(set.Count);
            set.Add(7);
            Console.WriteLine(set.Count);
            // нельзя сортирвать
            // нельзя получать элементы по индексу
            // можно проверять на наличие элементов 
            int i = 6;
            while (i < 10)
            {
                if (set.Contains(i))
                {
                    Console.WriteLine("Содержит "+i);
                }
                else
                {
                    Console.WriteLine("Не содержит "+i);
                }
                i++;
            }

        }
    }
}
