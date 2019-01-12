using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_17
{
    class Program
    {
        static void Main(string[] args)
        {
            string b = Console.ReadLine();
            string [] bill = new string[] { "a", "b", "c", "d", "e", "f", "g", "h" };
            int i = 0;
            while (i<bill.Length)
            {
                if (bill[i] == b) { bill[i] = bill[i] + "+"; }
                Console.WriteLine(bill[i]);
                i++;
            }
        }
    }
}
