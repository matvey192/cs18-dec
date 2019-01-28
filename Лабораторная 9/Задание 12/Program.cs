using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Задание_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = 0;
            int res1 = 0;
            string s = Console.ReadLine();
            string ch = "task4463/test" + s + ".txt";
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
                if(line.Contains("src"))
                {
                    res = line.IndexOf('"')+1;
                    res1 = line.IndexOf('"', res + 1);
                    line = line.Substring(res,res1-res);
                    Console.WriteLine(line);
                }
                if (sr.EndOfStream && res == 0) { Console.WriteLine("Файл не содержит скриптов"); sr.Close(); return; }
            }
            sr.Close();
        }
    }
}
