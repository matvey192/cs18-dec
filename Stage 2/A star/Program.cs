using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace A_star
{
    class Program
    {
        // Ожидаемое полное расстояние до цели
        public static double F(Pstar point, Pstar start, Pstar end)
        {
            return Program.G(point, start) + Program.H(point, end);
        }
        // G - Дистанция от старта до текущей точки
        public static double G(Pstar point, Pstar start)
        {
            return Math.Sqrt(Math.Pow(point.x - start.x, 2) + Math.Pow(point.y - start.y, 2));
        }
        // Н - Дистанция от точки END до текущей точки
        public static double H(Pstar point, Pstar end)
        {
            return Math.Sqrt(Math.Pow(end.x - point.x, 2) + Math.Pow(end.y - point.y, 2));
        }
        static void Main(string[] args)
        {
            Pstar[,] Arr = new Pstar[4, 3];
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    Pstar kes = new Pstar();
                    kes.set(x, y);
                    Arr[x, y] = kes;
                }
            }
            Console.WriteLine(Arr.GetLength(1));
            Pstar Field = new Pstar();
            Field.set(1, 1);
            Field.field = true;
            Arr[1, 1] = Field;
            Pstar Field1 = new Pstar();
            Field1.set(0, 1);
            Field1.field = true;
            Arr[0, 1] = Field;
            Pstar start = new Pstar();
            Pstar end = new Pstar();
            start.x = 0;
            start.y = 0;
            end.x = 2;
            end.y = 2;
           foreach( var path in PathFinder.FindPath(Arr, start, end))
            {
                Console.WriteLine(path);
            }
        }
    }
}
