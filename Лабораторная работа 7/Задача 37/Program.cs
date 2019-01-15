using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_37
{
    class Program
    {
        static void Main(string[] args)
        {
            string b = Console.ReadLine();
            string[] arr = b.Split(';');
            ShowAllCombinations(arr);
            Console.Read();
        }
        public static void ShowAllCombinations<T>(IList<T> arr, string current = "")
        {
            if (arr.Count == 0)
            {
                Console.WriteLine(current);
                return;
            }
            for (int i = 0; i < arr.Count; i++) 
            {
                List<T> lst = new List<T>(arr);
                lst.RemoveAt(i);
                ShowAllCombinations(lst, current + arr[i].ToString());
            }
        }
    }
}