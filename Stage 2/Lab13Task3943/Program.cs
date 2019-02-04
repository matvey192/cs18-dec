using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodeProject;
namespace Lab13Task3943
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Начало работы программы");
            try
            {
                step3943();
                
            }
            catch (ArgumentException ex)
            {
                Console.Write("Не удалось вычислить результат ");
                Console.WriteLine(ex.Message);
            }
            catch (FormatException es)
            {
                Console.Write("Не удалось вычислить результат ");
                Console.WriteLine(es.Message);
            }
            Console.WriteLine("Конец работы программы");
        }
        public static void step3943()
        {
            Console.WriteLine("Введите значения x и y");
            int x, y;
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            double result;
            result = Methods.Task3943(x,y);
            Console.WriteLine("Результат равен {0:F4}", result);
        }
    }
}
