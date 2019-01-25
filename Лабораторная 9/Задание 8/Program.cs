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
            string s = Console.ReadLine();
            string ch = "task4488/test" + s + ".txt"; 
            string[] strok = File.ReadAllLines(ch);
            if (strok.Length == 0)
            {
                Console.WriteLine("Файл пуст");
                return;
            }
            if (!File.Exists(ch)) // истино если существует
            {
                Console.WriteLine("File not found " + Path.GetFullPath(ch));
                return;
            } 
            StreamReader sr = new StreamReader(ch);
            sr.Close();
        }
    }
}
