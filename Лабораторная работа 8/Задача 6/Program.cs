using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "abcdefwxyz";
            string CA = Console.ReadLine();
            if (!text.Contains(CA))
            { Console.WriteLine("Значение CA отсутствует в строке");return;  }
            int A = text.IndexOf(CA);
            string CB = Console.ReadLine();
            if  (!text.Contains(CB))
            { Console.WriteLine("Значение CB отсутствует в строке");return;  }
            int B = text.IndexOf(CB);
            if (A < B)
            {
                A += 1;
                int i = B - A;
                text = text.Substring(A,i);
            }
            else
            {
                B += 1;
                int i = A-B;
                text = text.Substring(B,i); // index , num 
               
            }
            Console.WriteLine(text);
        }
    }
}
