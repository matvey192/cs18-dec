using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_21
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int a1 = int.Parse(a) * 100;
            if (a1 <= 0)
            {
                Console.WriteLine("Длина рулона должна быть положительна");
                return;
            }
            string b = Console.ReadLine();
            int b1 = int.Parse(b);
            if (b1 <= 0)
            {
                Console.WriteLine("Расход материала должен быть положительным");
                return;
            }
            if (a1 < b1)
            {
                Console.WriteLine("Материала не хватит даже на одно изделие");
                return;
            }
            int kol = a1 / b1;
            int ost = a1 % b1;
            Console.WriteLine("Получится шт ="+kol+"\n"+"Остаток="+ost);
        }
    }
}
