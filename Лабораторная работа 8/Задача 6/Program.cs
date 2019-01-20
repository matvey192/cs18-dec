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
            if(text.IndexOf(CA)>text.Length|| text.IndexOf(CA) < text.Length)
            { Console.WriteLine("Значение CA отсутствует в строке"); return; }
            int A = text.IndexOf(CA);
            string CB = Console.ReadLine();
            if (text.IndexOf(CB) > text.Length || text.IndexOf(CB) < text.Length)
            { Console.WriteLine("Значение CB отсутствует в строке"); return; }
            int B = text.IndexOf(CB);
            if (A < B) { A += 1; }
            else { B += 1; }
            while(A<B)
            {
                Console.Write(text[A]);
                A++;
            }
            while (A > B)
            {
                Console.Write(text[B]);
                B++;
            }
        }
    }
}
