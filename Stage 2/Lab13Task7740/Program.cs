using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab13Task7740
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 
            try
            {
                double x = double.Parse(Console.ReadLine());
                x = x + 7;
                Console.WriteLine("{0:F4}", x);
            }
            catch(FormatException )
            {
                Console.WriteLine("Не удалось преобразовать строку в число");
            }
        }
    }
}
