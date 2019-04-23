using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Mutex n = new Mutex();
            bool c = false;
            int res2 = 0;
            Thread pr = new Thread(() =>
            {
                string ch2 = "nums1.txt";
                StreamReader sr1 = new StreamReader(ch2);
                // Поочередное выполнение потоков 
                // Первым потоком лучше ставить меньший объём
                n.WaitOne();
                while (!sr1.EndOfStream)
                {
                    string line = sr1.ReadLine();
                    int res = int.Parse(line);
                    res2 = res2 + res;
                }
                Console.WriteLine("End");
                n.ReleaseMutex();
            }
            );
            pr.Start();
            int nums = 0;
            string ch1 = "nums.txt";
            StreamReader sr = new StreamReader(ch1);
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                int res = int.Parse(line);
                nums = nums + res;
            }
            int result = nums + res2;
            Console.WriteLine(result);
        }
    }
}

