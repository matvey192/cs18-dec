using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача_14
{
    class Program
    {
        static void Main(string[] args)
        {
            string user = Console.ReadLine();
            string pass = Console.ReadLine();
            string host = Console.ReadLine();
            string port = Console.ReadLine();
            string db = Console.ReadLine();
            Console.WriteLine(@"User ID = "+ user +";"+" Password = "+ pass + ";"+"\n"+
            "Host = "+ host +";"+" Port = "+ port +";"+" Database = "+ db +";");
        }
    }
}
