using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_18
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            string[] bill = new string[] { "a", "b", "c", "d", "e", "f", "g", "h" };
            int i = 0;
            while (i < bill.Length)
            {
                Console.Write(bill[i]);
                if (bill[i] == x) { Console.WriteLine(); break; }
                i++;
            }
        }
    }
}
