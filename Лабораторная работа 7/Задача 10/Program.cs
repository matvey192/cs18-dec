using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string b = Console.ReadLine();
            string[] sim = b.Split(' ');
            for (int i = sim.Length - 1; i >= 0; i--)
            {
                Console.Write(sim[i]+" ");
            }
        }
    }
}
