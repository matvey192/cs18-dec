using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace lab_15_num_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "";
            string x = Console.ReadLine();
            HashSet<string> set = new HashSet<string>();
            string ch = "task9990/test" + x + ".txt";
            if (!File.Exists(ch))
            {
                Console.WriteLine("Файл не существует");
                return;
            }
            StreamReader sr = new StreamReader(ch);
            if (sr.EndOfStream) { Console.WriteLine("Файл пуст"); sr.Close(); }
            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                set.Add(line);
            }
            string res = string.Join(", ", set);
            Console.WriteLine(res);
        }
    }
}
