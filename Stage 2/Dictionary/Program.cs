using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_star;
namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> map = new Dictionary<string, string>();
            map.Add("Key1", "Value1");
            map.Add("key2", "Value2");
            map.Add("key3", "Value3");
            Console.WriteLine(map.Count);
            map.Remove("Key1");
            if (map.ContainsKey("key999"))
            {
                Console.WriteLine(map["key999"]);
            }
            else
            {
                Console.WriteLine("key999 отсутсвует");
            }
            Console.WriteLine(map["key2"]);
            Console.WriteLine(String.Join(",", map));
            var Close = new List<Pstar>();
            var node1 = new Pstar();
            node1.set(1, 1);
            var node2 = new Pstar();
            node2.set(1, 1);
            var node3 = new Pstar();
            node3.set(2, 2);
            var node4 = new Pstar();
            node4.set(2, 2);
            Close.Add(node1);
            Close.Add(node3);
            Close.Add(node4);
            Close.Add(node2);
            Console.WriteLine(Close.Count);
            Console.WriteLine(Close[2]);
            int i = 0;
            while (i < 5)
            {
                if (Close.Contains(node3))
                {
                    Console.WriteLine("fuck");
                }
                i++;
            }
        }
    }
}
