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
            string[] strok = File.ReadAllLines(ch);
            if (strok.Length == 0)
            {
                Console.WriteLine("Файл пуст");
                return;
            }
            if (!File.Exists(ch))
            {
                Console.WriteLine("File not found " + Path.GetFullPath(ch));
                return;
            }
            StreamReader sr = new StreamReader(ch);
            string line = sr.ReadLine();
            if (!line.Contains(cc)) { Console.WriteLine("Указанная буква не найдена"); return; }
            int res = 0;
            if (line.IndexOf(cc) >= line.IndexOf(cc1)) { res = line.IndexOf(cc) -1- line.IndexOf(cc1); }
            else { res = line.IndexOf(cc1) -1- line.IndexOf(cc); }
            Console.WriteLine(res);
            sr.Close();
        }
    }
}
