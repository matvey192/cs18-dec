using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Задание_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string ch = "task6175/test"+s+".txt"; // относительный 
            if (!File.Exists(ch)) // истино если не существует
            {
                Console.WriteLine("File not found"+Path.GetFullPath(ch));  
                return;
            } // File not foundC:\Users\adm\Desktop\cs18-dec\Лабораторная 9\Задание 1\bin\Debug\task6175\test13.txt
            // АБсолютный путь 
            StreamReader sr = new StreamReader(ch); // указываем на файл 
            do
            {
                String line = sr.ReadLine(); // Ввод данных из файлы
                Console.WriteLine(line);
            }
            while (!sr.EndOfStream);// endofstream = будет верно если дошли до конца файла 
            sr.Close(); // Закрытие файла
        }
    }
}
