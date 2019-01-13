using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_24
{
    class Program
    {
        static void Main(string[] args)
        {
            string b = Console.ReadLine();
            string[] sim = b.Split(' '); //   qw fg hj ty kl
            string c = Console.ReadLine();
            string[] sim1 = c.Split(' '); //   qw er ty ui op
            int i = 0;
            int cd = 0;
            int res = 0;
            while (cd < sim1.Length) // 5
            {
                while (i < sim.Length)//5
                {
                    if (sim[i] == sim1[cd]) { res = res + 1; }
                    i++;
                }
                cd++;
                i = 0;
            }
            Console.WriteLine("Повторений: "+res);
        }
        
    }
}
