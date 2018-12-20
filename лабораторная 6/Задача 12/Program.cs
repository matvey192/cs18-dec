using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_12
{
    class Program
    {
        static void Main(string[] args)
        {
            string sl = Console.ReadLine();
            switch (sl)
            {
                case ("a"):
                string slov =  sl + "+";
                    Console.WriteLine(slov+"\n"+" b\n c\n d\n e\n f\n g\n h\n");
                    break;
                case ("b"):
                    string slov1 = sl + "+";
                    Console.WriteLine(" a\n"+slov1+"\n"+" c\n d\n e\n f\n g\n h\n");
                    break;
                case ("c"):
                    string slov2 = sl + "+";
                    Console.WriteLine(" a\n b\n "+slov2+"\n d\n e\n f\n g\n h\n");
                    break;
                case ("d"):
                    string slov3 = sl + "+";
                    Console.WriteLine( "a\n b\n c\n "+slov3+"\n e\n f\n g\n h\n");
                    break;
                case ("e"):
                    string slov4 = sl + "+";
                    Console.WriteLine(" a\n b\n c\n d\n"+slov4 +"\n f\n g\n h\n");
                    break;
                case ("f"):
                    string slov5 = sl + "+";
                    Console.WriteLine(" a\n b\n c\n d\n e\n"+slov5 +"\n g\n h\n");
                    break;
                case ("g"):
                    string slov6 = sl + "+";
                    Console.WriteLine(" a\n b\n c\n d\n e\n f\n"+slov6+"\n h\n");
                    break;
                case ("h"):
                    string slov7 = sl + "+";
                    Console.WriteLine(" a\n b\n c\n d\n e\n f\n g\n "+slov7+"\n");
                    break;
                default: Console.WriteLine("a\n b\n c\n d\n e\n f\n g\n h\n");
                    break;
            }
        }
    }
}
