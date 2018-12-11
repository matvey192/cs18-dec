using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача_10
{
    class Program
    {
        static void Main(string[] args)
        {// ff 
            Console.WriteLine("Введите ваше Имя");
            string fn = Console.ReadLine();
            Console.WriteLine("Введите вашу фамилию");
            string ln = Console.ReadLine();
            Console.WriteLine("Меня зовут " + ln+','+fn+" "+ln+'.');
        }
    }
}
