using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Задача_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 3;
            int i1 = 0;
            string s = Console.ReadLine();
            string ch = "task5537/test" + s + ".txt";
            if (!File.Exists(ch))
            {
                Console.WriteLine("File not found " + Path.GetFullPath(ch));
                return;
            }
            StreamReader sr = new StreamReader(ch);
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                while ( i!=0 )
                {
                    Console.Write(line[i]);
                    Console.Write(line[i-1]);
                    if (line[i] == line[i-1]) { i1++; }
                    i--;
                }
                i = 3;
            }
            Console.WriteLine(i1);
            sr.Close();
        }
    }
}
