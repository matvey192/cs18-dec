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
            int i = 0;
            string b = Console.ReadLine();
            string[] sim = b.Split(' ');
            int bc = sim.Length-1;
            string ri = "";
            while (i < sim.Length / 2)
            {
                ri = sim[bc]; 
                sim[bc] = sim[i]; 
                sim[i] = ri; 
                ri = "";
                bc -= 1;
                i++;
            }
            i = 0;
            while (i < sim.Length) { Console.Write(sim[i]);i++; }
        }
    }
}
