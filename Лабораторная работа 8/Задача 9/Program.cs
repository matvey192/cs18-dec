using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_9
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            char c = text[0];
            if(c=='s')
            {
                Console.WriteLine(text.ToLower());
            }
            else if (c=='U')
            {
                Console.WriteLine(text.ToUpper());
            }
            else
            {
                Console.WriteLine(text);
            }
        }
    }
}
