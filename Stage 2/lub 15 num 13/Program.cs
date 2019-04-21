using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lub_15_num_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,int> map = new Dictionary<string,int>();
            string[] sim = new string[] { "q", "w", "e", "r", "q", "w", "q" };

            int i = 0;
            int res = 0;
            while (i < sim.Length)
            {
                if(map.ContainsKey(sim[i]))
                {
                    res=map[sim[i]];
                    res += 1;
                    map[sim[i]] = res;
                }
                else
                {
                    map.Add(sim[i],1);
                }
                i++;
            }
            Console.WriteLine(String.Join(",", map));
            List<string> map1 = map.Keys.ToList();
            map1.Sort();
            foreach (string item in map1) // item = map1[j] 
            {
                Console.WriteLine(item+" "+map[item]);
            }

        }
    }
}
