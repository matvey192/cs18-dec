using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_22
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            string b = Console.ReadLine();
            string[] bill = b.Split(';');
            int[] nums = new int[bill.Length]; // to int
            while (i < bill.Length)
            {
                nums[i] = int.Parse(bill[i]);
            }
            i = 0;
            while (i < nums.Length)
            {
                if (nums[i] > nums[i+1]) { Console.WriteLine("Элемент со значением " + nums[i+1] + " на индексе" + i+1 + " нарушает закономерность");return; }
                i++;
            }
            Console.WriteLine("Значения отсортированы по возрастанию");
        }
    }
}
