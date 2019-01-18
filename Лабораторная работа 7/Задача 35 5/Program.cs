using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_35_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 0;
            string b = Console.ReadLine();
            string[] nums = b.Split(' '); // Вводим набор чисел
            int[] num = new int[nums.Length];
            while (c < nums.Length)
            {
                num[c] = int.Parse(nums[c]); // наполняем массив типа инт 
                c++;
            }
            c = 0;
            int n = num.Length; // n равно длине массива с числами 
            for (int i = 0, m = 0; i != n; i++, n = m) /* объявляем i(отвечает за номер индекса) m , i не должно ровняться 
 длине массива , увеличиваем i на 1 , n=m . */
            {
                for (int j = m = i + 1; j != n; j++)/*ввели j,=m=i+1(следующий индекс массива) . j не должен ровняться
 длине массива , j увеличиваем*/
                {
                    if (num[j] != num[i]) // если числы разные то прибавляем к M+1
                    {
                        if (m != j) // если m не равно индексу j то
                        {
                            num[m] = num[j]; // ячейке с индексом m присваиваем значение j
                        }
                        m++; // kol-vo razlichiy 
                    }
                }
            }
            if (n != num.Length) 
            {
                int[] x = new int[num.Length];
                for (int i = 0; i < n; i++)
                {
                    x[i] = num[i];
                }
                num = x;
            }
            int bc = 0;
            while (bc < num.Length)
            {
                if (num[bc] == 0) { goto brr; }
                Console.Write(num[bc]);
            brr:
                bc++;
            }
        }
    }
}
