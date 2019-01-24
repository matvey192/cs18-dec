using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.WriteLine("Номер файла");
            string s = Console.ReadLine();
            string ch = "task4954/test" + s + ".txt"; // относительный 
            Console.WriteLine("Символ");
            string ch1 = Console.ReadLine();
            if (!File.Exists(ch)) // истино если  существует
            {
                Console.WriteLine("File not found " + Path.GetFullPath(ch));
                return;
            } // File not foundC:\Users\adm\Desktop\cs18-dec\Лабораторная 9\Задание 1\bin\Debug\task6175\test13.txt
            // АБсолютный путь 
            StreamReader sr = new StreamReader(ch); // указываем на файл 
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                if (line.Contains(ch1))
                {
                    i++;
                }
            }
            Console.WriteLine(i);
        }
    }
}
