using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_9
{
    class Program
    {
        static void Main(string[] args)
        {
            string b = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            string[] sim = b.Split(' ');
            if (a < 1 || a > sim.Length) { Console.WriteLine("Количество позиций при сдвиге должно быть в интервале [1, длина массива)");return; }
            for (int i = 0; i < a; ++i)
            {
                string aLast = sim[sim.Length - 1]; // последний элемент массива
                for (int j = sim.Length - 1; j > 0; j--) // пока не начало массива
                    sim[j] = sim[j - 1];//5 элемент становится 4-м
                sim[0] = aLast; // по условию до 0 . первый элемент равен последнему 
                Console.WriteLine(String.Join(" ", sim));
            }
        }
    }
}
