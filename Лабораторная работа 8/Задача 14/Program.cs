using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int kl = 0;
            int kk = 0;
            int i = 0;
            string res = "";
            string text = Console.ReadLine();
            while (i<text.Length)
            {
                if(text[i]=='[')
                {
                    res = res + "\\[";
                }
               else if (text[i] == ']')
                {
                    res = res + "\\]";
                }
               else if (text[i] == '"')
                {
                    kk++;
                    if (kk % 2 != 0)
                        res = res + '[';
                    else
                    {
                        res = res + ']';
                    }
                }
                else
                { res = res + text[i]; }
                i++;
            }
            Console.WriteLine(res);
        }
    }
}
