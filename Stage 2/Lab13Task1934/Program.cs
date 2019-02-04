using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodeProject;
namespace Lab13Task1934
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Начало работы программы");
            try
            {
                Step1934();
                Console.WriteLine("Программа успешно завершена");
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(FormatException es)
            {
                Console.WriteLine(es.Message);
            }
        }
        public static void Step1934()
        {
            Console.WriteLine("Введите значения A и B");
            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            double result;
            result = Methods.Task1934(a, b);
            Console.WriteLine("Результат равен {0:F4}",result);
        }
    }
}
