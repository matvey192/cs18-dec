using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Задание_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int res1 = 0; 
            string res = "";
            string s = Console.ReadLine();
            string ch = "task9930/test" + s + ".txt"; 
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
                if (line.IndexOf('*') != -1) { Console.WriteLine("Некорректное имя файла"); }
                else if (line.IndexOf('|') != -1) { Console.WriteLine("Некорректное имя файла"); }
                else if (line.IndexOf(';') != -1) { Console.WriteLine("Некорректное имя файла"); }
                else if (line.IndexOf('"') != -1) { Console.WriteLine("Некорректное имя файла"); }
                else if (line.IndexOf('<') != -1) { Console.WriteLine("Некорректное имя файла"); }
                else if (line.IndexOf('>') != -1) { Console.WriteLine("Некорректное имя файла"); }
                else if (line.IndexOf('?') != -1) { Console.WriteLine("Некорректное имя файла"); }
                else if (line.IndexOf('/') != -1) { Console.WriteLine("Некорректное имя файла"); }
                else
                {
                    res1 = line.LastIndexOf('\\');
                    res = line.Substring(res1 + 1, line.Length - res1 - 5);
                    Console.WriteLine(res);
                }
            }
            sr.Close();
            // Znak
        }
    }
}
