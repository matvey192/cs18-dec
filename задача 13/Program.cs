using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача_13
{
    class Program
    {
        static void Main(string[] args)
        {
            string cx = '"' + Console.ReadLine() + '"';
            string cy =  '"' + Console.ReadLine() + '"';
            string r ='"'+Console.ReadLine()+'"';
            string fill = Console.ReadLine();
            Console.WriteLine("<circle cx ="+cx+"cy="+cy+"\n"+"r="+r+"fill="+fill+"/>");
        }
    }
}
