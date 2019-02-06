using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Задача_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0;
            double cx = 0; //circle
            double rx = 0;//rect
            double ry = 0;//rect
            double rres = 0;
            double rres1 = 0;
            double cres = 0;
            double cres1 = 0;
            string line = "";
            string x = Console.ReadLine();
            string ch = "task9472/test" + x + ".csv";
            if (!File.Exists(ch))
            {
                Console.WriteLine("Файл не существует");
                return;
            }
            StreamReader sr = new StreamReader(ch);
            if (sr.EndOfStream) { Console.WriteLine("Файл пуст"); sr.Close(); return; }
            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                string[] nums = line.Split(';');
                if (nums[0] == "rect" && nums.Length == 5)
                {
                    rx = double.Parse(nums[3]);
                    ry = double.Parse(nums[4]);
                    rres = rx * ry;
                    if (rres > rres1) { rres1 = rres; }
                }
                else if (nums[0] == "circle" && nums.Length == 4)
                {
                    cx = double.Parse(nums[3]);
                    cres = Math.PI * Math.Pow(cx, 2);
                    if (cres > cres1) { cres1 = cres; }
                }
                else
                {
                    Console.WriteLine("Некорректный формат данных в строке " + k);
                    Console.WriteLine(line);
                    return;
                }
                k++;
            }
            if (rres1 > cres1)
            {
                Console.WriteLine("Максимальная площадь: {0:F4}", rres1);
                Console.WriteLine("Всего записей " + k);
            }
            else
            {
                Console.WriteLine("Максимальная площадь: {0:F4}", cres1);
                Console.WriteLine("Всего записей " + k);
            }
            sr.Close();
        }
    }
}
