using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Задание_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = 0;
            string s = Console.ReadLine();
            string ch = "task6861/test" + s + ".txt";
            if (!File.Exists(ch)) // истино если существует
            {
                Console.WriteLine("File not found " + Path.GetFullPath(ch));
                return;
            }
            StreamReader sr = new StreamReader(ch);
            if (sr.EndOfStream) { Console.WriteLine("Файл пуст"); sr.Close(); return; }
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                if (line.IndexOf('@') == 0)
                {
                    Console.WriteLine("Некорректный почтовый адрес");
                }
                else if (line.IndexOf('@') == line.Length - 1)
                {
                    Console.WriteLine("Некорректный почтовый адрес");
                }
                else if (line.IndexOf('@') == -1)
                {
                    Console.WriteLine("Некорректный почтовый адрес");
                }
                else if (line.IndexOf('@', line.IndexOf("@") + 1) != -1)
                {
                    Console.WriteLine("Некорректный почтовый адрес");
                }
                else
                {
                    line = line.Substring(0, line.IndexOf('@'));
                    Console.WriteLine(line);
                }
            }
            sr.Close();
        }
    }
}
