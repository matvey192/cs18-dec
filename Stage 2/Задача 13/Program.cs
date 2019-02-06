using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Задача_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = 0;
            int i = 0;
            string line = "";
            string x = Console.ReadLine();
            string ch = "task5081/test" + x + ".txt";
            if (!File.Exists(ch))
            {
                Console.WriteLine("Файл не существует");
                return;
            }
            StreamReader sr = new StreamReader(ch);
            if (sr.EndOfStream) { Console.WriteLine("Файл пуст"); sr.Close(); return; }
            while(!sr.EndOfStream)
            {
                res = 0;
                i = 0;
                try
                {
                    line = sr.ReadLine();
                    string[] nums1 = line.Split(',');
                    if (line == "") { Console.WriteLine("Строка пуста"); continue; }
                    while (i < nums1.Length)
                    {
                        res = int.Parse(nums1[i]) + res;
                        i++;
                    }
                    Console.WriteLine(res);
                }
                catch (FormatException) { Console.WriteLine("Не удалось преобразовать строку в число"); }
                catch (NullReferenceException) { return; }
            }
            sr.Close();
        }
    }
}
