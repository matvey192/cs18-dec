using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            Console.WriteLine(@"SELECT first_name, last_name, group +
FROM students WHERE student_id ="+" "+"'"+a+"'");
        }
    }
}
