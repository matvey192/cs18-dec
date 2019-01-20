using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "abcdefwxyz";
            int CA = int.Parse(Console.ReadLine());
            if(CA<0||CA>text.Length)
            { Console.WriteLine("Значение CA должно быть в интервале [0, длина строки)");return; }
            int CB = int.Parse(Console.ReadLine());
            if (CB < 0) { Console.WriteLine("Значение CB должно быть неотрицательно");return; }
            if (CA + CB > text.Length) { Console.WriteLine("Сумма значений CA и CB должна быть меньше длины строки");return; }
            text = text.Remove(CA, CB); // index start , num
            Console.WriteLine(text);
        }
    }
}
