using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string b = Console.ReadLine();
            string[] sim = b.Split(' ');
            int a = sim.Length;
            int a1 = 0; 
            for (;a1<a;a1++)
             Console.WriteLine(sim[a1] +" "+ a1);
            
        }
    }
}
