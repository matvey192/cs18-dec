using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sim = new string[] { "a", "s", "d", "f", "g", "h" };
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            string c=null;
            Console.WriteLine("Меняю "+sim[a]+" на "+sim[b]);
            c = sim[a]; // c=a 
            sim[a] = sim[b]; // f
            sim[b] = c; // 
            Console.WriteLine(String.Join(" ", sim));  
        }
    }
}
