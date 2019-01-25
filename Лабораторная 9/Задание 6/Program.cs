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
            if (!File.Exists(ch))
            {
                Console.WriteLine("File not found " + Path.GetFullPath(ch));
                return;
            }
            StreamReader sr = new StreamReader(ch);
            if (sr.EndOfStream) { Console.WriteLine("Файл пуст"); sr.Close(); sr.Close(); return; }
            string line = sr.ReadLine();
            if (!line.Contains(cc)) { Console.WriteLine("Указанная буква не найдена"); sr.Close(); return; }
            if (line.IndexOf(cc, line.IndexOf(cc)+1) != -1) { Console.WriteLine("В данной строке несколько искомых букв");sr.Close();return; }
            int res = 0;
            res = line.Length-1 - line.IndexOf(cc);
            Console.WriteLine(res);
            sr.Close();
        }
    }
}
