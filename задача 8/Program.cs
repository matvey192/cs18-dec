using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача_8
{
    class Program
    {
        static void Main(string[] args)
        {  // 1 
            string a = Console.ReadLine();
            Console.WriteLine("Программирование это - "+a+'!');
            // 2 
            string vs = "Программирование это - "; 
            string va = "!";
            string b = Console.ReadLine();
            Console.WriteLine(vs+b+va);
            // 3 
            Console.WriteLine("Программирование это - " + Console.ReadLine() +'!');
        }
    }
}
