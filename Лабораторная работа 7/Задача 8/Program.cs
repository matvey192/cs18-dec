using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string b = Console.ReadLine();
            string[] sim = b.Split(' ');
            string aLast = sim[sim.Length - 1]; // последний элемент массива
            for (int j = sim.Length - 1; j > 0; j--) // пока не начало массива
            {
                sim[j] = sim[j - 1];//5 элемент становится 4-м
            }
            sim[0] = aLast; // по условию до 0 . первый элемент равен последнему 
            Console.WriteLine(String.Join(" ", sim));
        }
    }
}
