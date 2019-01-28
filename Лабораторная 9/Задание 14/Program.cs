using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Задание_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 0;
            int c = 0;
            int res = 0;
            while (s < 11)
            {
                
                string ch = "task9417/data" + s + ".txt";
                if (!File.Exists(ch)) // истино если существует
                {
                    Console.WriteLine("File not found " + Path.GetFullPath(ch));
                    return;
                }
                StreamReader sr = new StreamReader(ch);
                if (sr.EndOfStream) { Console.WriteLine("Файл пуст"); sr.Close(); return; }
                while (!sr.EndOfStream)
                {
                    int line = int.Parse(sr.ReadLine());
                    c = line;
                    res = res + c;
                    s++;
                }
                sr.Close();
            }
        }
    }
}
