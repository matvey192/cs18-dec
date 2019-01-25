using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Задание_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            string[] cha; 
            int a1 = 0;
            int a2 = 0;
            Console.WriteLine("Номер файла");
            string s = Console.ReadLine();
            string ch = "task3148/list" + s + ".txt";
            if (!File.Exists(ch))
            {
                Console.WriteLine("File not found " + Path.GetFullPath(ch));
                return;
            }
            StreamReader sr = new StreamReader(ch);
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string ch1 = "task3148/" + line;
                StreamReader sr1 = new StreamReader(ch1);
                while (!sr1.EndOfStream)
                {
                    cha[i]=
                }
            }
            sr.Close();
        }
    }
}
