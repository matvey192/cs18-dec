using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Задача_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string line="";
            int k = 0;
            int x1 = 0;
            int y1 = 0;
            int res;
            int res1 = 0; ;
            string x = Console.ReadLine();
            string ch = "task1212/test" + x + ".csv";
            if (!File.Exists(ch))
            {
                Console.WriteLine("Файл не существует");
                return;
            }
            StreamReader sr = new StreamReader(ch);
            if (sr.EndOfStream) { Console.WriteLine("Файл пуст"); sr.Close();return; }
            try
            {
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    string[] nums = line.Split(';');
                    x1 = int.Parse(nums[2]);
                    y1 = int.Parse(nums[3]);
                    res = x1 * y1;
                    if (res > res1) { res1 = res; }
                    k++;
                }
                Console.WriteLine("Максимальная площадь: " + res1);
                Console.WriteLine("Всего записей: " + k);
            }
            catch(IndexOutOfRangeException)
            {
                Console.WriteLine("Некорректный формат данных в строке"+k);
                Console.WriteLine(line);
            }
            catch(FormatException)
            {

                Console.WriteLine("Не удалось преобразовать строку в число в строке " + k);
                Console.WriteLine(line);
            }
            sr.Close();
        }
    }
}
