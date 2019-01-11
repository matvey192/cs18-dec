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
            string c = null;
            c = sim[0];
            sim[0] = sim[sim.Length-1];
            for (int i = 1 ; i < sim.Length ; i++) 
            {
                Console.WriteLine(i +" "+ (i-1));

            }
            Console.WriteLine(String.Join(" ", sim));
        }
    }
}
