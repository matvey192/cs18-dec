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
            string text = "abcdacadbacdaabaadc";
            string cc = Console.ReadLine();
            if (cc.Length != 2) { Console.WriteLine("Вводимая строка должна содержать ровно 2 символа ");return; }
            text = text.Replace(cc, " ");
            Console.WriteLine(text);
        }
    }
}
