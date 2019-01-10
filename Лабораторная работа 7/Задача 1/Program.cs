using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string b = Console.ReadLine();
            string[] sim = b.Split(';');
            int c = sim.Length / 2;
            Console.WriteLine("Индекс:"+c+", улемент :"+sim[c]);

        }
    }
}
