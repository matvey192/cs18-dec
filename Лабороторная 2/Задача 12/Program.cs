using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_12
{
    class Program
    {
        static void Main(string[] args)
        {
            string edge = Console.ReadLine();
            int e = int.Parse(edge);
            if (e <= 0)
            {
                Console.WriteLine("Значение edge должно быть положительным");
                return;
            }
            int res = 6 * (e * e);
            Console.WriteLine(res);
        }
    }
}
