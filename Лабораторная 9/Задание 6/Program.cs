using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Задание_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Номер файла");
            string s = Console.ReadLine();
            Console.WriteLine("Символ");
            string cc = Console.ReadLine();
            string ch = "task5847/test" + s + ".txt";
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
            if (!line.Contains(cc)) { Console.WriteLine("Указанная буква не найдена");return; }
            int res = 0;
            res = line.Length-1 - line.IndexOf(cc);
            Console.WriteLine(res);
            sr.Close();
        }
    }
}
