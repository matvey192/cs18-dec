using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_19
{
    class Program
    {
        static void Main(string[] args)
        {
            string b = Console.ReadLine();
            string[] bill = new string[] { "11","13", "17","19", "10", "12", "14", "15", "16", "18", "20" };
            int i = 0;
            while (i < bill.Length)
            {
                if (bill[i] == b) { bill[i] = bill[i] + "+"; }
                Console.WriteLine(bill[i]);
                i++;
            }
            /////////////////////////////////////////
        }
    }
}
