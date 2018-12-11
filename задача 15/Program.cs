using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача_15
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();
            Console.WriteLine(@"Квадратное уравнение "+a+"* x * x + "+b+" * x + "+c+" = 0." +
            "\n"+"Его дискриминант вычисляется по формуле: d = "+b+"*"+b+" - 4 * "+a+" * "+c);
        }
    }
}
