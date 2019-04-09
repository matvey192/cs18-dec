using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.WriteLine(String.Join(",",map));

        }
    }
}
