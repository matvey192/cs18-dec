using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Задание_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Номер файла");
            string s = Console.ReadLine();
            Console.WriteLine("Символ № 1");
            string cc = Console.ReadLine();
            Console.WriteLine("Символ № 2");
            string cc1 = Console.ReadLine();
            string ch = "task4769/test" + s + ".txt";
            if (!File.Exists(ch))
            {
                Console.WriteLine("File not found " + Path.GetFullPath(ch));
                return;
            }
            StreamReader sr = new StreamReader(ch);
            if (sr.EndOfStream) { Console.WriteLine("Файл пуст"); sr.Close(); return; }
            string line = sr.ReadLine();
            if (!line.Contains(cc)) { Console.WriteLine("Одна из указанных букв не найдена"); return; }
            int res = 0;
            if (line.IndexOf(cc, line.IndexOf(cc) + 1) != -1) { Console.WriteLine("В данной строке несколько искомых букв"); sr.Close(); return; }
            if (line.IndexOf(cc) >= line.IndexOf(cc1)) { res = line.IndexOf(cc) - 1 - line.IndexOf(cc1); }
            else { res = line.IndexOf(cc1) - 1 - line.IndexOf(cc); }
            Console.WriteLine(res);
            sr.Close();
        }
    }
}
