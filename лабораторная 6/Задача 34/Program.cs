using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_34
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int w = int.Parse(Console.ReadLine());
            if (w < 0) { Console.WriteLine("Значение W должно быть неотрицательно ");return; }
            int h = int.Parse(Console.ReadLine());
            if (h < 0) { Console.WriteLine("Значение H должно быть неотрицательно ");return; }
            int i = 0;
            int id = 0;
            do
            {
                Console.Write(s);
                i++;
                if (i == w) { Console.WriteLine(); i = 0; id++; }
            }
            while (!(id == h));
        }
    }
}
